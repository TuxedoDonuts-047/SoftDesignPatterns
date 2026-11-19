namespace DatabaseConnect
{
    partial class frmUpdateHobby
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
            btnUpdateHobby = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            lblHobbyID = new Label();
            grpUpdateHobby = new GroupBox();
            label1 = new Label();
            txtPlayerNum = new TextBox();
            lblPlayerNum = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtHobbyID = new TextBox();
            mnuStrip = new MenuStrip();
            mnuExit = new ToolStripMenuItem();
            mnuBack = new ToolStripMenuItem();
            lblHobbyIDcb = new Label();
            cboHobbyID = new ComboBox();
            lblKey = new Label();
            grpUpdateHobby.SuspendLayout();
            mnuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateHobby
            // 
            btnUpdateHobby.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateHobby.ForeColor = Color.Red;
            btnUpdateHobby.Location = new Point(195, 219);
            btnUpdateHobby.Name = "btnUpdateHobby";
            btnUpdateHobby.Size = new Size(167, 78);
            btnUpdateHobby.TabIndex = 7;
            btnUpdateHobby.Text = "Update Hobby";
            btnUpdateHobby.UseVisualStyleBackColor = true;
            btnUpdateHobby.Click += btnUpdateHobby_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(111, 65);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(189, 25);
            txtDescription.TabIndex = 20;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(5, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 21);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description:";
            // 
            // lblHobbyID
            // 
            lblHobbyID.AutoSize = true;
            lblHobbyID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbyID.ForeColor = Color.Black;
            lblHobbyID.Location = new Point(5, 28);
            lblHobbyID.Name = "lblHobbyID";
            lblHobbyID.Size = new Size(82, 21);
            lblHobbyID.TabIndex = 0;
            lblHobbyID.Text = "HobbyID:";
            // 
            // grpUpdateHobby
            // 
            grpUpdateHobby.Controls.Add(label1);
            grpUpdateHobby.Controls.Add(txtPlayerNum);
            grpUpdateHobby.Controls.Add(lblPlayerNum);
            grpUpdateHobby.Controls.Add(txtPrice);
            grpUpdateHobby.Controls.Add(lblPrice);
            grpUpdateHobby.Controls.Add(txtHobbyID);
            grpUpdateHobby.Controls.Add(btnUpdateHobby);
            grpUpdateHobby.Controls.Add(txtDescription);
            grpUpdateHobby.Controls.Add(lblDescription);
            grpUpdateHobby.Controls.Add(lblHobbyID);
            grpUpdateHobby.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpUpdateHobby.ForeColor = Color.FromArgb(0, 0, 192);
            grpUpdateHobby.Location = new Point(26, 84);
            grpUpdateHobby.Name = "grpUpdateHobby";
            grpUpdateHobby.Size = new Size(571, 308);
            grpUpdateHobby.TabIndex = 3;
            grpUpdateHobby.TabStop = false;
            grpUpdateHobby.Text = "Update Hobby";
            grpUpdateHobby.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(344, 30);
            label1.Name = "label1";
            label1.Size = new Size(230, 51);
            label1.TabIndex = 22;
            label1.Text = "Update details and press 'Update \r\nHobby' button to update the hobby\r\ndetails in the system.";
            // 
            // txtPlayerNum
            // 
            txtPlayerNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlayerNum.Location = new Point(111, 106);
            txtPlayerNum.Name = "txtPlayerNum";
            txtPlayerNum.Size = new Size(52, 25);
            txtPlayerNum.TabIndex = 2;
            txtPlayerNum.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPlayerNum
            // 
            lblPlayerNum.AutoSize = true;
            lblPlayerNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerNum.ForeColor = Color.Black;
            lblPlayerNum.Location = new Point(5, 110);
            lblPlayerNum.Name = "lblPlayerNum";
            lblPlayerNum.Size = new Size(102, 21);
            lblPlayerNum.TabIndex = 12;
            lblPlayerNum.Text = "# of Players:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(111, 151);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(52, 25);
            txtPrice.TabIndex = 5;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(5, 151);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 21);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price:";
            // 
            // txtHobbyID
            // 
            txtHobbyID.Enabled = false;
            txtHobbyID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHobbyID.Location = new Point(111, 24);
            txtHobbyID.Name = "txtHobbyID";
            txtHobbyID.Size = new Size(79, 25);
            txtHobbyID.TabIndex = 2;
            // 
            // mnuStrip
            // 
            mnuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuExit, mnuBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Padding = new Padding(5, 2, 0, 2);
            mnuStrip.Size = new Size(609, 29);
            mnuStrip.TabIndex = 4;
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
            // lblHobbyIDcb
            // 
            lblHobbyIDcb.AutoSize = true;
            lblHobbyIDcb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbyIDcb.ForeColor = Color.Black;
            lblHobbyIDcb.Location = new Point(26, 39);
            lblHobbyIDcb.Name = "lblHobbyIDcb";
            lblHobbyIDcb.Size = new Size(82, 21);
            lblHobbyIDcb.TabIndex = 5;
            lblHobbyIDcb.Text = "HobbyID:";
            // 
            // cboHobbyID
            // 
            cboHobbyID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboHobbyID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHobbyID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboHobbyID.FormattingEnabled = true;
            cboHobbyID.Location = new Point(119, 38);
            cboHobbyID.Name = "cboHobbyID";
            cboHobbyID.Size = new Size(241, 25);
            cboHobbyID.TabIndex = 6;
            cboHobbyID.SelectedIndexChanged += cboHobbyID_SelectedIndexChanged;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.Location = new Point(370, 38);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(217, 34);
            lblKey.TabIndex = 21;
            lblKey.Text = "Select HobbyID to display Hobby \r\ndetails. \r\n";
            // 
            // frmUpdateHobby
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 397);
            Controls.Add(lblKey);
            Controls.Add(cboHobbyID);
            Controls.Add(lblHobbyIDcb);
            Controls.Add(grpUpdateHobby);
            Controls.Add(mnuStrip);
            MaximizeBox = false;
            Name = "frmUpdateHobby";
            Text = "Killarney Hobby Shop - Update Hobby";
            Load += frmUpdateHobby_Load;
            grpUpdateHobby.ResumeLayout(false);
            grpUpdateHobby.PerformLayout();
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateHobby;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHobbyID;
        private System.Windows.Forms.GroupBox grpUpdateHobby;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtHobbyID;
        private System.Windows.Forms.Label lblHobbyIDcb;
        private System.Windows.Forms.ComboBox cboHobbyID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPlayerNum;
        private System.Windows.Forms.Label lblPlayerNum;
        private Label label1;
        private Label lblKey;
    }
}