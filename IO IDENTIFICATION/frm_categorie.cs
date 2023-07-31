using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static IO_IDENTIFICATION.clas_configuration;

namespace IO_IDENTIFICATION
{
    public partial class frm_categorie : Form
    {
        public  bool modifier = false;
        public  long id_element = 0;

        public frm_categorie()
        {
            InitializeComponent();
        }

        private void frm_categorie_Load(object sender, EventArgs e)
        {
            suggestion("tbl_categorie", "cat_nom", txt_nom);
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
                    cm = new OleDbCommand("INSERT  INTO tbl_categorie (cat_nom, cat_date_update, cat_id, entite_id, cat_date_creation) VALUES (@cat_nom, @cat_date_update, @cat_id, @entite_id, @cat_date_creation) ", cn);
                }
                else
                    cm = new OleDbCommand("UPDATE tbl_categorie SET cat_nom=@cat_nom, cat_date_update=@cat_date_update WHERE cat_id=@cat_id ", cn);
                
                cm.Parameters.AddWithValue("@cat_nom", txt_nom.Text);
                cm.Parameters.AddWithValue("@cat_date_update", DateTime.Now.ToString());
                cm.Parameters.AddWithValue("@cat_id", id_element);
                cm.Parameters.AddWithValue("@entite_id", id_entite);
                cm.Parameters.AddWithValue("@cat_date_creation", DateTime.Now.ToString());
                cm.ExecuteNonQuery();
                cn.Close();

                string cat = _frm_principal.cob_categorie.Text;
                _frm_principal.remplissage_categorie();
                _frm_principal.cob_categorie.SelectedItem = cat;

                if (!modifier)
                {
                    suggestion("tbl_categorie", "cat_nom", txt_nom);
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
