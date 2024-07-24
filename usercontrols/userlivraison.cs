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
    public partial class userlivraison : UserControl
    {
        classes.clslivraison clsl = new classes.clslivraison();
        classes.clsfournisseur clsf = new classes.clsfournisseur();
        classes.clsmedicament clsm = new classes.clsmedicament();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userlivraison()
        {
            InitializeComponent();
            loadlist();
        }
        private void loadlist()
        {
            dglivraison.DataSource = clsl.getlivraison();
            cmbfournisseur.DataSource = clsf.getfournisseur();
            cmbfournisseur.ValueMember = "codefournisseur";
            cmbfournisseur.DisplayMember = "nom";
            cmbmedicament.DataSource = clsm.getmedicament();
            cmbmedicament.ValueMember = "codemedicament";
            cmbmedicament.DisplayMember = "designation";
        }
        private void bindingclass()
        {
            clsl.Codelivraison = txtcode.Text;
            clsl.Reffournisseur = Convert.ToString(cmbfournisseur.SelectedValue);
            clsl.Refmedicament = Convert.ToString(cmbmedicament.SelectedValue);
            clsl.Quantite = Convert.ToInt32(txtquantite.Text);
            clsl.Prixu = Convert.ToDecimal(txtprixu.Text);
            clsl.Date_livraison = Convert.ToDateTime(datelivraison.Text);
        }
        private void userlivraison_Load(object sender, EventArgs e)
        {
            loadlist();
            dglivraison.DataSource = clsl.getlivraison();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsl.ajouterlivraison(clsl);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsl.modifierlivraison(clsl);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsl.supprimerlivraison(clsl);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void dglivraison_DoubleClick(object sender, EventArgs e)
        {
            if(dglivraison.RowCount > 0)
            {
                txtcode.Text = dglivraison["dgcode", dglivraison.CurrentRow.Index].Value.ToString();
                cmbfournisseur.Text= dglivraison["dgfournisseur", dglivraison.CurrentRow.Index].Value.ToString();
                cmbmedicament.Text= dglivraison["dgmedicament", dglivraison.CurrentRow.Index].Value.ToString();
                txtquantite.Text= dglivraison["dgquantite", dglivraison.CurrentRow.Index].Value.ToString();
                txtprixu.Text= dglivraison["dgprixu", dglivraison.CurrentRow.Index].Value.ToString();
                datelivraison.Text= dglivraison["dgdate", dglivraison.CurrentRow.Index].Value.ToString();
                btnajouter.Enabled = false;
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repots.listLivraison rpt = new repots.listLivraison();
            rpt.DataSource = M.get_Report_Z("*", "Vlivraison");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
