namespace WinClassfd
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.ForeColor = System.Drawing.Color.Black;
            this.lblIPAddress.Location = new System.Drawing.Point(95, 9);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(64, 13);
            this.lblIPAddress.TabIndex = 1;
            this.lblIPAddress.Text = "[IP Address]";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(86, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 32);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(167, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Black;
            this.lblCountdown.Location = new System.Drawing.Point(9, 9);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 13);
            this.lblCountdown.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 74);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(300, 82);
            this.txtStatus.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 166);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblIPAddress);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "classfd";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

