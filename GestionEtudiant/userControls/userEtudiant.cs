using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEtudiant.ManagerSingleConnexion;
using GestionEtudiant.classes;
using GestionEtudiant.clsGestionEtudiant_variables;

namespace GestionEtudiant.userControls
{
    public partial class userEtudiant : UserControl
    {
        classes.clsetudiant clsetu = new classes.clsetudiant();
        clsvariable_etudiants personne;
        public userEtudiant()
        {
            InitializeComponent();
            loadlistSql();
        }

        private void loadlistSql()
        {
            try
            {
                 dgetudiant.DataSource = clsetu.Etudiant();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void bindingclass()
        {
            clsetu.id = txtcode.Text;
            clsetu.nom = txtnom.Text;
            clsetu.postnom = txtpostnom.Text;
            clsetu.prenom = txtprenom.Text;
            clsetu.etat_civil = Convert.ToString(cmbetat_civil.SelectedItem);
            clsetu.sexe = Convert.ToString(cmbsexe.SelectedItem);
        }
        private void refresh()
        {
            txtcode.Text = "";
            txtmatricule.Text = "";
            txtnom.Text = "";
            txtpostnom.Text = "";
            txtprenom.Text = "";
            cmbsexe.Text = "";
            cmbetat_civil.Text = "";

        }
      private void userEtudiant_Load(object sender, EventArgs e)
        {
            loadlistSql();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                bindingclass();

                clsetu.Enregistrer(clsetu);

                MessageBox.Show("Record has been saved Successfuly !!!", "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadlistSql();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error when saving datas, " + ex.Message, "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Error when saving datas sql, " + ex.Message, "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error when saving datas Mysql, " + ex.Message, "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //catch (Npgsql.NpgsqlException ex)
            //{
            //    MessageBox.Show("Error when saving datas, " + ex.Message, "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            catch (Exception ex)
            {
                MessageBox.Show("Error when saving datas, " + ex.Message, "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void dgetudiant_DoubleClick(object sender, EventArgs e)
        {
            if (dgetudiant.RowCount > 0)
            {
                txtcode.Text = dgetudiant["dgid", dgetudiant.CurrentRow.Index].Value.ToString();
                txtmatricule.Text = dgetudiant["dgmatricule", dgetudiant.CurrentRow.Index].Value.ToString();
                txtnom.Text = dgetudiant["dgnom", dgetudiant.CurrentRow.Index].Value.ToString();
                txtpostnom.Text = dgetudiant["dgpostnom", dgetudiant.CurrentRow.Index].Value.ToString();
                txtprenom.Text = dgetudiant["dgprenom", dgetudiant.CurrentRow.Index].Value.ToString();
                cmbsexe.Text = dgetudiant["dgsexe", dgetudiant.CurrentRow.Index].Value.ToString();
                cmbetat_civil.Text = dgetudiant["dgetatcivil", dgetudiant.CurrentRow.Index].Value.ToString();
                btnsave.Enabled = false;
                btnedit.Enabled = true;
                btndelete.Enabled = true;
            }
        }

        private void cmbsgbd_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadlistSql();
        }
    }
}
