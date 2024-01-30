using System.Drawing.Text;
using System.Xml.Serialization;

namespace HOT2_3
{
    public partial class frmLawncareService : Form
    {
        const decimal seasonLength = 20; // how many weeks are in the mowing season
        const decimal largeYardCost = 50; // cost per week for lawn 600 sq feet or more
        const decimal largeYardSize = 600;
        const decimal mediumYardCost = 35; // cost per week for lawn 400 feet or more, but under 600 feet
        const decimal mediumYardSize = 400;
        const decimal smallYardCost = 25; // cost per week for lawn under 400 sq feet
        decimal length; // length of the users lawn in feet
        decimal width; // width of the users lawn in feet
        decimal yardSize; // users total yard size in sq feet. length * width 
        decimal totalCost;

        public frmLawncareService()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ClearResults();
            CalculateResults();
        }

        private void CalculateResults()
        {
            bool keepGoing = true;

            keepGoing = ValidateNotEmpty();

            if (keepGoing)
            {
                keepGoing = ValidateNumericEntry();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidatePositiveEntry();
            }
            else
            {
                return;
            }
            if (keepGoing)
            {
                CalculateYardSize();
                CalculateTotalCost();
                lblSeasonLength.Text += $"{seasonLength} weeks";
            }
        }

        private bool ValidateNotEmpty()
        {
            bool retVal = true;
            string length = txtLength.Text.Trim();
            string width = txtWidth.Text.Trim();
            if (length == "" || width == "")
            {
                ShowErrorMessage("TextBox cannot be empty", "ERROR: TEXTBOX EMPTY");
                txtLength.Text = string.Empty;
                txtWidth.Text = string.Empty;
                txtLength.Focus();
                retVal = false;
            }
            return retVal;
        }

        private bool ValidateNumericEntry()
        {
            string strLength = txtLength.Text.Trim();
            string strWidth = txtWidth.Text.Trim();
            bool retVal = true;
            bool resultLength;
            bool resultWidth;

            resultLength = decimal.TryParse(strLength, out length);
            resultWidth = decimal.TryParse(strWidth, out width);
            if (!resultLength || !resultWidth)
            {
                ShowErrorMessage("TextBox values must be numeric", "ERROR: NON-NUMERIC ENTRY");
                txtLength.Text = string.Empty;
                txtWidth.Text = string.Empty;
                txtLength.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidatePositiveEntry()
        {
            bool retVal = true;
            if (length <= 0 || width <= 0)
            {
                ShowErrorMessage("TextBox values must be greater than 0", "ERROR: NON-POSITIVE ENTRY");
                txtLength.Text = string.Empty;
                txtWidth.Text = string.Empty;
                txtLength.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void CalculateYardSize()
        {
            yardSize = length * width;
            lblArea.Text += $"{yardSize} sq feet";
        }

        private void CalculateTotalCost()
        {
            if (yardSize >= largeYardSize)
            {
                totalCost = largeYardCost * seasonLength;
                lblWeeklyFee.Text += $"${largeYardCost}";
                lblTotalCost.Text += $"${totalCost:0.00}";
            }
            else if (yardSize >= 400 && yardSize < 600)
            {
                totalCost = mediumYardCost * seasonLength;
                lblWeeklyFee.Text += $"${mediumYardCost:0.00}";
                lblTotalCost.Text += $"${totalCost:0.00}";
            }
            else
            {
                totalCost = smallYardCost * seasonLength;
                lblWeeklyFee.Text += $"${smallYardCost:0.00}";
                lblTotalCost.Text += $"${totalCost:0.00}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearResults();
        }

        private void ClearTextBoxes()
        {
            txtLength.Text = string.Empty;
            txtWidth.Text = string.Empty;
            txtLength.Focus();
        }

        private void ClearResults()
        {
            lblArea.Text = "Area: ";
            lblWeeklyFee.Text = "Weekly Fee: ";
            lblSeasonLength.Text = "Season Length: ";
            lblTotalCost.Text = "Total Cost: ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
