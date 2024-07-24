using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class clscategorie
    {
        string codecategorie;
        string designation;

        public string Codecategorie
        {
            get
            {
                return codecategorie;
            }

            set
            {
                codecategorie = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }

        SqlConnection con;

        public int Ajoutercategorie(clscategorie clsc)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_categorie_medi @designation ;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prdesignation = new SqlParameter("@designation", clsc.designation);
                cmd.Parameters.Add(prdesignation);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }

        }

        //==============================================
        public int Modifiercategorie(clscategorie clsc)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_categorie_medi @codecategorie, @desigantion;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodcategorie = new SqlParameter("@codecategorie", clsc.codecategorie);
                SqlParameter prdesignation = new SqlParameter("@desigantion", clsc.designation);
                cmd.Parameters.Add(prcodcategorie);
                cmd.Parameters.Add(prdesignation);
                value = cmd.ExecuteNonQuery();
                return value;
            }
            else
            {
                return value;
            }

        }
        //=====================================================DELETE ================================================
        public int supprimercategorie(clscategorie clsc)
        {
            int value = 0;
            string strquery = " exec delete_categorie_medi @codecategorie";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodecategorie = new SqlParameter("@codecategorie", clsc.codecategorie);
                cmd.Parameters.Add(prcodecategorie);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<clscategorie> getcategorie()
        {
            List<clscategorie> list = new List<clscategorie>();
            con = new connexion().DBConnect();
            string strquery = "exec afficher_categorie_medi";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clscategorie clsc = new clscategorie();
                clsc.codecategorie = dr["codecategorie"].ToString();
                clsc.designation = dr["designation"].ToString();
                list.Add(clsc);
            }
            return list;
        }
    }
}
