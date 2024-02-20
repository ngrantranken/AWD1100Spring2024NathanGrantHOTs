namespace HOT4_1
{
    partial class frmAddressBook
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
            txtSearchTerm = new TextBox();
            lblSearchTerm = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblResults = new Label();
            SuspendLayout();
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Location = new Point(12, 27);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(188, 23);
            txtSearchTerm.TabIndex = 0;
            // 
            // lblSearchTerm
            // 
            lblSearchTerm.AutoSize = true;
            lblSearchTerm.Location = new Point(12, 9);
            lblSearchTerm.Name = "lblSearchTerm";
            lblSearchTerm.Size = new Size(102, 15);
            lblSearchTerm.TabIndex = 1;
            lblSearchTerm.Text = "First or Last Name";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(206, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(206, 56);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(206, 85);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblResults
            // 
            lblResults.Location = new Point(12, 56);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(188, 80);
            lblResults.TabIndex = 5;
            // 
            // frmAddressBook
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(299, 158);
            Controls.Add(lblResults);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(lblSearchTerm);
            Controls.Add(txtSearchTerm);
            Name = "frmAddressBook";
            Text = "Address Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchTerm;
        private Label lblSearchTerm;
        private Button btnSearch;
        private Button btnClear;
        private Button btnExit;
        private Label lblResults;
    }
}
