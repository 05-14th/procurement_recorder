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

namespace Procurement_Recorder
{
    public partial class Form6 : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=procurementdb;Uid=root;Pwd=;";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClosePopup();
        }

        private void ClosePopup()
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO purchase_request (pr_number, date, item_no, client_id) VALUES (@Value1 ,@Value2, @Value3, @Value4)";
            string pr_num = textBox1.Text;
            string date = textBox2.Text;
            string item_num = textBox3.Text;
            string client_id = textBox4.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    // Add parameters to the query to avoid SQL Injection
                    command.Parameters.AddWithValue("@Value1", pr_num);
                    command.Parameters.AddWithValue("@Value2", date);
                    command.Parameters.AddWithValue("@Value3", item_num);
                    command.Parameters.AddWithValue("@Value4", client_id);

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
