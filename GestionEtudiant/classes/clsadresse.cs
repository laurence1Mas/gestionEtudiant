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
    public class clsadresse : clsvariable_adresse
    {
        public clsadresse()
        {

        }
        string _id;
        string _quartier;
        string _commune;
        string _ville;
        string _pays;

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

        public string quartier
        {
            get
            {
                return _quartier;
            }

            set
            {
                _quartier = value; 
            }
        }

        public string commune
        {
            get
            {
                return _commune;
            }

            set
            {
                _commune=value;
            }
        }

        public string ville
        {
            get
            {
                return _ville;
            }

            set
            {
                _ville=value;
            }
        }

        public string pays
        {
            get
            {
               return _pays;
            }

            set
            {
                _pays=value;
            }
        }

        public void Enregistrer(clsvariable_adresse telephone)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_or_update_telephone";
                cmd.CommandType = CommandType.StoredProcedure;

                // Utilisez les propriétés de l'objet actuel (this)
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 50, DbType.String, _id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@quartier", 50, DbType.String, _quartier));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@commune", 50, DbType.String, _commune));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ville", 50, DbType.String, _ville));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@pays", 50, DbType.String, _pays));

                cmd.ExecuteNonQuery();
            }
        }
        public void Modifier(clsvariable_adresse telephone)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_insert_or_update_adresse";
                cmd.CommandType = CommandType.StoredProcedure;

                // Utilisez les propriétés de l'objet actuel (this)
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 50, DbType.String, _id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@quartier", 50, DbType.String, _quartier));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@commune", 50, DbType.String, _commune));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@ville", 50, DbType.String, _ville));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@pays", 50, DbType.String, _pays));

                cmd.ExecuteNonQuery();
            }
        }

        private clsvariable_adresse GetAdresse(IDataReader rd)
        {
            clsvariable_adresse adresse = new clsadresse();
            adresse.id = rd["id"].ToString();
            adresse.quartier = rd["quartier"].ToString();
            adresse.commune = rd["commune"].ToString();
            adresse.ville = rd["ville"].ToString();
            adresse.pays = rd["pays"].ToString();
            return adresse;
        }

        public List<clsvariable_adresse> Adresse()
        {
            List<clsvariable_adresse> lst = new List<clsvariable_adresse>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "sp_select_adresses";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetAdresse(rd));
                }

                rd.Dispose();
            }

            return lst;
        }
    }
}
