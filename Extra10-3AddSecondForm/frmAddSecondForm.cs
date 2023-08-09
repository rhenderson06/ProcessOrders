using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra10_3AddSecondForm
{
    public partial class frmAddSecondForm : Form
    {
        public frmAddSecondForm()
        {
            InitializeComponent();
        }

        private void btnChangeTax_Click(object sender, EventArgs e)
        {
            frmChangeTax changeTax = new frmChangeTax();

            changeTax.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtProdTotal.Text = string.Empty;
            txtDisAmount.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtProdTotal.Focus();
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
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
