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
    public partial class userAdresse : UserControl
    {
        classes.clsadresse clsdre = new classes.clsadresse();
        clsGestionEtudiant_variables.clsvariable_adresse clsadreV = new clsGestionEtudiant_variables.clsvariable_adresse();
        public userAdresse()
        {
            InitializeComponent();
            loadlistSQL();
        }
        //============================methode d'affichage=========================//
        private void loadlistSQL()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    dgadresse.DataSource = clsdre.getlistadresse();
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    dgadresse.DataSource = clsdre.getlistadresseMYSQL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void refresh()
        {
            txtcode.Text = "";
            txtquartier.Text = "";
            txtcommune.Text = "";
            txtville.Text = "";
            txtpays.Text = "";
        }
        private void bindingclassSql()
        {
            clsadreV.id = txtcode.Text;
            clsadreV.quartier = txtquartier.Text;
            clsadreV.commune = txtcommune.Text;
            clsadreV.ville = txtville.Text;
            clsadreV.pays = txtpays.Text;
        }
        //======================methode d'insertion===============================//
        private void save()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclassSql();
                    int value = clsdre.insert_adresse(clsadreV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclassSql();
                    int value = clsdre.insert_adresseMYSQL(clsadreV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                }

            }
            catch ( Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee"+ex, "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //======================methode pour les modification===========================//
        private void edit()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclassSql();
                    int value = clsdre.update_adresse(clsadreV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclassSql();
                    int value = clsdre.update_adresseMYSQL(clsadreV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //=======================methode de suppression=================================
        private void delete()
        {
            try
            {
                if (cmbsgbd.Text== "Sql_server")
                {
                    bindingclassSql();
                    int value = clsdre.delete_adresse(clsadreV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclassSql();
                    int value = clsdre.delete_adresseMYSQL(clsadreV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlistSQL();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void userAdresse_Load(object sender, EventArgs e)
        {
            loadlistSQL();
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

        private void dgadresse_DoubleClick(object sender, EventArgs e)
        {
            if (dgadresse.RowCount > 0)
            {
                txtcode.Text = dgadresse["dgid", dgadresse.CurrentRow.Index].Value.ToString();
                txtquartier.Text = dgadresse["dgquartier", dgadresse.CurrentRow.Index].Value.ToString();
                txtcommune.Text = dgadresse["dgcommune", dgadresse.CurrentRow.Index].Value.ToString();
                txtville.Text = dgadresse["dgville", dgadresse.CurrentRow.Index].Value.ToString();
                txtpays.Text = dgadresse["dgpays", dgadresse.CurrentRow.Index].Value.ToString();
                btnsave.Enabled = false;
                btnedit.Enabled = true;
                btndelete.Enabled = true;
            }
        }

        private void cmbsgbd_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadlistSQL();
        }
    }
}
