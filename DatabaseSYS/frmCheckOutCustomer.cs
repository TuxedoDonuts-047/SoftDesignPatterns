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
    public partial class frmCheckOutCustomer : Form
    {
        frmMainMenu parent;
        public frmCheckOutCustomer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
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
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (cboResNo.SelectedIndex == -1)
                return;

            //Save Data
            Reservation aRes = new Reservation();
            aRes.SetResNo(Convert.ToInt32(cboResNo.Text.Substring(0,2)));
            aRes.checkOutCustomer();

            //Confirmation Message
            MessageBox.Show("Customer ("+txtName.Text+") Checked Out", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset
            cboResNo.SelectedIndex = -1;
            RefreshComboBox();
            txtName.Clear();
            txtStatus.Clear();
            cboResNo.Focus();
        }
        private void cboResNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboResNo.SelectedIndex == -1)
                return;

            Reservation aRes = new Reservation();
            aRes.getReservation(Convert.ToInt32(cboResNo.Text.Substring(0, 2)));
            txtName.Text = aRes.GetName();
            txtStatus.Text = aRes.GetStatus();

            if (aRes.GetStatus() != "I")
            {
                MessageBox.Show("This customer is already checked out.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboResNo.Refresh();
                cboResNo.Focus();
                btnCheckOut.Enabled = false;
                return;
            }
            else
            {
                btnCheckOut.Enabled = true;
            }
        }
        private void frmCheckOutCustomer_Load(object sender, EventArgs e)
        {
            DataSet ds = Reservation.getCheckedRes();
            for (int i = 0; i < ds.Tables["res"].Rows.Count; i++)
            {
                cboResNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][3].ToString());
            }
        }
        private void RefreshComboBox()
        {
            cboResNo.Items.Clear();
            DataSet ds = Reservation.getCheckedRes();
            for (int i = 0; i < ds.Tables["res"].Rows.Count; i++)
            {
                cboResNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][3].ToString());
            }
            btnCheckOut.Enabled = false;
        }
    }
}
