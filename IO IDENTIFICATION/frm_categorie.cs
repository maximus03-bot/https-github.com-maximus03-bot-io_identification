﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IO_IDENTIFICATION.clas_configuration;

namespace IO_IDENTIFICATION
{
    public partial class frm_categorie : Form
    {
        public frm_categorie()
        {
            InitializeComponent();
        }

        private void frm_categorie_Load(object sender, EventArgs e)
        {
            suggestion("tbl_categorie", "cat_nom", txt_nom);
        }
    }
}
