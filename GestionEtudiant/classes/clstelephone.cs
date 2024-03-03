using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.classes
{
    class clstelephone
    {
        SqlConnection con;
        public int insert_telephone(clsGestionEtudiant_variables.clsvariable_telephone clstel)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_or_update_telephone null,@id_proprietaire,@initial,@numero";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prproprietaire = new SqlParameter("@id_proprietaire", clstel.id_proprietaire);
                    SqlParameter prinitial = new SqlParameter("@initial", clstel.initial);
                    SqlParameter prnumero = new SqlParameter("@numero", clstel.numero);
                    cmd.Parameters.Add(prproprietaire);
                    cmd.Parameters.Add(prinitial);
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

        public int update_telephone(clsGestionEtudiant_variables.clsvariable_telephone clstel)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_or_update_telephone @id,@id_proprietaire,@initial,@numero";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clstel.id);
                    SqlParameter prproprietaire = new SqlParameter("@id_proprietaire", clstel.id_proprietaire);
                    SqlParameter prinitial = new SqlParameter("@initial", clstel.initial);
                    SqlParameter prnumero = new SqlParameter("@numero", clstel.numero);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prproprietaire);
                    cmd.Parameters.Add(prinitial);
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

        public int delete_telephone(clsGestionEtudiant_variables.clsvariable_telephone clstel)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_telephone @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clstel.id);
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
        public List<clsGestionEtudiant_variables.clsvariable_telephone> getlisttelephone()
        {
            List<clsGestionEtudiant_variables.clsvariable_telephone> list = new List<clsGestionEtudiant_variables.clsvariable_telephone>();
            con = new clsConnexion.clsconnexionSQL().DBConnect();
            string strquery = "exec sp_select_telephones";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsGestionEtudiant_variables.clsvariable_telephone clstel = new clsGestionEtudiant_variables.clsvariable_telephone();
                clstel.id = dr["id"].ToString();
                clstel.id_proprietaire =Convert.ToInt32(dr["id_proprietaire"]);
                clstel.initial = dr["initial"].ToString();
                clstel.numero = dr["numero"].ToString();
                list.Add(clstel);
            }
            return list;
        }
        MySqlConnection cons;
        public int insert_telephoneMSQL(clsGestionEtudiant_variables.clsvariable_telephone clstel)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = " call InsertOrUpdattelephone (null,@id_proprietaire,@initial,@numero)";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prproprietaire = new MySqlParameter("@id_proprietaire", clstel.id_proprietaire);
                    MySqlParameter prinitial = new MySqlParameter("@initial", clstel.initial);
                    MySqlParameter prnumero = new MySqlParameter("@numero", clstel.numero);
                    cmd.Parameters.Add(prproprietaire);
                    cmd.Parameters.Add(prinitial);
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

        public int update_telephoneMSQL(clsGestionEtudiant_variables.clsvariable_telephone clstel)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = " call InsertOrUpdattelephone (@id,@id_proprietaire,@initial,@numero)";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prid = new MySqlParameter("@id", clstel.id);
                    MySqlParameter prproprietaire = new MySqlParameter("@id_proprietaire", clstel.id_proprietaire);
                    MySqlParameter prinitial = new MySqlParameter("@initial", clstel.initial);
                    MySqlParameter prnumero = new MySqlParameter("@numero", clstel.numero);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prproprietaire);
                    cmd.Parameters.Add(prinitial);
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

        public int delete_telephoneMYSQL(clsGestionEtudiant_variables.clsvariable_telephone clstel)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = " delele from telephone where id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prid = new MySqlParameter("@id", clstel.id);
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
        public List<clsGestionEtudiant_variables.clsvariable_telephone> getlisttelephoneMYSQL()
        {
            List<clsGestionEtudiant_variables.clsvariable_telephone> list = new List<clsGestionEtudiant_variables.clsvariable_telephone>();
            con = new clsConnexion.clsconnexionSQL().DBConnect();
            string strquery = "CALL sp_select_telephones";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsGestionEtudiant_variables.clsvariable_telephone clstel = new clsGestionEtudiant_variables.clsvariable_telephone();
                clstel.id = dr["id"].ToString();
                clstel.id_proprietaire = Convert.ToInt32(dr["id_proprietaire"]);
                clstel.initial = dr["initial"].ToString();
                clstel.numero = dr["numero"].ToString();
                list.Add(clstel);
            }
            return list;
        }
    }
}
