using SingletonLibrary;
using System;
using System.Data;

namespace InterfaceUsage
{
    public class Student : IPerson
    {
        public Student()
        {

        }

        public Student(int id,
            string matricule , 
            string nom, 
            string postnom, 
            string prenom,
            string sexe,
            string etatcivil)
        {
            this.Id = id;
            this.Matricule = matricule;
            this.Nom = nom;
            this.Postnom = postnom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.Etatcivil = etatcivil;
        }

        private int _id;
        private string _matricule;
        private string _nom;
        private string _postnom;
        private string _prenom;
        private string _sexe;
        private string _etatcivil;

        public int Id
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

        public string Matricule
        {
            get
            {
                return _matricule;
            }

            set
            {
                _matricule = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Postnom
        {
            get
            {
                return _postnom;
            }

            set
            {
                _postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Sexe
        {
            get
            {
                return _sexe;
            }

            set
            {
                _sexe = value;
            }
        }

        public string Etatcivil
        {
            get
            {
                return _etatcivil;
            }

            set
            {
                _etatcivil = value;
            }
        }

        public void ShowIdentity()
        {
            Console.WriteLine(String.Format("etudiant with id [{0}],matricule [{1}] ,nom [{2}], postnom [{3}],prenom [{4}],sexe [{5}],etat_civil[{6}]", Id, Matricule, Nom, Postnom, Prenom, Sexe, Etatcivil));
        }

        public void ShowDynamicIdentity(int id)
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
                    Console.WriteLine(String.Format("etudiant with id [{0}], matricule [{1}], nom [{2}], postnom [{3}],prenom[{4}],sexe[{5}],etat_civil[{6}]", Convert.ToInt32(rd["id"]), rd["matricule"].ToString(), rd["postnom"].ToString(), rd["prenom"].ToString(), rd["sexe"].ToString(), rd["etat_civil"].ToString()));
                }

                rd.Dispose();
            }
        }

        public int Add()
        {
            int record = 0;

            // Open Connection if closed
            if (ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).State == ConnectionState.Closed)
                ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).Open();

            using (IDbCommand cmd = ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).CreateCommand())
            {
                cmd.CommandText = "INSERT INTO etudiant(id,matricule,nom,postnom,prenom,sexe,etat_civil) VALUES(@id,@matricule,@nom,@postnom,@prenom,@sexe,@etatcivile)";
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@id", 4, DbType.Int32, _id));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@matricule", 100, DbType.String, _matricule));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@nom", 100, DbType.String,_nom));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@postnom", 100, DbType.String, _postnom));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@prenom", 100, DbType.String, _prenom));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@sexe", 100, DbType.String, _sexe));
                cmd.Parameters.Add(UtilitiesFactory.Instance.AddParameter(cmd, "@etatcivile", 100, DbType.String,_etatcivil));
                record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("Failed to insert Person data to the database!");
            }

            return record;
        }
    }
}
