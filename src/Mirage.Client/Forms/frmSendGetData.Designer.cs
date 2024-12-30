namespace Mirage.Forms
{
	partial class frmSendGetData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendGetData));
            lblStatus = new Label();
            picDeleteAccount = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDeleteAccount).BeginInit();
            picDeleteAccount.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(192, 192, 255);
            lblStatus.Location = new Point(0, 16);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(321, 25);
            lblStatus.TabIndex = 1;
            lblStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // picDeleteAccount
            // 
            picDeleteAccount.Controls.Add(lblStatus);
            picDeleteAccount.Image = (Image)resources.GetObject("picDeleteAccount.Image");
            picDeleteAccount.Location = new Point(0, 0);
            picDeleteAccount.Name = "picDeleteAccount";
            picDeleteAccount.Size = new Size(320, 55);
            picDeleteAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            picDeleteAccount.TabIndex = 0;
            picDeleteAccount.TabStop = false;
            // 
            // frmSendGetData
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(319, 55);
            ControlBox = false;
            Controls.Add(picDeleteAccount);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSendGetData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mirage Online";
            KeyPress += frmSendGetData_KeyPress;
            ((System.ComponentModel.ISupportInitialize)picDeleteAccount).EndInit();
            picDeleteAccount.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.PictureBox picDeleteAccount;
	}
}
