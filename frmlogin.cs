using gestion_vente_pharmacie.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_vente_pharmacie
{
    public partial class frmlogin : Form
    {
        classes.MYCONNECTION M = new classes.MYCONNECTION();
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnconnecter_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "administrateur" && password == "admin01")
            {
                Form1 home1 = new Form1();
                frmlogin lg = new frmlogin();
                this.Hide();
                home1.Show();
            }
            else if (username == "" && password == "")
            {
                MessageBox.Show("veillez remplir les champs", "user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("mot de pass incorect", "user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
    }
}
