namespace DatabaseConnect
{
    partial class frmYearlyHobby
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
            lblYear = new Label();
            cboYear = new ComboBox();
            grdHobby = new DataGridView();
            lblKey = new Label();
            label2 = new Label();
            label1 = new Label();
            mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdHobby).BeginInit();
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
            mnuStrip.Size = new Size(780, 29);
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
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.Location = new Point(30, 41);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(48, 21);
            lblYear.TabIndex = 4;
            lblYear.Text = "Year:";
            // 
            // cboYear
            // 
            cboYear.AutoCompleteCustomSource.AddRange(new string[] { "001", "002", "003", "004", "005" });
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboYear.FormattingEnabled = true;
            cboYear.Items.AddRange(new object[] { "2024", "2023", "2022" });
            cboYear.Location = new Point(84, 38);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(75, 29);
            cboYear.TabIndex = 14;
            cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;
            // 
            // grdHobby
            // 
            grdHobby.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            grdHobby.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdHobby.Location = new Point(10, 76);
            grdHobby.Name = "grdHobby";
            grdHobby.RowHeadersWidth = 51;
            grdHobby.RowTemplate.Height = 24;
            grdHobby.Size = new Size(453, 397);
            grdHobby.TabIndex = 15;
            grdHobby.Visible = false;
            grdHobby.CellContentClick += grdHobbies_CellContentClick;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblKey.Location = new Point(175, 47);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(231, 17);
            lblKey.TabIndex = 21;
            lblKey.Text = "Select year to display hobby details.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(469, 119);
            label2.Name = "label2";
            label2.Size = new Size(106, 68);
            label2.TabIndex = 24;
            label2.Text = "1. HobbyID\r\n2. Description\r\n3. Price (€)\r\n4. Total_Year (€)\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(469, 76);
            label1.Name = "label1";
            label1.Size = new Size(303, 34);
            label1.TabIndex = 25;
            label1.Text = "This chart analysies the total money per hobby \r\nin a year. \r\n";
            // 
            // frmYearlyHobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 485);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblKey);
            Controls.Add(grdHobby);
            Controls.Add(cboYear);
            Controls.Add(lblYear);
            Controls.Add(mnuStrip);
            MaximizeBox = false;
            Name = "frmYearlyHobby";
            Text = "Killarney Hobby Shop - Yearly Hobby Analysis";
            Load += frmYearlyHobby_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdHobby).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataGridView grdHobby;
        private Label lblKey;
        private Label label2;
        private Label label1;
    }
}