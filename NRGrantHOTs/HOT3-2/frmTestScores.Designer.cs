namespace HOT3_2
{
    partial class frmTestScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTestScore = new Label();
            txtTestScore = new TextBox();
            btnCalculate = new Button();
            btnReset = new Button();
            btnExit = new Button();
            lblNumberOfScores = new Label();
            lblSum = new Label();
            lblAverage = new Label();
            lblLowest = new Label();
            lblHighest = new Label();
            SuspendLayout();
            // 
            // lblTestScore
            // 
            lblTestScore.AutoSize = true;
            lblTestScore.Location = new Point(12, 9);
            lblTestScore.Name = "lblTestScore";
            lblTestScore.Size = new Size(135, 15);
            lblTestScore.TabIndex = 0;
            lblTestScore.Text = "Please enter a test score:";
            // 
            // txtTestScore
            // 
            txtTestScore.Location = new Point(12, 27);
            txtTestScore.Name = "txtTestScore";
            txtTestScore.Size = new Size(135, 23);
            txtTestScore.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 56);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(93, 56);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(174, 56);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblNumberOfScores
            // 
            lblNumberOfScores.AutoSize = true;
            lblNumberOfScores.Location = new Point(12, 96);
            lblNumberOfScores.Name = "lblNumberOfScores";
            lblNumberOfScores.Size = new Size(104, 15);
            lblNumberOfScores.TabIndex = 5;
            lblNumberOfScores.Text = "Number of scores:";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Location = new Point(12, 111);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(106, 15);
            lblSum.TabIndex = 6;
            lblSum.Text = "Sum of test scores:";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(12, 126);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(106, 15);
            lblAverage.TabIndex = 7;
            lblAverage.Text = "Average test score:";
            // 
            // lblLowest
            // 
            lblLowest.AutoSize = true;
            lblLowest.Location = new Point(12, 141);
            lblLowest.Name = "lblLowest";
            lblLowest.Size = new Size(100, 15);
            lblLowest.TabIndex = 8;
            lblLowest.Text = "Lowest test score:";
            // 
            // lblHighest
            // 
            lblHighest.AutoSize = true;
            lblHighest.Location = new Point(12, 156);
            lblHighest.Name = "lblHighest";
            lblHighest.Size = new Size(104, 15);
            lblHighest.TabIndex = 9;
            lblHighest.Text = "Highest test score:";
            // 
            // frmTestScores
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(271, 192);
            Controls.Add(lblHighest);
            Controls.Add(lblLowest);
            Controls.Add(lblAverage);
            Controls.Add(lblSum);
            Controls.Add(lblNumberOfScores);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(txtTestScore);
            Controls.Add(lblTestScore);
            Name = "frmTestScores";
            Text = "Test Scores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTestScore;
        private TextBox txtTestScore;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnExit;
        private Label lblNumberOfScores;
        private Label lblSum;
        private Label lblAverage;
        private Label lblLowest;
        private Label lblHighest;
    }
}
