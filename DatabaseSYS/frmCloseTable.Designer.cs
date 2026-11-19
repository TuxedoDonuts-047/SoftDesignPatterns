namespace DatabaseConnect
{
    partial class frmCloseTable
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
            menuStrip1 = new MenuStrip();
            mnuExit = new ToolStripMenuItem();
            mnuBack = new ToolStripMenuItem();
            grpCloseTable = new GroupBox();
            txtHobbies = new TextBox();
            label1 = new Label();
            txtTableNo = new TextBox();
            label2 = new Label();
            btnCloseTable = new Button();
            lblRate = new Label();
            lblHobbyID = new Label();
            cboTableNo = new ComboBox();
            lblTableNocb = new Label();
            lblKey = new Label();
            menuStrip1.SuspendLayout();
            grpCloseTable.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuExit, mnuBack });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(621, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
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
            // grpCloseTable
            // 
            grpCloseTable.Controls.Add(txtHobbies);
            grpCloseTable.Controls.Add(label1);
            grpCloseTable.Controls.Add(txtTableNo);
            grpCloseTable.Controls.Add(label2);
            grpCloseTable.Controls.Add(btnCloseTable);
            grpCloseTable.Controls.Add(lblRate);
            grpCloseTable.Controls.Add(lblHobbyID);
            grpCloseTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpCloseTable.ForeColor = Color.FromArgb(0, 0, 192);
            grpCloseTable.Location = new Point(12, 87);
            grpCloseTable.Name = "grpCloseTable";
            grpCloseTable.Size = new Size(594, 280);
            grpCloseTable.TabIndex = 5;
            grpCloseTable.TabStop = false;
            grpCloseTable.Text = "Close Table";
            grpCloseTable.Visible = false;
            // 
            // txtHobbies
            // 
            txtHobbies.Enabled = false;
            txtHobbies.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHobbies.Location = new Point(112, 125);
            txtHobbies.Name = "txtHobbies";
            txtHobbies.Size = new Size(121, 25);
            txtHobbies.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(337, 62);
            label1.Name = "label1";
            label1.Size = new Size(215, 34);
            label1.TabIndex = 20;
            label1.Text = "Confirm details and 'Close Table' \r\nbutton to close the table.";
            // 
            // txtTableNo
            // 
            txtTableNo.Enabled = false;
            txtTableNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTableNo.Location = new Point(112, 56);
            txtTableNo.Name = "txtTableNo";
            txtTableNo.Size = new Size(121, 25);
            txtTableNo.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(27, 60);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 17;
            label2.Text = "TableNo:";
            // 
            // btnCloseTable
            // 
            btnCloseTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseTable.ForeColor = Color.Red;
            btnCloseTable.Location = new Point(223, 188);
            btnCloseTable.Name = "btnCloseTable";
            btnCloseTable.Size = new Size(153, 70);
            btnCloseTable.TabIndex = 7;
            btnCloseTable.Text = "Close Table";
            btnCloseTable.UseVisualStyleBackColor = true;
            btnCloseTable.Click += btnCloseTable_Click;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRate.ForeColor = Color.Black;
            lblRate.Location = new Point(11, 188);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(0, 15);
            lblRate.TabIndex = 2;
            // 
            // lblHobbyID
            // 
            lblHobbyID.AutoSize = true;
            lblHobbyID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbyID.ForeColor = Color.Black;
            lblHobbyID.Location = new Point(27, 132);
            lblHobbyID.Name = "lblHobbyID";
            lblHobbyID.Size = new Size(82, 21);
            lblHobbyID.TabIndex = 0;
            lblHobbyID.Text = "HobbyID:";
            // 
            // cboTableNo
            // 
            cboTableNo.AutoCompleteCustomSource.AddRange(new string[] { "001", "002", "003", "004", "005" });
            cboTableNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTableNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboTableNo.FormattingEnabled = true;
            cboTableNo.Location = new Point(101, 46);
            cboTableNo.Name = "cboTableNo";
            cboTableNo.Size = new Size(90, 25);
            cboTableNo.TabIndex = 13;
            cboTableNo.SelectedIndexChanged += cboTableNo_SelectedIndexChanged;
            // 
            // lblTableNocb
            // 
            lblTableNocb.AutoSize = true;
            lblTableNocb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNocb.ForeColor = Color.Black;
            lblTableNocb.Location = new Point(17, 48);
            lblTableNocb.Name = "lblTableNocb";
            lblTableNocb.Size = new Size(78, 21);
            lblTableNocb.TabIndex = 12;
            lblTableNocb.Text = "TableNo:";
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.Location = new Point(214, 49);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(312, 17);
            lblKey.TabIndex = 19;
            lblKey.Text = "Select TableNo to display TableNo and HobbyID. \r\n";
            // 
            // frmCloseTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 375);
            Controls.Add(lblKey);
            Controls.Add(cboTableNo);
            Controls.Add(lblTableNocb);
            Controls.Add(grpCloseTable);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            Name = "frmCloseTable";
            Text = "Killarney Hobby Shop - Close Table";
            Load += frmCloseTable_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpCloseTable.ResumeLayout(false);
            grpCloseTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpCloseTable;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblHobbyID;
        private System.Windows.Forms.ComboBox cboTableNo;
        private System.Windows.Forms.Label lblTableNocb;
        private System.Windows.Forms.Label label2;
        private TextBox txtTableNo;
        private Label lblKey;
        private Label label1;
        private TextBox txtHobbies;
    }
}