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
    public partial class userTelephone : UserControl
    {
        classes.clstelephone clstel = new classes.clstelephone();
        clsGestionEtudiant_variables.clsvariable_telephone clstelV = new clsGestionEtudiant_variables.clsvariable_telephone();
        classes.clsetudiant clsetu = new classes.clsetudiant();
        public userTelephone()
        {
            InitializeComponent();
            loadlist();
        }
        private void refresh()
        {
            txtcode.Text = "";
            cmbproprietaire.Text = "";
            txtinitial.Text = "";
            txtnumero.Text = "";
        }
        private void bindingclass()
        {
            clstelV.id = txtcode.Text;
            clstelV.id_proprietaire = Convert.ToString(cmbproprietaire.SelectedValue);
            clstelV.initial = txtinitial.Text;
            clstelV.numero = txtnumero.Text;
        }
        private void loadlist()
        {
            try {
                if (cmbsgbd.Text=="Sql_server")
                {
                    dgtelephone.DataSource = clstel.getlisttelephone();
                    clsetu.chargercomboboxSQL(cmbproprietaire);
                }
                else if (cmbsgbd.Text =="Mysql")
                {
                    dgtelephone.DataSource = clstel.getlisttelephoneMYSQL();
                    cmbproprietaire.DataSource = clsetu.getlistetudiantMYSQL();
                    cmbproprietaire.ValueMember = "id";
                    cmbproprietaire.DisplayMember = "nom";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //===================METHODE D'INSERTION======================//
        private void save()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclass();
                    int value = clstel.insert_telephone(clstelV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclass();
                    int value = clstel.insert_telephoneMSQL(clstelV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //==================METHODE DE MODIFICATION===================//
        private void edit()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclass();
                    int value = clstel.update_telephone(clstelV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclass();
                    int value = clstel.update_telephoneMSQL(clstelV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //==================METHODE DE SUPPRESSION====================//
        private void delete()
        {
            try
            {
                if (cmbsgbd.Text == "Sql_server")
                {
                    bindingclass();
                    int value = clstel.delete_telephone(clstelV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
                else if (cmbsgbd.Text == "Mysql")
                {
                    bindingclass();
                    int value = clstel.delete_telephoneMYSQL(clstelV);
                    if (value >= 1)
                    {
                        MessageBox.Show("Operation effectuée avec succès", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'operation", "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadlist();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de connection a la base de donnee" + ex, "telephone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userTelephone_Load(object sender, EventArgs e)
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

        private void dgtelephone_DoubleClick(object sender, EventArgs e)
        {
            if (dgtelephone.RowCount > 0)
            {
                txtcode.Text = dgtelephone["dgid", dgtelephone.CurrentRow.Index].Value.ToString();
                cmbproprietaire.Text = dgtelephone["dgproprietaire", dgtelephone.CurrentRow.Index].Value.ToString();
                txtinitial.Text = dgtelephone["dginitial", dgtelephone.CurrentRow.Index].Value.ToString();
                txtnumero.Text = dgtelephone["dgnumero", dgtelephone.CurrentRow.Index].Value.ToString();
                btnsave.Enabled = false;
                btnedit.Enabled = true;
                btndelete.Enabled = true;
            }
        }
    }
}
