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
        clsGestionEtudiant_variables.clsvariable_telephone clstelV;
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
                 //dgtelephone.DataSource = clstel.getlisttelephone();
                 //clsetu.Etudiant(cmbproprietaire);

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
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
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
