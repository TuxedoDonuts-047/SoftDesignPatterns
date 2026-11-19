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
    public partial class frmYearlyHobby : Form
    {
        frmMainMenu parent;
        public frmYearlyHobby(frmMainMenu parent)
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
            grdHobby.Visible = true;
        }

        private void grdHobbies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdHobby.DataSource = Hobby.GetTotalHobbies().Tables["hob"];
        }

        private void frmYearlyHobby_Load(object sender, EventArgs e)
        {
            grdHobby.DataSource = Hobby.GetTotalHobbies().Tables["hob"];

            /* Start of Code
             Title: How to Format a DataGridView
             Author:Catherine Woods.
             Site: Canvas
             Site Owner: Instructure
             Date: 2024
             Version: Unknown 
             Availability: https://mtukerry.instructure.com/courses/4920/files/788398?module_item_id=254771 (Accessed 12/08/2025)
             Modifications: Changed columns to relate to grdHobby.
           */
            grdHobby.Columns["HobbyID"].DefaultCellStyle.Format = "0";
            grdHobby.Columns["HobbyID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdHobby.Columns["Description"].DefaultCellStyle.Format = "000";
            grdHobby.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdHobby.Columns["Price"].DefaultCellStyle.Format = "C2";
            grdHobby.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grdHobby.Columns["Total_Year"].DefaultCellStyle.Format = "C2";
            grdHobby.Columns["Total_Year"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            /*End of Code*/
        }
    }
}
