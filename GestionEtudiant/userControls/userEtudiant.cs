using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant.userControls
{
    public partial class userEtudiant : UserControl
    {
        classes.clsetudiant clsetu = new classes.clsetudiant();
        clsGestionEtudiant_variables.clsvariable_etudiants clsetuV = new clsGestionEtudiant_variables.clsvariable_etudiants();
        public userEtudiant()
        {
            InitializeComponent();
            loadlistSql();
        }

        private void loadlistSql()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    dgetudiant.DataSource = clsetu.getlistetudiant();
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    dgetudiant.DataSource = clsetu.getlistetudiantMYSQL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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
        private void bindingclassSql()
        {
            clsetuV.id = txtcode.Text;
            clsetuV.matricule = txtmatricule.Text;
            clsetuV.nom = txtnom.Text;
            clsetuV.postnom = txtpostnom.Text;
            clsetuV.prenom = txtprenom.Text;
            clsetuV.sexe = Convert.ToString(cmbsexe.SelectedItem);
            clsetuV.etat_civil = Convert.ToString(cmbetat_civil.SelectedItem);
        }
        //===========================methode d'insertion==============================//
        private void save()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclassSql();
                    int value = clsetu.insert_etudiant(clsetuV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclassSql();
                    int value = clsetu.insert_etudiantMYSQL(clsetuV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        //=============================methode de modification===========================//
        private void edit()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclassSql();
                    int value = clsetu.update_etudiant(clsetuV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclassSql();
                    int value = clsetu.update_etudiantMYSQL(clsetuV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        //=====================================methode de suppression=============================//
        private void delete()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclassSql();
                    int value = clsetu.delete_etudiant(clsetuV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclassSql();
                    int value = clsetu.delete_etudiantMYSQL(clsetuV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSql();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void userEtudiant_Load(object sender, EventArgs e)
        {
            loadlistSql();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete();
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
