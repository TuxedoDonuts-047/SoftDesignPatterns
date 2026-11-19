using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DatabaseConnect
{
    public partial class frmAddTable : Form
    {
        frmMainMenu parent;
        public frmAddTable(frmMainMenu parent)
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
            parent.Visible = true; //(For Main Menu)
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(cboHobbyID.Text))
            {
                MessageBox.Show("HobbyID must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHobbyID.Focus();
                return;
            }
            else
            {
                //Save Data
                Table aTable = new Table(Convert.ToInt32(txtTableNo.Text), Convert.ToInt32(cboHobbyID.Text.Substring(0, 2)),"O");
                aTable.addTable();
            }

            //Confirmation Message
            MessageBox.Show("Table (" + txtTableNo.Text + ") Set Successfully", "Confirm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset
            txtTableNo.Text=Table.GetNextTableNo().ToString();
            cboHobbyID.SelectedIndex = -1;
            cboHobbyID.Focus();
        }

        private void cboHobbyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHobbyID.SelectedIndex == -1)
                return;
            //put details into text boxes
            if (cboHobbyID.Equals(""))
            {
                MessageBox.Show("HobbyID must be entered","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Hobby aHobby = new Hobby();
            cboHobbyID.Text = aHobby.GetHobbyID().ToString();
            aHobby.getHobby(Convert.ToInt32(cboHobbyID.Text.Substring(0, 2)));

        }

        private void frmAddTable_Load(object sender, EventArgs e)
        {
            txtTableNo.Text = Table.GetNextTableNo().ToString();
            loadHobbies();
        }

        public void loadHobbies()
        {
            DataSet ds = Hobby.GetAllHobbies();
            for (int i = 0; i < ds.Tables["hob"].Rows.Count; i++)
                cboHobbyID.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][1].ToString());
        }
    }
}
