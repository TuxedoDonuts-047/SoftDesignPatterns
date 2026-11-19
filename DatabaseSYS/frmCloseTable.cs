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
    public partial class frmCloseTable : Form
    {
        frmMainMenu parent;
        Table aTable = new Table();
        public frmCloseTable(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void btnCloseTable_Click(object sender, EventArgs e)
        {
            if (txtHobbies.Equals(""))
            {
                MessageBox.Show("HobbyID must be entered", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHobbies.Focus();
                return;
            }

            if (aTable.getStatus().Equals("C"))
            {
                MessageBox.Show("Table was already closed", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {    
                //Save Data
                Table aTable = new Table();
                aTable.setTableNo(Convert.ToInt32(txtTableNo.Text));
                aTable.setStatus("C");

                aTable.closeTable();

                //Confirmation Message
                MessageBox.Show("Table (" + cboTableNo.Text + ") Closed Successfully", "Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset
                cboTableNo.SelectedIndex = -1;
                RefreshComboBox();
                grpCloseTable.Visible = false;
                cboTableNo.Focus();
            }
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void cboTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTableNo.SelectedIndex == -1)
                return;

            Table aTable = new Table();
            cboTableNo.Text = aTable.getTableNo().ToString();
            int hobbyIndex = 0;
            aTable.getTable(Convert.ToInt32(cboTableNo.Text.Substring(0, 2)));

            //Validation
            if (aTable.getStatus().Equals("C"))
            {
                MessageBox.Show("Table was already closed", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cboTableNo.Text = aTable.getTableNo().ToString() + aTable.getHobbyID().ToString();

                if (cboTableNo.SelectedIndex == -1)
                    return;

                aTable.getTable(Convert.ToInt32(cboTableNo.Text.Substring(0, 2)));

                //put details into text boxes
                txtTableNo.Text = aTable.getTableNo().ToString();
                txtHobbies.Text = aTable.getHobbyID().ToString();

                grpCloseTable.Visible = true;
            }
            btnCloseTable.Enabled = true;
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
        private void frmCloseTable_Load(object sender, EventArgs e)
        {
            DataSet ds = Table.GetOpenTables();
            for (int i = 0; i < ds.Tables["tab"].Rows.Count; i++)
                cboTableNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][1].ToString());
        }

        private void RefreshComboBox()
        {
            cboTableNo.Items.Clear();
            DataSet ds = Table.GetOpenTables();
            for (int i = 0; i < ds.Tables["tab"].Rows.Count; i++)
            {
                cboTableNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][2].ToString());
            }
            btnCloseTable.Enabled = false;
        }
    }
}
