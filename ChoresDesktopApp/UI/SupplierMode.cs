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

        private void profilebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void choresbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void communicatebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void successbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
