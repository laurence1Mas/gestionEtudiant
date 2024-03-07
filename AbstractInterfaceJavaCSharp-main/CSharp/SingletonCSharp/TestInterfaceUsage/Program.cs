using InterfaceUsage;
using SingletonLibrary;
using System;
using System.Data;

namespace TestInterfaceUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Students Insertion
                IPerson s3 = new Student(3, "54546MTCFEfgy14", "KILINGO", "LIKWAYABO", "jean-paul", "M", "celibataire");
                s3.Add();
                Console.WriteLine("Student inserted successfully!");

                IPerson s4 = new Student(4, "54546MTCF-514", "MUHINDO", "KAMI", "el-bethel", "M", "celibataire");
                s4.Add();

                Console.WriteLine("Student insert successfully!");
                // Show inserted values for Student
                s3.ShowDynamicIdentity(((Student)s3).Id);
                Console.WriteLine("------------------------------------------");
                s4.ShowDynamicIdentity(((Student)s4).Id);
                Console.WriteLine("-----------------------------------------");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Failed to insert records to the Database, " + ex.Message);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Failed to insert records to the Database, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to insert records to the Database, " + ex.Message);
            }
            finally
            {
                if (ConnectionFactory.getConnection(ConnectionType.MYSQL_CONNECTION) != null)
                {
                    if (ConnectionFactory.getConnection(ConnectionType.MYSQL_CONNECTION).State == ConnectionState.Open)
                        ConnectionFactory.getConnection(ConnectionType.MYSQL_CONNECTION).Close();
                }

                if (ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION) != null)
                {
                    if (ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).State == ConnectionState.Open)
                        ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).Close();
                }
            }
            Console.ReadLine();
        }
    }
}
