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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {

            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "admin" && password == "1234")
            {
                frmprincipal home1 = new frmprincipal();
                frmLogin lg = new frmLogin();
                this.Hide();
                home1.Show();
            }
            else if (username == "" && password == "")
            {
                MessageBox.Show("veillez remplir les champs", "user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("mot de pass incorect", "user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
