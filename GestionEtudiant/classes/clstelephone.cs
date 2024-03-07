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

namespace GestionEtudiant.classes
{
    public class clstelephone: clsvariable_telephone
    {
        public clstelephone()
        {
        }
        private string _id;
        private string _id_proprietaire;
        private string _initial;
        private string _numero;

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

        public string id_proprietaire
        {
            get
            {
                return _id_proprietaire;
            }

            set
            {
                _id_proprietaire = value;
            }
        }

        public string initial
        {
            get
            {
                return _initial;
            }

            set
            {
                _initial = value;
            }
        }

        public string numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }
        public void Enregistrer(clsvariable_telephone telephone)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_or_update_telephone";
                cmd.CommandType = CommandType.StoredProcedure;

                // Utilisez les propriétés de l'objet actuel (this)
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id_proprietaire", 50, DbType.String, _id_proprietaire));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@initial", 50, DbType.String, _initial));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@numero", 50, DbType.String, _numero));

                cmd.ExecuteNonQuery();
            }
        }
        public void Modifier(clsvariable_telephone telephone)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_or_update_telephone";
                cmd.CommandType = CommandType.StoredProcedure;

                // Utilisez les propriétés de l'objet actuel (this)
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 50, DbType.String, _id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id_proprietaire", 50, DbType.String, _id_proprietaire));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@initial", 50, DbType.String, _initial));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@numero", 50, DbType.String, _numero));

                cmd.ExecuteNonQuery();
            }
        }

        private clsvariable_telephone GetTelephone(IDataReader rd)
        {
            clsvariable_telephone telephone = new clstelephone();
            telephone.id = rd["id"].ToString();
            telephone.id_proprietaire = rd["id_proprietaire"].ToString();
            telephone.initial = rd["initial"].ToString();
            telephone.numero = rd["numero"].ToString();

            return telephone;
        }

        public List<clsvariable_telephone> Telephone()
        {
            List<clsvariable_telephone> lst = new List<clsvariable_telephone>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_select_telephones";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetTelephone(rd));
                }

                rd.Dispose();
            }

            return lst;
        }

    }
}
