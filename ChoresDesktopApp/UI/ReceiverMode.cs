using ChoresDesktopApp.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoresDesktopApp.UI
{
    public partial class ReceiverMode : Form
    {
        public ReceiverMode()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            SupplierMode form = new SupplierMode();
            this.Hide();
            form.ShowDialog();
        }

        private void ReceiverMode_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void receiverbtn_Click(object sender, EventArgs e)
        {
            receiverbtn.Enabled = false;
        }

        private void logOutbtn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.ShowDialog();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            profile_cs controls = new profile_cs();
            addUserControl(controls);
        }

        private void viewChoresbtn_Click(object sender, EventArgs e)
        {
           // profile_cs1.Visible = false;
        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
           // profile_cs1.Visible = false;
        }

        private void communicatebtn_Click(object sender, EventArgs e)
        {
          //  profile_cs1.Visible = false;
        }

        private void reviewbtn_Click(object sender, EventArgs e)
        {
          //  profile_cs1.Visible = false;
        }
    }
}
