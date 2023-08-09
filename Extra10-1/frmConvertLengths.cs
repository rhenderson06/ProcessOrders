using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra10_1
{
    public partial class frmConvertLengths : Form
    {
        public frmConvertLengths()
        {
            InitializeComponent();
        }

        const decimal MILESTOKILOS  = 1.6093m;
        const decimal KILOTOMILES   = 0.6214m;
        const decimal FEETTOMETERS  = 0.3048m;
        const decimal METERSTOFEET  = 3.2808m;
        const decimal INCHESTOCENTS = 2.54m;
        const decimal CENTSTOINCHES = 0.3937m;

        //global array
        string[] conversions =
        {
            "Please select conversion",
            "Miles to Kilometers",
            "Kilometers to Miles",
            "Feet to Meters",
            "Meters to Feet",
            "Inches to Centimeters",
            "Centimeters to Inches"
        };

        private void frmConvertLengths_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < conversions.Length; i++)
            {
                cmbConversion.Items.Add(conversions[i]);
            }

            cmbConversion.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            RunProgram();
        }

        private void RunProgram()
        {
            decimal fromVal = 0m;
            decimal toVal = 0m;

            bool keepGoing = CmbBoxGreaterThanZero();

            if (keepGoing)
            {
                keepGoing = IsDecimal(txtFrom.Text, txtFrom.Tag.ToString());
            }
            else
            {
                cmbConversion.Focus();
                return;
            }

            if (keepGoing)
            {
                PerformConversion(ref fromVal, ref toVal);
            }
            else
            {
                txtFrom.Text = "";
                txtFrom.Focus();
            }
        }

        private void PerformConversion(ref decimal fromVal, ref decimal toVal)
        {
            //1 miles  to kilos
            //2 kilos  to miles
            //3 feet   to meters
            //4 meters to feet
            //5 inces  to cents
            //6 cents  to inches
            fromVal = Convert.ToDecimal(txtFrom.Text);
            int si = cmbConversion.SelectedIndex;
            
            switch (si)
            {
                case -1:
                    case 0:
                    return;

                case 1:
                    toVal = fromVal * MILESTOKILOS;
                    lblFrom.Text = "Miles:";
                    lblTo.Text = "Kilometers:";
                    txtTo.Text = toVal.ToString("n2");
                    break;

                case 2:
                    toVal = fromVal * KILOTOMILES;
                    lblFrom.Text = "Kilometers:";
                    lblTo.Text = "Miles:";
                    txtTo.Text = toVal.ToString("n2");
                    break;

                case 3:
                    toVal = fromVal * FEETTOMETERS;
                    lblFrom.Text = "Feet:";
                    lblTo.Text = "Meters:";
                    txtTo.Text = toVal.ToString("n2");
                    break;

                case 4:
                    toVal = fromVal * METERSTOFEET;
                    lblFrom.Text = "Meters:";
                    lblTo.Text = "Feet:";
                    txtTo.Text = toVal.ToString("n2");
                    break;

                case 5:
                    toVal = fromVal * INCHESTOCENTS;
                    lblFrom.Text = "Inches:";
                    lblTo.Text = "Centimeters:";
                    txtTo.Text = toVal.ToString("n2");
                    break;

                case 6:
                    toVal = fromVal * CENTSTOINCHES;
                    lblFrom.Text = "Centimeters:";
                    lblTo.Text = "Inches:";
                    txtTo.Text = toVal.ToString("n2");
                    break;

                default:
                    break;
            }

        }

        private bool CmbBoxGreaterThanZero()
        {
            bool retVal = true;

            if (cmbConversion.SelectedIndex <= 0)
            {
                ShowMessage("Please choose a conversion", "Error");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbConversion.SelectedIndex = 0;
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            lblFrom.Text = "From:";
            lblTo.Text = "To:";
            cmbConversion.Focus();
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
