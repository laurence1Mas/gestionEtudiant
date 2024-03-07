using AbstractClassUsage;
using SingletonLibrary;
using System;
using System.Data;

namespace TestAbstractClassUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Students Insertion
                Person s1 = new Student(1, "54546MTCFE514","MASIKA", "MAKASI", "laurence","F","celibataire");
                s1.Add(s1);
                Console.WriteLine("Student inserted successfully!");

                Person s2 = new Student(2, "54546MTCFGGR", "MBONYIMBUGA", "PROMESSE", "dorcas", "F", "celibataire");
                s2.Add(s2);

                Console.WriteLine("Student insert successfully!");
                // Show inserted values for Student
                s1.ShowDynamicIdentity(s1.Id);
                Console.WriteLine("------------------------------------------");
                s2.ShowDynamicIdentity(s2.Id);
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
