namespace DatabaseConnect
{
    partial class frmCheckInCustomer
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
            mnuStrip = new MenuStrip();
            mnuExit = new ToolStripMenuItem();
            mnuBack = new ToolStripMenuItem();
            grpCheckInCustomer = new GroupBox();
            label1 = new Label();
            txtTime = new TextBox();
            txtDate = new TextBox();
            lblDate = new Label();
            lblTime = new Label();
            lblName = new Label();
            btnCheckInCustomer = new Button();
            txtName = new TextBox();
            lblResNo = new Label();
            cboResNo = new ComboBox();
            lblKey = new Label();
            mnuStrip.SuspendLayout();
            grpCheckInCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // mnuStrip
            // 
            mnuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuExit, mnuBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Padding = new Padding(5, 2, 0, 2);
            mnuStrip.Size = new Size(650, 29);
            mnuStrip.TabIndex = 15;
            mnuStrip.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            mnuExit.Alignment = ToolStripItemAlignment.Right;
            mnuExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuExit.ForeColor = Color.Firebrick;
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(51, 25);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuBack
            // 
            mnuBack.Alignment = ToolStripItemAlignment.Right;
            mnuBack.Name = "mnuBack";
            mnuBack.Size = new Size(58, 25);
            mnuBack.Text = "Back";
            mnuBack.Click += mnuBack_Click;
            // 
            // grpCheckInCustomer
            // 
            grpCheckInCustomer.Controls.Add(label1);
            grpCheckInCustomer.Controls.Add(txtTime);
            grpCheckInCustomer.Controls.Add(txtDate);
            grpCheckInCustomer.Controls.Add(lblDate);
            grpCheckInCustomer.Controls.Add(lblTime);
            grpCheckInCustomer.Controls.Add(lblName);
            grpCheckInCustomer.Controls.Add(btnCheckInCustomer);
            grpCheckInCustomer.Controls.Add(txtName);
            grpCheckInCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpCheckInCustomer.ForeColor = Color.FromArgb(0, 0, 192);
            grpCheckInCustomer.Location = new Point(10, 109);
            grpCheckInCustomer.Name = "grpCheckInCustomer";
            grpCheckInCustomer.Size = new Size(628, 272);
            grpCheckInCustomer.TabIndex = 16;
            grpCheckInCustomer.TabStop = false;
            grpCheckInCustomer.Text = "Check-In Customer";
            grpCheckInCustomer.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(455, 39);
            label1.Name = "label1";
            label1.Size = new Size(167, 51);
            label1.TabIndex = 22;
            label1.Text = "Confirm Details and click \r\nthe 'Check-In' button to \r\nCheck-In the customer.\r\n";
            // 
            // txtTime
            // 
            txtTime.Enabled = false;
            txtTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTime.Location = new Point(150, 126);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(181, 25);
            txtTime.TabIndex = 14;
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Location = new Point(150, 82);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(181, 25);
            txtDate.TabIndex = 13;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(61, 86);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 21);
            lblDate.TabIndex = 12;
            lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(61, 130);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(52, 21);
            lblTime.TabIndex = 11;
            lblTime.Text = "Time:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(61, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 21);
            lblName.TabIndex = 10;
            lblName.Text = "Name:";
            // 
            // btnCheckInCustomer
            // 
            btnCheckInCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckInCustomer.ForeColor = Color.Red;
            btnCheckInCustomer.Location = new Point(245, 184);
            btnCheckInCustomer.Name = "btnCheckInCustomer";
            btnCheckInCustomer.Size = new Size(129, 71);
            btnCheckInCustomer.TabIndex = 7;
            btnCheckInCustomer.Text = "Check-In";
            btnCheckInCustomer.UseVisualStyleBackColor = true;
            btnCheckInCustomer.Click += btnCheckInCustomer_Click;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(150, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(291, 25);
            txtName.TabIndex = 5;
            // 
            // lblResNo
            // 
            lblResNo.AutoSize = true;
            lblResNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResNo.ForeColor = Color.Black;
            lblResNo.Location = new Point(16, 65);
            lblResNo.Name = "lblResNo";
            lblResNo.Size = new Size(63, 21);
            lblResNo.TabIndex = 0;
            lblResNo.Text = "ResNo:";
            // 
            // cboResNo
            // 
            cboResNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboResNo.FormattingEnabled = true;
            cboResNo.Location = new Point(104, 63);
            cboResNo.Name = "cboResNo";
            cboResNo.Size = new Size(266, 25);
            cboResNo.TabIndex = 17;
            cboResNo.SelectedIndexChanged += cboResNo_SelectedIndexChanged_1;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.Location = new Point(390, 54);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(233, 34);
            lblKey.TabIndex = 21;
            lblKey.Text = "Select ResNo to display Reservation \r\ndetails.";
            // 
            // frmCheckInCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 388);
            Controls.Add(lblKey);
            Controls.Add(cboResNo);
            Controls.Add(grpCheckInCustomer);
            Controls.Add(mnuStrip);
            Controls.Add(lblResNo);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "frmCheckInCustomer";
            Text = "Killarney Hobby Shop - Check-In Customer";
            Load += frmCheckInCustomer_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            grpCheckInCustomer.ResumeLayout(false);
            grpCheckInCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpCheckInCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCheckInCustomer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblResNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cboResNo;
        private Label lblKey;
        private Label label1;
    }
}