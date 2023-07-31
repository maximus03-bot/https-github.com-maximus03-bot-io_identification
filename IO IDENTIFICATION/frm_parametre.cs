using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IO_IDENTIFICATION.clas_configuration;
using static IO_IDENTIFICATION.Properties.Settings;

namespace IO_IDENTIFICATION
{
    public partial class frm_parametre : Form
    {
        string chemin_image;
        public frm_parametre()
        {
            InitializeComponent();
        }

        bool valide;

        private void check_info()
        {
            valide = false;
            if (vide(num_id)) return;
            if (vide(txt_chemin_bdd)) return;

            OleDbConnection _cn = new  OleDbConnection();
            OleDbCommand _cm;
            OleDbDataReader _dr;
            try
            {
                string bdd = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + txt_chemin_bdd.Text;
                _cn.ConnectionString = bdd;

                txt_nom_piece.Clear();
                txt_nom_entite.Clear();
                txt_info_entite.Clear();
                chemin_image = "";
                pic_logo.Image = Image.FromFile(logo_vide);

                _cn.Open();
                _cm = new OleDbCommand("SELECT * FROM tbl_entite WHERE ent_id = " + num_id.Value,_cn);
               _dr = _cm.ExecuteReader();
                _dr.Read();
                if (_dr.HasRows )
                {
                    txt_nom_piece.Text = _dr["piece_nom"].ToString();
                    txt_nom_entite.Text = _dr["ent_nom"].ToString();
                    txt_info_entite.Text = _dr["ent_info"].ToString();
                    chemin_image = _dr["ent_chemin_logo"].ToString();
                    
                    if (File.Exists(chemin_image))
                    {
                        using (FileStream stream = new FileStream(chemin_image, FileMode.Open, FileAccess.Read))

                        {
                            pic_logo.Image = Image.FromStream(stream);
                            stream.Dispose();
                        }
                    }
                    valide = true;
                }
                _cn.Close();


            }
            catch (Exception ex)
            {
                _cn.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void num_id_ValueChanged(object sender, EventArgs e)
        {
            check_info();
        }

        private void bt_ouvrir_bdd_Click(object sender, EventArgs e)
        {
            if (choisir_fichier("Base des données (*.mdb)|*.mdb") == true)
            {
                txt_chemin_bdd.Text = fichier_choisi;
            }
        }

        private void lab_choisir_logo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (choisir_fichier("Image (*.Jpeg;*.Jpg;*.Png;*Gif)|*.jpeg;*.jpg;*.png;*.gif") == true)
            {
                pic_logo.Image = Image.FromFile(fichier_choisi);
                chemin_image = fichier_choisi;
            }
        }

        private void bt_enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!valide)
                {
                    MessageBox.Show("Les configuration ne sont pas valides", titre, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (MessageBox.Show("Vous-vous modifier ?", titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                Default.chemin_bdd = txt_chemin_bdd.Text;
                Default.id_entite = int.Parse(num_id.Value.ToString());
                Default.type_piece = cob_type_piece.Text;

                if (vide(num_id)) return;
                if (vide(txt_nom_piece)) return;
                if (vide(txt_nom_entite)) return;
                if (vide(txt_chemin_bdd)) return;

                copy_photo(chemin_image, chemin_image_logo, id_entite + "_" + txt_nom_entite.Text);

                cn.Open();
                    cm = new OleDbCommand("UPDATE tbl_entite SET ent_nom=@ent_nom, ent_chemin_logo=@ent_chemin_logo, piece_nom=@piece_nom , ent_info=@ent_info, ent_date_update=@ent_date_update WHERE ent_id=@ent_id ", cn);
                
                cm.Parameters.AddWithValue("@ent_nom", txt_nom_entite.Text);
                cm.Parameters.AddWithValue("@ent_chemin_logo", nouvelle_photo);
                cm.Parameters.AddWithValue("@piece_nom", txt_nom_piece.Text);
                cm.Parameters.AddWithValue("@ent_info", txt_info_entite.Text);
                cm.Parameters.AddWithValue("@ent_date_update", DateTime.Now.ToString());
                cm.Parameters.AddWithValue("@ent_id", id_entite);
                cm.ExecuteNonQuery();
                cn.Close();

                connection();

                _frm_principal.frm_principal_Load(sender, e);
                this.Dispose();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_chemin_bdd_TextChanged(object sender, EventArgs e)
        {
            check_info();
        }

        private void frm_parametre_Load(object sender, EventArgs e)
        {
            cob_type_piece.SelectedItem = Default.type_piece;
        }

        private void cob_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string image_piece = Application.StartupPath + @"\piece_" + cob_type_piece.Text + ".png";
            if (File.Exists(image_piece))
                     pic_type.Image = Image.FromFile(image_piece);
            else
                pic_type.Image = null;

        }
    }
}
