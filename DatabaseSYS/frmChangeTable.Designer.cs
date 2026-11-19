namespace DatabaseConnect
{
    partial class frmChangeTable
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
            grpChangeTable = new GroupBox();
            label1 = new Label();
            cboHobbies = new ComboBox();
            txtTableNo = new TextBox();
            lblTableNo = new Label();
            btnChangeTable = new Button();
            lblHobbyID = new Label();
            lblTableNocb = new Label();
            cboTableNo = new ComboBox();
            mnuStrip = new MenuStrip();
            mnuExit = new ToolStripMenuItem();
            mnuBack = new ToolStripMenuItem();
            lblKey = new Label();
            grpChangeTable.SuspendLayout();
            mnuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // grpChangeTable
            // 
            grpChangeTable.Controls.Add(label1);
            grpChangeTable.Controls.Add(cboHobbies);
            grpChangeTable.Controls.Add(txtTableNo);
            grpChangeTable.Controls.Add(lblTableNo);
            grpChangeTable.Controls.Add(btnChangeTable);
            grpChangeTable.Controls.Add(lblHobbyID);
            grpChangeTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpChangeTable.ForeColor = Color.FromArgb(0, 0, 192);
            grpChangeTable.Location = new Point(10, 119);
            grpChangeTable.Name = "grpChangeTable";
            grpChangeTable.Size = new Size(651, 230);
            grpChangeTable.TabIndex = 4;
            grpChangeTable.TabStop = false;
            grpChangeTable.Text = "Change Table";
            grpChangeTable.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(458, 28);
            label1.Name = "label1";
            label1.Size = new Size(182, 51);
            label1.TabIndex = 21;
            label1.Text = "Update details and 'Change \r\nTable' button to update the \r\ntable details in the system.";
            // 
            // cboHobbies
            // 
            cboHobbies.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHobbies.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboHobbies.FormattingEnabled = true;
            cboHobbies.Location = new Point(94, 67);
            cboHobbies.Name = "cboHobbies";
            cboHobbies.Size = new Size(328, 25);
            cboHobbies.TabIndex = 11;
            cboHobbies.SelectedIndexChanged += cboHobbies_SelectedIndexChanged;
            // 
            // txtTableNo
            // 
            txtTableNo.Enabled = false;
            txtTableNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTableNo.Location = new Point(94, 28);
            txtTableNo.Name = "txtTableNo";
            txtTableNo.Size = new Size(79, 25);
            txtTableNo.TabIndex = 10;
            // 
            // lblTableNo
            // 
            lblTableNo.AutoSize = true;
            lblTableNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNo.ForeColor = Color.Black;
            lblTableNo.Location = new Point(5, 32);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(78, 21);
            lblTableNo.TabIndex = 9;
            lblTableNo.Text = "TableNo:";
            // 
            // btnChangeTable
            // 
            btnChangeTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeTable.ForeColor = Color.Red;
            btnChangeTable.Location = new Point(231, 147);
            btnChangeTable.Name = "btnChangeTable";
            btnChangeTable.Size = new Size(176, 67);
            btnChangeTable.TabIndex = 7;
            btnChangeTable.Text = "Change Table";
            btnChangeTable.UseVisualStyleBackColor = true;
            btnChangeTable.Click += btnChangeTable_Click;
            // 
            // lblHobbyID
            // 
            lblHobbyID.AutoSize = true;
            lblHobbyID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbyID.ForeColor = Color.Black;
            lblHobbyID.Location = new Point(5, 67);
            lblHobbyID.Name = "lblHobbyID";
            lblHobbyID.Size = new Size(82, 21);
            lblHobbyID.TabIndex = 0;
            lblHobbyID.Text = "HobbyID:";
            // 
            // lblTableNocb
            // 
            lblTableNocb.AutoSize = true;
            lblTableNocb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNocb.ForeColor = Color.Black;
            lblTableNocb.Location = new Point(15, 61);
            lblTableNocb.Name = "lblTableNocb";
            lblTableNocb.Size = new Size(78, 21);
            lblTableNocb.TabIndex = 10;
            lblTableNocb.Text = "TableNo:";
            // 
            // cboTableNo
            // 
            cboTableNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTableNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboTableNo.FormattingEnabled = true;
            cboTableNo.Location = new Point(84, 60);
            cboTableNo.Name = "cboTableNo";
            cboTableNo.Size = new Size(99, 25);
            cboTableNo.TabIndex = 11;
            cboTableNo.SelectedIndexChanged += cboTableNo_SelectedIndexChanged;
            // 
            // mnuStrip
            // 
            mnuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuExit, mnuBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Padding = new Padding(5, 2, 0, 2);
            mnuStrip.Size = new Size(673, 29);
            mnuStrip.TabIndex = 12;
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
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.Location = new Point(224, 63);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(312, 17);
            lblKey.TabIndex = 20;
            lblKey.Text = "Select TableNo to display TableNo and HobbyID. \r\n";
            // 
            // frmChangeTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 357);
            Controls.Add(lblKey);
            Controls.Add(mnuStrip);
            Controls.Add(cboTableNo);
            Controls.Add(lblTableNocb);
            Controls.Add(grpChangeTable);
            MaximizeBox = false;
            Name = "frmChangeTable";
            Text = "Killarney Hobby Shop - Change Table";
            Load += frmChangeTable_Load;
            grpChangeTable.ResumeLayout(false);
            grpChangeTable.PerformLayout();
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpChangeTable;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Label lblHobbyID;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblTableNocb;
        private System.Windows.Forms.ComboBox cboTableNo;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private ComboBox cboHobbies;
        private Label lblKey;
        private Label label1;
    }
}