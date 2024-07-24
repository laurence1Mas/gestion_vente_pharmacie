namespace gestion_vente_pharmacie.usercontrols
{
    partial class userachat
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
            this.dgachat = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprixu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateachat = new System.Windows.Forms.DateTimePicker();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.montant = new System.Windows.Forms.Label();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmedicament = new System.Windows.Forms.ComboBox();
            this.cmbpatient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgachat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(128, 278);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(198, 31);
            this.txtrecherche.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "recherche";
            // 
            // dgachat
            // 
            this.dgachat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgachat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgachat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgpatient,
            this.dgmedicament,
            this.dgquantite,
            this.dgprixu,
            this.dgdate});
            this.dgachat.Location = new System.Drawing.Point(33, 312);
            this.dgachat.Name = "dgachat";
            this.dgachat.Size = new System.Drawing.Size(1020, 203);
            this.dgachat.TabIndex = 17;
            this.dgachat.DoubleClick += new System.EventHandler(this.dgachat_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codeachat";
            this.dgcode.HeaderText = "code";
            this.dgcode.Name = "dgcode";
            // 
            // dgpatient
            // 
            this.dgpatient.DataPropertyName = "refpatient";
            this.dgpatient.HeaderText = "patient";
            this.dgpatient.Name = "dgpatient";
            // 
            // dgmedicament
            // 
            this.dgmedicament.DataPropertyName = "refmedicament";
            this.dgmedicament.HeaderText = "medicament";
            this.dgmedicament.Name = "dgmedicament";
            // 
            // dgquantite
            // 
            this.dgquantite.DataPropertyName = "Quantite";
            this.dgquantite.HeaderText = "quantite";
            this.dgquantite.Name = "dgquantite";
            // 
            // dgprixu
            // 
            this.dgprixu.DataPropertyName = "prixU";
            this.dgprixu.HeaderText = "prixU";
            this.dgprixu.Name = "dgprixu";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "date_achat";
            this.dgdate.HeaderText = "date-achat";
            this.dgdate.Name = "dgdate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateachat);
            this.groupBox1.Controls.Add(this.txtmontant);
            this.groupBox1.Controls.Add(this.montant);
            this.groupBox1.Controls.Add(this.txtquantite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbmedicament);
            this.groupBox1.Controls.Add(this.cmbpatient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 213);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement livraison";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(749, 26);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(72, 31);
            this.txtcode.TabIndex = 20;
            this.txtcode.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "date achat";
            // 
            // dateachat
            // 
            this.dateachat.Location = new System.Drawing.Point(315, 141);
            this.dateachat.Name = "dateachat";
            this.dateachat.Size = new System.Drawing.Size(236, 27);
            this.dateachat.TabIndex = 8;
            // 
            // txtmontant
            // 
            this.txtmontant.Location = new System.Drawing.Point(50, 141);
            this.txtmontant.Multiline = true;
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(236, 29);
            this.txtmontant.TabIndex = 7;
            // 
            // montant
            // 
            this.montant.AutoSize = true;
            this.montant.Location = new System.Drawing.Point(46, 117);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(80, 21);
            this.montant.TabIndex = 6;
            this.montant.Text = "montant";
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(574, 79);
            this.txtquantite.Multiline = true;
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(236, 29);
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
            // cmbpatient
            // 
            this.cmbpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpatient.FormattingEnabled = true;
            this.cmbpatient.Location = new System.Drawing.Point(50, 79);
            this.cmbpatient.Name = "cmbpatient";
            this.cmbpatient.Size = new System.Drawing.Size(236, 29);
            this.cmbpatient.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnsupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Location = new System.Drawing.Point(943, 189);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(123, 40);
            this.btnsupprimer.TabIndex = 15;
            this.btnsupprimer.Text = "SUPPRIMER";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(943, 127);
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
            this.btnajouter.Location = new System.Drawing.Point(943, 61);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(123, 40);
            this.btnajouter.TabIndex = 13;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "FACTURE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(824, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "LISTE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // userachat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgachat);
            this.Controls.Add(this.groupBox1);
            this.Name = "userachat";
            this.Size = new System.Drawing.Size(1087, 550);
            this.Load += new System.EventHandler(this.userachat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgachat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgachat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateachat;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.Label montant;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmedicament;
        private System.Windows.Forms.ComboBox cmbpatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprixu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
