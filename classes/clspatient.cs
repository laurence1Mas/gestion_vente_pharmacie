using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class clspatient
    {
        string codepatient;
        string nom;
        string postnom;
        string prenom;
        string genre;
        string etat_civil;
        DateTime date_naissance;
        int age;
        string adresse;
        string numero;

        public string Codepatient
        {
            get
            {
                return codepatient;
            }

            set
            {
                codepatient = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Postnom
        {
            get
            {
                return postnom;
            }

            set
            {
                postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public string Etat_civil
        {
            get
            {
                return etat_civil;
            }

            set
            {
                etat_civil = value;
            }
        }

        public DateTime Date_naissance
        {
            get
            {
                return date_naissance;
            }

            set
            {
                date_naissance = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        SqlConnection con;
        public int Ajouterpatient(clspatient clsp)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_patient @nom,@postnom,@prenom,@genre,@etat_civil,@date_naissance,@adresse,@numero;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prnom = new SqlParameter("@nom", clsp.nom);
                SqlParameter prpostnom = new SqlParameter("@postnom", clsp.postnom);
                SqlParameter prprenom = new SqlParameter("@prenom", clsp.prenom);
                SqlParameter prgenre = new SqlParameter("@genre", clsp.genre);
                SqlParameter pretat = new SqlParameter("@etat_civil", clsp.etat_civil);
                SqlParameter prdate_naissance = new SqlParameter("@date_naissance", clsp.date_naissance);
                SqlParameter pradresse = new SqlParameter("@adresse", clsp.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsp.numero);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prpostnom);
                cmd.Parameters.Add(prprenom);
                cmd.Parameters.Add(prgenre);
                cmd.Parameters.Add(pretat);
                cmd.Parameters.Add(prdate_naissance);
                cmd.Parameters.Add(pradresse);
                cmd.Parameters.Add(prnumero);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }

        }

        //==============================================
        public int Modifierpatient(clspatient clsp)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                // string strquery1 = "insert into Client(codeclient,noms,telephone,mail,adresse) values(@codeclient,@noms,@telephone,@mail,@adresse)";
                string strquery = "exec update_patient @codepatient, @nom,@postnom,@prenom,@genre,@etat_civil,@date_naissance,@adresse,@numero;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodepatient = new SqlParameter("@codepatient", clsp.codepatient);
                SqlParameter prnom = new SqlParameter("@nom", clsp.nom);
                SqlParameter prpostnom = new SqlParameter("@postnom", clsp.postnom);
                SqlParameter prprenom = new SqlParameter("@prenom", clsp.prenom);
                SqlParameter prgenre = new SqlParameter("@genre", clsp.genre);
                SqlParameter pretat = new SqlParameter("@etat_civil", clsp.etat_civil);
                SqlParameter prdate_naissance = new SqlParameter("@date_naissance", clsp.date_naissance);
                SqlParameter pradresse = new SqlParameter("@adresse", clsp.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsp.numero);
                cmd.Parameters.Add(prcodepatient);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prpostnom);
                cmd.Parameters.Add(prprenom);
                cmd.Parameters.Add(prgenre);
                cmd.Parameters.Add(pretat);
                cmd.Parameters.Add(prdate_naissance);
                cmd.Parameters.Add(pradresse);
                cmd.Parameters.Add(prnumero);
                value = cmd.ExecuteNonQuery();
                return value;
            }
            else
            {
                return value;
            }

        }
        //=====================================================DELETE ================================================
        public int supprimerpatient(clspatient clsp)
        {
            int value = 0;
            string strquery = " exec delete_patient @codepatient";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodepatient = new SqlParameter("@codepatient", clsp.codepatient);
                cmd.Parameters.Add(prcodepatient);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<clspatient> getpatient()
        {
            List<clspatient> list = new List<clspatient>();
            con = new connexion().DBConnect();
            string strquery = "exec afficher_patient ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clspatient clsp = new clspatient();
                clsp.codepatient =dr["codepatient"].ToString();
                clsp.nom = dr["nom"].ToString();
                clsp.postnom = dr["postnom"].ToString();
                clsp.prenom = dr["prenom"].ToString();
                clsp.genre = dr["genre"].ToString();
                clsp.etat_civil = dr["etat_civil"].ToString();
                clsp.date_naissance =Convert.ToDateTime( dr["date_naissance"]);
                clsp.age = Convert.ToInt32(dr["age"]);
                clsp.adresse = dr["adresse"].ToString();
                clsp.numero = dr["telephone"].ToString();
                list.Add(clsp);
            }
            return list;
        }
    }
}
