namespace ChoresDesktopApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.registerbtn = new Infragistics.Win.Misc.UltraButton();
            this.LogInbtn = new Infragistics.Win.Misc.UltraButton();
            this.homebtn = new Infragistics.Win.Misc.UltraButton();
            this.aboutbtn = new Infragistics.Win.Misc.UltraButton();
            this.welcomelbl = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraPictureBox1 = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.147128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.362706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.20535F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.33596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.710464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.238395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.registerbtn, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.LogInbtn, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.homebtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.aboutbtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.welcomelbl, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.96113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.50883F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26502F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26502F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1292, 143);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // registerbtn
            // 
            this.registerbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerbtn.Location = new System.Drawing.Point(1178, 27);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(85, 40);
            this.registerbtn.TabIndex = 1;
            this.registerbtn.Text = "Register";
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // LogInbtn
            // 
            this.LogInbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogInbtn.Location = new System.Drawing.Point(1081, 27);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(91, 40);
            this.LogInbtn.TabIndex = 0;
            this.LogInbtn.Text = "LogIn";
            this.LogInbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homebtn.Location = new System.Drawing.Point(42, 27);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(112, 40);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "Home";
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutbtn.Location = new System.Drawing.Point(160, 27);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(110, 40);
            this.aboutbtn.TabIndex = 3;
            this.aboutbtn.Text = "About";
            // 
            // welcomelbl
            // 
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.welcomelbl.Appearance = appearance1;
            this.welcomelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomelbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.welcomelbl.Location = new System.Drawing.Point(276, 27);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(799, 40);
            this.welcomelbl.TabIndex = 4;
            this.welcomelbl.Text = "Welcome To Your Dream Chores";
            // 
            // ultraPanel1
            // 
            this.ultraPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraPictureBox1);
            this.ultraPanel1.Location = new System.Drawing.Point(998, 149);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(290, 580);
            this.ultraPanel1.TabIndex = 1;
            // 
            // ultraPictureBox1
            // 
            this.ultraPictureBox1.AutoSize = true;
            this.ultraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty;
            this.ultraPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPictureBox1.Image = ((object)(resources.GetObject("ultraPictureBox1.Image")));
            this.ultraPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraPictureBox1.Name = "ultraPictureBox1";
            this.ultraPictureBox1.Size = new System.Drawing.Size(290, 580);
            this.ultraPictureBox1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.181745F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.7117F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.186972F));
            this.tableLayoutPanel2.Controls.Add(this.ultraLabel1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(90, 192);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.020438F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.5666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.553911F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(829, 473);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(37, 45);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(745, 393);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = resources.GetString("ultraLabel1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1292, 729);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ultraPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ClientArea.PerformLayout();
            this.ultraPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Infragistics.Win.Misc.UltraButton LogInbtn;
        private Infragistics.Win.Misc.UltraButton registerbtn;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.UltraWinEditors.UltraPictureBox ultraPictureBox1;
        private Infragistics.Win.Misc.UltraButton homebtn;
        private Infragistics.Win.Misc.UltraButton aboutbtn;
        private Infragistics.Win.Misc.UltraLabel welcomelbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
    }
}