namespace HOT2_2
{
    partial class frmLetterGrade
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
            btnConvert = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblGPA = new Label();
            lblResults = new Label();
            txtGPA = new TextBox();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(12, 175);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(112, 27);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Letter Grade";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(130, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 27);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(248, 175);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 27);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(98, 68);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(32, 15);
            lblGPA.TabIndex = 3;
            lblGPA.Text = "GPA:";
            // 
            // lblResults
            // 
            lblResults.Location = new Point(48, 124);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(282, 38);
            lblResults.TabIndex = 4;
            lblResults.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(142, 65);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(100, 23);
            txtGPA.TabIndex = 5;
            // 
            // frmLetterGrade
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(385, 214);
            Controls.Add(txtGPA);
            Controls.Add(lblResults);
            Controls.Add(lblGPA);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Name = "frmLetterGrade";
            Text = "Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private Button btnClear;
        private Button btnExit;
        private Label lblGPA;
        private Label lblResults;
        private TextBox txtGPA;
    }
}
