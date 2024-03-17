namespace HOT6_1
{
    partial class frmPasswordCracker
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
            lblHash = new Label();
            lblPassword = new Label();
            txtHash = new TextBox();
            btnCrack = new Button();
            SuspendLayout();
            // 
            // lblHash
            // 
            lblHash.AutoSize = true;
            lblHash.Location = new Point(12, 9);
            lblHash.Name = "lblHash";
            lblHash.Size = new Size(62, 15);
            lblHash.TabIndex = 0;
            lblHash.Text = "MD5 Hash";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 77);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 15);
            lblPassword.TabIndex = 1;
            // 
            // txtHash
            // 
            txtHash.Location = new Point(12, 27);
            txtHash.Name = "txtHash";
            txtHash.Size = new Size(256, 23);
            txtHash.TabIndex = 0;
            // 
            // btnCrack
            // 
            btnCrack.Location = new Point(274, 27);
            btnCrack.Name = "btnCrack";
            btnCrack.Size = new Size(75, 23);
            btnCrack.TabIndex = 1;
            btnCrack.Text = "Crack";
            btnCrack.UseVisualStyleBackColor = true;
            btnCrack.Click += btnCrack_Click;
            // 
            // frmPasswordCracker
            // 
            AcceptButton = btnCrack;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 125);
            Controls.Add(btnCrack);
            Controls.Add(txtHash);
            Controls.Add(lblPassword);
            Controls.Add(lblHash);
            Name = "frmPasswordCracker";
            Text = "Password Cracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHash;
        private Label lblPassword;
        private TextBox txtHash;
        private Button btnCrack;
    }
}
