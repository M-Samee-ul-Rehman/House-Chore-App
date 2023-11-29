namespace ChoresDesktopApp.UI
{
    partial class SupplierMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.supplierbtn = new Infragistics.Win.Misc.UltraButton();
            this.aboutbtn = new Infragistics.Win.Misc.UltraButton();
            this.welcomelbl = new Infragistics.Win.Misc.UltraLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.profilebtn = new Infragistics.Win.Misc.UltraButton();
            this.choresbtn = new Infragistics.Win.Misc.UltraButton();
            this.bookingbtn = new Infragistics.Win.Misc.UltraButton();
            this.communicatebtn = new Infragistics.Win.Misc.UltraButton();
            this.successbtn = new Infragistics.Win.Misc.UltraButton();
            this.logOutbtn = new Infragistics.Win.Misc.UltraButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.166023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.266409F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.72973F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.01158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.710464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.238395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Controls.Add(this.supplierbtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.aboutbtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.welcomelbl, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.96113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.50883F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26502F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26502F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1319, 143);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // supplierbtn
            // 
            this.supplierbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierbtn.Location = new System.Drawing.Point(42, 27);
            this.supplierbtn.Name = "supplierbtn";
            this.supplierbtn.Size = new System.Drawing.Size(109, 40);
            this.supplierbtn.TabIndex = 2;
            this.supplierbtn.Text = "Supplier Mode";
            this.supplierbtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutbtn.Location = new System.Drawing.Point(157, 27);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(114, 40);
            this.aboutbtn.TabIndex = 3;
            this.aboutbtn.Text = "Receiver Mode";
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // welcomelbl
            // 
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.welcomelbl.Appearance = appearance1;
            this.welcomelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomelbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.welcomelbl.Location = new System.Drawing.Point(277, 27);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(777, 40);
            this.welcomelbl.TabIndex = 4;
            this.welcomelbl.Text = "Welcome To Your Dream Chores";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.60843F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.94696F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.44462F));
            this.tableLayoutPanel2.Controls.Add(this.profilebtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.choresbtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bookingbtn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.communicatebtn, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.successbtn, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.logOutbtn, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 143);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.4164133F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22623F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22623F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22623F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22623F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22623F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22623F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22623F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(213, 563);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // profilebtn
            // 
            this.profilebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilebtn.Location = new System.Drawing.Point(25, 5);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(151, 74);
            this.profilebtn.TabIndex = 0;
            this.profilebtn.Text = "Profile Management";
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            this.profilebtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.profilebtn_MouseDown);
            // 
            // choresbtn
            // 
            this.choresbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choresbtn.Location = new System.Drawing.Point(25, 85);
            this.choresbtn.Name = "choresbtn";
            this.choresbtn.Size = new System.Drawing.Size(151, 74);
            this.choresbtn.TabIndex = 1;
            this.choresbtn.Text = "Chores Management";
            this.choresbtn.Click += new System.EventHandler(this.choresbtn_Click);
            // 
            // bookingbtn
            // 
            this.bookingbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingbtn.Location = new System.Drawing.Point(25, 165);
            this.bookingbtn.Name = "bookingbtn";
            this.bookingbtn.Size = new System.Drawing.Size(151, 74);
            this.bookingbtn.TabIndex = 2;
            this.bookingbtn.Text = "Booking";
            this.bookingbtn.Click += new System.EventHandler(this.bookingbtn_Click);
            // 
            // communicatebtn
            // 
            this.communicatebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.communicatebtn.Location = new System.Drawing.Point(25, 245);
            this.communicatebtn.Name = "communicatebtn";
            this.communicatebtn.Size = new System.Drawing.Size(151, 74);
            this.communicatebtn.TabIndex = 3;
            this.communicatebtn.Text = "Communication";
            this.communicatebtn.Click += new System.EventHandler(this.communicatebtn_Click);
            // 
            // successbtn
            // 
            this.successbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.successbtn.Location = new System.Drawing.Point(25, 325);
            this.successbtn.Name = "successbtn";
            this.successbtn.Size = new System.Drawing.Size(151, 74);
            this.successbtn.TabIndex = 4;
            this.successbtn.Text = "Chores Success";
            this.successbtn.Click += new System.EventHandler(this.successbtn_Click);
            // 
            // logOutbtn
            // 
            this.logOutbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logOutbtn.Location = new System.Drawing.Point(25, 405);
            this.logOutbtn.Name = "logOutbtn";
            this.logOutbtn.Size = new System.Drawing.Size(151, 74);
            this.logOutbtn.TabIndex = 5;
            this.logOutbtn.Text = "Log Out";
            this.logOutbtn.Click += new System.EventHandler(this.logOutbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(377, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 442);
            this.panel1.TabIndex = 3;
            // 
            // SupplierMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1319, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SupplierMode";
            this.Text = "SupplierMode";
            this.Load += new System.EventHandler(this.SupplierMode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Infragistics.Win.Misc.UltraButton supplierbtn;
        private Infragistics.Win.Misc.UltraButton aboutbtn;
        private Infragistics.Win.Misc.UltraLabel welcomelbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Infragistics.Win.Misc.UltraButton profilebtn;
        private Infragistics.Win.Misc.UltraButton choresbtn;
        private Infragistics.Win.Misc.UltraButton bookingbtn;
        private Infragistics.Win.Misc.UltraButton communicatebtn;
        private Infragistics.Win.Misc.UltraButton successbtn;
        private Infragistics.Win.Misc.UltraButton logOutbtn;
        private System.Windows.Forms.Panel panel1;
        //  private profileManagement profileManagement2;
    }
}