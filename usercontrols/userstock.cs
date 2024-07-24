using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_vente_pharmacie.usercontrols
{
    public partial class userstock : UserControl
    {
        classes.clsStock clsst = new classes.clsStock();
        classes.clslivraison clsl = new classes.clslivraison();
        public userstock()
        {
            InitializeComponent();
        }
        private void loadlist()
        {
            cmbmedicament.DataSource = clsl.getlivraisonmed();
            cmbmedicament.ValueMember = "codelivraison";
            cmbmedicament.DisplayMember = "designation";
            dgachat.DataSource = clsst.getlistStock();
        }
        private void bindingclass()
        {
            clsst.Id = txtcode.Text;
            clsst.Medicament =Convert.ToString(cmbmedicament.SelectedValue);
            clsst.Quantite = Convert.ToInt32(txtquantite.Text);
            clsst.Prixu = Convert.ToDecimal(txtprixu.Text);
        }
        private void userstock_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsst.ajouterstock(clsst);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
            }
        }

        private void dgachat_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
