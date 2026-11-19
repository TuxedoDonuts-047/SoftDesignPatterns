using DatabaseConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnect
{
    public partial class frmMainMenu : Form
    {

        public frmMainMenu()
        {
            InitializeComponent();
        }
        //Exit button
        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are " +
            "you sure?", "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        //Add Hobby
        private void mnuAddHobby_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddHobby nextForm = new frmAddHobby(this);
            nextForm.Show();
        }

        //Update Hobby
        private void mnuUpdateHobby_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateHobby nextForm = new frmUpdateHobby(this);
            nextForm.Show();
        }

        //Add Table
        private void mnuAddTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddTable nextForm = new frmAddTable(this);
            nextForm.Show();
        }

        //Change Table
        private void mnuChangeTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangeTable nextForm = new frmChangeTable(this); 
            nextForm.Show();
        }

        //Close Table
        private void mnuCloseTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCloseTable nextForm = new frmCloseTable(this); 
            nextForm.Show();
        }

        //Make Reservation
        private void mnuMakeReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeReservation nextForm = new frmMakeReservation(this); 
            nextForm.Show();
        }

        //Cancel Reservation
        private void mnuCancelReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelReservation nextForm = new frmCancelReservation(this); 
            nextForm.Show();
        }

        //Check-In Customer
        private void mnuCheckInCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckInCustomer nextForm = new frmCheckInCustomer(this); 
            nextForm.Show();
        }

        //Check-Out Customer
        private void mnuCheckOutCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckOutCustomer nextForm = new frmCheckOutCustomer(this); 
            nextForm.Show();
        }

        //Yearly Reservation Analysis (yearlyRevenueAnalysis.cs)
        private void mnuYearlyRevenueAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenue nextForm = new frmYearlyRevenue(this); 
            nextForm.Show();
        }

        //Load
        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }


        //Yearly Hobby Analysis
        private void mnuYearlyHobbyAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyHobby nextForm = new frmYearlyHobby(this); 
            nextForm.Show();
        }
    }
}
