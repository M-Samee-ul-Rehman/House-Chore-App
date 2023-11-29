using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoresDesktopApp.Controls
{
    public partial class services : UserControl
    {
        private const string ConnectionString = @"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True";
        public services()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data from the form
                string taskCategory = comboBox1.Text;
                string taskDescription = richTextBox1.Text;
                string rate = textBox1.Text;

                if(taskCategory == "" || taskDescription == "" || rate == "")
                {
                    throw new Exception("Please fill all the fields.");
                }

                string pattern = @"^\d+$";

                if (!string.IsNullOrEmpty(rate) && Regex.IsMatch(rate, pattern))
                {
                    // Check if the string can be converted to a number
                    if ((int.TryParse(rate, out _)))
                    {
                        float number = float.Parse(rate);
                        if(number <= 0)
                        {
                            throw new Exception("Rate is invalid");
                        }
                       
                    }
                }



                // Insert data into the Services table
                using (SqlConnection connection = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO dbo.Services (TaskCategory, TaskDescription, Rate, CreatedAT, UpdatedAT, Active) " +
                                         "VALUES (@TaskCategory, @TaskDescription, @Rate, GETDATE(), GETDATE(), 1)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@TaskCategory", taskCategory);
                        command.Parameters.AddWithValue("@TaskDescription", taskDescription);
                        command.Parameters.AddWithValue("@Rate", rate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            comboBox1.Text = "";
                            textBox1.Text = "";
                            richTextBox1.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to add service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            comboBox1.Text = "";
                            textBox1.Text = "";
                            richTextBox1.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (SqlConnection connection2 = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
            {
                try
                {
                    connection2.Open();

                    string selectQuery = "SELECT TaskCategory, TaskDescription, Rate FROM dbo.Services";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection2))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT TaskCategory, TaskDescription, Rate FROM dbo.Services";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;

                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                string category = dataGridView1.Rows[e.RowIndex].Cells["TaskCategory"].Value.ToString();
                string TaskDescription = dataGridView1.Rows[e.RowIndex].Cells["TaskDescription"].Value.ToString();
                string Rate = dataGridView1.Rows[e.RowIndex].Cells["Rate"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM dbo.Services " +
                                         "WHERE TaskCategory = @TaskCategory AND TaskDescription = @TaskDescription AND Rate = @Rate";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // command.Parameters.AddWithValue("@ServiceID", category);
                        command.Parameters.AddWithValue("@TaskCategory", category);
                        command.Parameters.AddWithValue("@TaskDescription", TaskDescription);
                        command.Parameters.AddWithValue("@Rate", Rate);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Deleted Successfully");

                    using (SqlConnection connection2 = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
                    {
                        try
                        {
                            connection2.Open();

                            string selectQuery = "SELECT TaskCategory, TaskDescription, Rate FROM dbo.Services";

                            using (SqlCommand command = new SqlCommand(selectQuery, connection2))
                            {
                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    DataTable dataTable = new DataTable();
                                    adapter.Fill(dataTable);

                                    // Bind the DataTable to the DataGridView
                                    dataGridView1.DataSource = dataTable;


                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }

            else if(dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {

            }
        }
    }
}
