namespace HOT2_1
{
    partial class frmDistanceConverter
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
            lblInches = new Label();
            lblYards = new Label();
            txtInches = new TextBox();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(22, 156);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(102, 27);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert to Yards";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(130, 156);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 27);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(238, 156);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 27);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblInches
            // 
            lblInches.AutoSize = true;
            lblInches.Location = new Point(82, 74);
            lblInches.Name = "lblInches";
            lblInches.Size = new Size(44, 15);
            lblInches.TabIndex = 3;
            lblInches.Text = "Inches:";
            // 
            // lblYards
            // 
            lblYards.Location = new Point(79, 115);
            lblYards.Name = "lblYards";
            lblYards.Size = new Size(194, 23);
            lblYards.TabIndex = 4;
            lblYards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtInches
            // 
            txtInches.Location = new Point(132, 71);
            txtInches.Name = "txtInches";
            txtInches.Size = new Size(100, 23);
            txtInches.TabIndex = 5;
            // 
            // frmDistanceConverter
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(352, 195);
            Controls.Add(txtInches);
            Controls.Add(lblYards);
            Controls.Add(lblInches);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Name = "frmDistanceConverter";
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private Button btnClear;
        private Button btnExit;
        private Label lblInches;
        private Label lblYards;
        private TextBox txtInches;
    }
}
