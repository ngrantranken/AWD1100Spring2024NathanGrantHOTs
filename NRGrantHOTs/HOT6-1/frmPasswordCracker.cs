namespace HOT6_1
{
    public partial class frmPasswordCracker : Form
    {
        List<Password> rainbowTable = new List<Password>();
        public frmPasswordCracker()
        {
            InitializeComponent();
            InitializeRainbowTable();
        }

        private void InitializeRainbowTable()
        {
            rainbowTable = new List<Password>
            {
                new Password("123456", "e10adc3949ba59abbe56e057f20f883e"),
                new Password("123456789", "25f9e794323b453885f5181f1b624d0b"),
                new Password("qwerty", "d8578edf8458ce06fbc5bb76a58c5ca4"),
                new Password("111111", "96e79218965eb72c92a549dd5a330112"),
                new Password("password", "5f4dcc3b5aa765d61d8327deb882cf99"),
                new Password("qwertyuiop", "6eea9b7ef19179a06954edd0f6c05ceb"),
                new Password("123321", "c8837b23ff8aaa8a2dde915473ce0991"),
                new Password("google", "c822c1b63853ed273b89687ac505f9fa"),
                new Password("P@ssw0rd", "161ebd7d45089b3446ee4e0d86dbcf92"),
                new Password("Tr0ub4dor&3", "4ece57a61323b52ccffdbef021956754")
            };
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string inputHash = txtHash.Text.Trim().ToLower();
            string password = CrackPassword(inputHash);

            if (password != null)
            {
                lblPassword.Text = password;
            }
            else
            {
                lblPassword.Text = "* FAIL *";
            }
        }

        private string CrackPassword(string hash)
        {
            foreach (Password entry in rainbowTable)
            {
                if (entry.Hash == hash)
                {
                    return entry.Raw;
                }
            }

            return null;
        }
    }
}
