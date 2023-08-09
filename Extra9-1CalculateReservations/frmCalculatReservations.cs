using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra9_1CalculateReservations
{
    public partial class frmCalculatReservations : Form
    {
        public frmCalculatReservations()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtArrDate.Text = string.Empty;
            txtDepartDate.Text = string.Empty;
            txtNights.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtAverage.Text = string.Empty;
            txtArrDate.Focus();
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
