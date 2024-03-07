using GestionEtudiant.clsGestionEtudiant_variables;
using GestionEtudiant.GestionEtudiantUtilitiesLib;
using GestionEtudiant.ManagerSingleConnexion;
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
    public class clsetudiant: clsvariable_etudiants
    {

        public clsetudiant()
        {
        }
        private string _id;
        private string _matricule;
        private string _nom;
        private string _postnom;
        private string _prenom;
        private string _sex;
        private string _etatcivile;

        public string id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string matricule
        {
            get
            {
                return _matricule;
            }

            set
            {
                _matricule = value;
            }
        }

        public string nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string postnom
        {
            get
            {
                return _postnom;
            }

            set
            {
                _postnom = value;
            }
        }

        public string prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string sexe
        {
            get
            {
                return _sex;
            }

            set
            {
                _sex = value;
            }
        }

        public string etat_civil
        {
            get
            {
                return _etatcivile;
            }

            set
            {
                _etatcivile = value;
            }
        }

        

        public void Enregistrer(classes.clsetudiant etudiant)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_or_update_etudiant";
                cmd.CommandType = CommandType.StoredProcedure;

                // Utilisez les propriétés de l'objet actuel (this)
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@nom", 50, DbType.String, _nom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@postnom", 50, DbType.String, _postnom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@prenom", 50, DbType.String, _prenom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@sexe", 1, DbType.String, _sex));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@etatcivil", 50, DbType.String, _etatcivile));

                cmd.ExecuteNonQuery();
            }
        }

        public void Modifier(clsvariable_etudiants etudiant)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_or_update_etudiant";
                cmd.CommandType = CommandType.StoredProcedure;

                // Utilisez les propriétés de l'objet actuel (this)
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 50, DbType.String, _id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@nom", 50, DbType.String, _nom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@postnom", 50, DbType.String, _postnom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@prenom", 50, DbType.String, _prenom));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@sexe", 1, DbType.String, _sex));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@etatcivil", 50, DbType.String, _etatcivile));

                cmd.ExecuteNonQuery();
            }
        }

        public void Supprimer(int id)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_delete_etudiant";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        public List<clsvariable_etudiants> Etudiant()
        {
            List<clsvariable_etudiants> lst = new List<clsvariable_etudiants>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_select_etudiants";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetEtudiant(rd));
                }

                rd.Dispose();
            }

            return lst;
        }

        private clsvariable_etudiants GetEtudiant(IDataReader rd)
        {
            clsvariable_etudiants etudiant = new clsetudiant();

            etudiant.id = rd["id"].ToString();
            etudiant.matricule = rd["matricule"].ToString();
            etudiant.nom = rd["nom"].ToString();
            etudiant.postnom = rd["postnom"].ToString();
            etudiant.prenom = rd["prenom"].ToString();
            etudiant.sexe = rd["sexe"].ToString();
            etudiant.etat_civil = rd["etat_civile"].ToString();

            return etudiant;
        }
       
    }
}
