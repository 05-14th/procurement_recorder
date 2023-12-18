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
using MySql.Data.MySqlClient;

namespace Procurement_Recorder
{
    public partial class Form8 : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Port=3306;Database=procurementdb;Uid=root;Pwd=;";
        public int StateFromForm1 { get; set; }
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void changeLabel(string newText)
        {
            label1.Text = newText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = null;

                    // Specify your DELETE SQL command
                    if (StateFromForm1 == 1)
                    {
                        deleteQuery = $"DELETE FROM clients WHERE client_id = {textBox1.Text}";
                    }else if (StateFromForm1 == 2)
                    {
                        deleteQuery = $"DELETE FROM employee WHERE employee_id = '{textBox1.Text}'";
                    }
                    else if (StateFromForm1 == 3)
                    {
                        deleteQuery = $"DELETE FROM items WHERE item_no = {textBox1.Text}";
                    }
                    else if (StateFromForm1 == 4)
                    {
                        deleteQuery = $"DELETE FROM supplier WHERE supplier_id = {textBox1.Text}";
                    }
                    else if (StateFromForm1 == 5)
                    {
                        deleteQuery = $"DELETE FROM purchase_request WHERE pr_number = '{textBox1.Text}'";
                    }
                    else if (StateFromForm1 == 6)
                    {
                        deleteQuery = $"DELETE FROM purchase_order WHERE po_number = '{textBox1.Text}'";
                    }

                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                    // Execute the DELETE command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No data deleted.");
                    }

                    RestartApplication();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static void RestartApplication()
        {
            string applicationPath = Application.ExecutablePath;
            Process.Start(applicationPath);
            Environment.Exit(0); // Exit the current instance of the application
        }
    }
}
