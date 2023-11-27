namespace ChoresDesktopApp.UI
{
    partial class ReceiverMode
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
            this.homebtn = new Infragistics.Win.Misc.UltraButton();
            this.receiverbtn = new Infragistics.Win.Misc.UltraButton();
            this.welcomelbl = new Infragistics.Win.Misc.UltraLabel();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.homebtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.receiverbtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.welcomelbl, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.96113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.50883F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26502F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26502F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1318, 143);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // homebtn
            // 
            this.homebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homebtn.Location = new System.Drawing.Point(44, 27);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(114, 40);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "Supplier Mode";
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // receiverbtn
            // 
            this.receiverbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiverbtn.Location = new System.Drawing.Point(164, 27);
            this.receiverbtn.Name = "receiverbtn";
            this.receiverbtn.Size = new System.Drawing.Size(120, 40);
            this.receiverbtn.TabIndex = 3;
            this.receiverbtn.Text = "Receiver Mode";
            this.receiverbtn.Click += new System.EventHandler(this.receiverbtn_Click);
            // 
            // welcomelbl
            // 
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.welcomelbl.Appearance = appearance1;
            this.welcomelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomelbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.welcomelbl.Location = new System.Drawing.Point(290, 27);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(810, 40);
            this.welcomelbl.TabIndex = 4;
            this.welcomelbl.Text = "Welcome To Your Dream Chores";
            // 
            // ReceiverMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1318, 726);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReceiverMode";
            this.Text = "ReceiverMode";
            this.Load += new System.EventHandler(this.ReceiverMode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Infragistics.Win.Misc.UltraButton homebtn;
        private Infragistics.Win.Misc.UltraButton receiverbtn;
        private Infragistics.Win.Misc.UltraLabel welcomelbl;
    }
}