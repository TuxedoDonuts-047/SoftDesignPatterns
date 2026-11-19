namespace DatabaseConnect
{
    partial class frmAddTable
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
            grpAddTable = new GroupBox();
            cboHobbyID = new ComboBox();
            lblTableNo = new Label();
            txtTableNo = new TextBox();
            btnAdd = new Button();
            lblHobbyID = new Label();
            lblKey = new Label();
            mnuStrip.SuspendLayout();
            grpAddTable.SuspendLayout();
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
            mnuStrip.Size = new Size(524, 29);
            mnuStrip.TabIndex = 1;
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
            // grpAddTable
            // 
            grpAddTable.Controls.Add(lblKey);
            grpAddTable.Controls.Add(cboHobbyID);
            grpAddTable.Controls.Add(lblTableNo);
            grpAddTable.Controls.Add(txtTableNo);
            grpAddTable.Controls.Add(btnAdd);
            grpAddTable.Controls.Add(lblHobbyID);
            grpAddTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpAddTable.ForeColor = Color.FromArgb(0, 0, 192);
            grpAddTable.Location = new Point(10, 32);
            grpAddTable.Name = "grpAddTable";
            grpAddTable.Size = new Size(502, 255);
            grpAddTable.TabIndex = 3;
            grpAddTable.TabStop = false;
            grpAddTable.Text = "Add Table";
            // 
            // cboHobbyID
            // 
            cboHobbyID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHobbyID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboHobbyID.FormattingEnabled = true;
            cboHobbyID.Location = new Point(104, 96);
            cboHobbyID.Name = "cboHobbyID";
            cboHobbyID.Size = new Size(241, 29);
            cboHobbyID.TabIndex = 10;
            cboHobbyID.SelectedIndexChanged += cboHobbyID_SelectedIndexChanged;
            // 
            // lblTableNo
            // 
            lblTableNo.AutoSize = true;
            lblTableNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNo.ForeColor = Color.Black;
            lblTableNo.Location = new Point(15, 41);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(78, 21);
            lblTableNo.TabIndex = 9;
            lblTableNo.Text = "TableNo:";
            // 
            // txtTableNo
            // 
            txtTableNo.Enabled = false;
            txtTableNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTableNo.Location = new Point(104, 41);
            txtTableNo.Name = "txtTableNo";
            txtTableNo.Size = new Size(79, 29);
            txtTableNo.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(194, 172);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 55);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Table";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblHobbyID
            // 
            lblHobbyID.AutoSize = true;
            lblHobbyID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbyID.ForeColor = Color.Black;
            lblHobbyID.Location = new Point(15, 100);
            lblHobbyID.Name = "lblHobbyID";
            lblHobbyID.Size = new Size(82, 21);
            lblHobbyID.TabIndex = 0;
            lblHobbyID.Text = "HobbyID:";
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.ForeColor = Color.Black;
            lblKey.Location = new Point(362, 36);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(140, 34);
            lblKey.TabIndex = 20;
            lblKey.Text = "Select HobbyID and \r\nclick the 'Add Table'. \r\n";
            // 
            // frmAddTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 293);
            Controls.Add(grpAddTable);
            Controls.Add(mnuStrip);
            MaximizeBox = false;
            Name = "frmAddTable";
            Text = "Killarney Hobby Shop - Add Table";
            Load += frmAddTable_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            grpAddTable.ResumeLayout(false);
            grpAddTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpAddTable;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHobbyID;
        private System.Windows.Forms.ComboBox cboHobbyID;
        private Label lblKey;
    }
}