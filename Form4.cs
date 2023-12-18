using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=procurementdb;Uid=root;Pwd=;";
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO items (Item, quantity, unit, price) VALUES (@Value1 ,@Value2, @Value3, @Value4)";
            string item_name = textBox1.Text;
            string quantity = textBox2.Text;
            string unit = textBox3.Text;
            string price = textBox4.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    // Add parameters to the query to avoid SQL Injection
                    command.Parameters.AddWithValue("@Value1", item_name);
                    command.Parameters.AddWithValue("@Value2", quantity);
                    command.Parameters.AddWithValue("@Value3", unit);
                    command.Parameters.AddWithValue("@Value4", price);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Data successfully added to the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestartApplication();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        static void RestartApplication()
        {
            string applicationPath = Application.ExecutablePath;
            Process.Start(applicationPath);
            Environment.Exit(0); // Exit the current instance of the application
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ClosePopup();
        }

        private void ClosePopup()
        {
            this.Close();
        }
    }
}
