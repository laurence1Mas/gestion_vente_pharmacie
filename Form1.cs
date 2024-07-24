using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_vente_pharmacie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            defilement.Height = btnPatient.Height;
            defilement.Top = btnPatient.Top;

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            defilement.Height = btnPatient.Height;
            defilement.Top = btnPatient.Top;
            container.Controls.Clear();
            container.Controls.Add(new usercontrols.userpatient());
        }

        private void btnfournisseur_Click(object sender, EventArgs e)
        {
            defilement.Height = btnfournisseur.Height;
            defilement.Top = btnfournisseur.Top;
            container.Controls.Clear();
            container.Controls.Add(new usercontrols.userfournisseur());
        }

        private void btnmedicament_Click(object sender, EventArgs e)
        {
            defilement.Height = btnmedicament.Height;
            defilement.Top = btnmedicament.Top;
            container.Controls.Clear();
            container.Controls.Add(new usercontrols.usermedicament());
        }

        private void btnlivraison_Click(object sender, EventArgs e)
        {
            defilement.Height = btnlivraison.Height;
            defilement.Top = btnlivraison.Top;
            container.Controls.Clear();
            container.Controls.Add(new usercontrols.userlivraison());
        }

        private void btnachat_Click(object sender, EventArgs e)
        {
            defilement.Height = btnachat.Height;
            defilement.Top = btnachat.Top;
            container.Controls.Clear();
            container.Controls.Add(new usercontrols.userachat());
        }

        private void btnpayement_Click(object sender, EventArgs e)
        {
            defilement.Height = btnpayement.Height;
            defilement.Top = btnpayement.Top;
            container.Controls.Clear();
            container.Controls.Add(new usercontrols.userpayement());
        }

        private void defilement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            defilement.Height = btnstock.Height;
            defilement.Top = btnstock.Top;
            container.Controls.Clear();
            container.Controls.Add(new usercontrols.userstock());
        }

        private void btnpanier_Click(object sender, EventArgs e)
        {
            defilement.Height = btnpanier.Height;
            defilement.Top = btnpanier.Top;
            container.Controls.Clear();
            container.Controls.Add(new usercontrols.userpanier());
        }
    }
}
