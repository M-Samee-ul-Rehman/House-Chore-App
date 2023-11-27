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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void headerlbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.ShowDialog();
        }

        private void resgisterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
                {
                    connection.Open();

                    // Insert data into Registration table
                    string registrationInsertQuery = "INSERT INTO Registration (FirstName, LastName, Email, PhoneNumber, HomeAddress, CNIC) " +
                                                    "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @HomeAddress, @CNIC); " +
                                                    "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand registrationCommand = new SqlCommand(registrationInsertQuery, connection))
                    {
                        registrationCommand.Parameters.AddWithValue("@FirstName", firstNametxt.Text);
                        registrationCommand.Parameters.AddWithValue("@LastName", lastNametxt.Text);
                        registrationCommand.Parameters.AddWithValue("@Email", emailtxt.Text);
                        registrationCommand.Parameters.AddWithValue("@PhoneNumber", contacttxt.Text);
                        registrationCommand.Parameters.AddWithValue("@HomeAddress", addresstxt.Text);
                        registrationCommand.Parameters.AddWithValue("@CNIC", cnictxt.Text);

                        // Retrieve the UserID for the newly inserted user in Registration table
                        int userID = Convert.ToInt32(registrationCommand.ExecuteScalar());

                        // Insert data into Login table
                        string loginInsertQuery = "INSERT INTO Login (UserID, Email, CNIC) VALUES (@UserID, @Email, @CNIC);";

                        using (SqlCommand loginCommand = new SqlCommand(loginInsertQuery, connection))
                        {
                            loginCommand.Parameters.AddWithValue("@UserID", userID);
                            loginCommand.Parameters.AddWithValue("@Email", emailtxt.Text);
                            loginCommand.Parameters.AddWithValue("@CNIC", cnictxt.Text);

                            loginCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Data inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
