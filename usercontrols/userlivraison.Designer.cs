namespace gestion_vente_pharmacie.usercontrols
{
    partial class userlivraison
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datelivraison = new System.Windows.Forms.DateTimePicker();
            this.txtprixu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmedicament = new System.Windows.Forms.ComboBox();
            this.cmbfournisseur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.dglivraison = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprixu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglivraison)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datelivraison);
            this.groupBox1.Controls.Add(this.txtprixu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtquantite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbmedicament);
            this.groupBox1.Controls.Add(this.cmbfournisseur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(103, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement livraison";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(739, 24);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(70, 39);
            this.txtcode.TabIndex = 10;
            this.txtcode.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "date livraison";
            // 
            // datelivraison
            // 
            this.datelivraison.Location = new System.Drawing.Point(315, 153);
            this.datelivraison.Name = "datelivraison";
            this.datelivraison.Size = new System.Drawing.Size(225, 27);
            this.datelivraison.TabIndex = 8;
            // 
            // txtprixu
            // 
            this.txtprixu.Location = new System.Drawing.Point(50, 153);
            this.txtprixu.Multiline = true;
            this.txtprixu.Name = "txtprixu";
            this.txtprixu.Size = new System.Drawing.Size(196, 27);
            this.txtprixu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "prix unitaire";
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(574, 79);
            this.txtquantite.Multiline = true;
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(196, 29);
            this.txtquantite.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "quantite";
            // 
            // cmbmedicament
            // 
            this.cmbmedicament.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbmedicament.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbmedicament.FormattingEnabled = true;
            this.cmbmedicament.Location = new System.Drawing.Point(315, 79);
            this.cmbmedicament.Name = "cmbmedicament";
            this.cmbmedicament.Size = new System.Drawing.Size(236, 29);
            this.cmbmedicament.TabIndex = 3;
            // 
            // cmbfournisseur
            // 
            this.cmbfournisseur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbfournisseur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbfournisseur.FormattingEnabled = true;
            this.cmbfournisseur.Location = new System.Drawing.Point(50, 79);
            this.cmbfournisseur.Name = "cmbfournisseur";
            this.cmbfournisseur.Size = new System.Drawing.Size(236, 29);
            this.cmbfournisseur.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fournisseur";
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnsupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Location = new System.Drawing.Point(936, 204);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(123, 40);
            this.btnsupprimer.TabIndex = 12;
            this.btnsupprimer.Text = "SUPPRIMER";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(936, 142);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 40);
            this.btnmodifier.TabIndex = 11;
            this.btnmodifier.Text = "MODFIER";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.SeaGreen;
            this.btnajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.Location = new System.Drawing.Point(936, 76);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(123, 40);
            this.btnajouter.TabIndex = 10;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // dglivraison
            // 
            this.dglivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglivraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglivraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgfournisseur,
            this.dgmedicament,
            this.dgquantite,
            this.dgprixu,
            this.dgdate});
            this.dglivraison.Location = new System.Drawing.Point(39, 327);
            this.dglivraison.Name = "dglivraison";
            this.dglivraison.Size = new System.Drawing.Size(1020, 203);
            this.dglivraison.TabIndex = 13;
            this.dglivraison.DoubleClick += new System.EventHandler(this.dglivraison_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codelivraison";
            this.dgcode.HeaderText = "codelivraison";
            this.dgcode.Name = "dgcode";
            // 
            // dgfournisseur
            // 
            this.dgfournisseur.DataPropertyName = "reffournisseur";
            this.dgfournisseur.HeaderText = "fournisseur";
            this.dgfournisseur.Name = "dgfournisseur";
            // 
            // dgmedicament
            // 
            this.dgmedicament.DataPropertyName = "refmedicament";
            this.dgmedicament.HeaderText = "medicament";
            this.dgmedicament.Name = "dgmedicament";
            // 
            // dgquantite
            // 
            this.dgquantite.DataPropertyName = "quantite";
            this.dgquantite.HeaderText = "quantite";
            this.dgquantite.Name = "dgquantite";
            // 
            // dgprixu
            // 
            this.dgprixu.DataPropertyName = "prixu";
            this.dgprixu.HeaderText = "prixU";
            this.dgprixu.Name = "dgprixu";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "date_livraison";
            this.dgdate.HeaderText = "date-livraison";
            this.dgdate.Name = "dgdate";
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(759, 290);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(198, 31);
            this.txtrecherche.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(663, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "recherche";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(961, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "IMPRIMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userlivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dglivraison);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnajouter);
            this.Name = "userlivraison";
            this.Size = new System.Drawing.Size(1087, 550);
            this.Load += new System.EventHandler(this.userlivraison_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglivraison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datelivraison;
        private System.Windows.Forms.TextBox txtprixu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmedicament;
        private System.Windows.Forms.ComboBox cmbfournisseur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.DataGridView dglivraison;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprixu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
        private System.Windows.Forms.Button button1;
    }
}
