namespace DatabaseConnect
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            mnuStrip = new MenuStrip();
            mnuExit = new ToolStripMenuItem();
            mnuHobbies = new ToolStripMenuItem();
            mnuAddHobby = new ToolStripMenuItem();
            mnuUpdateHobby = new ToolStripMenuItem();
            mnuTables = new ToolStripMenuItem();
            mnuAddTable = new ToolStripMenuItem();
            mnuChangeTable = new ToolStripMenuItem();
            mnuCloseTable = new ToolStripMenuItem();
            mnuReservations = new ToolStripMenuItem();
            mnuMakeReservation = new ToolStripMenuItem();
            mnuCancelReservation = new ToolStripMenuItem();
            mnuCheckInCustomer = new ToolStripMenuItem();
            mnuCheckOutCustomer = new ToolStripMenuItem();
            mnuAdmin = new ToolStripMenuItem();
            mnuYearlyRevenueAnalysis = new ToolStripMenuItem();
            mnuYearlyHobbyAnalysis = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            mnuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mnuStrip
            // 
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { mnuExit, mnuHobbies, mnuTables, mnuReservations, mnuAdmin });
            mnuStrip.Location = new Point(0, 0);
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Padding = new Padding(5, 2, 0, 2);
            mnuStrip.Size = new Size(626, 29);
            mnuStrip.TabIndex = 0;
            mnuStrip.Text = "mnuStrip";
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
            // mnuHobbies
            // 
            mnuHobbies.DropDownItems.AddRange(new ToolStripItem[] { mnuAddHobby, mnuUpdateHobby });
            mnuHobbies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuHobbies.Name = "mnuHobbies";
            mnuHobbies.Size = new Size(85, 25);
            mnuHobbies.Text = "Hobbies";
            // 
            // mnuAddHobby
            // 
            mnuAddHobby.Name = "mnuAddHobby";
            mnuAddHobby.Size = new Size(191, 26);
            mnuAddHobby.Text = "Add Hobby";
            mnuAddHobby.Click += mnuAddHobby_Click;
            // 
            // mnuUpdateHobby
            // 
            mnuUpdateHobby.Name = "mnuUpdateHobby";
            mnuUpdateHobby.Size = new Size(191, 26);
            mnuUpdateHobby.Text = "Update Hobby";
            mnuUpdateHobby.Click += mnuUpdateHobby_Click;
            // 
            // mnuTables
            // 
            mnuTables.DropDownItems.AddRange(new ToolStripItem[] { mnuAddTable, mnuChangeTable, mnuCloseTable });
            mnuTables.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuTables.Name = "mnuTables";
            mnuTables.Size = new Size(70, 25);
            mnuTables.Text = "Tables";
            // 
            // mnuAddTable
            // 
            mnuAddTable.Name = "mnuAddTable";
            mnuAddTable.Size = new Size(183, 26);
            mnuAddTable.Text = "Add Table";
            mnuAddTable.Click += mnuAddTable_Click;
            // 
            // mnuChangeTable
            // 
            mnuChangeTable.Name = "mnuChangeTable";
            mnuChangeTable.Size = new Size(183, 26);
            mnuChangeTable.Text = "Change Table";
            mnuChangeTable.Click += mnuChangeTable_Click;
            // 
            // mnuCloseTable
            // 
            mnuCloseTable.Name = "mnuCloseTable";
            mnuCloseTable.Size = new Size(183, 26);
            mnuCloseTable.Text = "Close Table";
            mnuCloseTable.Click += mnuCloseTable_Click;
            // 
            // mnuReservations
            // 
            mnuReservations.DropDownItems.AddRange(new ToolStripItem[] { mnuMakeReservation, mnuCancelReservation, mnuCheckInCustomer, mnuCheckOutCustomer });
            mnuReservations.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuReservations.Name = "mnuReservations";
            mnuReservations.Size = new Size(120, 25);
            mnuReservations.Text = "Reservations";
            // 
            // mnuMakeReservation
            // 
            mnuMakeReservation.Name = "mnuMakeReservation";
            mnuMakeReservation.Size = new Size(236, 26);
            mnuMakeReservation.Text = "Make Reservation";
            mnuMakeReservation.Click += mnuMakeReservation_Click;
            // 
            // mnuCancelReservation
            // 
            mnuCancelReservation.Name = "mnuCancelReservation";
            mnuCancelReservation.Size = new Size(236, 26);
            mnuCancelReservation.Text = "Cancel Reservation ";
            mnuCancelReservation.Click += mnuCancelReservation_Click;
            // 
            // mnuCheckInCustomer
            // 
            mnuCheckInCustomer.Name = "mnuCheckInCustomer";
            mnuCheckInCustomer.Size = new Size(236, 26);
            mnuCheckInCustomer.Text = "Check-In Customer";
            mnuCheckInCustomer.Click += mnuCheckInCustomer_Click;
            // 
            // mnuCheckOutCustomer
            // 
            mnuCheckOutCustomer.Name = "mnuCheckOutCustomer";
            mnuCheckOutCustomer.Size = new Size(236, 26);
            mnuCheckOutCustomer.Text = "Check-Out Customer";
            mnuCheckOutCustomer.Click += mnuCheckOutCustomer_Click;
            // 
            // mnuAdmin
            // 
            mnuAdmin.DropDownItems.AddRange(new ToolStripItem[] { mnuYearlyRevenueAnalysis, mnuYearlyHobbyAnalysis });
            mnuAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuAdmin.Name = "mnuAdmin";
            mnuAdmin.Size = new Size(73, 25);
            mnuAdmin.Text = "Admin";
            // 
            // mnuYearlyRevenueAnalysis
            // 
            mnuYearlyRevenueAnalysis.Name = "mnuYearlyRevenueAnalysis";
            mnuYearlyRevenueAnalysis.Size = new Size(264, 26);
            mnuYearlyRevenueAnalysis.Text = "Yearly Revenue Analysis";
            mnuYearlyRevenueAnalysis.Click += mnuYearlyRevenueAnalysis_Click;
            // 
            // mnuYearlyHobbyAnalysis
            // 
            mnuYearlyHobbyAnalysis.Name = "mnuYearlyHobbyAnalysis";
            mnuYearlyHobbyAnalysis.Size = new Size(264, 26);
            mnuYearlyHobbyAnalysis.Text = "Yearly Hobby Analysis";
            mnuYearlyHobbyAnalysis.Click += mnuYearlyHobbyAnalysis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(151, 216);
            label1.Name = "label1";
            label1.Size = new Size(315, 94);
            label1.TabIndex = 21;
            label1.Text = "Killarney Hobby Shop\r\nEstablished 2022\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightBlue;
            label2.Location = new Point(12, 328);
            label2.Name = "label2";
            label2.Size = new Size(371, 75);
            label2.TabIndex = 24;
            label2.Text = resources.GetString("label2.Text");
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(626, 439);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mnuStrip);
            MainMenuStrip = mnuStrip;
            MaximizeBox = false;
            Name = "frmMainMenu";
            Text = "Killarney Hobby Shop - Main Menu";
            Load += frmMainMenu_Load;
            mnuStrip.ResumeLayout(false);
            mnuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHobbies;
        private System.Windows.Forms.ToolStripMenuItem mnuTables;
        private System.Windows.Forms.ToolStripMenuItem mnuReservations;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateHobby;
        private System.Windows.Forms.ToolStripMenuItem mnuAddTable;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeTable;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseTable;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeReservation;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelReservation;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckInCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckOutCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyReservationAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyHobbyAnalysis;
        private ToolStripMenuItem mnuAddHobby;
        private ToolStripMenuItem mnuYearlyRevenueAnalysis;
        private Label label1;
        private Label label2;
    }
}