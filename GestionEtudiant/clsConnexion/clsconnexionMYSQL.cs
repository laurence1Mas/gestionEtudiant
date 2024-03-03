using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GestionEtudiant.clsConnexion
{
    class clsconnexionMYSQL
    {
        MySqlConnection con;
        public MySqlConnection DBConnect()
        {
            try
            {
                string strConnectionString = "datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=gestion_Etudiant;";
                con = new MySqlConnection(strConnectionString);
                con.Open();
                return con;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("erreur de la connection au serveur MYSQL" + ex);
                return null;
            }
        }
    }
}
