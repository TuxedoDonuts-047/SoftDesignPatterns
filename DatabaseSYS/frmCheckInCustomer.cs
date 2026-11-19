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
    public partial class frmCheckInCustomer : Form
    {
        frmMainMenu parent;
        public frmCheckInCustomer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnCheckInCustomer_Click(object sender, EventArgs e)
        {
            if (cboResNo.Equals(""))
            {
                btnCheckInCustomer.Enabled = false;
            }

            //Save Data
            Reservation aRes = new Reservation();
            aRes.SetResNo(Convert.ToInt32(cboResNo.Text.Substring(0,2)));
            aRes.checkInCustomer();

            //Confirmation Message
            MessageBox.Show("Customer ("+txtName.Text+") Checked In", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset
            cboResNo.Items.Remove(cboResNo.SelectedItem);
            cboResNo.SelectedIndex = -1;
            txtName.Clear();
            txtDate.Clear();
            txtTime.Clear();
            grpCheckInCustomer.Visible = false;
            cboResNo.Focus();
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
            parent.Visible = true; //(For Main Menu)
        }
        private void cboResNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboResNo.Equals(""))
            {
                MessageBox.Show("ResNo must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboResNo.Focus();
            }

            else
            {
                grpCheckInCustomer.Visible = true;
                Reservation aRes = new Reservation();
                txtName.Text = aRes.GetName();
                txtDate.Text = aRes.GetResDate();
                txtTime.Text = aRes.GetResTime();
            }
        }
        private void cboResNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboResNo.SelectedIndex == -1)
                return;
            Reservation aRes = new Reservation();
            cboResNo.Text = aRes.GetResNo().ToString();
            aRes.getReservation(Convert.ToInt32(cboResNo.Text.Substring(0, 2)));

            if (aRes.GetStatus().Equals("O"))
            {
                MessageBox.Show("Reservation was already checked out", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboResNo.Focus();
                return;
            }

            //Checks Date with system date. currently in progress
            DateTime currentDate = Convert.ToDateTime(aRes.GetResDate());
            if (currentDate != System.DateTime.Today){
                MessageBox.Show("Reservation is not current.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboResNo.Focus();
                return;
            }

            else
            {
                if (cboResNo.SelectedIndex == -1)
                    return;
                txtName.Text = aRes.GetName();
                txtDate.Text = aRes.GetResDate();
                txtTime.Text = aRes.GetResTime();
                grpCheckInCustomer.Visible = true;
            }
        }
        private void frmCheckInCustomer_Load(object sender, EventArgs e)
        {
            DataSet ds = Reservation.checkDateCustomer();
            for (int i = 0; i < ds.Tables["res"].Rows.Count; i++)
            {
                cboResNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][3].ToString());
            }
        }
    }
}
