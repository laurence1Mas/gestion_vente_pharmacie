using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_vente_pharmacie.classes
{
    class clsfournisseur
    {
        string codefournisseur;
        string nom;
        string postnom;
        string prenom;
        string genre;
        string etat_civil;
        string adresse;
        string numero;

        public string Codefournisseur
        {
            get
            {
                return codefournisseur;
            }

            set
            {
                codefournisseur = value;
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
        SqlConnection con;
        public int Ajouterfournisseur(clsfournisseur clsf)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_fournisseur @nom,@postnom,@prenom,@genre,@etat_civil,@adresse,@numero;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prnom = new SqlParameter("@nom", clsf.nom);
                SqlParameter prpostnom = new SqlParameter("@postnom", clsf.postnom);
                SqlParameter prprenom = new SqlParameter("@prenom", clsf.prenom);
                SqlParameter prgenre = new SqlParameter("@genre", clsf.genre);
                SqlParameter pretat = new SqlParameter("@etat_civil", clsf.etat_civil);
                SqlParameter pradresse = new SqlParameter("@adresse", clsf.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsf.numero);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prpostnom);
                cmd.Parameters.Add(prprenom);
                cmd.Parameters.Add(prgenre);
                cmd.Parameters.Add(pretat);
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
        public int Modifierfournisseur(clsfournisseur clsf)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                // string strquery1 = "insert into Client(codeclient,noms,telephone,mail,adresse) values(@codeclient,@noms,@telephone,@mail,@adresse)";
                string strquery = "exec update_fournisseur @codefournisseur, @nom,@postnom,@prenom,@genre,@etat_civil,@adresse,@numero;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodefournisseur = new SqlParameter("@codefournisseur", clsf.codefournisseur);
                SqlParameter prnom = new SqlParameter("@nom", clsf.nom);
                SqlParameter prpostnom = new SqlParameter("@postnom", clsf.postnom);
                SqlParameter prprenom = new SqlParameter("@prenom", clsf.prenom);
                SqlParameter prgenre = new SqlParameter("@genre", clsf.genre);
                SqlParameter pretat = new SqlParameter("@etat_civil", clsf.etat_civil);
                SqlParameter pradresse = new SqlParameter("@adresse", clsf.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsf.numero);
                cmd.Parameters.Add(prcodefournisseur);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prpostnom);
                cmd.Parameters.Add(prprenom);
                cmd.Parameters.Add(prgenre);
                cmd.Parameters.Add(pretat);
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
        public int supprimerfournisseur(clsfournisseur clsf)
        {
            int value = 0;
            string strquery = " exec delete_fournisseur @codefournisseur";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodefournisseur = new SqlParameter("@codefournisseur", clsf.codefournisseur);
                cmd.Parameters.Add(prcodefournisseur);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<clsfournisseur> getfournisseur()
        {
            List<clsfournisseur> list = new List<clsfournisseur>();
            con = new connexion().DBConnect();
            string strquery = "exec afficher_fournisseur ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsfournisseur clsf = new clsfournisseur();
                clsf.codefournisseur = dr["codefournisseur"].ToString();
                clsf.nom = dr["nom"].ToString();
                clsf.postnom = dr["postnom"].ToString();
                clsf.prenom = dr["prenom"].ToString();
                clsf.genre = dr["genre"].ToString();
                clsf.etat_civil = dr["etat_civil"].ToString();
                clsf.adresse = dr["adresse"].ToString();
                clsf.numero = dr["telephone"].ToString();
                list.Add(clsf);
            }
            return list;
        }
    }
}
