using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IO_IDENTIFICATION.clas_configuration;

namespace IO_IDENTIFICATION
{
    public partial class frm_personne : Form
    {
        public bool modifier = false;
        public long id_element = 0;
        public string chemin_image;

        public frm_personne()
        {
            InitializeComponent();
        }

        private void frm_personne_Load(object sender, EventArgs e)
        {
        }
        public  void remplir_element ()
        {
            remplir_suggestion();
            complete_combobox("tbl_sous_categorie", "sous_cat_nom", cob_sous_categorie);
            complete_combobox("tbl_categorie", "cat_nom", cob_categorie);

        }
        private void remplir_suggestion()
        {
            suggestion("tbl_personne", "prs_nom", txt_nom);
            suggestion("tbl_personne", "prs_post_nom", txt_post_nom);
            suggestion("tbl_personne", "prs_prenom", txt_prenom);
            suggestion("tbl_personne", "prs_lieu_naissance", txt_lieu_naissance);
            suggestion("tbl_personne", "prs_ad_ville", txt_ville);
            suggestion("tbl_personne", "prs_ad_commune", txt_commune);
            suggestion("tbl_personne", "prs_ad_quartier", txt_quartier);
            suggestion("tbl_personne", "prs_ad_avenue", txt_avenue);
        }
        private void lab_choix_photo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (choisir_fichier("Image (*.Jpeg;*.Jpg;*.Png;*Gif)|*.jpeg;*.jpg;*.png;*.gif") == true)
            {
                pic_photo.Image = Image.FromFile(fichier_choisi);
                chemin_image = fichier_choisi;
            }
        }
        private void cob_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection_combobox("tbl_categorie", "cat_nom", cob_categorie, "cat_id", lab_cat_id);
        }
        private void cob_sous_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection_combobox("tbl_sous_categorie", "sous_cat_nom", cob_sous_categorie, "sous_cat_id", lab_sous_cat_id);
        }
        private void bt_enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (vide(txt_nom)) return;
                if (vide(txt_post_nom)) return;
                if (vide(cob_genre)) return;
                if (vide(txt_lieu_naissance)) return;
                if (vide(cob_categorie)) return;
                if (vide(cob_categorie)) return;
                if (vide(txt_ville)) return;
                if (vide(txt_commune)) return;
                if (vide(txt_quartier)) return;

                cn.Open();
                if (!modifier)
                {
                    id_element = long.Parse(DateTime.Now.ToString("yyMMddHHmmss"));
                    cm = new OleDbCommand("INSERT  INTO tbl_personne (prs_nom, prs_post_nom, prs_prenom, prs_genre, prs_lieu_naissance, prs_date_naissance, prs_telephone, prs_cat_id, prs_sous_cat_id, prs_chemin_photo, prs_ad_ville, prs_ad_commune, prs_ad_quartier, prs_ad_avenue, " +
                        " prs_ad_numero, prs_code_carte, prs_telephone_urgence, prs_code_identite, prs_date_update, prs_id, entite_id, prs_date_creation) " +
                        " VALUES (@prs_nom, @prs_post_nom, @prs_prenom, @prs_genre, @prs_lieu_naissance,@prs_date_naissance, @prs_telephone, @prs_cat_id, @prs_sous_cat_id, @prs_chemin_photo, @prs_ad_ville, @prs_ad_commune, @prs_ad_quartier, @prs_ad_avenue, " +
                        " @prs_ad_numero, @prs_code_carte, @prs_telephone_urgence, @prs_code_identite, @prs_date_update, @prs_id, @entite_id, @prs_date_creation)  ", cn);
                }
                else
                {
                    if (MessageBox.Show("Vous-vous modifier ?", titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        cn.Close();
                        return;
                    }
                    cm = new OleDbCommand("UPDATE tbl_personne SET prs_nom=@prs_nom, prs_post_nom=@prs_post_nom, prs_prenom=@prs_prenom, prs_genre=@prs_genre, prs_lieu_naissance=@prs_lieu_naissance, prs_date_naissance=@prs_date_naissance, prs_telephone=@prs_telephone, prs_cat_id=@prs_cat_id," +
                        " prs_sous_cat_id=@prs_sous_cat_id, prs_chemin_photo=@prs_chemin_photo, prs_ad_ville=@prs_ad_ville, prs_ad_commune=@prs_ad_commune, prs_ad_quartier=@prs_ad_quartier, prs_ad_avenue=@prs_ad_avenue, " +
                        " prs_ad_numero=@prs_ad_numero, prs_code_carte=@prs_code_carte, prs_telephone_urgence=@prs_telephone_urgence, prs_code_identite=@prs_code_identite, prs_date_update=@prs_date_update WHERE prs_id=@prs_id", cn);
                }

                if (txt_code_identification.Text == "")
                    txt_code_identification.Text = "MARS-" + id_element;

                copy_photo(chemin_image, chemin_photo_personne, id_element + "_" + txt_nom.Text);

                cm.Parameters.AddWithValue("@prs_nom", txt_nom.Text);
                cm.Parameters.AddWithValue("@prs_post_nom", txt_post_nom.Text);
                cm.Parameters.AddWithValue("@prs_prenom", txt_prenom.Text);
                cm.Parameters.AddWithValue("@prs_genre", cob_genre.Text);
                cm.Parameters.AddWithValue("@prs_lieu_naissance", txt_lieu_naissance.Text);
                cm.Parameters.AddWithValue("@prs_date_naissance", dt_date_naissance.Value.ToString());
                cm.Parameters.AddWithValue("@prs_telephone", num_telephone.Value);
                cm.Parameters.AddWithValue("@prs_cat_id", lab_cat_id.Text);
                cm.Parameters.AddWithValue("@prs_sous_cat_id", lab_sous_cat_id.Text);
                cm.Parameters.AddWithValue("@prs_chemin_photo", nouvelle_photo);
                cm.Parameters.AddWithValue("@prs_ad_ville", txt_ville.Text);
                cm.Parameters.AddWithValue("@prs_ad_commune", txt_commune.Text);
                cm.Parameters.AddWithValue("@prs_ad_quartier", txt_quartier.Text);
                cm.Parameters.AddWithValue("@prs_ad_avenue", txt_avenue.Text);
                cm.Parameters.AddWithValue("@prs_ad_numero", txt_numero.Text);
                cm.Parameters.AddWithValue("@prs_code_carte", txt_code_electeur.Text);
                cm.Parameters.AddWithValue("@prs_telephone_urgence", num_telephone_urgence.Value);
                cm.Parameters.AddWithValue("@prs_code_identite", txt_code_identification.Text);
                cm.Parameters.AddWithValue("@prs_date_update", DateTime.Now.ToString());
                cm.Parameters.AddWithValue("@prs_id", id_element);
                cm.Parameters.AddWithValue("@entite_id", id_entite);
                cm.Parameters.AddWithValue("@prs_date_creation", DateTime.Now.ToString());
                cm.ExecuteNonQuery();
                cn.Close();

                _frm_principal.remplissage_personne();

                if (!modifier)
                {
                    remplir_suggestion();
                    txt_nom.Clear();
                    txt_post_nom.Clear();
                   txt_prenom.Clear();
                    txt_lieu_naissance.Clear();
                    num_telephone.Value = 243;
                    txt_ville.Clear();
                    txt_commune.Clear();
                    txt_quartier.Clear();
                    txt_avenue.Clear();
                    txt_numero.Clear();
                    txt_code_electeur.Clear();
                    num_telephone_urgence.Value = 243;
                    txt_code_identification.Clear();
                    chemin_image = "";
                    pic_photo.Image = Image.FromFile(avatar_vide);
                    txt_nom.Focus();
                }
                else
                    this.Dispose();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
