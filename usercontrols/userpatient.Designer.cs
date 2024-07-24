namespace gestion_vente_pharmacie.usercontrols
{
    partial class userpatient
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
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datenaiss = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbetat = new System.Windows.Forms.ComboBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.cmbgenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpostnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgpatient = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpostnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgetat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpatient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsupprimer);
            this.groupBox1.Controls.Add(this.btnmodifier);
            this.groupBox1.Controls.Add(this.btnajouter);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Patient";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnsupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.Color.White;
            this.btnsupprimer.Location = new System.Drawing.Point(928, 204);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(123, 40);
            this.btnsupprimer.TabIndex = 4;
            this.btnsupprimer.Text = "SUPPRIMER";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(928, 142);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 40);
            this.btnmodifier.TabIndex = 3;
            this.btnmodifier.Text = "MODFIER";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.SeaGreen;
            this.btnajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.Location = new System.Drawing.Point(928, 76);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(123, 40);
            this.btnajouter.TabIndex = 2;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datenaiss);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbetat);
            this.groupBox3.Controls.Add(this.txtadresse);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txttelephone);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(480, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 222);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autres ";
            // 
            // datenaiss
            // 
            this.datenaiss.Location = new System.Drawing.Point(238, 79);
            this.datenaiss.Name = "datenaiss";
            this.datenaiss.Size = new System.Drawing.Size(198, 27);
            this.datenaiss.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "date-nasissance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "telephone";
            // 
            // cmbetat
            // 
            this.cmbetat.FormattingEnabled = true;
            this.cmbetat.Items.AddRange(new object[] {
            "celibataire",
            "marie",
            "divorce"});
            this.cmbetat.Location = new System.Drawing.Point(6, 77);
            this.cmbetat.Name = "cmbetat";
            this.cmbetat.Size = new System.Drawing.Size(212, 29);
            this.cmbetat.TabIndex = 8;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(6, 152);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(212, 29);
            this.txtadresse.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "adresse";
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(238, 152);
            this.txttelephone.Multiline = true;
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(198, 29);
            this.txttelephone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "etat-civil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.cmbgenre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtpostnom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtprenom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtnom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(32, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 222);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Noms";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(362, 13);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(74, 30);
            this.txtcode.TabIndex = 8;
            this.txtcode.Visible = false;
            // 
            // cmbgenre
            // 
            this.cmbgenre.FormattingEnabled = true;
            this.cmbgenre.Items.AddRange(new object[] {
            "masculin",
            "feminin"});
            this.cmbgenre.Location = new System.Drawing.Point(238, 152);
            this.cmbgenre.Name = "cmbgenre";
            this.cmbgenre.Size = new System.Drawing.Size(198, 29);
            this.cmbgenre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "genre";
            // 
            // txtpostnom
            // 
            this.txtpostnom.Location = new System.Drawing.Point(238, 77);
            this.txtpostnom.Multiline = true;
            this.txtpostnom.Name = "txtpostnom";
            this.txtpostnom.Size = new System.Drawing.Size(198, 29);
            this.txtpostnom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "postnom";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(21, 152);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(198, 29);
            this.txtprenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "prenom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(21, 77);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(198, 29);
            this.txtnom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // dgpatient
            // 
            this.dgpatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgnom,
            this.dgpostnom,
            this.dgprenom,
            this.dggenre,
            this.dgetat,
            this.dgdate,
            this.dgage,
            this.dgadresse,
            this.dgtelephone});
            this.dgpatient.Location = new System.Drawing.Point(15, 364);
            this.dgpatient.Name = "dgpatient";
            this.dgpatient.Size = new System.Drawing.Size(1057, 168);
            this.dgpatient.TabIndex = 0;
            this.dgpatient.DoubleClick += new System.EventHandler(this.dgpatient_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codepatient";
            this.dgcode.HeaderText = "codepatient";
            this.dgcode.Name = "dgcode";
            // 
            // dgnom
            // 
            this.dgnom.DataPropertyName = "nom";
            this.dgnom.HeaderText = "nom";
            this.dgnom.Name = "dgnom";
            // 
            // dgpostnom
            // 
            this.dgpostnom.DataPropertyName = "postnom";
            this.dgpostnom.HeaderText = "postnom";
            this.dgpostnom.Name = "dgpostnom";
            // 
            // dgprenom
            // 
            this.dgprenom.DataPropertyName = "prenom";
            this.dgprenom.HeaderText = "prenom";
            this.dgprenom.Name = "dgprenom";
            // 
            // dggenre
            // 
            this.dggenre.DataPropertyName = "genre";
            this.dggenre.HeaderText = "genre";
            this.dggenre.Name = "dggenre";
            // 
            // dgetat
            // 
            this.dgetat.DataPropertyName = "etat_civil";
            this.dgetat.HeaderText = "etat-civil";
            this.dgetat.Name = "dgetat";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "date_naissance";
            this.dgdate.HeaderText = "datenaissance";
            this.dgdate.Name = "dgdate";
            // 
            // dgage
            // 
            this.dgage.DataPropertyName = "age";
            this.dgage.HeaderText = "age";
            this.dgage.Name = "dgage";
            // 
            // dgadresse
            // 
            this.dgadresse.DataPropertyName = "adresse";
            this.dgadresse.HeaderText = "adresse";
            this.dgadresse.Name = "dgadresse";
            // 
            // dgtelephone
            // 
            this.dgtelephone.DataPropertyName = "numero";
            this.dgtelephone.HeaderText = "telephone";
            this.dgtelephone.Name = "dgtelephone";
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(761, 327);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(198, 31);
            this.txtrecherche.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(665, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "recherche";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(961, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "IMPRIMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgpatient);
            this.Controls.Add(this.groupBox1);
            this.Name = "userpatient";
            this.Size = new System.Drawing.Size(1087, 550);
            this.Load += new System.EventHandler(this.userpatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgpatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbgenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpostnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbetat;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datenaiss;
        private System.Windows.Forms.DataGridView dgpatient;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpostnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgetat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtelephone;
        private System.Windows.Forms.Button button1;
    }
}
