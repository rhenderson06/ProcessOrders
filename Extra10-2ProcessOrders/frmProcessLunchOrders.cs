using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra10_2ProcessOrders
{
    public partial class frmProcessLunchOrders : Form
    {
        public frmProcessLunchOrders()
        {
            InitializeComponent();
        }

        const decimal HAMBURGER = 7.95m;
        const decimal PIZZA     = 6.95m;
        const decimal SALAD     = 6.75m;
        const decimal TAX       = .0775m;
        const decimal ADDON     = 1.25m;

        decimal subtotal = 0m;
        decimal total = 0m;
        decimal main;
        decimal extra;
        decimal showTax;

        private void btnOrder_Click(object sender, EventArgs e)
        {
            CalculateOrder();
        }

        private void CalculateOrder()
        {
            if (rdoHamburger.Checked)
            {
                main = HAMBURGER;
            }
            else if (rdoPizza.Checked)
            {
                main = PIZZA;
            }
            else
            {
                main = SALAD;
            }

            for (int i = 0; i < 2; i++)
            {
                if (chkFries.Checked)
                {
                    extra += ADDON;
                }
                else if (chkLTO.Checked)
                {
                    extra += ADDON;
                }
                else if (chkKMM.Checked)
                {
                    extra += ADDON;
                }
                else 
                { 
                    extra = 0; 
                }
            }

            subtotal = main + extra;
            showTax = subtotal * TAX;
            total = subtotal + showTax;

            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = showTax.ToString("c");
            txtTotal.Text = total.ToString("c");
        }

        private void btnClearTotal_Click(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void btnClearAddOns_Click(object sender, EventArgs e)
        {
            ClearAddOns();
        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls();
            ClearTotals();
            ClearAddOns();
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            DisableControls();
            ClearTotals();
            ClearAddOns();
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            DisableControls();
            ClearTotals();
            ClearAddOns();
        }

        private void EnableControls()
        {
            chkLTO.Enabled = true;
            chkKMM.Enabled = true;
        }

        private void DisableControls()
        {
            chkLTO.Enabled = false;
            chkKMM.Enabled = false;
        }

        private void ClearAddOns()
        {
            chkLTO.Checked = false;
            chkKMM.Checked = false;
            chkFries.Checked = false;
        }

        private void ClearTotals()
        {
            txtSubtotal.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotal.Text = string.Empty;
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
    }
}
