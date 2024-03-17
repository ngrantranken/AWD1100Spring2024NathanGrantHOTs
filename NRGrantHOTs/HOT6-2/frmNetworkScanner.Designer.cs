namespace HOT6_2
{
    partial class frmNetworkScanner
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
            lblIpAddress = new Label();
            txtIpAddress = new TextBox();
            btnScan = new Button();
            lblComputerName = new Label();
            lblComputerIpAddress = new Label();
            lblServices = new Label();
            lblDisplayServices = new Label();
            SuspendLayout();
            // 
            // lblIpAddress
            // 
            lblIpAddress.AutoSize = true;
            lblIpAddress.Location = new Point(12, 9);
            lblIpAddress.Name = "lblIpAddress";
            lblIpAddress.Size = new Size(62, 15);
            lblIpAddress.TabIndex = 0;
            lblIpAddress.Text = "IP Address";
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(12, 27);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(138, 23);
            txtIpAddress.TabIndex = 0;
            // 
            // btnScan
            // 
            btnScan.Location = new Point(156, 27);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(75, 23);
            btnScan.TabIndex = 1;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // lblComputerName
            // 
            lblComputerName.AutoSize = true;
            lblComputerName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblComputerName.Location = new Point(12, 53);
            lblComputerName.Name = "lblComputerName";
            lblComputerName.Size = new Size(0, 25);
            lblComputerName.TabIndex = 3;
            // 
            // lblComputerIpAddress
            // 
            lblComputerIpAddress.AutoSize = true;
            lblComputerIpAddress.Location = new Point(12, 78);
            lblComputerIpAddress.Name = "lblComputerIpAddress";
            lblComputerIpAddress.Size = new Size(0, 15);
            lblComputerIpAddress.TabIndex = 4;
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblServices.Location = new Point(11, 108);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(0, 15);
            lblServices.TabIndex = 5;
            // 
            // lblDisplayServices
            // 
            lblDisplayServices.AutoSize = true;
            lblDisplayServices.Location = new Point(11, 123);
            lblDisplayServices.Name = "lblDisplayServices";
            lblDisplayServices.Size = new Size(0, 15);
            lblDisplayServices.TabIndex = 6;
            // 
            // frmNetworkScanner
            // 
            AcceptButton = btnScan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 295);
            Controls.Add(lblDisplayServices);
            Controls.Add(lblServices);
            Controls.Add(lblComputerIpAddress);
            Controls.Add(lblComputerName);
            Controls.Add(btnScan);
            Controls.Add(txtIpAddress);
            Controls.Add(lblIpAddress);
            Name = "frmNetworkScanner";
            Text = "Network Scanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIpAddress;
        private TextBox txtIpAddress;
        private Button btnScan;
        private Label lblComputerName;
        private Label lblComputerIpAddress;
        private Label lblServices;
        private Label lblDisplayServices;
    }
}
