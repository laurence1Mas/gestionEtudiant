﻿using GestionEtudiant.ManagerSingleConnexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant.forms
{
    public partial class frmLogin : Form
    {
        private ConnexionType connexionType;
        private frmprincipal _main_form;

        public frmprincipal Main_form
        {
            get
            {
                return _main_form;
            }

            set
            {
                _main_form = value;
            }
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Affectation des valeurs dans l'objet de la classe
                Connexion connexion = new Connexion();

                connexion.Serveur = txtServer.Text;
                connexion.Database = txtDB.Text;
                connexion.User = txtUser.Text;
                connexion.Password = txtPassword.Text;
                //connexion.Port = Convert.ToInt32(txtport.Text);

                // Initialisation de la connexion a la BD
                ImplementeConnexion.Instance.Initialise(connexion, connexionType);

                //Ouverture de la connexion a la BD

                ImplementeConnexion.Instance.Conn.Open();
                MessageBox.Show("Connection Successfuly !!!", "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Main_form.Show();
                //Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase mysql", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //catch (Npgsql.NpgsqlException ex)
            //{
            //    MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (Exception ex)
            {
                MessageBox.Show("Connection error, " + ex.Message, "Connection to DataBase ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn != null)
                {
                    if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementeConnexion.Instance.Conn.Close();
                }
            }
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboDBType.DataSource = Enum.GetNames(typeof(ConnexionType));
            cboDBType.SelectedIndex = 0;
        }

        private void cboDBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDBType.SelectedIndex)
            {
                case 0:
                    connexionType = ConnexionType.SQLServer;
                    break;
                    //case 1:
                    //    connexionType = ConnexionType.MySQL;
                    //    break;
                    //case 2:
                    //    connexionType = ConnexionType.PostGrsSQL;
                    //    break;
                    //case 3:
                    //    connexionType = ConnexionType.Oracle;
                    //    break;
                    //case 4:
                    //    connexionType = ConnexionType.Access;
                    //    break;
            }
        }
    }
}
