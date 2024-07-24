using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class clslivraison
    {
        string codelivraison;
        string reffournisseur;
        string refmedicament;
        int quantite;
        decimal prixu;
        DateTime date_livraison;

        public string Codelivraison
        {
            get
            {
                return codelivraison;
            }

            set
            {
                codelivraison = value;
            }
        }

        public string Reffournisseur
        {
            get
            {
                return reffournisseur;
            }

            set
            {
                reffournisseur = value;
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

        public DateTime Date_livraison
        {
            get
            {
                return date_livraison;
            }

            set
            {
                date_livraison = value;
            }
        }
        SqlConnection con;
        public int ajouterlivraison(clslivraison clsl)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_livrason @reffournisseur,@refmedicament,@Quantinte,@prixU;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prreffournisseur = new SqlParameter("@reffournisseur", clsl.reffournisseur);
                SqlParameter prrefmedicament = new SqlParameter("@refmedicament", clsl.refmedicament);
                SqlParameter prquantite = new SqlParameter("@Quantinte", clsl.quantite);
                SqlParameter prprixu = new SqlParameter("@prixU", clsl.prixu);
                cmd.Parameters.Add(prreffournisseur);
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

        public int modifierlivraison(clslivraison clsl)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_livraison @codelivraison,@reffournisseur,@refmedicament,@Quantinte,@prixU;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodelivraison = new SqlParameter("@codelivraison", clsl.codelivraison);
                SqlParameter prreffournisseur = new SqlParameter("@reffournisseur", clsl.reffournisseur);
                SqlParameter prrefmedicament = new SqlParameter("@refmedicament", clsl.refmedicament);
                SqlParameter prquantite = new SqlParameter("@Quantinte", clsl.quantite);
                SqlParameter prprixu = new SqlParameter("@prixU", clsl.prixu);
                cmd.Parameters.Add(prcodelivraison);
                cmd.Parameters.Add(prreffournisseur);
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

        public int supprimerlivraison(clslivraison clsl)
        {
            int value = 0;
            string strquery = " exec delete_livraison @codelivraison";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodelivraison = new SqlParameter("@codelivraison", clsl.codelivraison);
                cmd.Parameters.Add(prcodelivraison);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<clslivraison> getlivraison()
        {
            List<clslivraison> list = new List<clslivraison>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vlivraison";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clslivraison clsl = new clslivraison();
                clsl.codelivraison = dr["codelivraison"].ToString();
                clsl.reffournisseur = dr["fournisseur"].ToString();
                clsl.refmedicament = dr["medicament"].ToString();
                clsl.quantite = Convert.ToInt32(dr["quantite"]);
                clsl.prixu = Convert.ToDecimal(dr["prixU"]);
                clsl.date_livraison = Convert.ToDateTime(dr["date_livraison"]);
                list.Add(clsl);
            }
            return list;
        }
        public List<clslivraison> getlivraisonmed()
        {
            List<clslivraison> list = new List<clslivraison>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vlivraisonmed";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clslivraison clsl = new clslivraison();
                clsl.codelivraison = dr["codelivraison"].ToString();
                clsl.refmedicament = dr["designation"].ToString();
                list.Add(clsl);
            }
            return list;
        }
    }
}
