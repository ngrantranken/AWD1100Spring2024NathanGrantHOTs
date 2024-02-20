namespace HOT4_2
{
    partial class frmNameList
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
            lblNameEntry = new Label();
            txtNameEntry = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblNamesList = new Label();
            lstNames = new ListBox();
            SuspendLayout();
            // 
            // lblNameEntry
            // 
            lblNameEntry.AutoSize = true;
            lblNameEntry.Location = new Point(29, 9);
            lblNameEntry.Name = "lblNameEntry";
            lblNameEntry.Size = new Size(78, 15);
            lblNameEntry.TabIndex = 0;
            lblNameEntry.Text = "Enter a Name";
            // 
            // txtNameEntry
            // 
            txtNameEntry.Location = new Point(12, 27);
            txtNameEntry.Name = "txtNameEntry";
            txtNameEntry.Size = new Size(111, 23);
            txtNameEntry.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "&Update Name";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "&Delete Name";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(129, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(129, 114);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblNamesList
            // 
            lblNamesList.AutoSize = true;
            lblNamesList.Location = new Point(152, 9);
            lblNamesList.Name = "lblNamesList";
            lblNamesList.Size = new Size(65, 15);
            lblNamesList.TabIndex = 6;
            lblNamesList.Text = "Names List";
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 15;
            lstNames.Location = new Point(129, 27);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(111, 49);
            lstNames.TabIndex = 4;
            // 
            // frmNameList
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(265, 161);
            Controls.Add(lstNames);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(lblNamesList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtNameEntry);
            Controls.Add(lblNameEntry);
            Name = "frmNameList";
            Text = "First Names List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameEntry;
        private TextBox txtNameEntry;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnExit;
        private Label lblNamesList;
        private ListBox lstNames;
    }
}
