using System.Web;

namespace HOT2_1
{
    public partial class frmDistanceConverter : Form
    {
        const int INCHES_PER_YD = 36;
        decimal inches;
        decimal yards;

        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertDistance();
        }

        private void ConvertDistance()
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
                CalculateInchesToYards();
            }
        }

        private bool ValidateNotEmpty()
        {
            bool retVal = true;
            string inches = txtInches.Text.Trim();
            if (inches == "")
            {
                ShowErrorMessage("TextBox cannot be empty", "ERROR: TEXTBOX EMPTY");
                txtInches.Focus();
                retVal = false;
            }
            return retVal;
        }

        private bool ValidateNumericEntry()
        {
            string strInches = txtInches.Text.Trim();
            bool retVal = true;
            bool result;

            result = decimal.TryParse(strInches, out inches);
            if (!result)
            {
                ShowErrorMessage("TextBox value must be numeric", "ERROR: NON-NUMERIC ENTRY");
                txtInches.Text = string.Empty;
                txtInches.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidatePositiveEntry()
        {
            bool retVal = true;
            if (inches < 0)
            {
                ShowErrorMessage("TextBox value must be a positive number", "ERROR: NON-POSITIVE ENTRY");
                txtInches.Text = string.Empty;
                txtInches.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void CalculateInchesToYards()
        {
            yards = inches * INCHES_PER_YD;
            lblYards.Text = $"{inches:0.00} inches = {yards:0.00} yards";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lblYards.Text = string.Empty;
            txtInches.Text = string.Empty;
            txtInches.Focus();
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
