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
    public partial class userachat : UserControl
    {
        classes.clsAchat clsa = new classes.clsAchat();
        classes.clspatient clsp = new classes.clspatient();
        classes.clslivraison clsm = new classes.clslivraison();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userachat()
        {
            InitializeComponent();
            loadlist();
        }

        private void loadlist()
        {
            dgachat.DataSource = clsa.getlistAchat();
            cmbpatient.DataSource = clsp.getpatient();
            cmbpatient.ValueMember = "codepatient";
            cmbpatient.DisplayMember = "nom";
            cmbmedicament.DataSource = clsm.getlivraison();
            cmbmedicament.ValueMember = "codelivraison";
            cmbmedicament.DisplayMember = "medicament";
        }
        private void bindingclass()
        {
            clsa.Codeachat = txtcode.Text;
            clsa.Refpatient = Convert.ToString(cmbpatient.SelectedValue);
            clsa.Refmedicament = Convert.ToString(cmbmedicament.SelectedValue);
            clsa.Quantite = Convert.ToInt32(txtquantite.Text);
            clsa.Prixu = Convert.ToDecimal(txtmontant.Text);
            clsa.Date_achat = Convert.ToDateTime(dateachat.Text);
        }
        private void userachat_Load(object sender, EventArgs e)
        {
            loadlist();
            dgachat.DataSource = clsa.getlistAchat();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsa.ajouterAchat(clsa);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "achat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "achat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsa.modifierAchat(clsa);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "achat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "achat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void dgachat_DoubleClick(object sender, EventArgs e)
        {
            if (dgachat.RowCount > 0)
            {
                txtcode.Text = dgachat["dgcode", dgachat.CurrentRow.Index].Value.ToString();
                cmbpatient.Text = dgachat["dgpatient", dgachat.CurrentRow.Index].Value.ToString();
                cmbmedicament.Text = dgachat["dgmedicament", dgachat.CurrentRow.Index].Value.ToString();
                txtquantite.Text = dgachat["dgquantite", dgachat.CurrentRow.Index].Value.ToString();
                txtmontant.Text = dgachat["dgprixu", dgachat.CurrentRow.Index].Value.ToString();
                dateachat.Text = dgachat["dgdate", dgachat.CurrentRow.Index].Value.ToString();
                btnajouter.Enabled = false;
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repots.facturevente rpt = new repots.facturevente();
            rpt.DataSource = M.get_Report_facture("Vfacture", "codeachat", txtcode.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
