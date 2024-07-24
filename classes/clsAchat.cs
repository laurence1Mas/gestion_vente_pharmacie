using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class clsAchat
    {
        string codeachat;
        string refpatient;
        string refmedicament;
        int quantite;
        decimal prixu;
        decimal montant_total;
        DateTime date_achat;

        public string Codeachat
        {
            get
            {
                return codeachat;
            }

            set
            {
                codeachat = value;
            }
        }

        public string Refpatient
        {
            get
            {
                return refpatient;
            }

            set
            {
                refpatient = value;
            }
        }

        public string Refmedicament
        {
            get
            {
                return refmedicament;
            }

            set
            {
                refmedicament = value;
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

        public DateTime Date_achat
        {
            get
            {
                return date_achat;
            }

            set
            {
                date_achat = value;
            }
        }

        public decimal Montant_total
        {
            get
            {
                return montant_total;
            }

            set
            {
                montant_total = value;
            }
        }

        SqlConnection con;

        public int ajouterAchat(clsAchat clsa)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_achat @refpatient,@refmedicament,@Quantinte,@prixU;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prrefpatient = new SqlParameter("@refpatient", clsa.refpatient);
                SqlParameter prrefmedicament = new SqlParameter("@refmedicament", clsa.refmedicament);
                SqlParameter prquantite = new SqlParameter("@Quantinte", clsa.quantite);
                SqlParameter prprixu = new SqlParameter("@prixU", clsa.prixu);
                cmd.Parameters.Add(prrefpatient);
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

        public int modifierAchat(clsAchat clsa)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_achat @codeachat,@refpatient,@refmedicament,@Quantinte,@prixU;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeachat = new SqlParameter("@codeachat", clsa.codeachat);
                SqlParameter prrefpatient = new SqlParameter("@refpatient", clsa.refpatient);
                SqlParameter prrefmedicament = new SqlParameter("@refmedicament", clsa.refmedicament);
                SqlParameter prquantite = new SqlParameter("@Quantinte", clsa.quantite);
                SqlParameter prprixu = new SqlParameter("@prixU", clsa.prixu);
                cmd.Parameters.Add(prcodeachat);
                cmd.Parameters.Add(prrefpatient);
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

        public List<clsAchat> getlistAchat()
        {
            List<clsAchat> list = new List<clsAchat>();
            con = new connexion().DBConnect();
            string strquery = "select * from VAchat";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsAchat clsa = new clsAchat();
                clsa.codeachat = dr["codeachat"].ToString();
                clsa.refpatient = dr["patient"].ToString();
                clsa.refmedicament = dr["medicament"].ToString();
                clsa.quantite = Convert.ToInt32(dr["Quantite"]);
                clsa.prixu = Convert.ToDecimal(dr["prixU"]);
                clsa.montant_total = Convert.ToDecimal(dr["Montant_total"]);
                clsa.date_achat = Convert.ToDateTime(dr["date_achat"]);
                list.Add(clsa);
            }
            return list;
        }
    }
}
