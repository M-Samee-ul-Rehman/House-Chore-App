using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoresDesktopApp.Controls
{
    public partial class ViewChores : UserControl
    {
        public ViewChores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            using (SqlConnection connection = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
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
    }
}
