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

namespace ChoresDesktopApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration();
            this.Hide();
            form.ShowDialog();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.ShowDialog();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
                {
                    connection.Open();

                    // Check if the provided email and CNIC exist in the Login table
                    string loginCheckQuery = "SELECT COUNT(*) FROM Login WHERE Email = @Email AND CNIC = @CNIC;";

                    using (SqlCommand loginCheckCommand = new SqlCommand(loginCheckQuery, connection))
                    {
                        loginCheckCommand.Parameters.AddWithValue("@Email", emailtxt.Text);
                        loginCheckCommand.Parameters.AddWithValue("@CNIC", cnictxt.Text);

                        int count = Convert.ToInt32(loginCheckCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            // Additional logic for successful login
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or CNIC. Please try again.");
                            // Additional logic for failed login
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
