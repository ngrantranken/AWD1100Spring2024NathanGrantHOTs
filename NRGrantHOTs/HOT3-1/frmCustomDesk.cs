namespace HOT3_1
{
    public partial class frmCustomDesk : Form
    {
        private const decimal CherryCost = 125;
        private const decimal MapleCost = 150;
        private const decimal OakCost = 140;
        private const decimal PineCost = 100;
        private const decimal DrawerSurcharge = 30;

        public frmCustomDesk()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            if (IsPresent(cboWoodType, "Wood") && IsPresent(txtNumberDrawers, "Drawers") && IsInt(txtNumberDrawers, "Drawers") && IsWithinRange(txtNumberDrawers,"Drawers", 1, 9))
            {
                string woodType = GetWood();
                int numDrawers = GetDrawers();
                decimal woodCost = CalculateWoodCost(woodType);
                decimal drawersCost = CalculateDrawerCost(numDrawers);
                decimal totalCost = CalculateTotalCost(woodType, numDrawers);
                lblWoodCost.Text = $"Wood Cost:\n${woodCost:0.00}";
                lblDrawersCost.Text = $"Drawers Cost:\n${drawersCost:0.00}";
                lblTotalCost.Text = $"Total Cost:\n${totalCost:0.00}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboWoodType.SelectedItem = null;
            txtNumberDrawers.Text = string.Empty;
            lblWoodCost.Text = "Wood Cost:";
            lblDrawersCost.Text = "Drawers Cost:";
            lblTotalCost.Text = "Total Cost:";
            cboWoodType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private string GetWood()
        {
            string woodType = "";
            switch (cboWoodType.SelectedItem.ToString()) 
            {
                case "c":
                    woodType = "cherry";
                    break;
                case "m":
                    woodType = "maple";
                    break;
                case "o":
                    woodType = "oak";
                    break;
                case "p":
                    woodType = "pine";
                    break;
            }
            return woodType;
        }

        private int GetDrawers()
        {
            return int.Parse(txtNumberDrawers.Text);
        }

        private decimal CalculateWoodCost(string woodType)
        {
            switch (woodType)
            {
                case "cherry":
                    return CherryCost;
                case "maple":
                    return MapleCost;
                case "oak":
                    return OakCost;
                case "pine":
                    return PineCost;
                default:
                    return 0;
            }
        }

        private decimal CalculateDrawerCost(int numDrawers)
        {
            return numDrawers * DrawerSurcharge;
        }

        private decimal CalculateTotalCost(string woodType, int numDrawers)
        {
            decimal woodCost = CalculateWoodCost(woodType);
            decimal drawerCost = CalculateDrawerCost(numDrawers);
            return woodCost + drawerCost;
        }

        private bool IsPresent(Control control, string name)
        {
            if (control.Text == "")
            {
                MessageBox.Show($"{name} is required.", "Input Error");
                control.Focus();
                return false;
            }
            return true;
        }

        private bool IsInt(Control control, string name)
        {
            if (!int.TryParse(control.Text, out _))
            {
                MessageBox.Show($"{name} must be an integer.", "Input Error");
                control.Focus();
                return false;
            }
            return true;
        }

        private bool IsWithinRange(Control control, string name, int min, int max)
        {
            int value = int.Parse(control.Text);
            if (value < min || value > max)
            {
                MessageBox.Show($"{name} must be between {min} and {max}.", "Input Error");
                control.Focus();
                return false;
            }
            return true;
        }

        private void Exit()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }
    }
}
