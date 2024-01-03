using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_SYSTEM.Class.DataMethod;
using static POS_SYSTEM.Class.CommonMethod;

namespace POS_SYSTEM
{
    public partial class frmLogin : Sample
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void pictShow_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtPassword.Focus();
            pictHide.Visible = true;
            pictShow.Visible = false;
            

        }

        private void pictHide_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '●';
            txtPassword.Focus();
            pictHide.Visible = false;
            pictShow.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string hashedPassword = ComputeSHA384Hash(txtPassword.Text);

            if (ValidateUser(txtUsername.Text, hashedPassword))
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username/Password", "POS System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void controlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
