namespace gestion_vente_pharmacie.usercontrols
{
    partial class userpayement
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
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgpayement = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrefpatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrefachat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datepayement = new System.Windows.Forms.DateTimePicker();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.montant = new System.Windows.Forms.Label();
            this.cmbmedicament = new System.Windows.Forms.ComboBox();
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgpayement)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(726, 275);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(198, 31);
            this.txtrecherche.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(630, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "recherche";
            // 
            // dgpayement
            // 
            this.dgpayement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgpayement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpayement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgrefpatient,
            this.dgrefachat,
            this.dgmontant,
            this.dgdate});
            this.dgpayement.Location = new System.Drawing.Point(33, 312);
            this.dgpayement.Name = "dgpayement";
            this.dgpayement.Size = new System.Drawing.Size(1020, 203);
            this.dgpayement.TabIndex = 21;
            this.dgpayement.DoubleClick += new System.EventHandler(this.dgpayement_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "Codepayement";
            this.dgcode.HeaderText = "codepayement";
            this.dgcode.Name = "dgcode";
            // 
            // dgrefpatient
            // 
            this.dgrefpatient.DataPropertyName = "Refpatient";
            this.dgrefpatient.HeaderText = "patient";
            this.dgrefpatient.Name = "dgrefpatient";
            // 
            // dgrefachat
            // 
            this.dgrefachat.DataPropertyName = "Refmedicament";
            this.dgrefachat.HeaderText = "medicament";
            this.dgrefachat.Name = "dgrefachat";
            // 
            // dgmontant
            // 
            this.dgmontant.DataPropertyName = "Montant";
            this.dgmontant.HeaderText = "montant";
            this.dgmontant.Name = "dgmontant";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "Datepayement";
            this.dgdate.HeaderText = "date-payement";
            this.dgdate.Name = "dgdate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datepayement);
            this.groupBox1.Controls.Add(this.txtmontant);
            this.groupBox1.Controls.Add(this.montant);
            this.groupBox1.Controls.Add(this.cmbmedicament);
            this.groupBox1.Controls.Add(this.cmbpatient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 213);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement livraison";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(726, 22);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(85, 31);
            this.txtcode.TabIndex = 24;
            this.txtcode.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "date payement";
            // 
            // datepayement
            // 
            this.datepayement.Location = new System.Drawing.Point(408, 150);
            this.datepayement.Name = "datepayement";
            this.datepayement.Size = new System.Drawing.Size(280, 27);
            this.datepayement.TabIndex = 8;
            // 
            // txtmontant
            // 
            this.txtmontant.Location = new System.Drawing.Point(94, 150);
            this.txtmontant.Multiline = true;
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(236, 27);
            this.txtmontant.TabIndex = 7;
            // 
            // montant
            // 
            this.montant.AutoSize = true;
            this.montant.Location = new System.Drawing.Point(90, 114);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(80, 21);
            this.montant.TabIndex = 6;
            this.montant.Text = "montant";
            // 
            // cmbmedicament
            // 
            this.cmbmedicament.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbmedicament.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbmedicament.FormattingEnabled = true;
            this.cmbmedicament.Location = new System.Drawing.Point(408, 76);
            this.cmbmedicament.Name = "cmbmedicament";
            this.cmbmedicament.Size = new System.Drawing.Size(280, 29);
            this.cmbmedicament.TabIndex = 3;
            // 
            // cmbpatient
            // 
            this.cmbpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpatient.FormattingEnabled = true;
            this.cmbpatient.Location = new System.Drawing.Point(94, 76);
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(236, 29);
            this.cmbpatient.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medicament Achater";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(944, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "SUPPRIMER";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(944, 124);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 40);
            this.btnmodifier.TabIndex = 14;
            this.btnmodifier.Text = "MODFIER";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.SeaGreen;
            this.btnajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.Location = new System.Drawing.Point(944, 58);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(123, 40);
            this.btnajouter.TabIndex = 13;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(930, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "RECU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userpayement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgpayement);
            this.Controls.Add(this.groupBox1);
            this.Name = "userpayement";
            this.Size = new System.Drawing.Size(1087, 550);
            this.Load += new System.EventHandler(this.userpayement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgpayement)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgpayement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datepayement;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Label montant;
        private System.Windows.Forms.ComboBox cmbmedicament;
        private System.Windows.Forms.ComboBox cmbpatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrefpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrefachat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
        private System.Windows.Forms.Button button1;
    }
}
