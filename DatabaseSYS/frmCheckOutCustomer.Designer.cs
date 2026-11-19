namespace DatabaseConnect
{
    partial class frmCheckOutCustomer
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
            btnCheckOut = new Button();
            lblResNo = new Label();
            cboResNo = new ComboBox();
            groupBox1 = new GroupBox();
            txtName = new TextBox();
            lblName = new Label();
            txtStatus = new TextBox();
            lblStatus = new Label();
            lblKey = new Label();
            mnuStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuStrip
            // 
            mnuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuExit, mnuBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Size = new Size(832, 29);
            mnuStrip.TabIndex = 14;
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
            // btnCheckOut
            // 
            btnCheckOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.Red;
            btnCheckOut.Location = new Point(195, 206);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(157, 75);
            btnCheckOut.TabIndex = 17;
            btnCheckOut.Text = "Check-Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // lblResNo
            // 
            lblResNo.AutoSize = true;
            lblResNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResNo.ForeColor = Color.Black;
            lblResNo.Location = new Point(88, 60);
            lblResNo.Name = "lblResNo";
            lblResNo.Size = new Size(51, 17);
            lblResNo.TabIndex = 16;
            lblResNo.Text = "ResNo:";
            // 
            // cboResNo
            // 
            cboResNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboResNo.FormattingEnabled = true;
            cboResNo.Location = new Point(169, 56);
            cboResNo.Name = "cboResNo";
            cboResNo.Size = new Size(329, 29);
            cboResNo.TabIndex = 15;
            cboResNo.SelectedIndexChanged += cboResNo_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(lblResNo);
            groupBox1.Controls.Add(btnCheckOut);
            groupBox1.Controls.Add(cboResNo);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 192);
            groupBox1.Location = new Point(11, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 313);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Check-Out Customer";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(169, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(277, 25);
            txtName.TabIndex = 21;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(88, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 17);
            lblName.TabIndex = 20;
            lblName.Text = "Name:";
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(169, 138);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(221, 25);
            txtStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(88, 145);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 17);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Status:";
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.ForeColor = Color.Black;
            lblKey.Location = new Point(576, 76);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(244, 85);
            lblKey.TabIndex = 22;
            lblKey.Text = "Select ResNo to display name and \r\nstatus.\r\n\r\nOnce confirmed, click the 'Check-Out' \r\nbutton to check out the customer. \r\n";
            // 
            // frmCheckOutCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 384);
            Controls.Add(lblKey);
            Controls.Add(groupBox1);
            Controls.Add(mnuStrip);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "frmCheckOutCustomer";
            Text = "Killarney Hobby Shop - Check Out Customer";
            Load += frmCheckOutCustomer_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblResNo;
        private System.Windows.Forms.ComboBox cboResNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private Label lblKey;
    }
}