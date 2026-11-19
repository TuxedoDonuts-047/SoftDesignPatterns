using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnect;

public partial class frmCancelReservation : Form
{
    frmMainMenu parent;
    public frmCancelReservation(frmMainMenu parent)
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

    private void btnCancelReservation_Click(object sender, EventArgs e)
    {
        if (cboResNo.Equals(""))
        {
            MessageBox.Show("ResNo must be entered", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            cboResNo.Focus();
            return;
        }

        Reservation aRes = new Reservation();
        aRes.SetResNo(Convert.ToInt32(cboResNo.Text.Substring(0,2)));
        aRes.cancelReservation();

        //Confirmation Message
        MessageBox.Show("Reservation ("+cboResNo.Text+")Cancelled Successfully", "Confirm",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        //Reset
        txtHobbyID.Clear();
        txtTableNo.Clear(); 
        txtPhoneNo.Clear(); 
        txtEmail.Clear();
        txtName.Clear();
        cboResNo.SelectedIndex = -1;
        cboResNo.Focus();
        grpCancelReservation.Visible=false;

    }

    private void cboResNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        Reservation aRes = new Reservation();
        cboResNo.Text = aRes.GetResNo().ToString();
        if (cboResNo.SelectedIndex == -1)
            return;

        aRes.getReservation(Convert.ToInt32(cboResNo.Text.Substring(0, 2)));

        txtTableNo.Text = aRes.GetTableNo().ToString();
        txtHobbyID.Text = aRes.GetHobbyID().ToString();
        txtName.Text = aRes.GetName();
        txtPhoneNo.Text = aRes.GetPhoneNo();
        txtEmail.Text = aRes.GetEmail();
        grpCancelReservation.Visible = true;
        btnCancelReservation.Visible = true;
    }

    private void frmCancelReservation_Load(object sender, EventArgs e)
    {
        DataSet ds = Reservation.getBookedRes();
        for (int i = 0; i < ds.Tables["res"].Rows.Count; i++)
            cboResNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][3].ToString()); 
    }
}
