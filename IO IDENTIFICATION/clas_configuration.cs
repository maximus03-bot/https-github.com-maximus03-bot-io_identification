using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
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

        public static OleDbConnection cn;
        public static OleDbCommand cm ;
        public static OleDbDataReader dr;

        public static OleDbConnection cn_ ;
        public static OleDbCommand cm_ ;
        public static OleDbDataReader dr_;

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
    }
}
