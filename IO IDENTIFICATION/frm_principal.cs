using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static IO_IDENTIFICATION.clas_configuration;
using static IO_IDENTIFICATION.Properties.Settings;
using System.IO;

namespace IO_IDENTIFICATION
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        public void frm_principal_Load(object sender, EventArgs e)
        {
            try
            {
                connection();

                _frm_principal = this;
                lab_titre.Text = titre + " : " + nom_entite.ToUpper(); 
                //chec de la base des données

                //remplissage
                remplissage_categorie();
                cob_categorie.SelectedIndex = 0;

                remplissage_sous_categorie();
                cob_sous_categorie.SelectedIndex = 0;

                cob_genre.Items.Clear();
                cob_genre.Items.Insert(0, "tous");
                cob_genre.Items.Add("M");
                cob_genre.Items.Add("F");
                cob_genre.SelectedIndex = 0;

                cob_impression.Items.Clear();
                cob_impression.Items.Add("liste des identites partielles");
                cob_impression.Items.Add("liste des toutes les  identité");
                cob_impression.Items.Add(nom_piece);
                cob_impression.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, titre,MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void remplissage_categorie ()
        {
            try
            {
                cn.Open();
                int i = 0;
                dgv_categorie.Rows.Clear();
                cm = new OleDbCommand("SELECT cat_id, cat_nom FROM tbl_categorie WHERE entite_id = " + id_entite + " ORDER BY cat_nom ASC" , cn);
                dr = cm.ExecuteReader();
                while( dr.Read())
                {
                    i += 1;
                    dgv_categorie.Rows.Add(dr["cat_id"].ToString(), i, dr["cat_nom"].ToString());
                }
                complete_combobox("tbl_categorie", "cat_nom", cob_categorie);
                cob_categorie.Items.Insert(0, "tous");
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message,titre,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void remplissage_sous_categorie()
        {
            try
            {

                cn.Open();
                int i = 0;
                dgv_sous_categorie.Rows.Clear();
                cm = new OleDbCommand("SELECT sous_cat_id, sous_cat_nom FROM tbl_sous_categorie WHERE entite_id = " + id_entite + " ORDER BY sous_cat_nom ASC", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dgv_sous_categorie.Rows.Add(dr["sous_cat_id"].ToString(), i, dr["sous_cat_nom"].ToString());
                }
                complete_combobox("tbl_sous_categorie", "sous_cat_nom", cob_sous_categorie);
                cob_sous_categorie.Items.Insert(0, "tous");
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        TextBox txt_condition = new TextBox();
        public void remplissage_personne()
        {
            try
            {
                if (vide(cob_categorie)) return;
                if (vide(cob_sous_categorie)) return;
                if (vide(cob_genre)) return;
                txt_condition.Text = " AND (prs_nom LIKE '%" + txt_recherche.Text + "%' OR prs_post_nom LIKE '%" + txt_recherche.Text + "%' OR prs_prenom LIKE '%" + txt_recherche.Text + "%' ) ";

                if (cob_categorie.Text != "tous")
                    txt_condition.AppendText(" AND prs_cat_id = " + lab_cat_id.Text);
                if (cob_sous_categorie.Text != "tous")
                    txt_condition.AppendText(" AND prs_sous_cat_id = " + lab_sous_cat_id.Text);
                if (cob_genre.Text != "tous")
                    txt_condition.AppendText(" AND prs_genre = '" + cob_genre.Text + "'");

                cn.Open();
                int i = 0;
                dgv_personne.Rows.Clear();
                cm = new OleDbCommand("SELECT * FROM tbl_personne, tbl_categorie, tbl_sous_categorie WHERE tbl_personne.entite_id = " + id_entite + " AND prs_cat_id=cat_id AND prs_sous_cat_id=sous_cat_id" +
                    " " + txt_condition.Text + " ORDER BY prs_nom, prs_post_nom, prs_prenom ASC", cn);
                string x = cm.CommandText;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dgv_personne.Rows.Add(dr["prs_id"].ToString(), i, dr["prs_nom"].ToString()  + " "+ dr["prs_post_nom"].ToString() +" " + dr["prs_prenom"].ToString(), dr["prs_genre"].ToString(), dr["prs_telephone"].ToString(), dr["cat_nom"].ToString() , dr["sous_cat_nom"].ToString(), dr["prs_statut"].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            remplissage_personne();
        }
        private void cob_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection_combobox("tbl_categorie", "cat_nom", cob_categorie, "cat_id", lab_cat_id);
            remplissage_personne();
        }
        private void cob_sous_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection_combobox("tbl_sous_categorie", "sous_cat_nom", cob_sous_categorie, "sous_cat_id", lab_sous_cat_id);
            remplissage_personne();
        }   
        private void cob_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplissage_personne();
        }

        private void bt_ajouter_personne_Click(object sender, EventArgs e)
        {
            
            frm_personne frm =  new frm_personne();
            frm.pic_photo.Image = Image.FromFile(avatar_vide);
            frm.cob_genre.SelectedIndex = 0;
            frm.remplir_element();
            frm.ShowDialog();
        }

        private void bt_imprimer_Click(object sender, EventArgs e)
        {
            frm_impression frm = new frm_impression();
            frm.Show();
        }

        private void bt_ajouter_sous_categorie_Click(object sender, EventArgs e)
        {
            frm_sous_categorie frm = new frm_sous_categorie();
            frm.ShowDialog();
        }

        private void bt_ajouter_categorie_Click(object sender, EventArgs e)
        {
            frm_categorie frm = new frm_categorie();    
            frm.ShowDialog();
        }

        private void bt_parametre_Click(object sender, EventArgs e)
        {
            frm_parametre frm = new frm_parametre();
            frm.txt_chemin_bdd.Text = Default.chemin_bdd;
            frm.num_id.Value = decimal.Parse(Default.id_entite.ToString());
            frm.ShowDialog();
        }


        private void dgv_categorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string col_nom = dgv_categorie.Columns[e.ColumnIndex].Name;
                long _id = long.Parse(dgv_categorie.Rows[e.RowIndex].Cells[0].Value.ToString());
                string _nom = dgv_categorie.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (col_nom == "col_cat_mod")
                {
                    frm_categorie frm = new frm_categorie();
                    frm.modifier = true;
                    frm.id_element = _id;
                    frm.txt_nom.Text = _nom;
                    frm.ShowDialog();
                }
                else if (col_nom == "col_cat_sup")
                {
                    if (suppression("tbl_categorie", "cat_id", _id) == true)
                    {
                        string cat = cob_categorie.Text;
                        remplissage_categorie();
                        cob_categorie.SelectedItem = cat;
                    }
                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_sous_categorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string col_nom = dgv_sous_categorie.Columns[e.ColumnIndex].Name;
                long _id = long.Parse(dgv_sous_categorie.Rows[e.RowIndex].Cells[0].Value.ToString());
                string _nom = dgv_sous_categorie.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (col_nom == "col_sous_cat_mod")
                {
                    frm_sous_categorie frm = new frm_sous_categorie();
                    frm.modifier = true;
                    frm.id_element = _id;
                    frm.txt_nom.Text = _nom;
                    frm.ShowDialog();
                }
                else if (col_nom == "col_sous_cat_sup")
                {
                    if (suppression("tbl_sous_categorie", "sous_cat_id", _id) == true)
                    {
                        string sous_cat = cob_sous_categorie.Text;
                        remplissage_sous_categorie();
                        cob_sous_categorie.SelectedItem = sous_cat;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_personne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string col_nom = dgv_personne.Columns[e.ColumnIndex].Name;
                long _id = long.Parse(dgv_personne.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (col_nom == "col_prs_stat")
                {

                }
                else if (col_nom == "col_prs_imp")
                {

                }
                else if (col_nom == "col_prs_mod")
                {
                    frm_personne frm = new frm_personne();
                    frm.remplir_element();
                    frm.modifier = true;
                    frm.id_element = _id;


                    cn.Open();
                    cm = new OleDbCommand("SELECT * FROM tbl_personne, tbl_categorie, tbl_sous_categorie WHERE tbl_personne.entite_id = " + id_entite + " AND prs_cat_id=cat_id AND prs_sous_cat_id=sous_cat_id AND prs_id = " +_id , cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        frm.txt_nom.Text = dr["prs_nom"].ToString();
                        frm.txt_post_nom.Text = dr["prs_post_nom"].ToString();
                        frm.txt_prenom.Text = dr["prs_prenom"].ToString();
                        frm.cob_genre.Text = dr["prs_genre"].ToString();
                        frm.txt_lieu_naissance.Text = dr["prs_lieu_naissance"].ToString();
                        frm.dt_date_naissance.Value = DateTime.Parse(dr["prs_date_naissance"].ToString());
                        frm.num_telephone.Value = decimal.Parse(dr["prs_telephone"].ToString());
                        frm.cob_categorie.Text = dr["cat_nom"].ToString();
                        frm.cob_sous_categorie.Text = dr["sous_cat_nom"].ToString();
                        frm.txt_ville.Text = dr["prs_ad_ville"].ToString();
                        frm.txt_commune.Text = dr["prs_ad_commune"].ToString();
                        frm.txt_quartier.Text = dr["prs_ad_quartier"].ToString();
                        frm.txt_avenue.Text = dr["prs_ad_avenue"].ToString();
                        frm.txt_numero.Text = dr["prs_ad_numero"].ToString();
                        frm.txt_code_electeur.Text = dr["prs_code_carte"].ToString();
                        frm.num_telephone_urgence.Value = decimal.Parse(dr["prs_telephone_urgence"].ToString());
                        frm.txt_code_identification.Text = dr["prs_code_identite"].ToString();
                        frm.chemin_image = dr["prs_chemin_photo"].ToString();
                    }
                    dr.Close();
                    cn.Close();
                    if (File.Exists(frm.chemin_image))
                    {
                        using (FileStream stream = new FileStream(frm.chemin_image, FileMode.Open, FileAccess.Read))
                        {
                            frm.pic_photo.Image = Image.FromStream(stream);
                            stream.Dispose();
                        }
                    }
                    else
                        frm.pic_photo.Image = Image.FromFile(avatar_vide);

                    frm.ShowDialog();
                }
                else if (col_nom == "col_prs_sup")
                {
                    if (suppression("tbl_personne", "prs_id", _id) == true)
                        remplissage_personne();
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
