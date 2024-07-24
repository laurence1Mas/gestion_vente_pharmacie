namespace gestion_vente_pharmacie.usercontrols
{
    partial class usermedicament
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
            this.txtcode1 = new System.Windows.Forms.TextBox();
            this.btnsupprimermed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.cmbcategorie = new System.Windows.Forms.ComboBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcode2 = new System.Windows.Forms.TextBox();
            this.btnsupprimercat = new System.Windows.Forms.Button();
            this.btnmodifiercat = new System.Windows.Forms.Button();
            this.txtdesignation1 = new System.Windows.Forms.TextBox();
            this.btnajoutercat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgmedicament = new System.Windows.Forms.DataGridView();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrefcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcategorie = new System.Windows.Forms.DataGridView();
            this.dgcode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbstock = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbstock);
            this.groupBox1.Controls.Add(this.txtcode1);
            this.groupBox1.Controls.Add(this.btnsupprimermed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnmodifier);
            this.groupBox1.Controls.Add(this.cmbcategorie);
            this.groupBox1.Controls.Add(this.btnajouter);
            this.groupBox1.Controls.Add(this.txtdesignation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Medicament";
            // 
            // txtcode1
            // 
            this.txtcode1.Location = new System.Drawing.Point(398, 26);
            this.txtcode1.Multiline = true;
            this.txtcode1.Name = "txtcode1";
            this.txtcode1.Size = new System.Drawing.Size(73, 35);
            this.txtcode1.TabIndex = 8;
            this.txtcode1.Visible = false;
            // 
            // btnsupprimermed
            // 
            this.btnsupprimermed.BackColor = System.Drawing.Color.DarkRed;
            this.btnsupprimermed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimermed.ForeColor = System.Drawing.Color.White;
            this.btnsupprimermed.Location = new System.Drawing.Point(337, 162);
            this.btnsupprimermed.Name = "btnsupprimermed";
            this.btnsupprimermed.Size = new System.Drawing.Size(123, 40);
            this.btnsupprimermed.TabIndex = 7;
            this.btnsupprimermed.Text = "SUPPRIMER";
            this.btnsupprimermed.UseVisualStyleBackColor = false;
            this.btnsupprimermed.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "categorie";
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.White;
            this.btnmodifier.Location = new System.Drawing.Point(179, 162);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 40);
            this.btnmodifier.TabIndex = 6;
            this.btnmodifier.Text = "MODFIER";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // cmbcategorie
            // 
            this.cmbcategorie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbcategorie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcategorie.FormattingEnabled = true;
            this.cmbcategorie.Location = new System.Drawing.Point(37, 127);
            this.cmbcategorie.Name = "cmbcategorie";
            this.cmbcategorie.Size = new System.Drawing.Size(197, 29);
            this.cmbcategorie.TabIndex = 2;
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.SeaGreen;
            this.btnajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.Color.White;
            this.btnajouter.Location = new System.Drawing.Point(25, 162);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(123, 40);
            this.btnajouter.TabIndex = 5;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(38, 53);
            this.txtdesignation.Multiline = true;
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(198, 29);
            this.txtdesignation.TabIndex = 1;
            this.txtdesignation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesignation_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "designation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcode2);
            this.groupBox2.Controls.Add(this.btnsupprimercat);
            this.groupBox2.Controls.Add(this.btnmodifiercat);
            this.groupBox2.Controls.Add(this.txtdesignation1);
            this.groupBox2.Controls.Add(this.btnajoutercat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(559, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enregistrement Categorie med";
            // 
            // txtcode2
            // 
            this.txtcode2.Location = new System.Drawing.Point(398, 26);
            this.txtcode2.Multiline = true;
            this.txtcode2.Name = "txtcode2";
            this.txtcode2.Size = new System.Drawing.Size(73, 35);
            this.txtcode2.TabIndex = 9;
            this.txtcode2.Visible = false;
            // 
            // btnsupprimercat
            // 
            this.btnsupprimercat.BackColor = System.Drawing.Color.DarkRed;
            this.btnsupprimercat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimercat.ForeColor = System.Drawing.Color.White;
            this.btnsupprimercat.Location = new System.Drawing.Point(348, 130);
            this.btnsupprimercat.Name = "btnsupprimercat";
            this.btnsupprimercat.Size = new System.Drawing.Size(123, 40);
            this.btnsupprimercat.TabIndex = 10;
            this.btnsupprimercat.Text = "SUPPRIMER";
            this.btnsupprimercat.UseVisualStyleBackColor = false;
            this.btnsupprimercat.Click += new System.EventHandler(this.btnsupprimercat_Click);
            // 
            // btnmodifiercat
            // 
            this.btnmodifiercat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodifiercat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifiercat.ForeColor = System.Drawing.Color.White;
            this.btnmodifiercat.Location = new System.Drawing.Point(189, 130);
            this.btnmodifiercat.Name = "btnmodifiercat";
            this.btnmodifiercat.Size = new System.Drawing.Size(123, 40);
            this.btnmodifiercat.TabIndex = 9;
            this.btnmodifiercat.Text = "MODFIER";
            this.btnmodifiercat.UseVisualStyleBackColor = false;
            this.btnmodifiercat.Click += new System.EventHandler(this.btnmodifiercat_Click);
            // 
            // txtdesignation1
            // 
            this.txtdesignation1.Location = new System.Drawing.Point(106, 89);
            this.txtdesignation1.Multiline = true;
            this.txtdesignation1.Name = "txtdesignation1";
            this.txtdesignation1.Size = new System.Drawing.Size(217, 29);
            this.txtdesignation1.TabIndex = 2;
            // 
            // btnajoutercat
            // 
            this.btnajoutercat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnajoutercat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajoutercat.ForeColor = System.Drawing.Color.White;
            this.btnajoutercat.Location = new System.Drawing.Point(34, 130);
            this.btnajoutercat.Name = "btnajoutercat";
            this.btnajoutercat.Size = new System.Drawing.Size(123, 40);
            this.btnajoutercat.TabIndex = 8;
            this.btnajoutercat.Text = "AJOUTER";
            this.btnajoutercat.UseVisualStyleBackColor = false;
            this.btnajoutercat.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "designation";
            // 
            // dgmedicament
            // 
            this.dgmedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgmedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgdesignation,
            this.dgrefcategorie});
            this.dgmedicament.Location = new System.Drawing.Point(43, 292);
            this.dgmedicament.Name = "dgmedicament";
            this.dgmedicament.Size = new System.Drawing.Size(493, 225);
            this.dgmedicament.TabIndex = 2;
            this.dgmedicament.DoubleClick += new System.EventHandler(this.dgmedicament_DoubleClick);
            // 
            // dgcode
            // 
            this.dgcode.DataPropertyName = "codemedicament";
            this.dgcode.HeaderText = "codemed";
            this.dgcode.Name = "dgcode";
            // 
            // dgdesignation
            // 
            this.dgdesignation.DataPropertyName = "designation";
            this.dgdesignation.HeaderText = "designation";
            this.dgdesignation.Name = "dgdesignation";
            // 
            // dgrefcategorie
            // 
            this.dgrefcategorie.DataPropertyName = "refcategorie";
            this.dgrefcategorie.HeaderText = "categorie";
            this.dgrefcategorie.Name = "dgrefcategorie";
            // 
            // dgcategorie
            // 
            this.dgcategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode1,
            this.dgdesignation1});
            this.dgcategorie.Location = new System.Drawing.Point(559, 292);
            this.dgcategorie.Name = "dgcategorie";
            this.dgcategorie.Size = new System.Drawing.Size(493, 225);
            this.dgcategorie.TabIndex = 3;
            this.dgcategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcategorie_CellContentClick);
            // 
            // dgcode1
            // 
            this.dgcode1.DataPropertyName = "codecategorie";
            this.dgcode1.HeaderText = "codecat";
            this.dgcode1.Name = "dgcode1";
            // 
            // dgdesignation1
            // 
            this.dgdesignation1.DataPropertyName = "designation";
            this.dgdesignation1.HeaderText = "designation";
            this.dgdesignation1.Name = "dgdesignation1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(413, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "IMPRIMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "stock";
            // 
            // cmbstock
            // 
            this.cmbstock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbstock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbstock.FormattingEnabled = true;
            this.cmbstock.Location = new System.Drawing.Point(251, 127);
            this.cmbstock.Name = "cmbstock";
            this.cmbstock.Size = new System.Drawing.Size(220, 29);
            this.cmbstock.TabIndex = 11;
            // 
            // usermedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgcategorie);
            this.Controls.Add(this.dgmedicament);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "usermedicament";
            this.Size = new System.Drawing.Size(1087, 550);
            this.Load += new System.EventHandler(this.usermedicament_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgmedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategorie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgmedicament;
        private System.Windows.Forms.DataGridView dgcategorie;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdesignation1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcategorie;
        private System.Windows.Forms.Button btnsupprimermed;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsupprimercat;
        private System.Windows.Forms.Button btnmodifiercat;
        private System.Windows.Forms.Button btnajoutercat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation1;
        private System.Windows.Forms.TextBox txtcode1;
        private System.Windows.Forms.TextBox txtcode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrefcategorie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbstock;
    }
}
