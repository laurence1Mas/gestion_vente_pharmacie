using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace gestion_vente_pharmacie.usercontrols
{
    public partial class userpayement : UserControl
    {
        classes.clsPayement clspyt = new classes.clsPayement();
        classes.clspatient clsp = new classes.clspatient();
        classes.clsAchat clsm = new classes.clsAchat();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userpayement()
        {
            InitializeComponent();
            loadlist();
        }
        private void loadlist()
        {
            dgpayement.DataSource = clspyt.getlistpayement();
            cmbpatient.DataSource = clsp.getpatient();
            cmbpatient.ValueMember = "codepatient";
            cmbpatient.DisplayMember = "nom";
            cmbmedicament.DataSource = clsm.getlistAchat();
            cmbmedicament.ValueMember = "codeachat";
            cmbmedicament.DisplayMember = "medicament";
        }
        private void bindingclass()
        {
            clspyt.Codepayement = txtcode.Text;
            clspyt.Refpatient = Convert.ToString(cmbpatient.SelectedValue);
            clspyt.Refmedicament = Convert.ToString(cmbmedicament.SelectedValue);
            clspyt.Montant = Convert.ToDecimal(txtmontant.Text);
            clspyt.Datepayement = Convert.ToDateTime(datepayement.Text);
        }
        private void userpayement_Load(object sender, EventArgs e)
        {
            loadlist();
            dgpayement.DataSource = clspyt.getlistpayement();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clspyt.AjouterPayement(clspyt);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "payement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "payement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clspyt.ModificationPayement(clspyt);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "payement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "payement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void dgpayement_DoubleClick(object sender, EventArgs e)
        {
            if(dgpayement.RowCount > 0)
            {
                txtcode.Text = dgpayement["dgcode", dgpayement.CurrentRow.Index].Value.ToString();
                cmbpatient.Text= dgpayement["dgrefpatient", dgpayement.CurrentRow.Index].Value.ToString();
                cmbmedicament.Text= dgpayement["dgrefachat", dgpayement.CurrentRow.Index].Value.ToString();
                txtmontant.Text= dgpayement["dgmontant", dgpayement.CurrentRow.Index].Value.ToString();
                datepayement.Text= dgpayement["dgdate", dgpayement.CurrentRow.Index].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repots.recupayement rpt = new repots.recupayement();
            rpt.DataSource = M.get_Report_recu("Vpayement", "codepayement", txtcode.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
