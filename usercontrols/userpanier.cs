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
    public partial class userpanier : UserControl
    {
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        classes.Clspanier clsp = new classes.Clspanier();
        public userpanier()
        {
            InitializeComponent();
            loardlist();
        }

        public void loardlist()
        {
            dgpanier.DataSource = clsp.getlistpanier();
        }
        private void userpanier_Load(object sender, EventArgs e)
        {
            dgpanier.DataSource = clsp.getlistpanier();
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            repots.ficheachat rpt = new repots.ficheachat();
            rpt.DataSource = M.get_Report_facturetotal("*", "fiche_achat");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            int value = clsp.viderpanier(clsp);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "panier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlist();
            }
            else
            {
                MessageBox.Show("Operation effectuée", "panier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loardlist();
            }
        }
    }
}
