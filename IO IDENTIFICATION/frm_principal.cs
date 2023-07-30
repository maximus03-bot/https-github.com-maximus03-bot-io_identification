using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IO_IDENTIFICATION.clas_configuration;
using static IO_IDENTIFICATION.Properties.Settings;

namespace IO_IDENTIFICATION
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            try
            {

                //chec de la base des données
                connection();

                string nom_piece = Default.nom_piece;
                //remplissage
                remplissage_categorie();
                remplissage_sous_categorie();
                cob_categorie.Items.Insert(0, "tous");
                cob_categorie.SelectedIndex = 0;
                cob_sous_categorie.Items.Insert(0, "tous");
                cob_sous_categorie.SelectedIndex = 0;

                cob_genre.Items.Insert(0, "tous");
                cob_genre.Items.Add("M");
                cob_genre.Items.Add("F");
                cob_genre.SelectedIndex = 0;

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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,titre,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void remplissage_sous_categorie()
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void remplissage_personne()
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            remplissage_personne();
        }
        private void cob_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplissage_personne();
        }
        private void cob_sous_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplissage_personne();
        }   
        private void cob_genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplissage_personne();
        }

        private void bt_ajouter_personne_Click(object sender, EventArgs e)
        {
            
            frm_personne frm =  new frm_personne();
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
            frm.ShowDialog();
        }



 
    }
}
