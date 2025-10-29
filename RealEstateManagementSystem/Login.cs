using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
//commend 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtUsername.Text.Equals("admin") || txtPassword.Equals("admin123"))
            {
                frmAdmin adminForm = new frmAdmin();
                this.Hide();
                adminForm.Show();
                Show();
                //blockkkkki
            }
            else if (txtUsername.Text.Equals("seller") || txtPassword.Equals("seller123"))
            {
                frmSeller sellerForm = new frmSeller();
                sellerForm.Show();
            }
            else if (txtUsername.Text.Equals("buyer") || txtPassword.Equals("buyer123"))
            {
                frmBuyer buyerForm = new frmBuyer();
                buyerForm.Show();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount createAccountForm = new frmCreateAccount();
            this.Hide();
            createAccountForm.Show();
        }
    }
}


