using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant.classes
{
    class clsetudiant
    {
        SqlConnection con;
        public int insert_etudiant(clsGestionEtudiant_variables.clsvariable_etudiants clsetu)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_or_update_etudiant null,@nom,@postnom,@prenom,@sexe,@etat_civil";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prnom = new SqlParameter("@nom", clsetu.nom);
                    SqlParameter prpostnom = new SqlParameter("@postnom", clsetu.postnom);
                    SqlParameter prprenom = new SqlParameter("@prenom", clsetu.prenom);
                    SqlParameter prsexe = new SqlParameter("@sexe", clsetu.sexe);
                    SqlParameter pretatcivil = new SqlParameter("@etat_civil", clsetu.etat_civil);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prpostnom);
                    cmd.Parameters.Add(prprenom);
                    cmd.Parameters.Add(prsexe);
                    cmd.Parameters.Add(pretatcivil);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int update_etudiant(clsGestionEtudiant_variables.clsvariable_etudiants clsetu)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_or_update_etudiant @id,@nom,@postnom,@prenom,@sexe,@etat_civil";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clsetu.id);
                    SqlParameter prnom = new SqlParameter("@nom", clsetu.nom);
                    SqlParameter prpostnom = new SqlParameter("@postnom", clsetu.postnom);
                    SqlParameter prprenom = new SqlParameter("@prenom", clsetu.prenom);
                    SqlParameter prsexe = new SqlParameter("@sexe", clsetu.sexe);
                    SqlParameter pretatcivil = new SqlParameter("@etat_civil", clsetu.etat_civil);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prpostnom);
                    cmd.Parameters.Add(prprenom);
                    cmd.Parameters.Add(prsexe);
                    cmd.Parameters.Add(pretatcivil);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int delete_etudiant(clsGestionEtudiant_variables.clsvariable_etudiants clsetu)
        {
            try
            {
                int value = 0;
                con = new clsConnexion.clsconnexionSQL().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_etudiant @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@id", clsetu.id);
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
        public List<clsGestionEtudiant_variables.clsvariable_etudiants> getlistetudiant()
        {
            List<clsGestionEtudiant_variables.clsvariable_etudiants> list = new List<clsGestionEtudiant_variables.clsvariable_etudiants>();
            con = new clsConnexion.clsconnexionSQL().DBConnect();
            string strquery = "exec sp_select_etudiants";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsGestionEtudiant_variables.clsvariable_etudiants clsetu = new clsGestionEtudiant_variables.clsvariable_etudiants();
                clsetu.id = dr["id"].ToString();
                clsetu.matricule = dr["matricule"].ToString();
                clsetu.nom = dr["nom"].ToString();
                clsetu.postnom = dr["postnom"].ToString();
                clsetu.prenom = dr["prenom"].ToString();
                clsetu.sexe = dr["sexe"].ToString();
                clsetu.etat_civil = dr["etat_civil"].ToString();
                list.Add(clsetu);
            }
            return list;
        }
        //=========================================================================================//
        //==================================LES METHODES POUR MYSQL================================//
        //=========================================================================================//
        MySqlConnection cons;
        public int insert_etudiantMYSQL(clsGestionEtudiant_variables.clsvariable_etudiants clsetu)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = " call InsertOrUpdateEtudiant(null,@nom,@postnom,@prenom,@sexe,@etat_civil)";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prnom = new MySqlParameter("@nom", clsetu.nom);
                    MySqlParameter prpostnom = new MySqlParameter("@postnom", clsetu.postnom);
                    MySqlParameter prprenom = new MySqlParameter("@prenom", clsetu.prenom);
                    MySqlParameter prsexe = new MySqlParameter("@sexe", clsetu.sexe);
                    MySqlParameter pretatcivil = new MySqlParameter("@etat_civil", clsetu.etat_civil);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prpostnom);
                    cmd.Parameters.Add(prprenom);
                    cmd.Parameters.Add(prsexe);
                    cmd.Parameters.Add(pretatcivil);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int update_etudiantMYSQL(clsGestionEtudiant_variables.clsvariable_etudiants clsetu)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = "call InsertOrUpdateEtudiant (@id,@nom,@postnom,@prenom,@sexe,@etat_civil)";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prid = new MySqlParameter("@id", clsetu.id);
                    MySqlParameter prnom = new MySqlParameter("@nom", clsetu.nom);
                    MySqlParameter prpostnom = new MySqlParameter("@postnom", clsetu.postnom);
                    MySqlParameter prprenom = new MySqlParameter("@prenom", clsetu.prenom);
                    MySqlParameter prsexe = new MySqlParameter("@sexe", clsetu.sexe);
                    MySqlParameter pretatcivil = new MySqlParameter("@etat_civil", clsetu.etat_civil);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prpostnom);
                    cmd.Parameters.Add(prprenom);
                    cmd.Parameters.Add(prsexe);
                    cmd.Parameters.Add(pretatcivil);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int delete_etudiantMYSQL(clsGestionEtudiant_variables.clsvariable_etudiants clsetu)
        {
            try
            {
                int value = 0;
                cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
                if (cons != null)
                {
                    string query = " delete from etudiant where id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, cons);
                    MySqlParameter prid = new MySqlParameter("@id", clsetu.id);
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
        public List<clsGestionEtudiant_variables.clsvariable_etudiants> getlistetudiantMYSQL()
        {
            List<clsGestionEtudiant_variables.clsvariable_etudiants> list = new List<clsGestionEtudiant_variables.clsvariable_etudiants>();
            cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
            string strquery = "select * from etudiant";
            MySqlCommand cmd = new MySqlCommand(strquery, cons);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsGestionEtudiant_variables.clsvariable_etudiants clsetu = new clsGestionEtudiant_variables.clsvariable_etudiants();
                clsetu.id = dr["id"].ToString();
                clsetu.matricule = dr["matricule"].ToString();
                clsetu.nom = dr["nom"].ToString();
                clsetu.postnom = dr["postnom"].ToString();
                clsetu.prenom = dr["prenom"].ToString();
                clsetu.sexe = dr["sexe"].ToString();
                clsetu.etat_civil = dr["etat_civil"].ToString();
                list.Add(clsetu);
            }
            return list;
        }

        public void chargercomboboxSQL(ComboBox list)
        {
            con = new clsConnexion.clsconnexionSQL().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_etudiant", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "etudiant");
                list.DataSource = ds.Tables["etudiant"];
                list.ValueMember = "id";
                list.DisplayMember = "noms";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void chargercomboboxMYSQL(ComboBox list)
        {
            cons = new clsConnexion.clsconnexionMYSQL().DBConnect();
            try
            {
                var chrg = new MySqlCommand("CALL `chargement_etudiant`()", cons)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new MySqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "etudiant");
                list.DataSource = ds.Tables["etudiant"];
                list.ValueMember = "id";
                list.DisplayMember = "noms";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
