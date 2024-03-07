using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.GestionEtudiantUtilitiesLib
{
    class Parametres
    {
        private Parametres()
        {
        }

        private static Parametres _instance = null;

        public static Parametres Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Parametres();
                return _instance;
            }
        }

        public IDbDataParameter AjouterParametre(IDbCommand command, string nomParametre, int taille, DbType type, object valeur)
        {
            IDbDataParameter param = command.CreateParameter();
            param.ParameterName = nomParametre;
            param.DbType = type;
            param.Size = taille;
            param.Value = valeur;

            return param;
        }
    }
}
