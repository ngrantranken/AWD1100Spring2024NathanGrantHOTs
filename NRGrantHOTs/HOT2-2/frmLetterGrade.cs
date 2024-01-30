namespace HOT2_2
{
    public partial class frmLetterGrade : Form
    {
        const decimal MAXGPA = 4.0m;
        const decimal MINGPA = 0.0m;
        decimal GPA;
        string letterGrade;

        public frmLetterGrade()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertToLetterGrade();
        }

        private void ConvertToLetterGrade()
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
                keepGoing = ValidateEntryRange();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateLetterGrade();
            }
        }

        private bool ValidateNotEmpty()
        {
            bool retVal = true;
            string GPA = txtGPA.Text.Trim();
            
            if (GPA == "")
            {
                ShowErrorMessage("TextBox cannot be empty", "ERROR: TEXTBOX EMPTY");
                txtGPA.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateNumericEntry()
        {
            string strGPA = txtGPA.Text.Trim();
            bool retVal = true;
            bool result;

            result = decimal.TryParse(strGPA, out GPA);
            if (!result)
            {
                ShowErrorMessage("TextBox value must be numeric", "ERROR: TEXTBOX EMPTY");
                txtGPA.Text = string.Empty;
                txtGPA.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateEntryRange()
        {
            bool retVal = true;
            if (GPA < MINGPA || GPA > MAXGPA)
            {
                ShowErrorMessage("TextBox value must be between 4.0 and 0.0", "ERROR: NON-VALID RANGE");
                txtGPA.Text = string.Empty;
                txtGPA.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void CalculateLetterGrade()
        {
            if (GPA > 3.0m)
            {
                letterGrade = "A";
            }
            else if (GPA <= 3.0m && GPA > 2.0m)
            {
                letterGrade = "B";
            }
            else if (GPA <= 2.0m && GPA > 1.0m)
            {
                letterGrade = "C";
            }
            else if (GPA <= 1.0m && GPA > 0.0m)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            lblResults.Text = $"GPA: {GPA: 0.0}\nLetter Grade: {letterGrade}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        
        private void ClearForm()
        {
            txtGPA.Text = string.Empty;
            lblGPA.Text = string.Empty;
            txtGPA.Focus();
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
