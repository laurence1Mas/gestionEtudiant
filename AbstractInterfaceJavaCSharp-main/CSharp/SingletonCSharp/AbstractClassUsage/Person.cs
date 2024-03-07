using SingletonLibrary;
using System;

namespace AbstractClassUsage
{
    public abstract class Person
    {

        public Person()
        {

        }

        public Person(
            int id, 
            string nom, 
            string postnom,
            string prenom,
            string sexe,
            string etatcivil
            )
        {
            this.Id = id;
            this.Nom = nom;
            this.Postnom = postnom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.Etatcivil = etatcivil;
        }

        private int _id;
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

        /// <summary>
        /// Print Person's identity without using Database connection.
        /// </summary>
        public abstract void ShowIdentity();

        /// <summary>
        /// Show Person's identity with a connection to the DataBase by using Person ID
        /// </summary>
        /// <param name="id">Person Id</param>
        public abstract void ShowDynamicIdentity(int id);

        /// <summary>
        /// Insert new Person into the database by passing a Person reference (Any type of Person)
        /// </summary>
        /// <param name="p">Person object</param>
        /// <returns></returns>
        public abstract int Add(Person p);
    }
}
