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
    public partial class frmYearlyRevenue : Form
    {
        frmMainMenu parent;
        public frmYearlyRevenue(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are " +
          "you sure?", "Confirm",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdRevenue.Visible = true;
        }

        private void frmYearlyRevenue_Load(object sender, EventArgs e)
        {
            grdRevenue.DataSource = Reservation.GetAverageRevenue().Tables["res"];

            /* Start of Code
             Title: How to Format a DataGridView
             Author:Catherine Woods.
             Site Canvas
             Site Owner: Canvas
             Date: 2024
             Version: Unknown 
             Availability: https://mtukerry.instructure.com/courses/4920/files/788398?module_item_id=254771 (Accessed 12/08/2025)
             Modifications: Changed columns to relate to grdRevenue.
           */
            grdRevenue.Columns["HobbyID"].DefaultCellStyle.Format = "0";
            grdRevenue.Columns["HobbyID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
           
            grdRevenue.Columns["Description"].DefaultCellStyle.Format = "000";
            grdRevenue.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          
            grdRevenue.Columns["Total_Res"].DefaultCellStyle.Format = "000";
            grdRevenue.Columns["Total_Res"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         
            grdRevenue.Columns["Total_Rev_Eur"].DefaultCellStyle.Format = "C2";
            grdRevenue.Columns["Total_Rev_Eur"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            grdRevenue.Columns["Avg_Rev_Eur"].DefaultCellStyle.Format = "C2";
            grdRevenue.Columns["Avg_Rev_Eur"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            /*End of Code*/
        }

        private void grdRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdRevenue.DataSource = Reservation.GetAverageRevenue().Tables["res"];
        }
    }
}
