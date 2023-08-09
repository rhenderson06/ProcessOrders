using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace Extra9_2Strings
{
    public partial class frmStrings : Form
    {
        public frmStrings()
        {
            InitializeComponent();
        }

        const string CSZ = "City, State, Zip";

        string msg;

        private void btnParse_Click(object sender, EventArgs e)
        {
            bool result = true;

            try
            {
                //check for empty text box
                result = IsPresent(txtEmail.Text, txtEmail.Tag.ToString());
                //if email is empty
                if (!result)
                {
                    throw new ArgumentNullException();
                }

                //email has @sign
                result = HasAtSign(txtEmail.Text, txtEmail.Tag.ToString());
                if (!result)
                {
                    throw new FormatException();
                }

                ParseEmail();
            }
            catch (ArgumentNullException ane)
            {
                ShowMessage(ane.Message, "No email inputted");
                txtEmail.Focus();
            }
            catch (FormatException fe)
            {
                ShowMessage(fe.Message, "Invalide Email");
            }
        }

        private bool IsPresent(string value, string name)
        {
            bool retVal = true;
            msg = "";

            if (value.Trim() == "")
            {
                msg = $"{name} is required\n";
                retVal = false;
            }

            return retVal;
        }

        private bool HasAtSign(string value, string name)
        {
            bool retVal = true;
            string email = value;
            msg = "";

            if (!email.Contains("@"))
            {
                msg = $"{name} is an invalid email";
                retVal = false;
            }

            return retVal;
        }

        private void ParseEmail()
        {
            string email = txtEmail.Text.Trim();
            string user;
            string domain;

            string[] splitEmail = email.Split('@');
            user = splitEmail[0];
            domain = splitEmail[1];

            if ((user == "") || (domain == ""))
            {
                ShowMessage("Invalid email", "Error");
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            ShowMessage($"User name: {user} \nDomain name: {domain}", "Parsed String");
            txtEmail.Text = "";
            txtEmail.Focus();
            return;
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            bool result;

            try
            {
                result = IsPresent(txtCity.Text, txtCity.Tag.ToString());
                if (!result)
                {
                    throw new ArgumentNullException();
                }
                
                result = IsPresent(txtState.Text, txtState.Tag.ToString());
                if (!result)
                {
                    throw new ArgumentNullException();
                }

                result = IsPresent(txtZip.Text, txtZip.Tag.ToString());
                if (!result)
                {
                    throw new ArgumentNullException();
                }

                FormatAddress();

            }
            catch (ArgumentNullException ane)
            {
                ShowMessage(ane.Message, "No input");
            }
        }

        private void FormatAddress()
        {
            string city  = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            string zip   = txtZip.Text.Trim();

            string output = $"{CSZ}:\t{city}, {state.ToUpper()} {zip}";

            ShowMessage(output, "Formatted String");
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtEmail.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZip.Text = string.Empty;
            txtEmail.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            DialogResult dialog = MessageBox.Show(
                "Do you really want to exit?",
                "Exit Now",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
