using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant.clsConnexion
{
    class clsconnexionSQL
    {
        SqlConnection con;
        public SqlConnection DBConnect()
        {
            try
            {
                string strConnectionString = "Server=DESKTOP-HTI1CR5;Database=gestion_etudiant;User Id=SA;Password=laure";
                con = new SqlConnection(strConnectionString);
                con.Open();
                return con;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("erreur de la connection au serveur SQL Server" + ex);
                return null;
            }
        }
    }
}
