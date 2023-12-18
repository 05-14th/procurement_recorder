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
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=procurementdb;Uid=root;Pwd=;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClosePopup();
        }

        // Inside the popup form code
        private void ClosePopup()
        {
            this.Close();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO clients (client_name, department) VALUES (@Value1, @Value2)";
            string client_name = textBox1.Text;
            string department = textBox2.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    // Add parameters to the query to avoid SQL Injection
                    command.Parameters.AddWithValue("@Value1", client_name);
                    command.Parameters.AddWithValue("@Value2", department);

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
    }
}
