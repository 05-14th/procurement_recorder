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
    public partial class Form7 : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=procurementdb;Uid=root;Pwd=;";
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            string insertQuery = "INSERT INTO purchase_order (po_number, date_of_delivery, pr_number, supplier_id) VALUES (@Value1 ,@Value2, @Value3, @Value4)";
            string po_num = textBox1.Text;
            string dod = textBox2.Text;
            string pr_num = textBox3.Text;
            string supplier_id = textBox4.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    // Add parameters to the query to avoid SQL Injection
                    command.Parameters.AddWithValue("@Value1", po_num);
                    command.Parameters.AddWithValue("@Value2", dod);
                    command.Parameters.AddWithValue("@Value3", pr_num);
                    command.Parameters.AddWithValue("@Value4", supplier_id);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Data successfully added to the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
