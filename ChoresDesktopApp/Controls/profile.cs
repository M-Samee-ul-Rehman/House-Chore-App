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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ChoresDesktopApp.Backend;

namespace ChoresDesktopApp.Controls
{
    public partial class profile_cs : UserControl
    {
        public profile_cs(string email)
        {
            InitializeComponent();
            
        }

        private void profile_cs_Load(object sender, EventArgs e)
        {
            
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            UserLogin user = UserLogin.GetLatestUserLogin();
            string email = user.email;

            using (SqlConnection connection = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT * FROM Registration WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve all columns from the database
                            int userID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                            string lastName = reader.GetString(reader.GetOrdinal("LastName"));
                            string phoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                            string homeAddress = reader.GetString(reader.GetOrdinal("HomeAddress"));
                            string cnic = reader.GetString(reader.GetOrdinal("CNIC"));
                            DateTime createdAt = reader.GetDateTime(reader.GetOrdinal("CreatedAT"));
                            DateTime updatedAt = reader.GetDateTime(reader.GetOrdinal("UpdatedAT"));
                            bool active = reader.GetBoolean(reader.GetOrdinal("Active"));

                            firstNametxt.Text = firstName;
                            lastNametxt.Text = lastName;
                            contacttxt.Text = phoneNumber;
                            addresstxt.Text = homeAddress;
                            cnictxt.Text = cnic;
                            emailtxt.Text = email;

                            // Display or use the retrieved information as needed
                           // MessageBox.Show($"User Information:\n\nUserID: {userID}\nFirst Name: {firstName}\nLast Name: {lastName}\nPhone Number: {phoneNumber}\nHome Address: {homeAddress}\nCNIC: {cnic}\nCreated At: {createdAt}\nUpdated At: {updatedAt}\nActive: {active}", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void firstNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=YASIRSELITEBOOK;Initial Catalog=ChoresDesktop;Integrated Security=True"))
                {
                    connection.Open();

                    string query = "UPDATE Registration SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, HomeAddress = @HomeAddress, UpdatedAT = GETDATE() WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstNametxt.Text);
                        command.Parameters.AddWithValue("@LastName", lastNametxt.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", contacttxt.Text);
                        command.Parameters.AddWithValue("@HomeAddress", addresstxt.Text);
                        command.Parameters.AddWithValue("@Email", emailtxt.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally, you can update the displayed information on the form or take other actions
                        }
                        else
                        {
                            MessageBox.Show("User not found or no changes were made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally, log the exception or take other actions as needed
            }

        }
    }
}
