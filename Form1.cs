using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Procurement_Recorder;
using System.IO;
using OfficeOpenXml;
using System.Web;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=procurementdb;Uid=root;Pwd=;";
        public int state = 1;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            LoadEmployeeData();
            LoadItemsData();
            LoadSupplierData();
            LoadPRData();
            LoadPOData();
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            panel3.Visible = false;
        }

        private void LoadData()
        {
            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // SQL query to fetch data from the database
            string query = "SELECT * FROM clients";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridView1.DataSource = dataTable;
        }

        private void LoadEmployeeData()
        {
            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // SQL query to fetch data from the database
            string query = "SELECT * FROM employee";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridView2.DataSource = dataTable;
        }

        private void LoadItemsData()
        {
            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // SQL query to fetch data from the database
            string query = "SELECT * FROM items";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridView3.DataSource = dataTable;
        }

        private void LoadSupplierData()
        {
            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // SQL query to fetch data from the database
            string query = "SELECT * FROM supplier";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridView4.DataSource = dataTable;
        }

        private void LoadPRData()
        {
            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // SQL query to fetch data from the database
            string query = "SELECT * FROM purchase_request";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridView5.DataSource = dataTable;
        }

        private void LoadPOData()
        {
            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // SQL query to fetch data from the database
            string query = "SELECT * FROM purchase_order";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridView6.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else if (state == 2)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else if (state == 3)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
            else if (state == 4)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
            else if (state == 5)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
            }
            else if (state == 6)
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            panel3.Visible = false;
            state = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            panel3.Visible = false;
            state = 2;
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            panel3.Visible = false;
            state = 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            panel3.Visible = false;
            state = 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;
            dataGridView6.Visible = false;
            panel3.Visible = false;
            state = 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
            dataGridView6.Visible = true;
            panel3.Visible = false;
            state = 6;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                Form8 form8 = new Form8();
                form8.StateFromForm1 = state;
                form8.changeLabel("Type the client_id number to delete: ");
                form8.ShowDialog();
            }
            else if (state == 2)
            {
                Form8 form8 = new Form8();
                form8.StateFromForm1 = state;
                form8.changeLabel("Type the employee_id number to delete: ");
                form8.ShowDialog();
            }
            else if (state == 3)
            {
                Form8 form8 = new Form8();
                form8.StateFromForm1 = state;
                form8.changeLabel("Type the item_no number to delete: ");
                form8.ShowDialog();
            }
            else if (state == 4)
            {
                Form8 form8 = new Form8();
                form8.StateFromForm1 = state;
                form8.changeLabel("Type the supplier_id number to delete: ");
                form8.ShowDialog();
            }
            else if (state == 5)
            {
                Form8 form8 = new Form8();
                form8.StateFromForm1 = state;
                form8.changeLabel("Type the pr_number number to delete: ");
                form8.ShowDialog();
            }
            else if (state == 6)
            {
                Form8 form8 = new Form8();
                form8.StateFromForm1 = state;
                form8.changeLabel("Type the po_number number to delete: ");
                form8.ShowDialog();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            UpdateChangesToDatabase();
        }

        private async Task UpdateChangesToDatabase()
        {
            DataTable dataTableToUpdate = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
                {
                    MySqlCommandBuilder commandBuilder;

                    switch (state)
                    {
                        // Case statements for different tables, modify as needed
                        case 1:
                            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM clients", connection);
                            dataTableToUpdate = ((DataTable)dataGridView1.DataSource).GetChanges();
                            break;

                        case 2:
                            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM employee", connection);
                            dataTableToUpdate = ((DataTable)dataGridView2.DataSource).GetChanges();
                            break;
                        case 3:
                            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM items", connection);
                            dataTableToUpdate = ((DataTable)dataGridView3.DataSource).GetChanges();
                            break;
                        case 4:
                            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM supplier", connection);
                            dataTableToUpdate = ((DataTable)dataGridView4.DataSource).GetChanges();
                            break;
                        case 5:
                            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM purchase_request", connection);
                            dataTableToUpdate = ((DataTable)dataGridView5.DataSource).GetChanges();
                            break;
                        case 6:
                            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM purchase_order", connection);
                            dataTableToUpdate = ((DataTable)dataGridView6.DataSource).GetChanges();
                            break;

                        default:
                            break;
                    }

                    if (dataTableToUpdate != null)
                    {
                        commandBuilder = new MySqlCommandBuilder(dataAdapter);
                        dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
                        dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                        dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                        try
                        {
                            await connection.OpenAsync();

                            // Start a transaction
                            using (MySqlTransaction transaction = connection.BeginTransaction())
                            {
                                dataAdapter.SelectCommand.Transaction = transaction;
                                dataAdapter.InsertCommand.Transaction = transaction;
                                dataAdapter.UpdateCommand.Transaction = transaction;
                                dataAdapter.DeleteCommand.Transaction = transaction;

                                // Update the database with the changes
                                dataAdapter.Update(dataTableToUpdate);

                                // Commit the transaction if successful
                                transaction.Commit();

                                RestartApplication();
                            }
                        }
                        catch (DBConcurrencyException ex)
                        {
                            // Handle concurrency conflict
                            MessageBox.Show("Concurrency conflict occurred. Please avoid simultaneous update and try again.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            dataTableToUpdate.RejectChanges();
                            // Reload the data from the database
                            LoadData(); // Example: Change this method call to match the specific table being updated
                        }
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

        private void button5_Click(object sender, EventArgs e)
        {
            string query = null;

            if (state == 1)
            {
                query = "SELECT * FROM clients";
            }
            else if (state == 2)
            {
                query = "SELECT * FROM employee";
            }
            else if (state == 3)
            {
                query = "SELECT * FROM items";
            }
            else if (state == 4)
            {
                query = "SELECT * FROM supplier";
            }
            else if (state == 5)
            {
                query = "SELECT * FROM purchase_request";
            }
            else if (state == 6)
            {
                query = "SELECT * FROM purchase_order";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    using (MySqlDataReader dataReader = command.ExecuteReader())
                    {
                        dataTable.Load(dataReader);
                    }

                    // Prompt user to choose a folder to save the CSV file
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                        saveFileDialog.FilterIndex = 1;
                        saveFileDialog.RestoreDirectory = true;
                        DialogResult result = saveFileDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            // Save DataTable content to a CSV file in the chosen folder
                            string csvFilePath = saveFileDialog.FileName;
                            WriteDataTableToCSV(dataTable, csvFilePath);

                            MessageBox.Show("CSV file created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No folder selected. CSV file not saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

        }

        static void WriteDataTableToCSV(DataTable dataTable, string csvFilePath)
        {
            using (StreamWriter streamWriter = new StreamWriter(csvFilePath))
            {
                // Write headers (column names)
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    streamWriter.Write(dataTable.Columns[i]);
                    if (i < dataTable.Columns.Count - 1)
                    {
                        streamWriter.Write(",");
                    }
                }
                streamWriter.WriteLine();

                // Write rows of data
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        streamWriter.Write(row[i].ToString());
                        if (i < dataTable.Columns.Count - 1)
                        {
                            streamWriter.Write(",");
                        }
                    }
                    streamWriter.WriteLine();
                }
            }
        }
    }

}
