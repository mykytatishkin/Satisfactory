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
using Server_System;
using System.IO;
using Microsoft.Extensions.Configuration;
using ConfigurationBuilder = Microsoft.Extensions.Configuration.ConfigurationBuilder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Collections;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project_Stock
{
    public partial class MainForm : Form
    {
        public string connectionString;
        public MainForm()
        {
            InitializeComponent();
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                   .AddJsonFile("appsettings.json")
                                                   .Build();

            DbContextOptionsBuilder<SatisfactoryDbContext> dbContextOptionsBuilder =
                new DbContextOptionsBuilder<SatisfactoryDbContext>();
            var options = dbContextOptionsBuilder;

            connectionString = config.GetConnectionString("MainConnectionString");
            
            //dgv.DataSource = await config?.sp_view_item_in_storage();
            sp_view_item_in_storage();
        }

        /*private void btnAdd_Click(object sender, EventArgs e)
        {
 

        }*/

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                var responseMessage = await client.SendMessage($"Button Delete clicked");
                //var responseName = await client.SendMessage(textBox1.Text);
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string itemName = textBox1.Text; // Новый предмет для добавления в таблицу
            string itemDesc = rtbDescription.Text;
            int itemQuantity = Convert.ToInt32(dNumeric.Value);
            double itemPrice = Convert.ToDouble(tbPrice.Text);

            string query = @$"INSERT INTO Item (Name, Description, QuantityOfGoods, Price) VALUES (@Name, @Description, @QuantityOfGoods, @Price)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", itemName);
                    command.Parameters.AddWithValue("@Description", itemDesc);
                    command.Parameters.AddWithValue("@QuantityOfGoods", itemQuantity);
                    command.Parameters.AddWithValue("@Price", itemPrice);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Insert successful");
                    }
                    else
                    {
                        Console.WriteLine("Insert failed");
                    }
                }

                connection.Close();
            }


     
            sp_view_item_in_storage();
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void sp_view_item_in_storage()
        {
            var query = @"sp_view_item_in_storage";

            string _connectionString = connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();


            // Создание DataTable и заполнение данными
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            // Установка источника данных для DataGridView
            dgv.DataSource = dataTable;


            reader.Close();
            connection.Close();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            string itemName = textBox1.Text; // Новый предмет для добавления в таблицу

            string query = "DELETE FROM Item WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", itemName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Delete successful");
                    }
                    else
                    {
                        Console.WriteLine("No rows deleted");
                    }
                }

                connection.Close();
            }


            
            sp_view_item_in_storage();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string itemName = textBox1.Text; // Новый предмет для добавления в таблицу
            string itemDesc = rtbDescription.Text;
            int itemQuantity = Convert.ToInt32(dNumeric.Value);
            double itemPrice = Convert.ToDouble(tbPrice.Text);

            string query = "UPDATE Item SET Description = @NewDescription, QuantityOfGoods = @NewQuantity, Price = @NewPrice WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewDescription", itemDesc);
                    command.Parameters.AddWithValue("@NewQuantity", itemQuantity);
                    command.Parameters.AddWithValue("@NewPrice", itemPrice);
                    command.Parameters.AddWithValue("@Name", itemName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Update successful");
                    }
                    else
                    {
                        Console.WriteLine("No rows updated");
                    }
                }

                connection.Close();
                
                sp_view_item_in_storage();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text;
            string query = "SELECT * FROM Item WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0];

                            // Retrieve column values from the row
                            string itemName = row["Name"].ToString();
                            string itemDescription = row["Description"].ToString();
                            int itemQuantity = Convert.ToInt32(row["QuantityOfGoods"]);
                            decimal itemPrice = Convert.ToDecimal(row["Price"]);

                            listBox1.Items.Clear();
                            // Update the display or perform any desired operations with the retrieved values
                            listBox1.Items.Add($"Name: {itemName}");
                            listBox1.Items.Add($"Description: {itemDescription}");
                            listBox1.Items.Add($"Quantity: {itemQuantity}");
                            listBox1.Items.Add($"Price: {itemPrice}");
                        }
                        else
                        {
                            listBox1.Items.Clear();
                            listBox1.Items.Add("No rows found");
                        }
                    }
                }
                
                connection.Close();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
