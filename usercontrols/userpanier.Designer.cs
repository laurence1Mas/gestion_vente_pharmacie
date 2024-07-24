namespace gestion_vente_pharmacie.usercontrols
{
    partial class userpanier
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
            this.dgpanier = new System.Windows.Forms.DataGridView();
            this.btnvider = new System.Windows.Forms.Button();
            this.btnimprimer = new System.Windows.Forms.Button();
            this.dgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprixu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtotalfacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgpanier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgpanier
            // 
            this.dgpanier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgpanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpanier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcode,
            this.dgpatient,
            this.dgmedicament,
            this.dgquantite,
            this.dgprixu,
            this.dgtotalfacture,
            this.dgdate});
            this.dgpanier.Location = new System.Drawing.Point(33, 110);
            this.dgpanier.Name = "dgpanier";
            this.dgpanier.Size = new System.Drawing.Size(1020, 398);
            this.dgpanier.TabIndex = 18;
            // 
            // btnvider
            // 
            this.btnvider.BackColor = System.Drawing.Color.Firebrick;
            this.btnvider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvider.ForeColor = System.Drawing.Color.White;
            this.btnvider.Location = new System.Drawing.Point(816, 64);
            this.btnvider.Name = "btnvider";
            this.btnvider.Size = new System.Drawing.Size(123, 40);
            this.btnvider.TabIndex = 19;
            this.btnvider.Text = "VIDER";
            this.btnvider.UseVisualStyleBackColor = false;
            this.btnvider.Click += new System.EventHandler(this.btnvider_Click);
            // 
            // btnimprimer
            // 
            this.btnimprimer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnimprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimer.ForeColor = System.Drawing.Color.White;
            this.btnimprimer.Location = new System.Drawing.Point(674, 64);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(123, 40);
            this.btnimprimer.TabIndex = 20;
            this.btnimprimer.Text = "IMPRIMER";
            this.btnimprimer.UseVisualStyleBackColor = false;
            this.btnimprimer.Click += new System.EventHandler(this.btnimprimer_Click);
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
            // dgtotalfacture
            // 
            this.dgtotalfacture.DataPropertyName = "total_facture";
            this.dgtotalfacture.HeaderText = "total_facture";
            this.dgtotalfacture.Name = "dgtotalfacture";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "date_achat";
            this.dgdate.HeaderText = "date-achat";
            this.dgdate.Name = "dgdate";
            // 
            // userpanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.btnvider);
            this.Controls.Add(this.dgpanier);
            this.Name = "userpanier";
            this.Size = new System.Drawing.Size(1087, 550);
            this.Load += new System.EventHandler(this.userpanier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgpanier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgpanier;
        private System.Windows.Forms.Button btnvider;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprixu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtotalfacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
    }
}
