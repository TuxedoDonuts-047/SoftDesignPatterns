namespace DatabaseConnect
{
    partial class frmMakeReservation
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
            grpMakeReservation = new GroupBox();
            label1 = new Label();
            txtResNo = new TextBox();
            lblResNo = new Label();
            cboHobbyID = new ComboBox();
            lblDate = new Label();
            grpTableSelect = new GroupBox();
            label2 = new Label();
            dtpTime = new DateTimePicker();
            lblTime = new Label();
            txtTableNo = new TextBox();
            btnMakeReservation = new Button();
            lblTableNo = new Label();
            cboTableSelect = new ComboBox();
            lblTable = new Label();
            dtpDate = new DateTimePicker();
            lblHobbyID = new Label();
            grpContact = new GroupBox();
            label3 = new Label();
            lblCardNo = new Label();
            txtCardNo = new TextBox();
            btnConfirm = new Button();
            lblEmail = new Label();
            lblPhoneNo = new Label();
            txtEmail = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            mnuStrip.SuspendLayout();
            grpMakeReservation.SuspendLayout();
            grpTableSelect.SuspendLayout();
            grpContact.SuspendLayout();
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
            mnuStrip.Size = new Size(1364, 29);
            mnuStrip.TabIndex = 2;
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
            // grpMakeReservation
            // 
            grpMakeReservation.Controls.Add(label1);
            grpMakeReservation.Controls.Add(txtResNo);
            grpMakeReservation.Controls.Add(lblResNo);
            grpMakeReservation.Controls.Add(cboHobbyID);
            grpMakeReservation.Controls.Add(lblDate);
            grpMakeReservation.Controls.Add(grpTableSelect);
            grpMakeReservation.Controls.Add(dtpDate);
            grpMakeReservation.Controls.Add(lblHobbyID);
            grpMakeReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpMakeReservation.ForeColor = Color.FromArgb(0, 0, 192);
            grpMakeReservation.Location = new Point(10, 32);
            grpMakeReservation.Name = "grpMakeReservation";
            grpMakeReservation.Size = new Size(634, 481);
            grpMakeReservation.TabIndex = 4;
            grpMakeReservation.TabStop = false;
            grpMakeReservation.Text = "Make Reservation";
            grpMakeReservation.Enter += grpMakeReservation_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(438, 80);
            label1.Name = "label1";
            label1.Size = new Size(172, 17);
            label1.TabIndex = 22;
            label1.Text = "Choose HobbyID and Date\r\n";
            // 
            // txtResNo
            // 
            txtResNo.Enabled = false;
            txtResNo.Location = new Point(155, 40);
            txtResNo.Name = "txtResNo";
            txtResNo.Size = new Size(46, 29);
            txtResNo.TabIndex = 3;
            // 
            // lblResNo
            // 
            lblResNo.AutoSize = true;
            lblResNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResNo.ForeColor = Color.Black;
            lblResNo.Location = new Point(5, 41);
            lblResNo.Name = "lblResNo";
            lblResNo.Size = new Size(63, 21);
            lblResNo.TabIndex = 24;
            lblResNo.Text = "ResNo:";
            // 
            // cboHobbyID
            // 
            cboHobbyID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHobbyID.FormattingEnabled = true;
            cboHobbyID.Location = new Point(153, 72);
            cboHobbyID.Name = "cboHobbyID";
            cboHobbyID.Size = new Size(241, 29);
            cboHobbyID.TabIndex = 23;
            cboHobbyID.SelectedIndexChanged += cboHobbyID_SelectedIndexChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(5, 106);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(122, 42);
            lblDate.TabIndex = 22;
            lblDate.Text = "Date: \r\n(dd/mm/yyyy)";
            // 
            // grpTableSelect
            // 
            grpTableSelect.Controls.Add(label2);
            grpTableSelect.Controls.Add(dtpTime);
            grpTableSelect.Controls.Add(lblTime);
            grpTableSelect.Controls.Add(txtTableNo);
            grpTableSelect.Controls.Add(btnMakeReservation);
            grpTableSelect.Controls.Add(lblTableNo);
            grpTableSelect.Controls.Add(cboTableSelect);
            grpTableSelect.Controls.Add(lblTable);
            grpTableSelect.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            grpTableSelect.Location = new Point(8, 174);
            grpTableSelect.Name = "grpTableSelect";
            grpTableSelect.Size = new Size(620, 301);
            grpTableSelect.TabIndex = 21;
            grpTableSelect.TabStop = false;
            grpTableSelect.Text = "Available Tables";
            grpTableSelect.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(420, 50);
            label2.Name = "label2";
            label2.Size = new Size(215, 119);
            label2.TabIndex = 22;
            label2.Text = "Choose available Table for \r\nselected Hobby and select \r\ntime.\r\n\r\nIf selected Hobby has no table, \r\ninform customer and give \r\noption to choose another hobby. ";
            // 
            // dtpTime
            // 
            dtpTime.CustomFormat = "hh:mm";
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(215, 149);
            dtpTime.MinDate = new DateTime(2025, 6, 16, 0, 0, 0, 0);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new Size(122, 29);
            dtpTime.TabIndex = 21;
            dtpTime.Value = new DateTime(2025, 6, 16, 10, 47, 7, 0);
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.Black;
            lblTime.Location = new Point(9, 136);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(116, 42);
            lblTime.TabIndex = 15;
            lblTime.Text = "Time:\r\n(09:30 - 19:00)";
            // 
            // txtTableNo
            // 
            txtTableNo.Enabled = false;
            txtTableNo.Location = new Point(215, 94);
            txtTableNo.Name = "txtTableNo";
            txtTableNo.Size = new Size(52, 29);
            txtTableNo.TabIndex = 3;
            // 
            // btnMakeReservation
            // 
            btnMakeReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMakeReservation.ForeColor = Color.Red;
            btnMakeReservation.Location = new Point(183, 199);
            btnMakeReservation.Name = "btnMakeReservation";
            btnMakeReservation.Size = new Size(231, 76);
            btnMakeReservation.TabIndex = 7;
            btnMakeReservation.Text = "Make Reservation";
            btnMakeReservation.UseVisualStyleBackColor = true;
            btnMakeReservation.Click += btnAddReservation_Click;
            // 
            // lblTableNo
            // 
            lblTableNo.AutoSize = true;
            lblTableNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNo.ForeColor = Color.Black;
            lblTableNo.Location = new Point(9, 102);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(78, 21);
            lblTableNo.TabIndex = 13;
            lblTableNo.Text = "TableNo:";
            // 
            // cboTableSelect
            // 
            cboTableSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTableSelect.FormattingEnabled = true;
            cboTableSelect.Location = new Point(215, 58);
            cboTableSelect.Name = "cboTableSelect";
            cboTableSelect.Size = new Size(182, 29);
            cboTableSelect.TabIndex = 12;
            cboTableSelect.SelectedIndexChanged += cboTableSelect_SelectedIndexChanged;
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTable.ForeColor = Color.Black;
            lblTable.Location = new Point(9, 45);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(172, 42);
            lblTable.TabIndex = 9;
            lblTable.Text = "Tables \r\n(TableNo - HobbyID):";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpDate.CustomFormat = "";
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(153, 116);
            dtpDate.MinDate = new DateTime(2025, 8, 6, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(122, 29);
            dtpDate.TabIndex = 11;
            dtpDate.Value = new DateTime(2025, 8, 18, 0, 0, 0, 0);
            // 
            // lblHobbyID
            // 
            lblHobbyID.AutoSize = true;
            lblHobbyID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbyID.ForeColor = Color.Black;
            lblHobbyID.Location = new Point(5, 72);
            lblHobbyID.Name = "lblHobbyID";
            lblHobbyID.Size = new Size(82, 21);
            lblHobbyID.TabIndex = 0;
            lblHobbyID.Text = "HobbyID:";
            // 
            // grpContact
            // 
            grpContact.Controls.Add(label3);
            grpContact.Controls.Add(lblCardNo);
            grpContact.Controls.Add(txtCardNo);
            grpContact.Controls.Add(btnConfirm);
            grpContact.Controls.Add(lblEmail);
            grpContact.Controls.Add(lblPhoneNo);
            grpContact.Controls.Add(txtEmail);
            grpContact.Controls.Add(lblName);
            grpContact.Controls.Add(txtName);
            grpContact.Controls.Add(txtPhone);
            grpContact.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            grpContact.Location = new Point(650, 41);
            grpContact.Name = "grpContact";
            grpContact.Size = new Size(702, 356);
            grpContact.TabIndex = 5;
            grpContact.TabStop = false;
            grpContact.Text = "Contact Details";
            grpContact.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(509, 48);
            label3.Name = "label3";
            label3.Size = new Size(194, 51);
            label3.TabIndex = 22;
            label3.Text = "Insert customer details and \r\nclick 'Confirm Details' button \r\nto make the reservation";
            // 
            // lblCardNo
            // 
            lblCardNo.AutoSize = true;
            lblCardNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCardNo.ForeColor = Color.Black;
            lblCardNo.Location = new Point(26, 210);
            lblCardNo.Name = "lblCardNo";
            lblCardNo.Size = new Size(76, 21);
            lblCardNo.TabIndex = 28;
            lblCardNo.Text = "Card No:";
            // 
            // txtCardNo
            // 
            txtCardNo.Location = new Point(131, 207);
            txtCardNo.MaxLength = 12;
            txtCardNo.Name = "txtCardNo";
            txtCardNo.Size = new Size(218, 29);
            txtCardNo.TabIndex = 12;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.Red;
            btnConfirm.Location = new Point(171, 277);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(200, 66);
            btnConfirm.TabIndex = 27;
            btnConfirm.Text = "Confirm Details";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(26, 159);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email:";
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhoneNo.ForeColor = Color.Black;
            lblPhoneNo.Location = new Point(26, 97);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(101, 42);
            lblPhoneNo.TabIndex = 23;
            lblPhoneNo.Text = "PhoneNo: \r\n(No Spaces)";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 156);
            txtEmail.MaxLength = 20;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 29);
            txtEmail.TabIndex = 24;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(26, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 21);
            lblName.TabIndex = 22;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 38);
            txtName.MaxLength = 40;
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 29);
            txtName.TabIndex = 40;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(131, 94);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(350, 29);
            txtPhone.TabIndex = 12;
            // 
            // frmMakeReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 525);
            Controls.Add(grpContact);
            Controls.Add(grpMakeReservation);
            Controls.Add(mnuStrip);
            MaximizeBox = false;
            Name = "frmMakeReservation";
            Text = "Killarney Hobby Shop - Make Reservation";
            Load += frmMakeReservation_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            grpMakeReservation.ResumeLayout(false);
            grpMakeReservation.PerformLayout();
            grpTableSelect.ResumeLayout(false);
            grpTableSelect.PerformLayout();
            grpContact.ResumeLayout(false);
            grpContact.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpMakeReservation;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Label lblHobbyID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpTableSelect;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboHobbyID;
        private System.Windows.Forms.ComboBox cboTableSelect;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblResNo;
        private System.Windows.Forms.TextBox txtResNo;
        private Label lblCardNo;
        private TextBox txtCardNo;
        private DateTimePicker dtpTime;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}