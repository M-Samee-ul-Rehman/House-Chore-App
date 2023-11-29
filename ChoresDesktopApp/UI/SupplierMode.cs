using ChoresDesktopApp.Controls;
using Infragistics.Win.UltraWinProgressBar;
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
    public partial class SupplierMode : Form
    {
        private Button lastPressedButton;
        public SupplierMode()
        {
            InitializeComponent();
           
        }

        private void SupplierMode_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            ReceiverMode form = new ReceiverMode();
            this.Hide();
            form.ShowDialog();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            supplierbtn.Enabled = false;
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
            BackColor = Color.Blue;
            
        }

        private void choresbtn_Click(object sender, EventArgs e)
        {
           services controls = new services();
            addUserControl(controls);
        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            Booking controls = new Booking();
            addUserControl(controls);
        }

        private void communicatebtn_Click(object sender, EventArgs e)
        {
            Communication controls = new Communication();
            addUserControl(controls);
        }

        private void successbtn_Click(object sender, EventArgs e)
        {
            Success controls = new Success();
            addUserControl(controls);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profile_cs1_Load(object sender, EventArgs e)
        {

        }

        

        private void profilebtn_MouseDown(object sender, MouseEventArgs e)
        {
          //  ChangeButtonColor((Button)sender);
        }
    }
}
