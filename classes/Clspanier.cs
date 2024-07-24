using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class Clspanier
    {
        string codeachat;
        string refpatient;
        string refmedicament;
        int quantite;
        decimal prixu;
        decimal montant_total;
        DateTime date_achat;
        decimal total_facture;

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

        public decimal Total_facture
        {
            get
            {
                return total_facture;
            }

            set
            {
                total_facture = value;
            }
        }
        SqlConnection con;
        public List<Clspanier> getlistpanier()
        {
            List<Clspanier> list = new List<Clspanier>();
            con = new connexion().DBConnect();
            string strquery = "select * from fiche_achat";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clspanier clsp = new Clspanier();
                clsp.codeachat = dr["codeachat"].ToString();
                clsp.refpatient = dr["patient"].ToString();
                clsp.refmedicament = dr["medicament"].ToString();
                clsp.quantite = Convert.ToInt32(dr["Quantite"]);
                clsp.prixu = Convert.ToDecimal(dr["prixU"]);
                clsp.montant_total = Convert.ToDecimal(dr["Montant_total"]);
                clsp.total_facture = Convert.ToDecimal(dr["total_facture"]);
                clsp.date_achat = Convert.ToDateTime(dr["date_achat"]);
                list.Add(clsp);
            }
            return list;
        }
        public int viderpanier(Clspanier clsf)
        {
            int value = 0;
            string strquery = " truncate table panier";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }
    }
}
