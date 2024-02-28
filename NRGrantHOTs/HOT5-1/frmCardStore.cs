namespace HOT5_1
{
    public partial class frmCardStore : Form
    {
        private const double ENVELOPE_COST = 0.25;
        private const double STAMP_COST = 0.50;
        private const double MESSAGE_COST = 0.25;
        private const double BDAY_COST = 1.25;
        private const double TY_COST = 1.50;
        private const double GW_COST = 1.00;

        private string[] occasions = { "Birthday", "Thank You", "Get Well" };
        private string[] birthdayStyles = { "Style 1 ($1.25)", "Style 2 ($2.25)", "Style 3 ($3.25)" };
        private string[] thankYouStyles = { "Style 1 ($1.50)", "Style 2 ($2.50)", "Style 3 ($3.50)" };
        private string[] getWellStyles = { "Style 1 ($1.00)", "Style 2 ($2.00)", "Style 3 ($3.00)" };
        private string[] bdayImages = { "../../../assets/images/bday-style1.png", "../../../assets/images/bday-style2.jpg", "../../../assets/images/bday-style3.jpg" };
        private string[] thankYouImages = { "../../../assets/images/ty-style1.jpg", "../../../assets/images/ty-style2.jpg", "../../../assets/images/ty-style3.jpg" };
        private string[] getWellImages = { "../../../assets/images/gw-style1.jpg", "../../../assets/images/gw-style2.jpg", "../../../assets/images/gw-style3.jpg" };

        public frmCardStore()
        {
            InitializeComponent();
            InitializeOccasions();
        }

        private void InitializeOccasions()
        {
            cboOccasion.Items.AddRange(occasions);
            cboOccasion.SelectedIndex = 0;
        }

        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOccasion = cboOccasion.SelectedItem.ToString();
            switch (selectedOccasion)
            {
                case "Birthday":
                    cboStyle.Items.Clear();
                    cboStyle.Items.AddRange(birthdayStyles);
                    break;
                case "Thank You":
                    cboStyle.Items.Clear();
                    cboStyle.Items.AddRange(thankYouStyles);
                    break;
                case "Get Well":
                    cboStyle.Items.Clear();
                    cboStyle.Items.AddRange(getWellStyles);
                    break;
            }
            cboStyle.SelectedIndex = 0;
            UpdateCost();
        }

        private void UpdateCost()
        {
            double baseCost = 0;
            switch (cboOccasion.SelectedIndex)
            {
                case 0:
                    baseCost = BDAY_COST;
                    break;
                case 1:
                    baseCost = TY_COST;
                    break;
                case 2:
                    baseCost = GW_COST;
                    break;
                default:
                    break;
            }
            baseCost += cboStyle.SelectedIndex;
            double totalCost = baseCost;

            if (chkEnvelope.Checked)
            {
                totalCost += ENVELOPE_COST;
            }
            if (chkStamp.Checked)
            {
                totalCost += STAMP_COST;
            }
            if (chkCustomMessage.Checked)
            {
                totalCost += MESSAGE_COST;
            }

            lblCost.Text = $"Cost: ${totalCost:F2}";
        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            double totalCost = 0;
            HandleStyleChange(totalCost);
            UpdateCost();
        }

        private void HandleStyleChange(double totalCost)
        {
            if (cboOccasion.SelectedIndex == -1)
            {
                MessageBox.Show("You Must Choose An Occasion.", "NO OCCASION SELECTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboStyle.SelectedIndex == -1)
            {
                MessageBox.Show("You Must Choose A Style.", "NO STYLE SELECTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (cboOccasion.SelectedIndex)
            {
                case -1:
                    return;
                case 0:
                    totalCost += BDAY_COST;
                    pbCardPreview.Image = System.Drawing.Image.FromFile(bdayImages[cboStyle.SelectedIndex]);
                    break;
                case 1:
                    totalCost += TY_COST;
                    pbCardPreview.Image = System.Drawing.Image.FromFile(thankYouImages[cboStyle.SelectedIndex]);
                    break;
                case 2:
                    totalCost += GW_COST;
                    pbCardPreview.Image = System.Drawing.Image.FromFile(getWellImages[cboStyle.SelectedIndex]);
                    break;
                default:
                    break;
            }
        }

        private void chkCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomMessage.Enabled = chkCustomMessage.Checked;
            if (!chkCustomMessage.Checked)
            {
                txtCustomMessage.Text = string.Empty;
            }
            UpdateCost();
        }

        private void txtCustomMessage_TextChanged(Object sender, EventArgs e)
        {
            pbCardPreview.Refresh();
        }

        private void chkEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void chkStamp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void pbCardPreview_Paint(object sender, PaintEventArgs e)
        {
            using (Font myfont = new Font("Arial", 9))
            {
                e.Graphics.DrawString(txtCustomMessage.Text, myfont, Brushes.Black, new Point(120, 200));
            }
        }
    }
}
