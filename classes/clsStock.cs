using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class clsStock
    {
        string id;
        string medicament;
        int quantite;
        decimal prixu;
        string statut;
        DateTime date_stock;
        decimal prixtotal;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Medicament
        {
            get
            {
                return medicament;
            }

            set
            {
                medicament = value;
            }
        }

        public int Quantite
        {
            get
            {
                return quantite;
            }

            set
            {
                quantite = value;
            }
        }

        public decimal Prixu
        {
            get
            {
                return prixu;
            }

            set
            {
                prixu = value;
            }
        }

        public string Statut
        {
            get
            {
                return statut;
            }

            set
            {
                statut = value;
            }
        }

        public DateTime Date_stock
        {
            get
            {
                return date_stock;
            }

            set
            {
                date_stock = value;
            }
        }

        public decimal Prixtotal
        {
            get
            {
                return prixtotal;
            }

            set
            {
                prixtotal = value;
            }
        }

        SqlConnection con;

        public int ajouterstock(clsStock clsst)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "insert into transactions_stock (ref_livraison,quantite,prixU,datestock)values(@reflivraison,@quantite,@prixU,getdate());";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prrefmedicament = new SqlParameter("@reflivraison", clsst.medicament);
                SqlParameter prquantite = new SqlParameter("@quantite", clsst.quantite);
                SqlParameter prprixu = new SqlParameter("@prixU", clsst.prixu);
                cmd.Parameters.Add(prrefmedicament);
                cmd.Parameters.Add(prquantite);
                cmd.Parameters.Add(prprixu);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        //public int modifierAchat(clsAchat clsa)
        //{
        //    int value = 0;
        //    con = new connexion().DBConnect();
        //    if (con != null)
        //    {
        //        string strquery = "exec update_achat @codeachat,@refpatient,@refmedicament,@Quantinte,@prixU;";

        //        SqlCommand cmd = new SqlCommand(strquery, con);
        //        SqlParameter prcodeachat = new SqlParameter("@codeachat", clsa.codeachat);
        //        SqlParameter prrefpatient = new SqlParameter("@refpatient", clsa.refpatient);
        //        SqlParameter prrefmedicament = new SqlParameter("@refmedicament", clsa.refmedicament);
        //        SqlParameter prquantite = new SqlParameter("@Quantinte", clsa.quantite);
        //        SqlParameter prprixu = new SqlParameter("@prixU", clsa.prixu);
        //        cmd.Parameters.Add(prcodeachat);
        //        cmd.Parameters.Add(prrefpatient);
        //        cmd.Parameters.Add(prrefmedicament);
        //        cmd.Parameters.Add(prquantite);
        //        cmd.Parameters.Add(prprixu);
        //        value = cmd.ExecuteNonQuery();

        //        return value;
        //    }
        //    else
        //    {
        //        return value;
        //    }
        //}

        public List<clsStock> getlistStock()
        {
            List<clsStock> list = new List<clsStock>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vstock";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsStock clsst = new clsStock();
                clsst.id = dr["id"].ToString();
                clsst.medicament = dr["medicament"].ToString();
                clsst.quantite = Convert.ToInt32(dr["quantite"]);
                clsst.prixu = Convert.ToDecimal(dr["prixU"]);
                clsst.prixtotal = Convert.ToDecimal(dr["prixtotal"]);
                clsst.statut = dr["statut"].ToString();
                clsst.date_stock = Convert.ToDateTime(dr["datestock"]);
                list.Add(clsst);
            }
            return list;
        }
    }
}
