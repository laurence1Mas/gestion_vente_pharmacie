using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class clsPayement
    {
        string codepayement;
        string refpatient;
        string refmedicament;
        decimal montant;
        DateTime datepayement;

        public string Codepayement
        {
            get
            {
                return codepayement;
            }

            set
            {
                codepayement = value;
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

        public decimal Montant
        {
            get
            {
                return montant;
            }

            set
            {
                montant = value;
            }
        }

        public DateTime Datepayement
        {
            get
            {
                return datepayement;
            }

            set
            {
                datepayement = value;
            }
        }
        SqlConnection con;

        public int AjouterPayement(clsPayement clsp)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_payement @refpatient,@refmedicament,@montant;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prrefpatient = new SqlParameter("@refpatient", clsp.refpatient);
                SqlParameter prrefmedicament = new SqlParameter("@refmedicament", clsp.refmedicament);
                SqlParameter prmontant = new SqlParameter("@montant", clsp.montant);
                cmd.Parameters.Add(prrefpatient);
                cmd.Parameters.Add(prrefmedicament);
                cmd.Parameters.Add(prmontant);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        public int ModificationPayement(clsPayement clsp)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_payement @codepayement, @refpatient,@refmedicament,@montant;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prrefpatient = new SqlParameter("@refpatient", clsp.refpatient);
                SqlParameter prrefmedicament = new SqlParameter("@refmedicament", clsp.refmedicament);
                SqlParameter prmontant = new SqlParameter("@montant", clsp.montant);
                SqlParameter prcodepayement = new SqlParameter("@codepayement", clsp.codepayement);
                cmd.Parameters.Add(prrefpatient);
                cmd.Parameters.Add(prrefmedicament);
                cmd.Parameters.Add(prmontant);
                cmd.Parameters.Add(prcodepayement);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
        public List<clsPayement> getlistpayement()
        {
        List<clsPayement> list = new List<clsPayement>();
        con = new connexion().DBConnect();
        string strquery = "select * from Vpayement";
        SqlCommand cmd = new SqlCommand(strquery, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            clsPayement clspyt = new clsPayement();
            clspyt.codepayement = dr["codepayement"].ToString();
            clspyt.refpatient = dr["patient"].ToString();
            clspyt.refmedicament = dr["medicament"].ToString();
            clspyt.montant = Convert.ToDecimal(dr["montant"]);
            clspyt.datepayement = Convert.ToDateTime(dr["date_payement"]);
            list.Add(clspyt);
        }
            return list;
        }
    }
}
