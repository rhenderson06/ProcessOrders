using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra10_3AddSecondForm
{
    public partial class frmChangeTax : Form
    {
        public frmChangeTax()
        {
            InitializeComponent();
        }

        string msg;

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool keepGoing = IsPresent(txtSalesTax.Text, txtSalesTax.Tag.ToString());

            if (keepGoing)
            {
                keepGoing = IsDecimal(txtSalesTax.Text, txtSalesTax.Tag.ToString());
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

        private bool IsDecimal(string value, string name)
        {
            bool retVal = true;
            decimal outVar;

            if (!Decimal.TryParse(value, out outVar))
            {
                ShowMessage($"{name} must be a valid decimal", "Error");
                retVal = false;
            }
            else if (outVar <= 0)
            {
                ShowMessage($"{name} must be greater than zero", "Error");
                retVal = false;
            }

            return retVal;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
