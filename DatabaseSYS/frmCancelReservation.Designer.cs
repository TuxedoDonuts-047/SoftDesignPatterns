namespace DatabaseConnect
{
    partial class frmCancelReservation
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
            lblResNo = new Label();
            grpCancelReservation = new GroupBox();
            label1 = new Label();
            txtName = new TextBox();
            txtPhoneNo = new TextBox();
            txtEmail = new TextBox();
            lblPhoneNo = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblTableNo = new Label();
            txtTableNo = new TextBox();
            btnCancelReservation = new Button();
            txtHobbyID = new TextBox();
            lblHobbyID = new Label();
            cboResNo = new ComboBox();
            lblKey = new Label();
            mnuStrip.SuspendLayout();
            grpCancelReservation.SuspendLayout();
            SuspendLayout();
            // 
            // mnuStrip
            // 
            mnuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuExit, mnuBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Padding = new Padding(6, 3, 0, 3);
            mnuStrip.Size = new Size(706, 31);
            mnuStrip.TabIndex = 3;
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
            mnuBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuBack.Name = "mnuBack";
            mnuBack.Size = new Size(58, 25);
            mnuBack.Text = "Back";
            mnuBack.Click += mnuBack_Click;
            // 
            // lblResNo
            // 
            lblResNo.AutoSize = true;
            lblResNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResNo.Location = new Point(24, 48);
            lblResNo.Margin = new Padding(4, 0, 4, 0);
            lblResNo.Name = "lblResNo";
            lblResNo.Size = new Size(63, 21);
            lblResNo.TabIndex = 5;
            lblResNo.Text = "ResNo:";
            // 
            // grpCancelReservation
            // 
            grpCancelReservation.Controls.Add(label1);
            grpCancelReservation.Controls.Add(txtName);
            grpCancelReservation.Controls.Add(txtPhoneNo);
            grpCancelReservation.Controls.Add(txtEmail);
            grpCancelReservation.Controls.Add(lblPhoneNo);
            grpCancelReservation.Controls.Add(lblName);
            grpCancelReservation.Controls.Add(lblEmail);
            grpCancelReservation.Controls.Add(lblTableNo);
            grpCancelReservation.Controls.Add(txtTableNo);
            grpCancelReservation.Controls.Add(btnCancelReservation);
            grpCancelReservation.Controls.Add(txtHobbyID);
            grpCancelReservation.Controls.Add(lblHobbyID);
            grpCancelReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpCancelReservation.ForeColor = Color.FromArgb(0, 0, 192);
            grpCancelReservation.Location = new Point(24, 77);
            grpCancelReservation.Margin = new Padding(4);
            grpCancelReservation.Name = "grpCancelReservation";
            grpCancelReservation.Padding = new Padding(4);
            grpCancelReservation.Size = new Size(669, 422);
            grpCancelReservation.TabIndex = 6;
            grpCancelReservation.TabStop = false;
            grpCancelReservation.Text = "Cancel Reservation";
            grpCancelReservation.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(450, 39);
            label1.Name = "label1";
            label1.Size = new Size(199, 51);
            label1.TabIndex = 23;
            label1.Text = "Confirm Details and click the\r\n'Cancel Reservation' button to \r\ncancel the reservation.\r\n";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(121, 165);
            txtName.Margin = new Padding(4);
            txtName.MaxLength = 40;
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 25);
            txtName.TabIndex = 19;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Enabled = false;
            txtPhoneNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNo.Location = new Point(121, 223);
            txtPhoneNo.Margin = new Padding(4);
            txtPhoneNo.MaxLength = 10;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(269, 25);
            txtPhoneNo.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(121, 279);
            txtEmail.Margin = new Padding(4);
            txtEmail.MaxLength = 20;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 25);
            txtEmail.TabIndex = 15;
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNo.ForeColor = Color.Black;
            lblPhoneNo.Location = new Point(6, 228);
            lblPhoneNo.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(86, 21);
            lblPhoneNo.TabIndex = 14;
            lblPhoneNo.Text = "PhoneNo:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(6, 171);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 21);
            lblName.TabIndex = 13;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(6, 283);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblTableNo
            // 
            lblTableNo.AutoSize = true;
            lblTableNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNo.ForeColor = Color.Black;
            lblTableNo.Location = new Point(6, 39);
            lblTableNo.Margin = new Padding(4, 0, 4, 0);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(78, 21);
            lblTableNo.TabIndex = 9;
            lblTableNo.Text = "TableNo:";
            // 
            // txtTableNo
            // 
            txtTableNo.Enabled = false;
            txtTableNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTableNo.Location = new Point(121, 34);
            txtTableNo.Margin = new Padding(4);
            txtTableNo.MaxLength = 3;
            txtTableNo.Name = "txtTableNo";
            txtTableNo.Size = new Size(100, 25);
            txtTableNo.TabIndex = 8;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelReservation.ForeColor = Color.Red;
            btnCancelReservation.Location = new Point(210, 340);
            btnCancelReservation.Margin = new Padding(4);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(253, 70);
            btnCancelReservation.TabIndex = 7;
            btnCancelReservation.Text = "Cancel Reservation";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Visible = false;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // txtHobbyID
            // 
            txtHobbyID.Enabled = false;
            txtHobbyID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHobbyID.Location = new Point(121, 95);
            txtHobbyID.Margin = new Padding(4);
            txtHobbyID.MaxLength = 2;
            txtHobbyID.Name = "txtHobbyID";
            txtHobbyID.Size = new Size(100, 25);
            txtHobbyID.TabIndex = 3;
            // 
            // lblHobbyID
            // 
            lblHobbyID.AutoSize = true;
            lblHobbyID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbyID.ForeColor = Color.Black;
            lblHobbyID.Location = new Point(6, 101);
            lblHobbyID.Margin = new Padding(4, 0, 4, 0);
            lblHobbyID.Name = "lblHobbyID";
            lblHobbyID.Size = new Size(82, 21);
            lblHobbyID.TabIndex = 0;
            lblHobbyID.Text = "HobbyID:";
            // 
            // cboResNo
            // 
            cboResNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboResNo.FormattingEnabled = true;
            cboResNo.Location = new Point(108, 44);
            cboResNo.Margin = new Padding(4);
            cboResNo.Name = "cboResNo";
            cboResNo.Size = new Size(306, 25);
            cboResNo.TabIndex = 11;
            cboResNo.SelectedIndexChanged += cboResNo_SelectedIndexChanged;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.Location = new Point(421, 48);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(282, 17);
            lblKey.TabIndex = 22;
            lblKey.Text = "Select ResNo to display Reservation details. \r\n";
            // 
            // frmCancelReservation
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 510);
            Controls.Add(lblKey);
            Controls.Add(cboResNo);
            Controls.Add(grpCancelReservation);
            Controls.Add(lblResNo);
            Controls.Add(mnuStrip);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmCancelReservation";
            Text = "Killarney Hobby Shop - Cancel Reservation";
            Load += frmCancelReservation_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            grpCancelReservation.ResumeLayout(false);
            grpCancelReservation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblResNo;
        private System.Windows.Forms.GroupBox grpCancelReservation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.TextBox txtHobbyID;
        private System.Windows.Forms.Label lblHobbyID;
        private System.Windows.Forms.ComboBox cboResNo;
        private Label label1;
        private Label lblKey;
    }
}