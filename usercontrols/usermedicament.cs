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
    public partial class usermedicament : UserControl
    {
        classes.clscategorie clsc = new classes.clscategorie();
        classes.clsmedicament clsm = new classes.clsmedicament();
        classes.clsStock scls = new classes.clsStock();
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public usermedicament()
        {
            InitializeComponent();
            loadlistcat();
            loadlistmed();
        }

        private void loadlistcat()
        {
            dgcategorie.DataSource = clsc.getcategorie();
        }
        //===============
        private void loadlistmed()
        {
            dgmedicament.DataSource = clsm.getmedicament();
            cmbcategorie.DataSource = clsc.getcategorie();
            cmbcategorie.ValueMember = "codecategorie";
            cmbcategorie.DisplayMember = "designation";
            cmbstock.DataSource = scls.getlistStock();
            cmbstock.ValueMember = "id";
            cmbstock.DisplayMember = "medicament";
        }
        //===============
        private void bindingclasscat()
        {
            clsc.Codecategorie = txtcode2.Text;
            clsc.Designation = txtdesignation1.Text;
        }
        //==================
        private void bindingclassmed()
        {
            clsm.Codemedicament = txtcode1.Text;
            clsm.Designation = txtdesignation.Text;
            clsm.Refcategorie = Convert.ToString(cmbcategorie.SelectedValue);
        }
        private void usermedicament_Load(object sender, EventArgs e)
        {
            loadlistcat();
            loadlistmed();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclassmed();
            int value = clsm.Ajoutermedicament(clsm);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlistmed();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclassmed();
            int value = clsm.Modifiermedicament(clsm);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlistmed();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingclassmed();
            int value = clsm.supprimermedicament(clsm);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlistmed();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingclasscat();
            int value = clsc.Ajoutercategorie(clsc);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistcat();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlistcat();
            }
        }

        private void btnmodifiercat_Click(object sender, EventArgs e)
        {
            bindingclasscat();
            int value = clsc.Modifiercategorie(clsc);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistcat();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlistcat();
            }
        }

        private void btnsupprimercat_Click(object sender, EventArgs e)
        {
            bindingclasscat();
            int value = clsc.supprimercategorie(clsc);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistcat();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlistcat();
            }
        }

        private void dgmedicament_DoubleClick(object sender, EventArgs e)
        {
            if(dgmedicament.RowCount > 0)
            {
                txtcode1.Text = dgmedicament["dgcode", dgmedicament.CurrentRow.Index].Value.ToString();
                txtdesignation.Text = dgmedicament["dgdesignation", dgmedicament.CurrentRow.Index].Value.ToString();
                cmbcategorie.Text = dgmedicament["dgrefcategorie", dgmedicament.CurrentRow.Index].Value.ToString();
                btnajouter.Enabled = false;
                btnmodifier.Enabled = true;
                btnsupprimermed.Enabled = true;
            }
        }

        private void dgcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgcategorie.RowCount > 0)
            {
                txtcode2.Text = dgcategorie["dgcode1", dgcategorie.CurrentRow.Index].Value.ToString();
                txtdesignation1.Text = dgcategorie["dgdesignation1", dgcategorie.CurrentRow.Index].Value.ToString();
                btnajoutercat.Enabled = false;
                btnmodifiercat.Enabled = true;
                btnsupprimercat.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            repots.listMedicament rpt = new repots.listMedicament();
            rpt.DataSource = M.get_Report_Z("*", "Vmedicament");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void txtdesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
