namespace IO_IDENTIFICATION
{
    partial class frm_parametre
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom_entite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_chemin_bdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_info_entite = new System.Windows.Forms.TextBox();
            this.lab_choisir_logo = new System.Windows.Forms.LinkLabel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nom_piece = new System.Windows.Forms.TextBox();
            this.num_id = new System.Windows.Forms.NumericUpDown();
            this.bt_ouvrir_bdd = new System.Windows.Forms.Button();
            this.bt_enregistrer = new System.Windows.Forms.Button();
            this.pic_type = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cob_type_piece = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_type)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 18);
            this.label9.TabIndex = 62;
            this.label9.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nom de l\'entité";
            // 
            // txt_nom_entite
            // 
            this.txt_nom_entite.Location = new System.Drawing.Point(123, 48);
            this.txt_nom_entite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom_entite.Name = "txt_nom_entite";
            this.txt_nom_entite.Size = new System.Drawing.Size(248, 26);
            this.txt_nom_entite.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Chemin bdd";
            // 
            // txt_chemin_bdd
            // 
            this.txt_chemin_bdd.Location = new System.Drawing.Point(105, 178);
            this.txt_chemin_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chemin_bdd.Name = "txt_chemin_bdd";
            this.txt_chemin_bdd.Size = new System.Drawing.Size(338, 26);
            this.txt_chemin_bdd.TabIndex = 5;
            this.txt_chemin_bdd.TextChanged += new System.EventHandler(this.txt_chemin_bdd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Info sur l\'entité";
            // 
            // txt_info_entite
            // 
            this.txt_info_entite.Location = new System.Drawing.Point(5, 110);
            this.txt_info_entite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_info_entite.Multiline = true;
            this.txt_info_entite.Name = "txt_info_entite";
            this.txt_info_entite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_info_entite.Size = new System.Drawing.Size(473, 61);
            this.txt_info_entite.TabIndex = 3;
            // 
            // lab_choisir_logo
            // 
            this.lab_choisir_logo.AutoSize = true;
            this.lab_choisir_logo.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lab_choisir_logo.Location = new System.Drawing.Point(278, 81);
            this.lab_choisir_logo.Name = "lab_choisir_logo";
            this.lab_choisir_logo.Size = new System.Drawing.Size(92, 18);
            this.lab_choisir_logo.TabIndex = 70;
            this.lab_choisir_logo.TabStop = true;
            this.lab_choisir_logo.Text = "Choisir logo";
            this.lab_choisir_logo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_choisir_logo_LinkClicked);
            // 
            // pic_logo
            // 
            this.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_logo.Location = new System.Drawing.Point(378, 5);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(100, 100);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 69;
            this.pic_logo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nom de la piece";
            // 
            // txt_nom_piece
            // 
            this.txt_nom_piece.Location = new System.Drawing.Point(203, 11);
            this.txt_nom_piece.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom_piece.Name = "txt_nom_piece";
            this.txt_nom_piece.Size = new System.Drawing.Size(168, 26);
            this.txt_nom_piece.TabIndex = 0;
            // 
            // num_id
            // 
            this.num_id.InterceptArrowKeys = false;
            this.num_id.Location = new System.Drawing.Point(28, 11);
            this.num_id.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_id.Name = "num_id";
            this.num_id.ReadOnly = true;
            this.num_id.Size = new System.Drawing.Size(47, 26);
            this.num_id.TabIndex = 10;
            this.num_id.ValueChanged += new System.EventHandler(this.num_id_ValueChanged);
            // 
            // bt_ouvrir_bdd
            // 
            this.bt_ouvrir_bdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ouvrir_bdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ouvrir_bdd.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ouvrir_bdd.Location = new System.Drawing.Point(448, 176);
            this.bt_ouvrir_bdd.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ouvrir_bdd.Name = "bt_ouvrir_bdd";
            this.bt_ouvrir_bdd.Size = new System.Drawing.Size(30, 30);
            this.bt_ouvrir_bdd.TabIndex = 4;
            this.bt_ouvrir_bdd.Text = "...";
            this.bt_ouvrir_bdd.UseVisualStyleBackColor = true;
            this.bt_ouvrir_bdd.Click += new System.EventHandler(this.bt_ouvrir_bdd_Click);
            // 
            // bt_enregistrer
            // 
            this.bt_enregistrer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enregistrer.Location = new System.Drawing.Point(80, 360);
            this.bt_enregistrer.Name = "bt_enregistrer";
            this.bt_enregistrer.Size = new System.Drawing.Size(300, 35);
            this.bt_enregistrer.TabIndex = 75;
            this.bt_enregistrer.Text = "Enregister";
            this.bt_enregistrer.UseVisualStyleBackColor = true;
            this.bt_enregistrer.Click += new System.EventHandler(this.bt_enregistrer_Click);
            // 
            // pic_type
            // 
            this.pic_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_type.Location = new System.Drawing.Point(203, 213);
            this.pic_type.Name = "pic_type";
            this.pic_type.Size = new System.Drawing.Size(275, 139);
            this.pic_type.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_type.TabIndex = 76;
            this.pic_type.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "Type de piece";
            // 
            // cob_type_piece
            // 
            this.cob_type_piece.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cob_type_piece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_type_piece.FormattingEnabled = true;
            this.cob_type_piece.Items.AddRange(new object[] {
            "type 1"});
            this.cob_type_piece.Location = new System.Drawing.Point(5, 241);
            this.cob_type_piece.Name = "cob_type_piece";
            this.cob_type_piece.Size = new System.Drawing.Size(190, 26);
            this.cob_type_piece.TabIndex = 77;
            this.cob_type_piece.SelectedIndexChanged += new System.EventHandler(this.cob_categorie_SelectedIndexChanged);
            // 
            // frm_parametre
            // 
            this.AcceptButton = this.bt_enregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(484, 400);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cob_type_piece);
            this.Controls.Add(this.pic_type);
            this.Controls.Add(this.bt_enregistrer);
            this.Controls.Add(this.bt_ouvrir_bdd);
            this.Controls.Add(this.num_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nom_piece);
            this.Controls.Add(this.lab_choisir_logo);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_info_entite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_chemin_bdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom_entite);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_parametre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.frm_parametre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txt_nom_entite;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txt_chemin_bdd;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txt_info_entite;
        private System.Windows.Forms.LinkLabel lab_choisir_logo;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txt_nom_piece;
        internal System.Windows.Forms.Button bt_ouvrir_bdd;
        internal System.Windows.Forms.Button bt_enregistrer;
        internal System.Windows.Forms.NumericUpDown num_id;
        private System.Windows.Forms.PictureBox pic_type;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cob_type_piece;
    }
}