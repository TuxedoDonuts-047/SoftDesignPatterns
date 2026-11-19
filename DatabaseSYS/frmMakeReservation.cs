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
    public partial class frmMakeReservation : Form
    {
        frmMainMenu parent;
        public frmMakeReservation(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (txtTableNo.Text.Equals(""))
            {
                MessageBox.Show("TableNo must be entered. If none, then there are none available, please inform customer", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTableNo.Focus();
                return;
            }

            if (cboHobbyID.Equals(""))
            {
                MessageBox.Show("HobbyID must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHobbyID.Focus();
                return;
            }

            if (dtpTime.Text.Equals(""))
            {
                MessageBox.Show("Time must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpTime.Focus();
                return;
            }

            //Time
            TimeSpan selectedTime = dtpTime.Value.TimeOfDay;
            TimeSpan start = new TimeSpan(9, 30, 0);  // 09:30
            TimeSpan end = new TimeSpan(19, 0, 0);  // 19:00

            if (selectedTime < start || selectedTime > end)
            {
                MessageBox.Show("Time must be between 09:30 and 19:00", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpTime.Focus();
                return;
            }

            //Date
            DateTime selectedDate = dtpDate.Value.Date;
            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Reservation date cannot be in the past", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDate.Focus();
                return;
            }
            grpContact.Visible = true;
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
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //txtName
            if (txtName.Equals(""))
            {
                MessageBox.Show("Name must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            else if (txtName.Text.Length > 40)
            {
                MessageBox.Show("Name must less or equal 40 letters", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            //txtPhone
            if (txtPhone.Equals(""))
            {
                MessageBox.Show("Phone No must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            else if (txtPhone.Text.Length > 15)
            {
                MessageBox.Show("Phone must be 15 numbers long", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            //txtEmail
            if (txtEmail.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if(txtEmail.Text.Length > 20) {
                MessageBox.Show("Email must be a text length of 20", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            //txtCardNo
            if (txtCardNo.Equals(""))
            {
                MessageBox.Show("CardNo must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNo.Focus();
                return;
            }
            else if (txtCardNo.Text.Length > 12)
            {
                MessageBox.Show("CardNo must be 12 numbers long", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNo.Focus();
                return;
            }

            //if all values are empty
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCardNo.Text))
            {
                MessageBox.Show("Customer Details must be entered", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPhone.Text))
                {
                    txtPhone.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtCardNo.Text))
                {
                    txtCardNo.Focus();
                    return;
                }


            }
            TimeSpan selectedTime = dtpTime.Value.TimeOfDay;
            TimeSpan start = new TimeSpan(9, 30, 0);  // 09:30
            TimeSpan end = new TimeSpan(19, 0, 0);  // 19:00
            if (selectedTime < start || selectedTime > end)
            {
                MessageBox.Show("Time must be between 09:30 and 19:00", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpTime.Focus();
                return;
            }
            else 
            {
                Reservation aRes = new Reservation(Convert.ToInt32(txtResNo.Text),
                                                    Convert.ToInt32(cboHobbyID.Text.Substring(0, 2)),
                                                    Convert.ToInt32(txtTableNo.Text),
                                                    Convert.ToString(txtName.Text),
                                                    Convert.ToString(txtPhone.Text),
                                                    Convert.ToString(txtEmail.Text),
                                                    Convert.ToString(dtpDate.Text.Substring(0,10)),
                                                    Convert.ToString(dtpTime.Text),
                                                    Convert.ToString(txtCardNo.Text),
                                                    ("B"));//B is for Booked*/
                aRes.makeReservation();

                //Confirmation Message
                MessageBox.Show("Reservation (" + txtResNo.Text + ") Booked Successfully", "Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset
                txtResNo.Text = Reservation.GetNextResNo().ToString();
                grpContact.Visible = false;
                grpTableSelect.Visible = false;
                cboTableSelect.SelectedIndex = -1;
                cboHobbyID.SelectedIndex = -1;
                cboHobbyID.Focus();
                txtName.Clear();
                txtTableNo.Clear();
                txtPhone.Clear();
                txtCardNo.Clear();
                txtEmail.Clear();
            }
        }
        private void grpMakeReservation_Enter(object sender, EventArgs e)
        {
            if (cboTableSelect.Equals(""))
            {
                MessageBox.Show("Table and date must be entered", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTableSelect.Focus();
            }
            else if (cboTableSelect.Equals("") && dtpDate.Equals(""))
            {
                MessageBox.Show("Table and date must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTableSelect.Focus();
                dtpDate.Focus();
            }
            btnMakeReservation.Enabled = true;
        }
        private void cboTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTableSelect.SelectedIndex == -1)
                return;
            //put details into text boxes

            txtTableNo.Text = cboTableSelect.Text.Substring(0, 2);
        }
        private void cboHobbyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHobbyID.SelectedIndex == -1)
                return;
            grpTableSelect.Visible = true;
            grpMakeReservation.Visible = true;

            int hob = Convert.ToInt32(cboHobbyID.Text.Substring(0, 2));
            if (hob < 0)
            {
                MessageBox.Show("Please select a valid hobby first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpTableSelect.Visible = false;
                return;
            }

            DataSet ta = Table.GetHobbyTable(Convert.ToInt32(cboHobbyID.Text.Substring(0, 2)));
            /* Start of Code
              Title: How to clear all Data in a TextBox? - Mike 
              Author:Ash Burlaczenko.
              Site Owner: stackoverflow.com
              Date: 14/02/2011 (Modified 11/06/2011)
              Version: Unknown 
              Availability: https://stackoverflow.com/questions/6442098/how-to-clear-all-data-in-a-listbox (Accessed 01/08/2025)
              Modifications: Changed list to be the cboTableSelect.
            */
            cboTableSelect.Items.Clear();
            /*End of Code*/
            for (int i = 0; i < ta.Tables["tab"].Rows.Count; i++)
            {
                cboTableSelect.Items.Add(ta.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ta.Tables[0].Rows[i][1].ToString());
            }
        }
        private void frmMakeReservation_Load(object sender, EventArgs e)
        {
            txtResNo.Text = Reservation.GetNextResNo().ToString();
            dtpDate.MinDate = DateTime.Today;
            DataSet ds = Hobby.GetAllHobbies();
            for (int i = 0; i < ds.Tables["hob"].Rows.Count; i++)
            {
                cboHobbyID.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][1].ToString());
            }
            //Relocated the cboTableSelect to cboHobbyID_SelectedIndexChanged to ensure that it activates once CboHobbyID is used
        }
    }
}
