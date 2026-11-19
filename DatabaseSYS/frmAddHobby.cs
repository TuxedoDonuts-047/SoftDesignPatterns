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
    public partial class frmAddHobby : Form
    {
        private readonly frmMainMenu parent;

        public frmAddHobby(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Call the separated validation class
            bool isValid = HobbyValidation.ValidateHobbyInput(
                txtDescription.Text,
                txtPlayerNum.Text,
                txtPrice.Text,
                out string errorMsg,
                out int playerNum,
                out decimal price
            );

            // Handle errors natively in the UI layer
            if (!isValid)
            {
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save Data using the pre-parsed safe fields
            int hobbyId = Convert.ToInt32(txtHobbyID.Text);
            Hobby aHobby = new Hobby(hobbyId, txtDescription.Text.Trim(), playerNum, price);
            aHobby.addHobby();

            // Confirmation Message
            MessageBox.Show($"Hobby ({hobbyId}) Set Successfully", "Confirm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
        }

        private void frmAddHobby_Load(object sender, EventArgs e)
        {
            LoadNextHobbyID();
        }

        //ResetForm()
        private void ResetForm()
        {
            LoadNextHobbyID();
            txtDescription.Clear();
            txtPlayerNum.Clear();
            txtPrice.Clear();
            txtDescription.Focus();
        }

        //HobbyID goes up by 1 after a new hobby is created
        private void LoadNextHobbyID()
        {
            txtHobbyID.Text = Hobby.GetNextHobbyID().ToString();
        }
    }
}
