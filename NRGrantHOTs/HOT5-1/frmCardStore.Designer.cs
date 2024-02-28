namespace HOT5_1
{
    partial class frmCardStore
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
            lblOccasion = new Label();
            lblStyle = new Label();
            cboOccasion = new ComboBox();
            cboStyle = new ComboBox();
            chkEnvelope = new CheckBox();
            chkStamp = new CheckBox();
            chkCustomMessage = new CheckBox();
            txtCustomMessage = new TextBox();
            lblCost = new Label();
            pbCardPreview = new PictureBox();
            lblCustomMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCardPreview).BeginInit();
            SuspendLayout();
            // 
            // lblOccasion
            // 
            lblOccasion.AutoSize = true;
            lblOccasion.Location = new Point(12, 9);
            lblOccasion.Name = "lblOccasion";
            lblOccasion.Size = new Size(56, 15);
            lblOccasion.TabIndex = 0;
            lblOccasion.Text = "Occasion";
            // 
            // lblStyle
            // 
            lblStyle.AutoSize = true;
            lblStyle.Location = new Point(12, 43);
            lblStyle.Name = "lblStyle";
            lblStyle.Size = new Size(32, 15);
            lblStyle.TabIndex = 1;
            lblStyle.Text = "Style";
            // 
            // cboOccasion
            // 
            cboOccasion.FormattingEnabled = true;
            cboOccasion.Location = new Point(74, 6);
            cboOccasion.Name = "cboOccasion";
            cboOccasion.Size = new Size(121, 23);
            cboOccasion.TabIndex = 0;
            cboOccasion.SelectedIndexChanged += cboOccasion_SelectedIndexChanged;
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(74, 40);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(121, 23);
            cboStyle.TabIndex = 1;
            cboStyle.SelectedIndexChanged += cboStyle_SelectedIndexChanged;
            // 
            // chkEnvelope
            // 
            chkEnvelope.AutoSize = true;
            chkEnvelope.Location = new Point(12, 69);
            chkEnvelope.Name = "chkEnvelope";
            chkEnvelope.Size = new Size(112, 19);
            chkEnvelope.TabIndex = 2;
            chkEnvelope.Text = "Envelope ($0.25)";
            chkEnvelope.UseVisualStyleBackColor = true;
            chkEnvelope.CheckedChanged += chkEnvelope_CheckedChanged;
            // 
            // chkStamp
            // 
            chkStamp.AutoSize = true;
            chkStamp.Location = new Point(12, 94);
            chkStamp.Name = "chkStamp";
            chkStamp.Size = new Size(98, 19);
            chkStamp.TabIndex = 3;
            chkStamp.Text = "Stamp ($0.50)";
            chkStamp.UseVisualStyleBackColor = true;
            chkStamp.CheckedChanged += chkStamp_CheckedChanged;
            // 
            // chkCustomMessage
            // 
            chkCustomMessage.AutoSize = true;
            chkCustomMessage.Location = new Point(12, 119);
            chkCustomMessage.Name = "chkCustomMessage";
            chkCustomMessage.Size = new Size(155, 19);
            chkCustomMessage.TabIndex = 4;
            chkCustomMessage.Text = "Custom Message ($0.25)";
            chkCustomMessage.UseVisualStyleBackColor = true;
            chkCustomMessage.CheckedChanged += chkCustomMessage_CheckedChanged;
            // 
            // txtCustomMessage
            // 
            txtCustomMessage.Enabled = false;
            txtCustomMessage.Location = new Point(10, 144);
            txtCustomMessage.Multiline = true;
            txtCustomMessage.Name = "txtCustomMessage";
            txtCustomMessage.Size = new Size(229, 132);
            txtCustomMessage.TabIndex = 5;
            txtCustomMessage.TextChanged += txtCustomMessage_TextChanged;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCost.Location = new Point(12, 279);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(59, 25);
            lblCost.TabIndex = 6;
            lblCost.Text = "Cost: ";
            // 
            // pbCardPreview
            // 
            pbCardPreview.Location = new Point(245, 6);
            pbCardPreview.Name = "pbCardPreview";
            pbCardPreview.Size = new Size(414, 298);
            pbCardPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCardPreview.TabIndex = 9;
            pbCardPreview.TabStop = false;
            pbCardPreview.Paint += pbCardPreview_Paint;
            // 
            // lblCustomMessage
            // 
            lblCustomMessage.AutoSize = true;
            lblCustomMessage.BackColor = Color.Transparent;
            lblCustomMessage.ImageAlign = ContentAlignment.BottomCenter;
            lblCustomMessage.Location = new Point(439, 256);
            lblCustomMessage.Name = "lblCustomMessage";
            lblCustomMessage.Size = new Size(0, 15);
            lblCustomMessage.TabIndex = 10;
            lblCustomMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCardStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 319);
            Controls.Add(lblCustomMessage);
            Controls.Add(pbCardPreview);
            Controls.Add(lblCost);
            Controls.Add(txtCustomMessage);
            Controls.Add(chkCustomMessage);
            Controls.Add(chkStamp);
            Controls.Add(chkEnvelope);
            Controls.Add(cboStyle);
            Controls.Add(cboOccasion);
            Controls.Add(lblStyle);
            Controls.Add(lblOccasion);
            Name = "frmCardStore";
            Text = "Card Designer";
            ((System.ComponentModel.ISupportInitialize)pbCardPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOccasion;
        private Label lblStyle;
        private ComboBox cboOccasion;
        private ComboBox cboStyle;
        private CheckBox chkEnvelope;
        private CheckBox chkStamp;
        private CheckBox chkCustomMessage;
        private TextBox txtCustomMessage;
        private Label lblCost;
        private PictureBox pbCardPreview;
        private Label lblCustomMessage;
    }
}
