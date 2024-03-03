using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.classes
{
    class clspersonneAdresse
    {
        SqlConnection con;
        public int insert_domicile(clsGestionEtudiant_variables.clsvariable_personneAdresse clsper)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_or_update_domicile null,@id_etudiant,@id_adresse,@avenue,@numero_avenue";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter pretudiant = new SqlParameter("@id_etudiant", clsper.id_etudiant);
                    SqlParameter pradresse = new SqlParameter("@id_adresse", clsper.id_adresse);
                    SqlParameter pravenue = new SqlParameter("@avenue", clsper.avenue);
                    SqlParameter prnumero = new SqlParameter("@numero_avenue", clsper.numero_avenue);
                    cmd.Parameters.Add(pretudiant);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(pravenue);
                    cmd.Parameters.Add(prnumero);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int update_domicile(clsGestionEtudiant_variables.clsvariable_personneAdresse clsper)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_or_update_domicile @id,@id_etudiant,@id_adresse,@avenue,@numero_avenue";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clsper.id_etudiant);
                    SqlParameter pretudiant = new SqlParameter("@id_etudiant", clsper.id_etudiant);
                    SqlParameter pradresse = new SqlParameter("@id_adresse", clsper.id_adresse);
                    SqlParameter pravenue = new SqlParameter("@avenue", clsper.avenue);
                    SqlParameter prnumero = new SqlParameter("@numero_avenue", clsper.numero_avenue);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(pretudiant);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(pravenue);
                    cmd.Parameters.Add(prnumero);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int delete_domicile(clsGestionEtudiant_variables.clsvariable_personneAdresse clsper)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_domicile @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clsper.id);
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
        public List<clsGestionEtudiant_variables.clsvariable_personneAdresse> getlistdomicile()
        {
            List<clsGestionEtudiant_variables.clsvariable_personneAdresse> list = new List<clsGestionEtudiant_variables.clsvariable_personneAdresse>();
            con = new clsConnexion.clsconnexionSQL().DBConnect();
            string strquery = "exec sp_select_domiciles";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsGestionEtudiant_variables.clsvariable_personneAdresse clstel = new clsGestionEtudiant_variables.clsvariable_personneAdresse();
                clstel.id = dr["id"].ToString();
                clstel.id_etudiant = dr["id_etudiant"].ToString();
                clstel.id_adresse = dr["id_adresse"].ToString();
                clstel.avenue = dr["avenue"].ToString();
                clstel. numero_avenue = Convert.ToInt32(dr["numero_avenue"]);
                list.Add(clstel);
            }
            return list;
        }
        MySqlConnection cons;
        public int insert_domicileMSQL(clsGestionEtudiant_variables.clsvariable_personneAdresse clsper)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (con != null)
                {
                    string query = " call InsertOrUpdatedomicile (null,@id_etudiant,@id_adresse,@avenue,@numero_avenue)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter pretudiant = new SqlParameter("@id_etudiant", clsper.id_etudiant);
                    SqlParameter pradresse = new SqlParameter("@id_adresse", clsper.id_adresse);
                    SqlParameter pravenue = new SqlParameter("@avenue", clsper.avenue);
                    SqlParameter prnumero = new SqlParameter("@numero_avenue", clsper.numero_avenue);
                    cmd.Parameters.Add(pretudiant);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(pravenue);
                    cmd.Parameters.Add(prnumero);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int update_domicileMSQL(clsGestionEtudiant_variables.clsvariable_personneAdresse clsper)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (con != null)
                {
                    string query = " call InsertOrUpdatedomicile (@id,@id_etudiant,@id_adresse,@avenue,@numero_avenue)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clsper.id);
                    SqlParameter pretudiant = new SqlParameter("@id_etudiant", clsper.id_etudiant);
                    SqlParameter pradresse = new SqlParameter("@id_adresse", clsper.id_adresse);
                    SqlParameter pravenue = new SqlParameter("@avenue", clsper.avenue);
                    SqlParameter prnumero = new SqlParameter("@numero_avenue", clsper.numero_avenue);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(pretudiant);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(pravenue);
                    cmd.Parameters.Add(prnumero);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int delete_domicileMYSQL(clsGestionEtudiant_variables.clsvariable_personneAdresse clsper)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = " delete from domicile where id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prid = new MySqlParameter("@id", clsper.id);
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
        public List<clsGestionEtudiant_variables.clsvariable_personneAdresse> getlistdomicileMYSQL()
        {
            List<clsGestionEtudiant_variables.clsvariable_personneAdresse> list = new List<clsGestionEtudiant_variables.clsvariable_personneAdresse>();
            cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
            string strquery = "select * from domicile";
            MySqlCommand cmd = new MySqlCommand(strquery, cons);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsGestionEtudiant_variables.clsvariable_personneAdresse clstel = new clsGestionEtudiant_variables.clsvariable_personneAdresse();
                clstel.id = dr["id"].ToString();
                clstel.id_etudiant = dr["id_etudiant"].ToString();
                clstel.id_adresse = dr["id_adresse"].ToString();
                clstel.avenue = dr["avenue"].ToString();
                clstel.numero_avenue = Convert.ToInt32(dr["numero_avenue"]);
                list.Add(clstel);
            }
            return list;
        }
    }
}
