namespace HOT3_1
{
    partial class frmCustomDesk
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
            lblWoodType = new Label();
            lblNumberDrawers = new Label();
            lblWoodCost = new Label();
            lblDrawersCost = new Label();
            lblTotalCost = new Label();
            txtNumberDrawers = new TextBox();
            btnEstimate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            cboWoodType = new ComboBox();
            SuspendLayout();
            // 
            // lblWoodType
            // 
            lblWoodType.AutoSize = true;
            lblWoodType.Location = new Point(12, 9);
            lblWoodType.Name = "lblWoodType";
            lblWoodType.Size = new Size(83, 15);
            lblWoodType.TabIndex = 0;
            lblWoodType.Text = "Type of Wood:";
            // 
            // lblNumberDrawers
            // 
            lblNumberDrawers.AutoSize = true;
            lblNumberDrawers.Location = new Point(131, 9);
            lblNumberDrawers.Name = "lblNumberDrawers";
            lblNumberDrawers.Size = new Size(113, 15);
            lblNumberDrawers.TabIndex = 1;
            lblNumberDrawers.Text = "Number of Drawers:";
            // 
            // lblWoodCost
            // 
            lblWoodCost.Location = new Point(12, 95);
            lblWoodCost.Name = "lblWoodCost";
            lblWoodCost.Size = new Size(100, 50);
            lblWoodCost.TabIndex = 2;
            lblWoodCost.Text = "Wood Cost:";
            lblWoodCost.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDrawersCost
            // 
            lblDrawersCost.Location = new Point(118, 95);
            lblDrawersCost.Name = "lblDrawersCost";
            lblDrawersCost.Size = new Size(100, 50);
            lblDrawersCost.TabIndex = 3;
            lblDrawersCost.Text = "Drawers Cost:";
            lblDrawersCost.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTotalCost
            // 
            lblTotalCost.Location = new Point(224, 95);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(100, 50);
            lblTotalCost.TabIndex = 4;
            lblTotalCost.Text = "Total Cost:";
            lblTotalCost.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNumberDrawers
            // 
            txtNumberDrawers.Location = new Point(131, 27);
            txtNumberDrawers.Name = "txtNumberDrawers";
            txtNumberDrawers.Size = new Size(113, 23);
            txtNumberDrawers.TabIndex = 1;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(12, 56);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(75, 23);
            btnEstimate.TabIndex = 2;
            btnEstimate.Text = "Estimate";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += btnEstimate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(93, 56);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(174, 56);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cboWoodType
            // 
            cboWoodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWoodType.FormattingEnabled = true;
            cboWoodType.Items.AddRange(new object[] { "c", "m", "o", "p" });
            cboWoodType.Location = new Point(4, 27);
            cboWoodType.Name = "cboWoodType";
            cboWoodType.Size = new Size(121, 23);
            cboWoodType.TabIndex = 0;
            // 
            // frmCustomDesk
            // 
            AcceptButton = btnEstimate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(340, 179);
            Controls.Add(cboWoodType);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnEstimate);
            Controls.Add(txtNumberDrawers);
            Controls.Add(lblTotalCost);
            Controls.Add(lblDrawersCost);
            Controls.Add(lblWoodCost);
            Controls.Add(lblNumberDrawers);
            Controls.Add(lblWoodType);
            Name = "frmCustomDesk";
            Text = "Custom Desk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWoodType;
        private Label lblNumberDrawers;
        private Label lblWoodCost;
        private Label lblDrawersCost;
        private Label lblTotalCost;
        private TextBox txtNumberDrawers;
        private Button btnEstimate;
        private Button btnClear;
        private Button btnExit;
        private ComboBox cboWoodType;
    }
}
