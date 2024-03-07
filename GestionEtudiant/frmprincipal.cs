using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEtudiant
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
            slide.Height = btnetudiant.Height;
            slide.Top = btnetudiant.Top;
        }
        public void ActivateItems(bool status)
        {
            btnetudiant.Enabled = !status;
            btntelephone.Enabled = !status;
            btnadresse.Enabled = status;
            btndomicile.Enabled = status;
        }
        private void btnetudiant_Click(object sender, EventArgs e)
        {
            slide.Height = btnetudiant.Height;
            slide.Top = btnetudiant.Top;
            container.Controls.Clear();
            container.Controls.Add(new userControls.userEtudiant());
        }

        private void btnadresse_Click(object sender, EventArgs e)
        {
            slide.Height = btnadresse.Height;
            slide.Top = btnadresse.Top;
            container.Controls.Clear();
            container.Controls.Add(new userControls.userAdresse());
        }

        private void btntelephone_Click(object sender, EventArgs e)
        {
            slide.Height = btntelephone.Height;
            slide.Top = btntelephone.Top;
            container.Controls.Clear();
            container.Controls.Add(new userControls.userTelephone());
        }

        private void btndomicile_Click(object sender, EventArgs e)
        {
            slide.Height = btndomicile.Height;
            slide.Top = btndomicile.Top;
            container.Controls.Clear();
            container.Controls.Add(new userControls.userDomicile());
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            ActivateItems(true);
        }
    }
}
