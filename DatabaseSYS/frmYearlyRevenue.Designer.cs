namespace DatabaseConnect
{
    partial class frmYearlyRevenue
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            mnuStrip = new MenuStrip();
            mnuExit = new ToolStripMenuItem();
            mnuBack = new ToolStripMenuItem();
            lblYear = new Label();
            cboYear = new ComboBox();
            grdRevenue = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdRevenue).BeginInit();
            SuspendLayout();
            // 
            // mnuStrip
            // 
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuExit, mnuBack });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Padding = new Padding(5, 2, 0, 2);
            mnuStrip.Size = new Size(906, 29);
            mnuStrip.TabIndex = 13;
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
            mnuBack.TextAlign = ContentAlignment.MiddleLeft;
            mnuBack.Click += mnuBack_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.Location = new Point(10, 45);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(48, 21);
            lblYear.TabIndex = 15;
            lblYear.Text = "Year:";
            // 
            // cboYear
            // 
            cboYear.AutoCompleteCustomSource.AddRange(new string[] { "001", "002", "003", "004", "005" });
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboYear.FormattingEnabled = true;
            cboYear.Items.AddRange(new object[] { "2024", "2023", "2022" });
            cboYear.Location = new Point(64, 42);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(72, 29);
            cboYear.TabIndex = 16;
            cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;
            // 
            // grdRevenue
            // 
            dataGridViewCellStyle1.NullValue = null;
            grdRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdRevenue.DefaultCellStyle = dataGridViewCellStyle3;
            grdRevenue.Location = new Point(10, 73);
            grdRevenue.Name = "grdRevenue";
            grdRevenue.RowHeadersWidth = 51;
            dataGridViewCellStyle4.NullValue = null;
            grdRevenue.RowsDefaultCellStyle = dataGridViewCellStyle4;
            grdRevenue.RowTemplate.Height = 24;
            grdRevenue.Size = new Size(551, 397);
            grdRevenue.TabIndex = 17;
            grdRevenue.Visible = false;
            grdRevenue.CellContentClick += grdRevenue_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(163, 50);
            label1.Name = "label1";
            label1.Size = new Size(241, 17);
            label1.TabIndex = 22;
            label1.Text = "Select year to display revenue details.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(576, 124);
            label2.Name = "label2";
            label2.Size = new Size(102, 85);
            label2.TabIndex = 23;
            label2.Text = "1. HobbyID\r\n2. Description\r\n3. Total_Res\r\n4. Total_Rev (€)\r\n5. Avg_Rev (€)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(576, 74);
            label3.Name = "label3";
            label3.Size = new Size(317, 34);
            label3.TabIndex = 26;
            label3.Text = "This chart analysies the total reservations, total \r\nrevenue and average revenue per year per hobby. \r\n";
            // 
            // frmYearlyRevenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 479);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grdRevenue);
            Controls.Add(cboYear);
            Controls.Add(lblYear);
            Controls.Add(mnuStrip);
            MaximizeBox = false;
            Name = "frmYearlyRevenue";
            Text = "Killarney Hobby Shop - Yearly Revenue Analysis";
            Load += frmYearlyRevenue_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdRevenue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private DataGridView grdRevenue;
        private Label lblKey;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}