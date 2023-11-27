﻿using System;
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
    }
}
