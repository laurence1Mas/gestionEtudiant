using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.classes
{
    class clsadresse
    {
        SqlConnection con;
        public int insert_adresse(clsGestionEtudiant_variables.clsvariable_adresse clsadrs)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_or_update_adresse null,@quartier,@commune,@ville,@pays";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prquartier = new SqlParameter("@quartier", clsadrs.quartier);
                    SqlParameter prcommune = new SqlParameter("@commune", clsadrs.commune);
                    SqlParameter prville = new SqlParameter("@ville", clsadrs.ville);
                    SqlParameter prpays = new SqlParameter("@pays", clsadrs.pays);
                    cmd.Parameters.Add(prquartier);
                    cmd.Parameters.Add(prcommune);
                    cmd.Parameters.Add(prville);
                    cmd.Parameters.Add(prpays);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int update_adresse(clsGestionEtudiant_variables.clsvariable_adresse clsadrs)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_or_update_adresse @id,@quartier,@commune,@ville,@pays";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clsadrs.id);
                    SqlParameter prquartier = new SqlParameter("@quartier", clsadrs.quartier);
                    SqlParameter prcommune = new SqlParameter("@commune", clsadrs.commune);
                    SqlParameter prville = new SqlParameter("@ville", clsadrs.ville);
                    SqlParameter prpays = new SqlParameter("@pays", clsadrs.pays);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prquartier);
                    cmd.Parameters.Add(prcommune);
                    cmd.Parameters.Add(prville);
                    cmd.Parameters.Add(prpays);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int delete_adresse(clsGestionEtudiant_variables.clsvariable_adresse clsadrs)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_adresse @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clsadrs.id);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<clsGestionEtudiant_variables.clsvariable_adresse> getlistadresse()
        {
            List<clsGestionEtudiant_variables.clsvariable_adresse> list = new List<clsGestionEtudiant_variables.clsvariable_adresse>();
            con = new clsConnexion.clsconnexionSQL().DBConnect();
            string strquery = "exec sp_select_adresses";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsGestionEtudiant_variables.clsvariable_adresse clsadrs = new clsGestionEtudiant_variables.clsvariable_adresse();
                clsadrs.id = dr["id"].ToString();
                clsadrs.quartier = dr["quartier"].ToString();
                clsadrs.commune = dr["commune"].ToString();
                clsadrs.ville = dr["ville"].ToString();
                clsadrs.pays = dr["pays"].ToString();
                list.Add(clsadrs);
            }
            return list;
        }


        MySqlConnection cons;
        public int insert_adresseMYSQL(clsGestionEtudiant_variables.clsvariable_adresse clsadrs)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = " call InsertOrUpdatadresse (null,@quartier,@commune,@ville,@pays)";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prquartier = new MySqlParameter("@quartier", clsadrs.quartier);
                    MySqlParameter prcommune = new MySqlParameter("@commune", clsadrs.commune);
                    MySqlParameter prville = new MySqlParameter("@ville", clsadrs.ville);
                    MySqlParameter prpays = new MySqlParameter("@pays", clsadrs.pays);
                    cmd.Parameters.Add(prquartier);
                    cmd.Parameters.Add(prcommune);
                    cmd.Parameters.Add(prville);
                    cmd.Parameters.Add(prpays);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int update_adresseMYSQL(clsGestionEtudiant_variables.clsvariable_adresse clsadrs)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = "call InsertOrUpdatadresse (@id,@quartier,@commune,@ville,@pays)";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prid = new MySqlParameter("@id", clsadrs.id);
                    MySqlParameter prquartier = new MySqlParameter("@quartier", clsadrs.quartier);
                    MySqlParameter prcommune = new MySqlParameter("@commune", clsadrs.commune);
                    MySqlParameter prville = new MySqlParameter("@ville", clsadrs.ville);
                    MySqlParameter prpays = new MySqlParameter("@pays", clsadrs.pays);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prquartier);
                    cmd.Parameters.Add(prcommune);
                    cmd.Parameters.Add(prville);
                    cmd.Parameters.Add(prpays);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int delete_adresseMYSQL(clsGestionEtudiant_variables.clsvariable_adresse clsadrs)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = " delete from adresse where id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prid = new MySqlParameter("@id", clsadrs.id);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<clsGestionEtudiant_variables.clsvariable_adresse> getlistadresseMYSQL()
        {
            List<clsGestionEtudiant_variables.clsvariable_adresse> list = new List<clsGestionEtudiant_variables.clsvariable_adresse>();
            cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
            string strquery = "select * from adresse";
            MySqlCommand cmd = new MySqlCommand(strquery, cons);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsGestionEtudiant_variables.clsvariable_adresse clsadrs = new clsGestionEtudiant_variables.clsvariable_adresse();
                clsadrs.id = dr["id"].ToString();
                clsadrs.quartier = dr["quartier"].ToString();
                clsadrs.commune = dr["commune"].ToString();
                clsadrs.ville = dr["ville"].ToString();
                clsadrs.pays = dr["pays"].ToString();
                list.Add(clsadrs);
            }
            return list;
        }


    }
}
