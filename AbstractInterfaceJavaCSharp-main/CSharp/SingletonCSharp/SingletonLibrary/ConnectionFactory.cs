
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SingletonLibrary
{
    public class ConnectionFactory
    {
        private static IDbConnection connection = null;

        private ConnectionFactory()
        {

        }

        public static IDbConnection getConnection(ConnectionType connectionType)
        {
            if (connection == null)
            {
                switch (connectionType)
                {
                    case ConnectionType.MYSQL_CONNECTION:
                        connection = createMySQLConnection();
                        break;
                    case ConnectionType.SQL_SERVER_CONNECTION:
                        connection = createSQLServerConnection();
                        break;
                    default:
                        throw new Exception("No Database type specified!");
                }

            }
            return connection;
        }

        private static String formatSQLServerConnectionString(Connect connect)
        {
            return String.Format("Data source={0};Initial catalog={1};User Ids={2};Password={3}", connect.Host, connect.Database, connect.Username, connect.Password);
        }

        private static IDbConnection createSQLServerConnection()
        {
            String strCon = formatSQLServerConnectionString(new Connect("LOCALHOST\\SQLEXPRESS", "gestion-etudiant", "sa", "laure"));
            return new SqlConnection(strCon);
        }

        private static String formatMySQLConnectionString(Connect connect)
        {
            return String.Format("Server={0};Database={1};User Id={2};Password={3}", connect.Host, connect.Database, connect.Username, connect.Password);
        }

        private static IDbConnection createMySQLConnection()
        {
            String strCon = formatMySQLConnectionString(new Connect("localhost","gestion-etudiant","root", ""));
            return new MySqlConnection(strCon);
        }
    }
}