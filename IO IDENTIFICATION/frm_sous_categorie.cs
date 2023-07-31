using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class frm_sous_categorie : Form
    {
        public bool modifier = false;
        public long id_element = 0;

        public frm_sous_categorie()
        {
            InitializeComponent();
        }

        private void frm_sous_categorie_Load(object sender, EventArgs e)
        {
            suggestion("tbl_sous_categorie", "sous_cat_nom", txt_nom);

        }

        private void bt_enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (vide(txt_nom)) return;

                    cn.Open();
                if (!modifier)
                {
                    id_element = long.Parse(DateTime.Now.ToString("yyMMddHHmmss"));
                    cm = new OleDbCommand("INSERT  INTO tbl_sous_categorie (sous_cat_nom, sous_cat_date_update, sous_cat_id, entite_id, sous_cat_date_creation) VALUES (@sous_cat_nom, @sous_cat_date_update, @sous_cat_id, @entite_id, @sous_cat_date_creation) ", cn);
                }
                else
                    cm = new OleDbCommand("UPDATE tbl_sous_categorie SET sous_cat_nom=@sous_cat_nom, sous_cat_date_update=@sous_cat_date_update WHERE sous_cat_id=@sous_cat_id ", cn);

                cm.Parameters.AddWithValue("@sous_cat_nom", txt_nom.Text);
                cm.Parameters.AddWithValue("@sous_cat_date_update", DateTime.Now.ToString());
                cm.Parameters.AddWithValue("@sous_cat_id", id_element);
                cm.Parameters.AddWithValue("@entite_id", id_entite);
                cm.Parameters.AddWithValue("@sous_cat_date_creation", DateTime.Now.ToString());
                cm.ExecuteNonQuery();
                cn.Close();

                string cat = _frm_principal.cob_sous_categorie.Text;
                _frm_principal.remplissage_sous_categorie();
                _frm_principal.cob_sous_categorie.SelectedItem = cat;

                if (!modifier)
                {
                    suggestion("tbl_sous_categorie", "sous_cat_nom", txt_nom);
                    txt_nom.Clear();
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
