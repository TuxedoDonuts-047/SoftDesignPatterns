namespace DatabaseConnect
{
    partial class frmAddHobby
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
            grpAddHobby = new GroupBox();
            lblPrice = new Label();
            lblPlayerNum = new Label();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtPlayerNum = new TextBox();
            lblDescription = new Label();
            txtHobbyID = new TextBox();
            btnAdd = new Button();
            lblHobbyID = new Label();
            label1 = new Label();
            mnuStrip.SuspendLayout();
            grpAddHobby.SuspendLayout();
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
            mnuStrip.Size = new Size(612, 29);
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
            // grpAddHobby
            // 
            grpAddHobby.Controls.Add(lblPrice);
            grpAddHobby.Controls.Add(lblPlayerNum);
            grpAddHobby.Controls.Add(txtDescription);
            grpAddHobby.Controls.Add(txtPrice);
            grpAddHobby.Controls.Add(txtPlayerNum);
            grpAddHobby.Controls.Add(lblDescription);
            grpAddHobby.Controls.Add(txtHobbyID);
            grpAddHobby.Controls.Add(btnAdd);
            grpAddHobby.Controls.Add(lblHobbyID);
            grpAddHobby.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpAddHobby.ForeColor = Color.FromArgb(0, 0, 192);
            grpAddHobby.Location = new Point(26, 30);
            grpAddHobby.Name = "grpAddHobby";
            grpAddHobby.Size = new Size(417, 308);
            grpAddHobby.TabIndex = 4;
            grpAddHobby.TabStop = false;
            grpAddHobby.Text = "Add Hobby";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(48, 163);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(42, 17);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price:";
            // 
            // lblPlayerNum
            // 
            lblPlayerNum.AutoSize = true;
            lblPlayerNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerNum.ForeColor = Color.Black;
            lblPlayerNum.Location = new Point(48, 123);
            lblPlayerNum.Name = "lblPlayerNum";
            lblPlayerNum.Size = new Size(80, 17);
            lblPlayerNum.TabIndex = 13;
            lblPlayerNum.Text = "PlayerNum:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(167, 74);
            txtDescription.MaxLength = 20;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 25);
            txtDescription.TabIndex = 20;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(167, 160);
            txtPrice.MaxLength = 5;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(56, 25);
            txtPrice.TabIndex = 5;
            // 
            // txtPlayerNum
            // 
            txtPlayerNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlayerNum.Location = new Point(167, 116);
            txtPlayerNum.MaxLength = 2;
            txtPlayerNum.Name = "txtPlayerNum";
            txtPlayerNum.Size = new Size(24, 25);
            txtPlayerNum.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(48, 81);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(83, 17);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // txtHobbyID
            // 
            txtHobbyID.Enabled = false;
            txtHobbyID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHobbyID.Location = new Point(167, 36);
            txtHobbyID.Name = "txtHobbyID";
            txtHobbyID.Size = new Size(57, 25);
            txtHobbyID.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(118, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 76);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Hobby";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblHobbyID
            // 
            lblHobbyID.AutoSize = true;
            lblHobbyID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHobbyID.ForeColor = Color.Black;
            lblHobbyID.Location = new Point(48, 43);
            lblHobbyID.Name = "lblHobbyID";
            lblHobbyID.Size = new Size(67, 17);
            lblHobbyID.TabIndex = 0;
            lblHobbyID.Text = "HobbyID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(449, 43);
            label1.Name = "label1";
            label1.Size = new Size(165, 85);
            label1.TabIndex = 21;
            label1.Text = "Insert hobby details into \r\nthe respective boxes and \r\nthen click 'Add Hobby' \r\nbutton to add the hobby \r\ninto the system.\r\n";
            // 
            // frmAddHobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 351);
            Controls.Add(label1);
            Controls.Add(grpAddHobby);
            Controls.Add(mnuStrip);
            MaximizeBox = false;
            Name = "frmAddHobby";
            Text = "Killarney Hobby Shop - Add Hobby";
            Load += frmAddHobby_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            grpAddHobby.ResumeLayout(false);
            grpAddHobby.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuStrip;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuBack;
        private GroupBox grpAddHobby;
        private Label lblDescription;
        private TextBox txtHobbyID;
        private Button btnAdd;
        private Label lblHobbyID;
        private Label lblPrice;
        private Label lblPlayerNum;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtPlayerNum;
        private Label label1;
    }
}