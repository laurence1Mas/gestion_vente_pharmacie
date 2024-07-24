namespace gestion_vente_pharmacie
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnstock = new System.Windows.Forms.Button();
            this.defilement = new System.Windows.Forms.Panel();
            this.btnmedicament = new System.Windows.Forms.Button();
            this.btnpayement = new System.Windows.Forms.Button();
            this.btnachat = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnlivraison = new System.Windows.Forms.Button();
            this.btnfournisseur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpanier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 76);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gestion_vente_pharmacie.Properties.Resources.gettyimages_523174932_612x612;
            this.pictureBox2.Location = new System.Drawing.Point(1132, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_vente_pharmacie.Properties.Resources.gettyimages_523174932_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 584);
            this.panel2.TabIndex = 1;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Location = new System.Drawing.Point(207, 82);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1087, 550);
            this.container.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.btnpanier);
            this.panel4.Controls.Add(this.btnstock);
            this.panel4.Controls.Add(this.defilement);
            this.panel4.Controls.Add(this.btnmedicament);
            this.panel4.Controls.Add(this.btnpayement);
            this.panel4.Controls.Add(this.btnachat);
            this.panel4.Controls.Add(this.btnPatient);
            this.panel4.Controls.Add(this.btnlivraison);
            this.panel4.Controls.Add(this.btnfournisseur);
            this.panel4.Location = new System.Drawing.Point(1, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 584);
            this.panel4.TabIndex = 1;
            // 
            // btnstock
            // 
            this.btnstock.BackColor = System.Drawing.Color.White;
            this.btnstock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnstock.Image = global::gestion_vente_pharmacie.Properties.Resources.achat1;
            this.btnstock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstock.Location = new System.Drawing.Point(22, 429);
            this.btnstock.Name = "btnstock";
            this.btnstock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnstock.Size = new System.Drawing.Size(153, 38);
            this.btnstock.TabIndex = 7;
            this.btnstock.Text = "STOCK";
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.button1_Click);
            // 
            // defilement
            // 
            this.defilement.BackColor = System.Drawing.Color.White;
            this.defilement.Location = new System.Drawing.Point(0, 110);
            this.defilement.Name = "defilement";
            this.defilement.Size = new System.Drawing.Size(12, 38);
            this.defilement.TabIndex = 0;
            this.defilement.Paint += new System.Windows.Forms.PaintEventHandler(this.defilement_Paint);
            // 
            // btnmedicament
            // 
            this.btnmedicament.BackColor = System.Drawing.Color.White;
            this.btnmedicament.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedicament.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnmedicament.Image = global::gestion_vente_pharmacie.Properties.Resources.medicament;
            this.btnmedicament.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmedicament.Location = new System.Drawing.Point(22, 180);
            this.btnmedicament.Name = "btnmedicament";
            this.btnmedicament.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnmedicament.Size = new System.Drawing.Size(153, 38);
            this.btnmedicament.TabIndex = 6;
            this.btnmedicament.Text = "MEDICAMENT";
            this.btnmedicament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmedicament.UseVisualStyleBackColor = false;
            this.btnmedicament.Click += new System.EventHandler(this.btnmedicament_Click);
            // 
            // btnpayement
            // 
            this.btnpayement.BackColor = System.Drawing.Color.White;
            this.btnpayement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayement.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnpayement.Image = global::gestion_vente_pharmacie.Properties.Resources.payement;
            this.btnpayement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpayement.Location = new System.Drawing.Point(22, 365);
            this.btnpayement.Name = "btnpayement";
            this.btnpayement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnpayement.Size = new System.Drawing.Size(153, 38);
            this.btnpayement.TabIndex = 5;
            this.btnpayement.Text = "PAYEMENT";
            this.btnpayement.UseVisualStyleBackColor = false;
            this.btnpayement.Click += new System.EventHandler(this.btnpayement_Click);
            // 
            // btnachat
            // 
            this.btnachat.BackColor = System.Drawing.Color.White;
            this.btnachat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnachat.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnachat.Image = global::gestion_vente_pharmacie.Properties.Resources.achat;
            this.btnachat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnachat.Location = new System.Drawing.Point(22, 302);
            this.btnachat.Name = "btnachat";
            this.btnachat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnachat.Size = new System.Drawing.Size(153, 38);
            this.btnachat.TabIndex = 4;
            this.btnachat.Text = "ACHAT";
            this.btnachat.UseVisualStyleBackColor = false;
            this.btnachat.Click += new System.EventHandler(this.btnachat_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.White;
            this.btnPatient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPatient.Image = global::gestion_vente_pharmacie.Properties.Resources.patient;
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatient.Location = new System.Drawing.Point(22, 58);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPatient.Size = new System.Drawing.Size(153, 38);
            this.btnPatient.TabIndex = 3;
            this.btnPatient.Text = "PATIENT";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnlivraison
            // 
            this.btnlivraison.BackColor = System.Drawing.Color.White;
            this.btnlivraison.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlivraison.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnlivraison.Image = global::gestion_vente_pharmacie.Properties.Resources.livraison;
            this.btnlivraison.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlivraison.Location = new System.Drawing.Point(22, 243);
            this.btnlivraison.Name = "btnlivraison";
            this.btnlivraison.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnlivraison.Size = new System.Drawing.Size(153, 38);
            this.btnlivraison.TabIndex = 1;
            this.btnlivraison.Text = "LIVRAISON";
            this.btnlivraison.UseVisualStyleBackColor = false;
            this.btnlivraison.Click += new System.EventHandler(this.btnlivraison_Click);
            // 
            // btnfournisseur
            // 
            this.btnfournisseur.BackColor = System.Drawing.Color.White;
            this.btnfournisseur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfournisseur.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnfournisseur.Image = global::gestion_vente_pharmacie.Properties.Resources.fournisseur;
            this.btnfournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfournisseur.Location = new System.Drawing.Point(21, 119);
            this.btnfournisseur.Name = "btnfournisseur";
            this.btnfournisseur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnfournisseur.Size = new System.Drawing.Size(153, 38);
            this.btnfournisseur.TabIndex = 0;
            this.btnfournisseur.Text = "    FOURNISSEUR";
            this.btnfournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfournisseur.UseVisualStyleBackColor = false;
            this.btnfournisseur.Click += new System.EventHandler(this.btnfournisseur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(654, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "copyright 2023";
            // 
            // btnpanier
            // 
            this.btnpanier.BackColor = System.Drawing.Color.White;
            this.btnpanier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpanier.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnpanier.Image = global::gestion_vente_pharmacie.Properties.Resources.achat1;
            this.btnpanier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpanier.Location = new System.Drawing.Point(22, 492);
            this.btnpanier.Name = "btnpanier";
            this.btnpanier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnpanier.Size = new System.Drawing.Size(153, 38);
            this.btnpanier.TabIndex = 8;
            this.btnpanier.Text = "PANIER";
            this.btnpanier.UseVisualStyleBackColor = false;
            this.btnpanier.Click += new System.EventHandler(this.btnpanier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1294, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnmedicament;
        private System.Windows.Forms.Button btnpayement;
        private System.Windows.Forms.Button btnachat;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnlivraison;
        private System.Windows.Forms.Button btnfournisseur;
        private System.Windows.Forms.Panel defilement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button btnpanier;
    }
}

