namespace IO_IDENTIFICATION
{
    partial class frm_personne
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
            this.bt_enregistrer = new System.Windows.Forms.Button();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_post_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lieu_naissance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_date_naissance = new System.Windows.Forms.DateTimePicker();
            this.pic_photo = new System.Windows.Forms.PictureBox();
            this.lab_sous_cat_id = new System.Windows.Forms.Label();
            this.lab_cat_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cob_categorie = new System.Windows.Forms.ComboBox();
            this.cob_sous_categorie = new System.Windows.Forms.ComboBox();
            this.cob_genre = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_choix_photo = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_avenue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_quartier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_commune = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_code_identification = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_code_electeur = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.num_telephone = new System.Windows.Forms.NumericUpDown();
            this.num_telephone_urgence = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_telephone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_telephone_urgence)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_enregistrer
            // 
            this.bt_enregistrer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enregistrer.Location = new System.Drawing.Point(100, 500);
            this.bt_enregistrer.Name = "bt_enregistrer";
            this.bt_enregistrer.Size = new System.Drawing.Size(300, 35);
            this.bt_enregistrer.TabIndex = 33;
            this.bt_enregistrer.Text = "Enregister";
            this.bt_enregistrer.UseVisualStyleBackColor = true;
            this.bt_enregistrer.Click += new System.EventHandler(this.bt_enregistrer_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(94, 11);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(407, 26);
            this.txt_nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Post-nom";
            // 
            // txt_post_nom
            // 
            this.txt_post_nom.Location = new System.Drawing.Point(94, 45);
            this.txt_post_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_post_nom.Name = "txt_post_nom";
            this.txt_post_nom.Size = new System.Drawing.Size(407, 26);
            this.txt_post_nom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Prénom";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(94, 79);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(279, 26);
            this.txt_prenom.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Lieu de naissance";
            // 
            // txt_lieu_naissance
            // 
            this.txt_lieu_naissance.Location = new System.Drawing.Point(154, 113);
            this.txt_lieu_naissance.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lieu_naissance.Name = "txt_lieu_naissance";
            this.txt_lieu_naissance.Size = new System.Drawing.Size(347, 26);
            this.txt_lieu_naissance.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Date de naissance";
            // 
            // dt_date_naissance
            // 
            this.dt_date_naissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_date_naissance.Location = new System.Drawing.Point(154, 150);
            this.dt_date_naissance.Name = "dt_date_naissance";
            this.dt_date_naissance.Size = new System.Drawing.Size(237, 26);
            this.dt_date_naissance.TabIndex = 5;
            // 
            // pic_photo
            // 
            this.pic_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_photo.Location = new System.Drawing.Point(401, 144);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(100, 110);
            this.pic_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_photo.TabIndex = 44;
            this.pic_photo.TabStop = false;
            // 
            // lab_sous_cat_id
            // 
            this.lab_sous_cat_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_sous_cat_id.AutoSize = true;
            this.lab_sous_cat_id.Location = new System.Drawing.Point(235, 260);
            this.lab_sous_cat_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_sous_cat_id.Name = "lab_sous_cat_id";
            this.lab_sous_cat_id.Size = new System.Drawing.Size(145, 18);
            this.lab_sous_cat_id.TabIndex = 57;
            this.lab_sous_cat_id.Text = "Sous_Categorie_id";
            this.lab_sous_cat_id.Visible = false;
            // 
            // lab_cat_id
            // 
            this.lab_cat_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_cat_id.AutoSize = true;
            this.lab_cat_id.Location = new System.Drawing.Point(280, 225);
            this.lab_cat_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_cat_id.Name = "lab_cat_id";
            this.lab_cat_id.Size = new System.Drawing.Size(100, 18);
            this.lab_cat_id.TabIndex = 56;
            this.lab_cat_id.Text = "Categorie_id";
            this.lab_cat_id.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Sous-categorie";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "Categorie";
            // 
            // cob_categorie
            // 
            this.cob_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cob_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_categorie.FormattingEnabled = true;
            this.cob_categorie.Location = new System.Drawing.Point(154, 222);
            this.cob_categorie.Name = "cob_categorie";
            this.cob_categorie.Size = new System.Drawing.Size(237, 26);
            this.cob_categorie.TabIndex = 7;
            this.cob_categorie.SelectedIndexChanged += new System.EventHandler(this.cob_categorie_SelectedIndexChanged);
            // 
            // cob_sous_categorie
            // 
            this.cob_sous_categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cob_sous_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_sous_categorie.FormattingEnabled = true;
            this.cob_sous_categorie.Location = new System.Drawing.Point(154, 257);
            this.cob_sous_categorie.Name = "cob_sous_categorie";
            this.cob_sous_categorie.Size = new System.Drawing.Size(237, 26);
            this.cob_sous_categorie.TabIndex = 8;
            this.cob_sous_categorie.SelectedIndexChanged += new System.EventHandler(this.cob_sous_categorie_SelectedIndexChanged);
            // 
            // cob_genre
            // 
            this.cob_genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cob_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_genre.FormattingEnabled = true;
            this.cob_genre.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cob_genre.Location = new System.Drawing.Point(437, 80);
            this.cob_genre.Name = "cob_genre";
            this.cob_genre.Size = new System.Drawing.Size(65, 26);
            this.cob_genre.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Téléphone";
            // 
            // lab_choix_photo
            // 
            this.lab_choix_photo.AutoSize = true;
            this.lab_choix_photo.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lab_choix_photo.Location = new System.Drawing.Point(401, 261);
            this.lab_choix_photo.Name = "lab_choix_photo";
            this.lab_choix_photo.Size = new System.Drawing.Size(101, 18);
            this.lab_choix_photo.TabIndex = 61;
            this.lab_choix_photo.TabStop = true;
            this.lab_choix_photo.Text = "Choisir photo";
            this.lab_choix_photo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_choix_photo_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_avenue);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_quartier);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_commune);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_ville);
            this.groupBox1.Location = new System.Drawing.Point(12, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adresse";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(386, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 18);
            this.label14.TabIndex = 44;
            this.label14.Text = "N°";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(412, 63);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(69, 26);
            this.txt_numero.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 18);
            this.label13.TabIndex = 42;
            this.label13.Text = "Av/";
            // 
            // txt_avenue
            // 
            this.txt_avenue.Location = new System.Drawing.Point(230, 63);
            this.txt_avenue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_avenue.Name = "txt_avenue";
            this.txt_avenue.Size = new System.Drawing.Size(151, 26);
            this.txt_avenue.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 18);
            this.label12.TabIndex = 40;
            this.label12.Text = "Q/";
            // 
            // txt_quartier
            // 
            this.txt_quartier.Location = new System.Drawing.Point(34, 63);
            this.txt_quartier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quartier.Name = "txt_quartier";
            this.txt_quartier.Size = new System.Drawing.Size(157, 26);
            this.txt_quartier.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 18);
            this.label11.TabIndex = 38;
            this.label11.Text = "C/";
            // 
            // txt_commune
            // 
            this.txt_commune.Location = new System.Drawing.Point(273, 26);
            this.txt_commune.Margin = new System.Windows.Forms.Padding(4);
            this.txt_commune.Name = "txt_commune";
            this.txt_commune.Size = new System.Drawing.Size(208, 26);
            this.txt_commune.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "V/";
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(34, 26);
            this.txt_ville.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(204, 26);
            this.txt_ville.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 468);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 18);
            this.label15.TabIndex = 66;
            this.label15.Text = "Code d\'identification";
            // 
            // txt_code_identification
            // 
            this.txt_code_identification.Location = new System.Drawing.Point(176, 465);
            this.txt_code_identification.Margin = new System.Windows.Forms.Padding(4);
            this.txt_code_identification.Name = "txt_code_identification";
            this.txt_code_identification.ReadOnly = true;
            this.txt_code_identification.Size = new System.Drawing.Size(325, 26);
            this.txt_code_identification.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 399);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 18);
            this.label16.TabIndex = 64;
            this.label16.Text = "Code carte d\'électeur";
            // 
            // txt_code_electeur
            // 
            this.txt_code_electeur.Location = new System.Drawing.Point(176, 396);
            this.txt_code_electeur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_code_electeur.Name = "txt_code_electeur";
            this.txt_code_electeur.Size = new System.Drawing.Size(325, 26);
            this.txt_code_electeur.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 434);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(207, 18);
            this.label17.TabIndex = 68;
            this.label17.Text = "Numero téléphone d\'urgence";
            // 
            // num_telephone
            // 
            this.num_telephone.Location = new System.Drawing.Point(154, 188);
            this.num_telephone.Maximum = new decimal(new int[] {
            -813135873,
            56,
            0,
            0});
            this.num_telephone.Name = "num_telephone";
            this.num_telephone.Size = new System.Drawing.Size(237, 26);
            this.num_telephone.TabIndex = 6;
            this.num_telephone.Value = new decimal(new int[] {
            243,
            0,
            0,
            0});
            // 
            // num_telephone_urgence
            // 
            this.num_telephone_urgence.Location = new System.Drawing.Point(226, 430);
            this.num_telephone_urgence.Maximum = new decimal(new int[] {
            -813135873,
            56,
            0,
            0});
            this.num_telephone_urgence.Name = "num_telephone_urgence";
            this.num_telephone_urgence.Size = new System.Drawing.Size(276, 26);
            this.num_telephone_urgence.TabIndex = 11;
            this.num_telephone_urgence.Value = new decimal(new int[] {
            243,
            0,
            0,
            0});
            // 
            // frm_personne
            // 
            this.AcceptButton = this.bt_enregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(514, 541);
            this.Controls.Add(this.num_telephone_urgence);
            this.Controls.Add(this.num_telephone);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_code_identification);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_code_electeur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_choix_photo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cob_genre);
            this.Controls.Add(this.lab_sous_cat_id);
            this.Controls.Add(this.lab_cat_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cob_categorie);
            this.Controls.Add(this.cob_sous_categorie);
            this.Controls.Add(this.pic_photo);
            this.Controls.Add(this.dt_date_naissance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_lieu_naissance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_post_nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_enregistrer);
            this.Controls.Add(this.txt_nom);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_personne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indentification de la personne";
            this.Load += new System.EventHandler(this.frm_personne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_telephone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_telephone_urgence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button bt_enregistrer;
        internal System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txt_post_nom;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txt_lieu_naissance;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lab_sous_cat_id;
        internal System.Windows.Forms.Label lab_cat_id;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cob_categorie;
        internal System.Windows.Forms.ComboBox cob_sous_categorie;
        internal System.Windows.Forms.ComboBox cob_genre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lab_choix_photo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txt_avenue;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txt_quartier;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txt_commune;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txt_code_identification;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txt_code_electeur;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.PictureBox pic_photo;
        internal System.Windows.Forms.DateTimePicker dt_date_naissance;
        internal System.Windows.Forms.NumericUpDown num_telephone;
        internal System.Windows.Forms.NumericUpDown num_telephone_urgence;
    }
}