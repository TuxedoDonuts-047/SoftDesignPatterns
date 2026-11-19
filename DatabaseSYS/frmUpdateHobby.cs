using DatabaseConnect;
using System.Data;

namespace DatabaseConnect
{
    public partial class frmUpdateHobby : Form
    {
        frmMainMenu parent;
        

        public frmUpdateHobby(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmUpdateHobby_Load(object sender, EventArgs e)
        {
            loadHobbies();
        }

        //loadHobbies() - this collects the data for the dropdown menu
        public void loadHobbies()
        {
            DataSet ds = Hobby.GetAllHobbies();
            for (int i = 0; i < ds.Tables["hob"].Rows.Count; i++)
                cboHobbyID.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(2, '0') + " - " +
                ds.Tables[0].Rows[i][1].ToString());
        }
        private void cboHobbyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hobby aHobby = new Hobby();
            cboHobbyID.Text = aHobby.GetHobbyID().ToString();

            if (cboHobbyID.SelectedIndex == -1)
                return;

            aHobby.getHobby(Convert.ToInt32(cboHobbyID.Text.Substring(0, 2)));

            //put details into text boxes
                txtHobbyID.Text = aHobby.GetHobbyID().ToString();
                txtDescription.Text = aHobby.GetDescription();
                txtPlayerNum.Text = aHobby.GetPlayerNum().ToString();
                txtPrice.Text = aHobby.GetPrice().ToString();

            grpUpdateHobby.Visible = true;
        }

        private void btnUpdateHobby_Click(object sender, EventArgs e)
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
            MessageBox.Show($"Hobby ({hobbyId}) Updated Successfully", "Confirm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
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

        //ResetForm()
        private void ResetForm()
        {
            grpUpdateHobby.Visible = false;
            cboHobbyID.Focus();
            cboHobbyID.SelectedIndex = -1;
            txtDescription.Clear();
            txtPlayerNum.Clear();
            txtPrice.Clear();
            txtDescription.Focus();
        }
    }
}
