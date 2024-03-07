using SingletonLibrary;
using System;
using System.Data;


namespace AbstractClassUsage
{
    public class Student : Person
    {
        public Student()
        {

        }
        
        public Student(int id,string rollNumber, string nom, string postnom,string prenom,string sexe,string etatcivil) : base(id, nom, postnom,prenom,sexe,etatcivil)
        {
            this.RollNumber = rollNumber;
        }

        private String _rollNumber;

        public string RollNumber
        {
            get
            {
                return _rollNumber;
            }

            set
            {
                _rollNumber = value;
            }
        }

        public override void ShowIdentity()
        {
            Console.WriteLine(String.Format("etudiant with id [{0}],matricule [{1}] ,nom [{2}], postnom [{3}],prenom [{4}],sexe [{5}],etat_civil[{6}]", Id, _rollNumber, Nom, Postnom,Prenom,Sexe,Etatcivil));
        }

        public override void ShowDynamicIdentity(int id)
        {
            // Open Connection if closed
            if (ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).State == ConnectionState.Closed)
                ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).Open();

            using (IDbCommand cmd = ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).CreateCommand())
            {
                cmd.CommandText = "SELECT etudiant.id, etudiant.matricule, etudiant.nom, etudiant.postnom,etudiant.prenom,etudiant.sexe,etudiant.etat_civil FROM etudiant WHERE etudiant.id=@id";
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@id", 4, DbType.Int32, id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    Console.WriteLine(String.Format("etudiant with id [{0}], matricule [{1}], nom [{2}], postnom [{3}],prenom[{4}],sexe[{5}],etat_civil[{6}]", Convert.ToInt32(rd["id"]), rd["matricule"].ToString(), rd["postnom"].ToString(), rd["prenom"].ToString(),rd["sexe"].ToString(), rd["etat_civil"].ToString()));
                }

                rd.Dispose();
            }
        }

        public override int Add(Person p)
        {
            int record = 0;

            // Open Connection if closed
            if (ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).State == ConnectionState.Closed)
                ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).Open();

            using (IDbCommand cmd = ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).CreateCommand())
            {
                cmd.CommandText = "INSERT INTO etudiant(id,matricule,nom,postnom,prenom,sexe,etat_civil) VALUES(@id,@matricule,@nom,@postnom,@prenom,@sexe,@etatcivile)";
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@id", 4, DbType.Int32, p.Id));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@matricule", 100, DbType.String, ((Student)p)._rollNumber));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@nom", 100, DbType.String, p.Nom));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@postnom", 100, DbType.String, p.Postnom));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@prenom", 100, DbType.String, p.Prenom));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@sexe", 100, DbType.String, p.Sexe));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@etatcivile", 100, DbType.String, p.Etatcivil));
                record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("Failed to insert Person data to the database!");
            }

            return record;
        }
    }
}
