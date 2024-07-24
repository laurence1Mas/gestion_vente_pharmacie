using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace gestion_vente_pharmacie.classes
{
    class MYCONNECTION
    {
        public String ErrorProviser()
        {
            return "Ce champs ne doit pas etre vide";
        }
        public void APPEL_PANEL(UserControl s, Panel pan)
        {

            s.Dock = DockStyle.Fill;
            pan.Controls.Clear();
            pan.Controls.Add(s);
            pan.Show();

        }

        public string imgLon = "";
        public static string cons = @"Data Source=DESKTOP-HTI1CR5;Initial Catalog=db_gestion_vente_pharmacie;User ID=SA;Password=laure";
        public static SqlConnection con = new SqlConnection("" + cons);
        public static SqlCommand cmd = new SqlCommand("", con);

        SqlDataReader dr;
        public static SqlDataAdapter dt = null;

        public static DataSet ds = new DataSet();

        //==========================METHODE D'IMPRESSION D'UNE LISTE=============
        public DataSet get_Report_Z(string colonnes, string nomTable)
        {
            Console.WriteLine("SELECT  " + colonnes + " FROM " + nomTable);
            DataSet dst;
            try
            {
                //   innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT  " + colonnes + " FROM " + nomTable, con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        //==========================METHODE D'IMPRESSION D'UNE facture total=============
        public DataSet get_Report_facturetotal(string colonnes, string nomTable)
        {
            Console.WriteLine("SELECT  " + colonnes + " FROM " + nomTable);
            DataSet dst;
            try
            {
                //   innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT  " + colonnes + " FROM " + nomTable, con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        public DataSet get_Report_S(string nomTable, string idTable)
        {
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " ORDER BY " + idTable + "", con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        //=========================METHODE D'IMPRESSION DU facture===================
        public DataSet get_Report_facture(string nomTable, string idTable, string value)
        {
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("select * from Vfacture WHERE codeachat =@code", con);
                cmd.Parameters.AddWithValue("@code", value);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        //=========================METHODE D'IMPRESSION DU recu===================
        public DataSet get_Report_recu(string nomTable, string idTable, string value)
        {
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("select * from Vpayement WHERE codepayement =@code", con);
                cmd.Parameters.AddWithValue("@code", value);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        public void CHOISIR_IMAGE(PictureBox picture)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "Selectionner une image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLon = dlg.FileName.ToString();
                picture.ImageLocation = imgLon;
            }
        }
        public void chargementCombo(ComboBox cmb, string rqt)
        {
            cmb.Items.Clear();

            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr[0].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void chargementlIST(ListBox cmb, string rqt)
        {
            cmb.Items.Clear();

            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr[0].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public String VALOR_OF(String rqt)
        {
            string caleur = "";
            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();

                caleur = dr[0].ToString();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return caleur;
        }

        public void chargementTableau(DataGridView dg, string rqt)
        {
            Console.WriteLine(rqt);
            con.Open();
            try
            {

                cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter(rqt, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "ETUDIANT");
                dg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();

        }


        public void EXEC_UNIVERSEL(String proc, string parametre, string message)
        {
            Console.WriteLine("EXEC " + proc + " " + parametre);
            con.Open();
            try
            {

                cmd.CommandText = "EXEC " + proc + " " + parametre;
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "reussite", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        public void EXEC_UNIVERSEL_picture(String proc, string parametre, string message)
        {
            con.Open();
            try
            {
                byte[] img = null;

                cmd.Parameters.Clear();
                FileStream fs = new FileStream(imgLon, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                cmd.CommandText = "EXEC " + proc + " " + parametre;
                cmd.Parameters.Add(new SqlParameter("@IMAGE", img));
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "Reussite", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }









        public void GET_PHOTO(string RQT, PictureBox picemp, int row)
        {
            con.Open();
            try
            {

                cmd.CommandText = RQT + "";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = (byte[])(dr[row]);
                    if (img == null)
                        picemp.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picemp.Image = System.Drawing.Image.FromStream(ms);
                    }

                }

                //  Console.WriteLine("select PHOTO from " + table + " where " + colonne_ref + "='" + reference + "'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        public void chargementLabel(String id, Label nom, Label postnom, Label prenom)
        {
            con.Open();

            try
            {

                cmd.CommandText = "SELECT NOM,POSTNOM,PRENOM FROM TCITOYEN WHERE TCITOYEN.IDENTIFICATIONNATIONAL='" + id + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nom.Text = dr[0].ToString();
                    postnom.Text = dr[1].ToString();
                    prenom.Text = dr[2].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void LOGIN(String USERNAME, string password)
        {


            try
            {
                con.Open();
                cmd.CommandText = "select * from login '" + USERNAME + "','" + password + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == "Le mot de passe ou nom d utilisateur est incorrect")
                    {
                        MessageBox.Show("" + dr[0].ToString(), "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    else
                    {


                    }
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UNIVERSALLabel(string RQT, Label prenom, int row)
        {
            Console.WriteLine("" + RQT);
            con.Open();

            try
            {

                cmd.CommandText = "" + RQT;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    prenom.Text = dr[row].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void UNIVERSALGROUPBOX(string RQT, GroupBox prenom)
        {
            Console.WriteLine("" + RQT);
            con.Open();

            try
            {

                cmd.CommandText = "" + RQT;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    prenom.Text = dr[0].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
