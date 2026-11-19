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

    public partial class frmChangeTable : Form
    {
        frmMainMenu parent;


        public frmChangeTable(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmChangeTable_Load(object sender, EventArgs e)
        {
            DataSet ds = Table.GetOpenTables();
            for (int i = 0; i < ds.Tables["tab"].Rows.Count; i++)
                cboTableNo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0'));
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            //Validation

            if (cboHobbies.Equals(""))
            {
                MessageBox.Show("Hobby must be entered", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Table aTable = new Table();
                //Save Data
                aTable.setTableNo(Convert.ToInt32(txtTableNo.Text));
                aTable.setHobbyID(Convert.ToInt32(cboHobbies.Text.Substring(0, 2)));
                aTable.changeTable();

                //Confirmation Message
                MessageBox.Show("Table Changed (" + txtTableNo.Text + ") Successfully", "Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset
                cboTableNo.SelectedIndex = -1;
                cboHobbies.Items.Clear();
                cboTableNo.Focus();
                grpChangeTable.Visible = false;
            }
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

        private void cboTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTableNo.SelectedIndex == -1)
                return;


            Table aTable = new Table();
            cboTableNo.Text = aTable.getTableNo().ToString();
            int hobbyIndex = 0;
            aTable.getTable(Convert.ToInt32(cboTableNo.Text.Substring(0, 2)));
            cboHobbies.Items.Clear();
            //load all hobbies
            DataSet ds = Hobby.GetAllHobbies();
            for (int i = 0; i < ds.Tables["hob"].Rows.Count; i++)
            {
                cboHobbies.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][1].ToString());

                if (aTable.getHobbyID() == Convert.ToInt32(ds.Tables[0].Rows[i][0]))
                    hobbyIndex = i;
            }

            //set current hobby for selected table
            cboHobbies.SelectedIndex = hobbyIndex;


            aTable.getTable(Convert.ToInt32(cboTableNo.Text.Substring(0,2)));

            //put details into text boxes
            txtTableNo.Text = aTable.getTableNo().ToString();
            cboHobbies.Text = aTable.getHobbyID().ToString();

            grpChangeTable.Visible = true;
        }
        private void cboHobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHobbies.SelectedIndex == -1)
                return;
        }
    }
}
