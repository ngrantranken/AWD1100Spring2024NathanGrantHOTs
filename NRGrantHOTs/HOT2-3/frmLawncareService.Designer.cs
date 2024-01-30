namespace HOT2_3
{
    partial class frmLawncareService
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
            lblLength = new Label();
            lblWidth = new Label();
            lblArea = new Label();
            lblWeeklyFee = new Label();
            lblSeasonLength = new Label();
            lblTotalCost = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(40, 33);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(66, 15);
            lblLength.TabIndex = 0;
            lblLength.Text = "Length (ft):";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(177, 33);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(61, 15);
            lblWidth.TabIndex = 1;
            lblWidth.Text = "Width (ft):";
            // 
            // lblArea
            // 
            lblArea.Location = new Point(75, 156);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(163, 23);
            lblArea.TabIndex = 2;
            lblArea.Text = "Area: ";
            lblArea.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWeeklyFee
            // 
            lblWeeklyFee.Location = new Point(75, 179);
            lblWeeklyFee.Name = "lblWeeklyFee";
            lblWeeklyFee.Size = new Size(163, 23);
            lblWeeklyFee.TabIndex = 3;
            lblWeeklyFee.Text = "Weekly Fee: ";
            lblWeeklyFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSeasonLength
            // 
            lblSeasonLength.Location = new Point(75, 202);
            lblSeasonLength.Name = "lblSeasonLength";
            lblSeasonLength.Size = new Size(163, 23);
            lblSeasonLength.TabIndex = 4;
            lblSeasonLength.Text = "Season Length: ";
            lblSeasonLength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalCost
            // 
            lblTotalCost.Location = new Point(75, 225);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(163, 23);
            lblTotalCost.TabIndex = 5;
            lblTotalCost.Text = "Total Cost: ";
            lblTotalCost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(40, 51);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 6;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(177, 51);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(40, 99);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(121, 99);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(202, 99);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLawncareService
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(328, 288);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblTotalCost);
            Controls.Add(lblSeasonLength);
            Controls.Add(lblWeeklyFee);
            Controls.Add(lblArea);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Name = "frmLawncareService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lawncare Service";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLength;
        private Label lblWidth;
        private Label lblArea;
        private Label lblWeeklyFee;
        private Label lblSeasonLength;
        private Label lblTotalCost;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
