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
    public partial class userDomicile : UserControl
    {
        classes.clspersonneAdresse clsper = new classes.clspersonneAdresse();
        classes.clsetudiant clsetu = new classes.clsetudiant();
        classes.clsadresse clsadre = new classes.clsadresse();
        clsGestionEtudiant_variables.clsvariable_personneAdresse clasperV = new clsGestionEtudiant_variables.clsvariable_personneAdresse();
        public userDomicile()
        {
            InitializeComponent();
            loadlist();
        }
        private void refresh()
        {
            txtcode.Text = "";
            cmbetudiant.Text = "";
            cmbadresse.Text = "";
            txtavenue.Text = "";
            txtnumeroavenue.Text = "";
        }
        private void bindingclass()
        {
            clasperV.id = txtcode.Text;
            clasperV.id_etudiant = Convert.ToString(cmbetudiant.SelectedValue);
            clasperV.id_adresse = Convert.ToString(cmbadresse.SelectedValue);
            clasperV.avenue = txtavenue.Text;
            clasperV.numero_avenue = Convert.ToInt32(txtnumeroavenue.Text);
        }
        private void loadlist()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    dgdomicile.DataSource = clsper.getlistdomicile();
                    clsetu.chargercomboboxSQL(cmbetudiant);
                    clsadre.chargercomboboxSQL(cmbadresse);
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    dgdomicile.DataSource = clsper.getlistdomicileMYSQL();
                    cmbetudiant.DataSource = clsetu.getlistetudiantMYSQL();
                    cmbetudiant.ValueMember = "id";
                    cmbetudiant.DisplayMember = "nom";
                    cmbadresse.DataSource = clsadre.getlistadresseMYSQL();
                    cmbadresse.ValueMember = "id";
                    cmbadresse.DisplayMember = "quartier";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void save()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclass();
                    int value = clsper.insert_domicile(clasperV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclass();
                    int value = clsper.insert_domicileMSQL(clasperV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void edit()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclass();
                    int value = clsper.update_domicile(clasperV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void delete()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclass();
                    int value = clsper.delete_domicile(clasperV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclass();
                    int value = clsper.delete_domicileMYSQL(clasperV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void userDomicile_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void cmbsgbd_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadlist();
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

        private void dgdomicile_DoubleClick(object sender, EventArgs e)
        {
            if (dgdomicile.RowCount > 0)
            {
                txtcode.Text = dgdomicile["dgid", dgdomicile.CurrentRow.Index].Value.ToString();
                cmbetudiant.Text = dgdomicile["dgetudiant", dgdomicile.CurrentRow.Index].Value.ToString();
                cmbadresse.Text = dgdomicile["dgadresse", dgdomicile.CurrentRow.Index].Value.ToString();
                txtavenue.Text = dgdomicile["dgavenue", dgdomicile.CurrentRow.Index].Value.ToString();
                txtnumeroavenue.Text = dgdomicile["dgnumeroavenue", dgdomicile.CurrentRow.Index].Value.ToString();
                btnsave.Enabled = false;
                btnedit.Enabled = true;
                btndelete.Enabled = true;
            }
        }
    }
}
