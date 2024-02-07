namespace HOT3_2
{
    public partial class frmTestScores : Form
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;

        private int numScores = 0;
        private double sumScores = 0;
        private double minScore = double.PositiveInfinity;
        private double maxScore = double.NegativeInfinity;

        public frmTestScores()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtTestScore.Text;
            ProcessInput(input);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void ProcessInput(string input)
        {
            try
            {
                if (IsValid(input, out double score))
                {
                    UpdateScores(score);
                    UpdateScoresDisplay();
                }
            }
            catch (FormatException ex)
            {
                ShowErrorMessage(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private bool IsValid(string input, out double score)
        {
              if (string.IsNullOrWhiteSpace(input))
            {
                throw new FormatException("Please enter a score");
            }

              score = double.Parse(input);
            
            if (score < MinScore || score > MaxScore)
            {
                throw new ArgumentOutOfRangeException($"Please enter a value between {MinScore} and {MaxScore}");
            }
            return true;
        }

        private void UpdateScores(double score)
        {
            numScores++;
            sumScores += score;
            minScore = Math.Min(minScore, score);
            maxScore = Math.Max(maxScore, score);
        }

        private void UpdateScoresDisplay()
        { 
            double avgScores = sumScores / numScores;

            lblNumberOfScores.Text = $"Number of scores: {numScores}";
            lblSum.Text = $"Sum of test scores: {sumScores}";
            lblAverage.Text = $"Average test score: {avgScores}";
            lblLowest.Text = $"Lowest test score: {minScore}";
            lblHighest.Text = $"Highest test score: {maxScore}";
        }

        private void Reset()
        {
            numScores = 0;
            sumScores = 0;
            minScore = double.PositiveInfinity; 
            maxScore = double.NegativeInfinity;

            txtTestScore.Text = string.Empty;
            lblNumberOfScores.Text = "Number of scores:";
            lblSum.Text = "Sum of test scores:";
            lblAverage.Text = "Average test score:";
            lblLowest.Text = "Lowest test score:";
            lblHighest.Text = "Highest test score:";

            txtTestScore.Focus();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
