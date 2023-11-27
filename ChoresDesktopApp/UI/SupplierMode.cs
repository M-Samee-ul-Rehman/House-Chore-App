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
    }
}
