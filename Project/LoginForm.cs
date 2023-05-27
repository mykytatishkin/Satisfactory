using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Stock
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" && tbPass.Text == "")
                MessageBox.Show("Error. Enter login and password");
            else if (tbPass.Text == "")
                MessageBox.Show("Error. Enter password");
            else if (tbLogin.Text == "")
                MessageBox.Show("Error. Enter login");
            else
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }

        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
