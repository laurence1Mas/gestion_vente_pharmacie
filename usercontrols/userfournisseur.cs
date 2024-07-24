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
    public partial class userfournisseur : UserControl
    {
        classes.clsfournisseur clsf = new classes.clsfournisseur();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userfournisseur()
        {
            InitializeComponent();
            loadlist();
        }

        private void loadlist()
        {
            dgfournisseur.DataSource = clsf.getfournisseur();
        }
        private void bindingclass()
        {
            clsf.Codefournisseur =txtcode.Text;
            clsf.Nom = txtnom.Text;
            clsf.Postnom = txtpostnom.Text;
            clsf.Prenom = txtprenom.Text;
            clsf.Genre = Convert.ToString(cmbgenre.SelectedItem);
            clsf.Etat_civil = Convert.ToString(cmbetat.SelectedItem);
            clsf.Adresse = txtadresse.Text;
            clsf.Numero = txttelephone.Text;
        }
        private void userfournisseur_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void dgfournisseur_DoubleClick(object sender, EventArgs e)
        {
            if (dgfournisseur.RowCount > 0)
            {
                txtcode.Text = dgfournisseur["dgcode", dgfournisseur.CurrentRow.Index].Value.ToString();
                txtnom.Text = dgfournisseur["dgnom", dgfournisseur.CurrentRow.Index].Value.ToString();
                txtpostnom.Text = dgfournisseur["dgpostnom", dgfournisseur.CurrentRow.Index].Value.ToString();
                txtprenom.Text = dgfournisseur["dgprenom", dgfournisseur.CurrentRow.Index].Value.ToString();
                cmbgenre.Text = dgfournisseur["dggenre", dgfournisseur.CurrentRow.Index].Value.ToString();
                cmbetat.Text = dgfournisseur["dgetat", dgfournisseur.CurrentRow.Index].Value.ToString();
                txtadresse.Text = dgfournisseur["dgadresse", dgfournisseur.CurrentRow.Index].Value.ToString();
                txttelephone.Text = dgfournisseur["dgtelephone", dgfournisseur.CurrentRow.Index].Value.ToString();
                btnajouter.Enabled = false;
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsf.Ajouterfournisseur(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsf.Modifierfournisseur(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsf.supprimerfournisseur(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repots.listFournisseur rpt = new repots.listFournisseur();
            rpt.DataSource = M.get_Report_Z("*", "fournisseur");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
