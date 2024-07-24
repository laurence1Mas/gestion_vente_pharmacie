using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class clsmedicament
    {
        string codemedicament;
        string designation;
        string refcategorie;

        public string Codemedicament
        {
            get
            {
                return codemedicament;
            }

            set
            {
                codemedicament = value;
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

        public string Refcategorie
        {
            get
            {
                return refcategorie;
            }

            set
            {
                refcategorie = value;
            }
        }
        SqlConnection con;
        public int Ajoutermedicament(clsmedicament clsm)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_medicament @designation,@refcategorie ;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prdesignation = new SqlParameter("@designation", clsm.designation);
                SqlParameter prerefcategorie = new SqlParameter("@refcategorie", clsm.refcategorie);
                cmd.Parameters.Add(prdesignation);
                cmd.Parameters.Add(prerefcategorie);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
        public int Modifiermedicament(clsmedicament clsm)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_medicament @codemedicament, @designation,@refcategorie ;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodemedicament = new SqlParameter("@codemedicament", clsm.codemedicament);
                SqlParameter prdesignation = new SqlParameter("@designation", clsm.designation);
                SqlParameter prerefcategorie = new SqlParameter("@refcategorie", clsm.refcategorie);
                cmd.Parameters.Add(prdesignation);
                cmd.Parameters.Add(prerefcategorie);
                cmd.Parameters.Add(prcodemedicament);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        public int supprimermedicament(clsmedicament clsm)
        {
            int value = 0;
            string strquery = " exec delete_medicament @codemedicament";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodemedicament = new SqlParameter("@codemedicament", clsm.codemedicament);
                cmd.Parameters.Add(prcodemedicament);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }

        public List<clsmedicament> getmedicament()
        {
            List<clsmedicament> list = new List<clsmedicament>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vmedicament";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsmedicament clsm = new clsmedicament();
                clsm.codemedicament =dr["codemedicament"].ToString();
                clsm.designation = dr["designation"].ToString();
                clsm.refcategorie = dr["categorie"].ToString();
                list.Add(clsm);
            }
            return list;
        }
    }
}
