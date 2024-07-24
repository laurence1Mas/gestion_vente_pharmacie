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
using gestion_vente_pharmacie.repots;

namespace gestion_vente_pharmacie.usercontrols
{
    public partial class userpatient : UserControl
    {
        classes.clspatient clsp = new classes.clspatient();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public userpatient()
        {
            InitializeComponent();
            loadlist();
        }

        private void loadlist()
        {
            dgpatient.DataSource = clsp.getpatient();
        }
        private void bindingclass()
        {
            clsp.Codepatient =txtcode.Text;
            clsp.Nom = txtnom.Text;
            clsp.Postnom = txtpostnom.Text;
            clsp.Prenom = txtprenom.Text;
            clsp.Genre = Convert.ToString(cmbgenre.SelectedItem);
            clsp.Etat_civil = Convert.ToString(cmbetat.SelectedItem);
            clsp.Date_naissance = Convert.ToDateTime(datenaiss.Text);
            clsp.Adresse = txtadresse.Text;
            clsp.Numero = txttelephone.Text;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userpatient_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsp.Ajouterpatient(clsp);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsp.Modifierpatient(clsp);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsp.supprimerpatient(clsp);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void dgpatient_DoubleClick(object sender, EventArgs e)
        {
            if (dgpatient.RowCount > 0)
            {
                txtcode.Text = dgpatient["dgcode", dgpatient.CurrentRow.Index].Value.ToString();
                txtnom.Text = dgpatient["dgnom", dgpatient.CurrentRow.Index].Value.ToString();
                txtpostnom.Text = dgpatient["dgpostnom", dgpatient.CurrentRow.Index].Value.ToString();
                txtprenom.Text = dgpatient["dgprenom", dgpatient.CurrentRow.Index].Value.ToString();
                cmbgenre.Text = dgpatient["dggenre", dgpatient.CurrentRow.Index].Value.ToString();
                cmbetat.Text = dgpatient["dgetat", dgpatient.CurrentRow.Index].Value.ToString();
                datenaiss.Text = dgpatient["dgdate", dgpatient.CurrentRow.Index].Value.ToString();
                txtadresse.Text = dgpatient["dgadresse", dgpatient.CurrentRow.Index].Value.ToString();
                txttelephone.Text = dgpatient["dgtelephone", dgpatient.CurrentRow.Index].Value.ToString();
                btnajouter.Enabled = false;
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repots.listePatients rpt = new repots.listePatients();
            rpt.DataSource = M.get_Report_Z("*","Vpatient");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
