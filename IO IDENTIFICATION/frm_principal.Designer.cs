namespace IO_IDENTIFICATION
{
    partial class frm_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_personne = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prs_stat = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_prs_impr = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_prs_mod = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_prs_sup = new System.Windows.Forms.DataGridViewImageColumn();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lab_sous_cat_id = new System.Windows.Forms.Label();
            this.lab_cat_id = new System.Windows.Forms.Label();
            this.bt_parametre = new System.Windows.Forms.Button();
            this.cob_impression = new System.Windows.Forms.ComboBox();
            this.bt_imprimer = new System.Windows.Forms.Button();
            this.bt_ajouter_sous_categorie = new System.Windows.Forms.Button();
            this.bt_ajouter_categorie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cob_genre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cob_categorie = new System.Windows.Forms.ComboBox();
            this.cob_sous_categorie = new System.Windows.Forms.ComboBox();
            this.bt_ajouter_personne = new System.Windows.Forms.Button();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lab_titre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_sous_categorie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sous_cat_mod = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_sous_cat_sup = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_categorie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cat_mod = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_cat_sup = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personne)).BeginInit();
            this.Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sous_categorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_personne
            // 
            this.dgv_personne.AllowUserToAddRows = false;
            this.dgv_personne.AllowUserToDeleteRows = false;
            this.dgv_personne.AllowUserToResizeColumns = false;
            this.dgv_personne.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgv_personne.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_personne.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_personne.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_personne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_personne.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_personne.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_personne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column8,
            this.col_prs_stat,
            this.col_prs_impr,
            this.col_prs_mod,
            this.col_prs_sup});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_personne.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_personne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_personne.EnableHeadersVisualStyles = false;
            this.dgv_personne.GridColor = System.Drawing.Color.Black;
            this.dgv_personne.Location = new System.Drawing.Point(0, 123);
            this.dgv_personne.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_personne.Name = "dgv_personne";
            this.dgv_personne.ReadOnly = true;
            this.dgv_personne.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_personne.RowHeadersVisible = false;
            this.dgv_personne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_personne.Size = new System.Drawing.Size(831, 538);
            this.dgv_personne.TabIndex = 8;
            this.dgv_personne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_personne_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "N°";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 48;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nom complet";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Genre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 72;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Telephone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 98;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Categorie";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 95;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Sous-categorie";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 131;
            // 
            // col_prs_stat
            // 
            this.col_prs_stat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_prs_stat.HeaderText = "statut";
            this.col_prs_stat.LinkColor = System.Drawing.Color.Black;
            this.col_prs_stat.Name = "col_prs_stat";
            this.col_prs_stat.ReadOnly = true;
            this.col_prs_stat.Width = 49;
            // 
            // col_prs_impr
            // 
            this.col_prs_impr.HeaderText = "";
            this.col_prs_impr.Image = global::IO_IDENTIFICATION.Properties.Resources.print;
            this.col_prs_impr.Name = "col_prs_impr";
            this.col_prs_impr.ReadOnly = true;
            this.col_prs_impr.Width = 40;
            // 
            // col_prs_mod
            // 
            this.col_prs_mod.HeaderText = "";
            this.col_prs_mod.Image = global::IO_IDENTIFICATION.Properties.Resources.pen_1;
            this.col_prs_mod.Name = "col_prs_mod";
            this.col_prs_mod.ReadOnly = true;
            this.col_prs_mod.Width = 40;
            // 
            // col_prs_sup
            // 
            this.col_prs_sup.HeaderText = "";
            this.col_prs_sup.Image = global::IO_IDENTIFICATION.Properties.Resources.delete_1;
            this.col_prs_sup.Name = "col_prs_sup";
            this.col_prs_sup.ReadOnly = true;
            this.col_prs_sup.Width = 40;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.lab_sous_cat_id);
            this.Panel2.Controls.Add(this.lab_cat_id);
            this.Panel2.Controls.Add(this.bt_parametre);
            this.Panel2.Controls.Add(this.cob_impression);
            this.Panel2.Controls.Add(this.bt_imprimer);
            this.Panel2.Controls.Add(this.bt_ajouter_sous_categorie);
            this.Panel2.Controls.Add(this.bt_ajouter_categorie);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.cob_genre);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.cob_categorie);
            this.Panel2.Controls.Add(this.cob_sous_categorie);
            this.Panel2.Controls.Add(this.bt_ajouter_personne);
            this.Panel2.Controls.Add(this.txt_recherche);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 40);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1184, 83);
            this.Panel2.TabIndex = 7;
            // 
            // lab_sous_cat_id
            // 
            this.lab_sous_cat_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_sous_cat_id.AutoSize = true;
            this.lab_sous_cat_id.Location = new System.Drawing.Point(842, 14);
            this.lab_sous_cat_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_sous_cat_id.Name = "lab_sous_cat_id";
            this.lab_sous_cat_id.Size = new System.Drawing.Size(132, 17);
            this.lab_sous_cat_id.TabIndex = 51;
            this.lab_sous_cat_id.Text = "Sous_Categorie_id";
            this.lab_sous_cat_id.Visible = false;
            // 
            // lab_cat_id
            // 
            this.lab_cat_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_cat_id.AutoSize = true;
            this.lab_cat_id.Location = new System.Drawing.Point(540, 14);
            this.lab_cat_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_cat_id.Name = "lab_cat_id";
            this.lab_cat_id.Size = new System.Drawing.Size(90, 17);
            this.lab_cat_id.TabIndex = 50;
            this.lab_cat_id.Text = "Categorie_id";
            this.lab_cat_id.Visible = false;
            // 
            // bt_parametre
            // 
            this.bt_parametre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_parametre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_parametre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_parametre.Image = global::IO_IDENTIFICATION.Properties.Resources.settings_2;
            this.bt_parametre.Location = new System.Drawing.Point(1146, 45);
            this.bt_parametre.Margin = new System.Windows.Forms.Padding(4);
            this.bt_parametre.Name = "bt_parametre";
            this.bt_parametre.Size = new System.Drawing.Size(30, 30);
            this.bt_parametre.TabIndex = 49;
            this.bt_parametre.UseVisualStyleBackColor = true;
            this.bt_parametre.Click += new System.EventHandler(this.bt_parametre_Click);
            // 
            // cob_impression
            // 
            this.cob_impression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cob_impression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_impression.FormattingEnabled = true;
            this.cob_impression.Location = new System.Drawing.Point(434, 47);
            this.cob_impression.Name = "cob_impression";
            this.cob_impression.Size = new System.Drawing.Size(240, 25);
            this.cob_impression.TabIndex = 48;
            // 
            // bt_imprimer
            // 
            this.bt_imprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_imprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_imprimer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimer.Location = new System.Drawing.Point(353, 45);
            this.bt_imprimer.Margin = new System.Windows.Forms.Padding(4);
            this.bt_imprimer.Name = "bt_imprimer";
            this.bt_imprimer.Size = new System.Drawing.Size(324, 30);
            this.bt_imprimer.TabIndex = 47;
            this.bt_imprimer.Text = "Imprimer";
            this.bt_imprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_imprimer.UseVisualStyleBackColor = true;
            this.bt_imprimer.Click += new System.EventHandler(this.bt_imprimer_Click);
            // 
            // bt_ajouter_sous_categorie
            // 
            this.bt_ajouter_sous_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ajouter_sous_categorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ajouter_sous_categorie.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouter_sous_categorie.Location = new System.Drawing.Point(684, 45);
            this.bt_ajouter_sous_categorie.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ajouter_sous_categorie.Name = "bt_ajouter_sous_categorie";
            this.bt_ajouter_sous_categorie.Size = new System.Drawing.Size(228, 30);
            this.bt_ajouter_sous_categorie.TabIndex = 46;
            this.bt_ajouter_sous_categorie.Text = "Ajouter une sous-categorie";
            this.bt_ajouter_sous_categorie.UseVisualStyleBackColor = true;
            this.bt_ajouter_sous_categorie.Click += new System.EventHandler(this.bt_ajouter_sous_categorie_Click);
            // 
            // bt_ajouter_categorie
            // 
            this.bt_ajouter_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ajouter_categorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ajouter_categorie.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouter_categorie.Location = new System.Drawing.Point(926, 45);
            this.bt_ajouter_categorie.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ajouter_categorie.Name = "bt_ajouter_categorie";
            this.bt_ajouter_categorie.Size = new System.Drawing.Size(212, 30);
            this.bt_ajouter_categorie.TabIndex = 45;
            this.bt_ajouter_categorie.Text = "Ajouter une categorie";
            this.bt_ajouter_categorie.UseVisualStyleBackColor = true;
            this.bt_ajouter_categorie.Click += new System.EventHandler(this.bt_ajouter_categorie_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1051, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Genre";
            // 
            // cob_genre
            // 
            this.cob_genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cob_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_genre.FormattingEnabled = true;
            this.cob_genre.Location = new System.Drawing.Point(1106, 11);
            this.cob_genre.Name = "cob_genre";
            this.cob_genre.Size = new System.Drawing.Size(70, 25);
            this.cob_genre.TabIndex = 43;
            this.cob_genre.SelectedIndexChanged += new System.EventHandler(this.cob_genre_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Sous-categorie";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Categorie";
            // 
            // cob_categorie
            // 
            this.cob_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cob_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_categorie.FormattingEnabled = true;
            this.cob_categorie.Location = new System.Drawing.Point(427, 11);
            this.cob_categorie.Name = "cob_categorie";
            this.cob_categorie.Size = new System.Drawing.Size(250, 25);
            this.cob_categorie.TabIndex = 40;
            this.cob_categorie.SelectedIndexChanged += new System.EventHandler(this.cob_categorie_SelectedIndexChanged);
            // 
            // cob_sous_categorie
            // 
            this.cob_sous_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cob_sous_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_sous_categorie.FormattingEnabled = true;
            this.cob_sous_categorie.Location = new System.Drawing.Point(795, 11);
            this.cob_sous_categorie.Name = "cob_sous_categorie";
            this.cob_sous_categorie.Size = new System.Drawing.Size(250, 25);
            this.cob_sous_categorie.TabIndex = 39;
            this.cob_sous_categorie.SelectedIndexChanged += new System.EventHandler(this.cob_sous_categorie_SelectedIndexChanged);
            // 
            // bt_ajouter_personne
            // 
            this.bt_ajouter_personne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ajouter_personne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ajouter_personne.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouter_personne.Location = new System.Drawing.Point(8, 45);
            this.bt_ajouter_personne.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ajouter_personne.Name = "bt_ajouter_personne";
            this.bt_ajouter_personne.Size = new System.Drawing.Size(337, 30);
            this.bt_ajouter_personne.TabIndex = 4;
            this.bt_ajouter_personne.Text = "Ajouter une personne";
            this.bt_ajouter_personne.UseVisualStyleBackColor = true;
            this.bt_ajouter_personne.Click += new System.EventHandler(this.bt_ajouter_personne_Click);
            // 
            // txt_recherche
            // 
            this.txt_recherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_recherche.Location = new System.Drawing.Point(94, 11);
            this.txt_recherche.Margin = new System.Windows.Forms.Padding(4);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(251, 24);
            this.txt_recherche.TabIndex = 0;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 15);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 17);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Recherche";
            // 
            // lab_titre
            // 
            this.lab_titre.BackColor = System.Drawing.Color.LightGray;
            this.lab_titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_titre.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_titre.Location = new System.Drawing.Point(0, 0);
            this.lab_titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_titre.Name = "lab_titre";
            this.lab_titre.Size = new System.Drawing.Size(1184, 40);
            this.lab_titre.TabIndex = 6;
            this.lab_titre.Text = "I.O. IDENTIFICATION";
            this.lab_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.dgv_sous_categorie);
            this.panel1.Controls.Add(this.dgv_categorie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(831, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 538);
            this.panel1.TabIndex = 9;
            // 
            // dgv_sous_categorie
            // 
            this.dgv_sous_categorie.AllowUserToAddRows = false;
            this.dgv_sous_categorie.AllowUserToDeleteRows = false;
            this.dgv_sous_categorie.AllowUserToResizeColumns = false;
            this.dgv_sous_categorie.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgv_sous_categorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_sous_categorie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_sous_categorie.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_sous_categorie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_sous_categorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sous_categorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_sous_categorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sous_categorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.col_sous_cat_mod,
            this.col_sous_cat_sup});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sous_categorie.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_sous_categorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sous_categorie.EnableHeadersVisualStyles = false;
            this.dgv_sous_categorie.GridColor = System.Drawing.Color.Black;
            this.dgv_sous_categorie.Location = new System.Drawing.Point(0, 271);
            this.dgv_sous_categorie.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_sous_categorie.Name = "dgv_sous_categorie";
            this.dgv_sous_categorie.ReadOnly = true;
            this.dgv_sous_categorie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_sous_categorie.RowHeadersVisible = false;
            this.dgv_sous_categorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sous_categorie.Size = new System.Drawing.Size(353, 267);
            this.dgv_sous_categorie.TabIndex = 10;
            this.dgv_sous_categorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sous_categorie_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "N°";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 48;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Sous-categorie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // col_sous_cat_mod
            // 
            this.col_sous_cat_mod.HeaderText = "";
            this.col_sous_cat_mod.Image = global::IO_IDENTIFICATION.Properties.Resources.pen_1;
            this.col_sous_cat_mod.Name = "col_sous_cat_mod";
            this.col_sous_cat_mod.ReadOnly = true;
            this.col_sous_cat_mod.Width = 40;
            // 
            // col_sous_cat_sup
            // 
            this.col_sous_cat_sup.HeaderText = "";
            this.col_sous_cat_sup.Image = global::IO_IDENTIFICATION.Properties.Resources.delete_1;
            this.col_sous_cat_sup.Name = "col_sous_cat_sup";
            this.col_sous_cat_sup.ReadOnly = true;
            this.col_sous_cat_sup.Width = 40;
            // 
            // dgv_categorie
            // 
            this.dgv_categorie.AllowUserToAddRows = false;
            this.dgv_categorie.AllowUserToDeleteRows = false;
            this.dgv_categorie.AllowUserToResizeColumns = false;
            this.dgv_categorie.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgv_categorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_categorie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_categorie.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_categorie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_categorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_categorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_categorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.col_cat_mod,
            this.col_cat_sup});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_categorie.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_categorie.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_categorie.EnableHeadersVisualStyles = false;
            this.dgv_categorie.GridColor = System.Drawing.Color.Black;
            this.dgv_categorie.Location = new System.Drawing.Point(0, 0);
            this.dgv_categorie.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_categorie.Name = "dgv_categorie";
            this.dgv_categorie.ReadOnly = true;
            this.dgv_categorie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_categorie.RowHeadersVisible = false;
            this.dgv_categorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_categorie.Size = new System.Drawing.Size(353, 271);
            this.dgv_categorie.TabIndex = 9;
            this.dgv_categorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categorie_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "N°";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 48;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Categorie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // col_cat_mod
            // 
            this.col_cat_mod.HeaderText = "";
            this.col_cat_mod.Image = global::IO_IDENTIFICATION.Properties.Resources.pen_1;
            this.col_cat_mod.Name = "col_cat_mod";
            this.col_cat_mod.ReadOnly = true;
            this.col_cat_mod.Width = 40;
            // 
            // col_cat_sup
            // 
            this.col_cat_sup.HeaderText = "";
            this.col_cat_sup.Image = global::IO_IDENTIFICATION.Properties.Resources.delete_1;
            this.col_cat_sup.Name = "col_cat_sup";
            this.col_cat_sup.ReadOnly = true;
            this.col_cat_sup.Width = 40;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::IO_IDENTIFICATION.Properties.Resources.print;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::IO_IDENTIFICATION.Properties.Resources.pen_1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::IO_IDENTIFICATION.Properties.Resources.delete_1;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 40;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgv_personne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.lab_titre);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personne)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sous_categorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv_personne;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button bt_ajouter_personne;
        internal System.Windows.Forms.TextBox txt_recherche;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lab_titre;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cob_genre;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cob_categorie;
        internal System.Windows.Forms.ComboBox cob_sous_categorie;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button bt_imprimer;
        internal System.Windows.Forms.Button bt_ajouter_sous_categorie;
        internal System.Windows.Forms.Button bt_ajouter_categorie;
        internal System.Windows.Forms.DataGridView dgv_sous_categorie;
        internal System.Windows.Forms.DataGridView dgv_categorie;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        internal System.Windows.Forms.ComboBox cob_impression;
        internal System.Windows.Forms.Button bt_parametre;
        internal System.Windows.Forms.Label lab_cat_id;
        internal System.Windows.Forms.Label lab_sous_cat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn col_sous_cat_mod;
        private System.Windows.Forms.DataGridViewImageColumn col_sous_cat_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn col_cat_mod;
        private System.Windows.Forms.DataGridViewImageColumn col_cat_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewLinkColumn col_prs_stat;
        private System.Windows.Forms.DataGridViewImageColumn col_prs_impr;
        private System.Windows.Forms.DataGridViewImageColumn col_prs_mod;
        private System.Windows.Forms.DataGridViewImageColumn col_prs_sup;
    }
}

