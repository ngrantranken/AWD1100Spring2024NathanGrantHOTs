namespace HOT4_1
{
    public partial class frmAddressBook : Form
    {
        const string FNNF = "First Name Not Found";
        const string LNNF = "Last Name Not Found";
        const string PNNF = "Phone Number Not Found";
        const string FN = "First Name:";
        const string LN = "Last Name:";
        const string PN = "Phone Number:";

        private string[] firstNames = { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
        private string[] lastNames = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
        private string[] phoneNumbers = { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763" };

        public frmAddressBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInput();
            if (keepGoing)
            {
                PerformTheSearch();
            }
        }
        private bool CheckForNoInput()
        {
            bool retVal = true;
            string term = txtSearchTerm.Text.Trim();

            if (term == "")
            {
                MessageBox.Show("You must enter a search term", "Search Term Empty");
                retVal = false;
            }

            return retVal;
        }

        private void PerformTheSearch()
        {
            string term = txtSearchTerm.Text.Trim();
            bool isFound = false;
            int indexNumber = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < firstNames.Length; lcv++)
            {
                if (firstNames[lcv].ToLower().Contains(term.ToLower()) || lastNames[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    indexNumber = lcv;
                    break;
                }
            }

            if (isFound)
            {
                outputStr += ($"\t{FN} {firstNames[indexNumber]}\r\n");
                outputStr += ($"\t{LN} {lastNames[indexNumber]}\r\n");
                outputStr += ($"\t{PN} {phoneNumbers[indexNumber]}\r\n");
            }
            else
            {
                outputStr += ($"\t{FN} {FNNF}\r\n");
                outputStr += ($"\t{LN} {LNNF}\r\n");
                outputStr += ($"\t{PN} {PNNF}\r\n");
            }

            lblResults.Text = outputStr;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSearchTerm.Text = string.Empty;
            lblResults.Text = string.Empty;
            txtSearchTerm.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
