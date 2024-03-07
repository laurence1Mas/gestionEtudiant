using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.ManagerSingleConnexion
{
    public class ImplementeConnexion : IConnexion
    {
        private ImplementeConnexion()
        {
        }

        //private ConnexionType _conType;
        private IDbConnection _conn = null;
        private static ImplementeConnexion _instance = null;

        //public ConnexionType ConType
        //{
        //    get
        //    {
        //        return _conType;
        //    }

        //    set
        //    {
        //        _conType = value;
        //    }
        //}

        public IDbConnection Conn
        {
            get
            {
                return _conn;
            }

            set
            {
                _conn = value;
            }
        }

        public static ImplementeConnexion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ImplementeConnexion();
                return _instance;
            }
        }

        public IDbConnection Initialise(Connexion connexion, ConnexionType connexionType)
        {
            switch (connexionType)
            {
                case ConnexionType.SQLServer:
                    _conn = new SqlConnection(string.Format("Server={0};Database={1};User Id={2};Password={3};",
                        connexion.Serveur, connexion.Database, connexion.User, connexion.Password));
                    break;
                //case ConnexionType.MySQL:
                //    _conn = new MySqlConnection(string.Format("Server={0};Database={1};UserID={2};Password={3}",
                //        connexion.Serveur, connexion.Database, connexion.User, connexion.Password));
                //    break;
                //case ConnexionType.PostGrsSQL:
                //    _conn = new NpgsqlConnection(string.Format("Server={0};Database={1};Uid={2};Pwd={3};Port={4}",
                //        connexion.Serveur, connexion.Database, connexion.User, connexion.Password,connexion.Port));
                //    break;
                //case ConnexionType.Oracle:
                //    return null;
                //case ConnexionType.Access:
                //    return null;
                default:
                    return null;
            }
            return _conn;
        }

        IDbConnection IConnexion.Initialise(Connexion connexion, ConnexionType connectionType)
        {
            throw new NotImplementedException();
        }
    }
}
