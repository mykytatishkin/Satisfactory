using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Client_System;

namespace Project_Stock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                var responseMessage = await client.SendMessage("Button Add clicked");

                if (responseMessage == "server got add button")
                {
                    MessageBox.Show("Button Add clicked");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                var responseMessage = await client.SendMessage("Button Delete clicked");

                if (responseMessage == "server got delete button")
                {
                    MessageBox.Show("Button Delete clicked");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                var responseMessage = await client.SendMessage("Button Edit clicked");

                if (responseMessage == "server got edit button")
                {
                    MessageBox.Show("Button Edit clicked");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Close();
            Application.Exit();
        }


    }
}
