namespace HOT7_1
{
    partial class frmBankLoan
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
            grpCreateLoan = new GroupBox();
            btnCreateLoan = new Button();
            optLongTerm = new RadioButton();
            optShortTerm = new RadioButton();
            lblType = new Label();
            txtAmount = new TextBox();
            txtName = new TextBox();
            lblAmount = new Label();
            lblName = new Label();
            grpManageLoan = new GroupBox();
            lblPostInterest = new Label();
            lblPostPayment = new Label();
            btnPayment = new Button();
            lblLoanInfo = new Label();
            lblLoanholder = new Label();
            grpCreateLoan.SuspendLayout();
            grpManageLoan.SuspendLayout();
            SuspendLayout();
            // 
            // grpCreateLoan
            // 
            grpCreateLoan.Controls.Add(btnCreateLoan);
            grpCreateLoan.Controls.Add(optLongTerm);
            grpCreateLoan.Controls.Add(optShortTerm);
            grpCreateLoan.Controls.Add(lblType);
            grpCreateLoan.Controls.Add(txtAmount);
            grpCreateLoan.Controls.Add(txtName);
            grpCreateLoan.Controls.Add(lblAmount);
            grpCreateLoan.Controls.Add(lblName);
            grpCreateLoan.Location = new Point(12, 0);
            grpCreateLoan.Name = "grpCreateLoan";
            grpCreateLoan.Size = new Size(322, 168);
            grpCreateLoan.TabIndex = 0;
            grpCreateLoan.TabStop = false;
            grpCreateLoan.Text = "Create Loan";
            // 
            // btnCreateLoan
            // 
            btnCreateLoan.Location = new Point(6, 130);
            btnCreateLoan.Name = "btnCreateLoan";
            btnCreateLoan.Size = new Size(109, 23);
            btnCreateLoan.TabIndex = 4;
            btnCreateLoan.Text = "Create Loan";
            btnCreateLoan.UseVisualStyleBackColor = true;
            btnCreateLoan.Click += btnCreateLoan_Click;
            // 
            // optLongTerm
            // 
            optLongTerm.AutoSize = true;
            optLongTerm.Location = new Point(64, 105);
            optLongTerm.Name = "optLongTerm";
            optLongTerm.Size = new Size(112, 19);
            optLongTerm.TabIndex = 3;
            optLongTerm.TabStop = true;
            optLongTerm.Text = "Long-Term Loan";
            optLongTerm.UseVisualStyleBackColor = true;
            // 
            // optShortTerm
            // 
            optShortTerm.AutoSize = true;
            optShortTerm.Location = new Point(64, 80);
            optShortTerm.Name = "optShortTerm";
            optShortTerm.Size = new Size(113, 19);
            optShortTerm.TabIndex = 2;
            optShortTerm.TabStop = true;
            optShortTerm.Text = "Short-Term Loan";
            optShortTerm.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(6, 82);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 4;
            lblType.Text = "Type";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(64, 45);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(243, 23);
            txtAmount.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 23);
            txtName.TabIndex = 0;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(7, 48);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // grpManageLoan
            // 
            grpManageLoan.Controls.Add(lblPostInterest);
            grpManageLoan.Controls.Add(lblPostPayment);
            grpManageLoan.Controls.Add(btnPayment);
            grpManageLoan.Controls.Add(lblLoanInfo);
            grpManageLoan.Controls.Add(lblLoanholder);
            grpManageLoan.Enabled = false;
            grpManageLoan.Location = new Point(12, 174);
            grpManageLoan.Name = "grpManageLoan";
            grpManageLoan.Size = new Size(322, 144);
            grpManageLoan.TabIndex = 8;
            grpManageLoan.TabStop = false;
            grpManageLoan.Text = "Manage Loan";
            grpManageLoan.Visible = false;
            // 
            // lblPostInterest
            // 
            lblPostInterest.AutoSize = true;
            lblPostInterest.Location = new Point(7, 99);
            lblPostInterest.Name = "lblPostInterest";
            lblPostInterest.Size = new Size(0, 15);
            lblPostInterest.TabIndex = 4;
            // 
            // lblPostPayment
            // 
            lblPostPayment.AutoSize = true;
            lblPostPayment.Location = new Point(6, 84);
            lblPostPayment.Name = "lblPostPayment";
            lblPostPayment.Size = new Size(0, 15);
            lblPostPayment.TabIndex = 3;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(6, 58);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(109, 23);
            btnPayment.TabIndex = 0;
            btnPayment.Text = "Make Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // lblLoanInfo
            // 
            lblLoanInfo.AutoSize = true;
            lblLoanInfo.Location = new Point(7, 40);
            lblLoanInfo.Name = "lblLoanInfo";
            lblLoanInfo.Size = new Size(69, 15);
            lblLoanInfo.TabIndex = 1;
            lblLoanInfo.Text = "Placeholder";
            // 
            // lblLoanholder
            // 
            lblLoanholder.AutoSize = true;
            lblLoanholder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLoanholder.Location = new Point(7, 19);
            lblLoanholder.Name = "lblLoanholder";
            lblLoanholder.Size = new Size(101, 21);
            lblLoanholder.TabIndex = 0;
            lblLoanholder.Text = "Placeholder";
            // 
            // frmBankLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 332);
            Controls.Add(grpManageLoan);
            Controls.Add(grpCreateLoan);
            Name = "frmBankLoan";
            Text = "Bank Loan";
            grpCreateLoan.ResumeLayout(false);
            grpCreateLoan.PerformLayout();
            grpManageLoan.ResumeLayout(false);
            grpManageLoan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCreateLoan;
        private TextBox txtAmount;
        private TextBox txtName;
        private Label lblAmount;
        private Label lblName;
        private Button btnCreateLoan;
        private RadioButton optLongTerm;
        private RadioButton optShortTerm;
        private Label lblType;
        private GroupBox grpManageLoan;
        private Label lblLoanholder;
        private Label lblPostInterest;
        private Label lblPostPayment;
        private Button btnPayment;
        private Label lblLoanInfo;
    }
}
