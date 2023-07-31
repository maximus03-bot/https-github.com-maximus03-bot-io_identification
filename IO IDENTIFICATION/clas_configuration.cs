using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IO_IDENTIFICATION.Properties.Settings;

namespace IO_IDENTIFICATION
{
    internal class clas_configuration
    {
        public static string titre = "IO IDENTIFICATION";
       public static int id_entite;
      public static  string nom_piece ;  
        public static string nom_entite ;
        
        public static OleDbConnection cn;
        public static OleDbCommand cm ;
        public static OleDbDataReader dr;

        public static OleDbConnection cn_ ;
        public static OleDbCommand cm_ ;
        public static OleDbDataReader dr_;

        public static frm_principal _frm_principal;

        public static string avatar_vide = Application.StartupPath + @"\avatar_vide.png";
        public static string logo_vide = Application.StartupPath + @"\logo_vide.png";

        public static string chemin_stockage = @"C:\Mars Data\IO Identification\" + Default.id_entite + @"\";

        public static string chemin_photo_personne = chemin_stockage + @"Photos personnes\";
        public static string chemin_image_logo = chemin_stockage + @"Images logo\";

        public static void connection()
        {
            try
            {
                string bdd = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Default.chemin_bdd;

                cn = new OleDbConnection();
                cn.ConnectionString = bdd;

                cn_ = new OleDbConnection();
                cn_.ConnectionString = bdd;

                cn.Open();
                id_entite = Default.id_entite;
                cm = new OleDbCommand("SELECT * FROM tbl_entite WHERE ent_id = " + id_entite, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    nom_piece = dr["piece_nom"].ToString();
                    nom_entite = dr["ent_nom"].ToString();
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close ();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static bool vide(Control ctr)
        {
            bool vide;
            if (ctr.Text == "")
            {
                vide = true;
                ctr.BackColor = Color.LightCoral;
                ctr.Focus();
            }
            else
            {
                vide = false;
                ctr.BackColor = Color.White;
            }
            return vide;
        }

       public static void suggestion(string table, string colonne, TextBox txt)
        {
            try
            {
                cn.Open();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                cm = new OleDbCommand("SELECT " + colonne + " FROM " + table + " ORDER BY " + colonne + " ASC",cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    col.Add(dr[colonne].ToString());
                }
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource = col;
                txt.AutoCompleteMode = AutoCompleteMode.Suggest;
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void complete_combobox(string table, string colonne, ComboBox cob)
        {
            try
            {
                cn_.Open();
                cob.Items.Clear();
                cm_ = new OleDbCommand("SELECT " + colonne + " FROM " + table + " WHERE entite_id = "+ id_entite +" ORDER BY " + colonne + " ASC", cn_);
                dr_ = cm_.ExecuteReader();
                while (dr_.Read())
                {
                    cob.Items.Add(dr_[colonne].ToString());
                }
                cn_.Close();
            }
            catch (Exception ex)
            {
                cn_.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void selection_combobox(string table, string colonne_nom, ComboBox cob, string colonne_id, Label lab)
        {
            try
            {
                cn_.Open();
                cm_ = new OleDbCommand("SELECT " + colonne_id + " FROM " + table + " WHERE entite_id = " + id_entite + " AND " + colonne_nom +" LIKE @cob", cn_);
                cm_.Parameters.AddWithValue("@cob", cob.Text);
           dr_=      cm_.ExecuteReader();
                dr_.Read();
                if (dr_.HasRows)
                {
                    lab.Text = dr_[colonne_id].ToString();
                }
                dr_.Close();
                cn_.Close();
            }
            catch (Exception ex)
            {
                cn_.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static bool suppression (string table, string col_id, long val_id)
        {
            bool suppression = false;
            try
            {
                if (MessageBox.Show("Vous-vous supprimer ?", titre, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) 
                { 

                cn_.Open();
                cm_ = new OleDbCommand("DELETE FROM " + table + " WHERE " + col_id + " = " + val_id, cn_);
                dr_ = cm_.ExecuteReader();
                    suppression = true;
                cn_.Close();
                }
            }
            catch (Exception ex)
            {
                cn_.Close();
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return suppression;

        }

        public static string fichier_choisi = "";
        public static bool choisir_fichier(string filtre)
        {
            bool choisir_fichier = false;
            try
            {
                OpenFileDialog ouverture = new OpenFileDialog();
                fichier_choisi = "";
                ouverture.Filter = filtre;
                if (ouverture.ShowDialog() == DialogResult.OK)
                {
                    fichier_choisi = ouverture.FileName;
                    choisir_fichier = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return choisir_fichier;
        }

        public static string nouvelle_photo = "";
        public static void copy_photo(string chemin_origine, string dossier_destination, string nom_destination)
        {
            try
            {
                if (!Directory.Exists(dossier_destination))
                    Directory.CreateDirectory(dossier_destination);
                if (chemin_origine != nouvelle_photo & chemin_origine != "")
                {
                    nouvelle_photo = dossier_destination + nom_destination + ".jpeg";
                    File.Copy(chemin_origine, nouvelle_photo, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, titre, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
