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
        clsGestionEtudiant_variables.clsvariable_adresse clsadreV;
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
              dgadresse.DataSource = clsdre.Adresse();

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
        private void userAdresse_Load(object sender, EventArgs e)
        {
            loadlistSQL();
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
