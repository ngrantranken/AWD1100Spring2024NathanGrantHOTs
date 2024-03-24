using LoanLibrary;
namespace HOT7_1
{
    public partial class frmBankLoan : Form
    {
        private ILoan currentLoan;

        public frmBankLoan()
        {
            InitializeComponent();
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double amount;
            bool keepGoing;
            keepGoing = IsPresent();
            if (keepGoing)
            {
                keepGoing = IsDouble();
                if(keepGoing)
                {
                    double.TryParse(txtAmount.Text, out amount);
                    keepGoing = IsWithinRange(amount);
                    if (keepGoing)
                    {
                        string loanType = "";
                        if (optShortTerm.Checked)
                        {
                            loanType = "Short Term";
                        }
                        else if (optLongTerm.Checked)
                        {
                            loanType = "Long Term";
                        }

                        if (loanType == "Short Term")
                        {
                            currentLoan = new ShortTermLoan(name, amount);
                            grpManageLoan.Visible = true;
                            grpManageLoan.Enabled = true;
                            lblLoanholder.Text = name;
                            lblLoanInfo.Text = $"Short-Term loan of ${amount:0.00}";
                            lblPostPayment.Text = "";
                            lblPostInterest.Text = "";
                        }
                        else if (loanType == "Long Term")
                        {
                            currentLoan = new LongTermLoan(name, amount);
                            grpManageLoan.Visible = true;
                            grpManageLoan.Enabled = true;
                            lblLoanholder.Text = name;
                            lblLoanInfo.Text = $"Long-Term loan of ${amount:0.00}";
                            lblPostPayment.Text = "";
                            lblPostInterest.Text = "";
                        }
                    }
                }
            }
        }

        private bool IsPresent()
        {
            if (String.IsNullOrEmpty(txtName.Text) || (!optShortTerm.Checked && !optLongTerm.Checked))
            {
                MessageBox.Show("Please do not leave any entry fields empty.", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsDouble()
        {
            if (!Double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid loan amount.", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsWithinRange(double amount)
        {
            if (amount <= 0)
            {
                MessageBox.Show("Please enter a valid loan amount.", "INVALID INPUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            currentLoan.MakePayment();
            lblPostPayment.Text = $"After the last payment the loan is down to ${currentLoan.Balance:0.00}";
            currentLoan.ApplyInterest();
            lblPostInterest.Text = $"After the last interest accumulation the loan is now ${currentLoan.Balance:0.00}";

            if (currentLoan.Balance <= 0)
            {
                MessageBox.Show("Congratulations on fully paying off your loan.", "BALANCE PAID OFF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
