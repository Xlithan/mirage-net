namespace Mirage.Forms
{
	partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            picQuit = new PictureBox();
            picNewAccount = new PictureBox();
            picLogin = new PictureBox();
            picDeleteAccount = new PictureBox();
            picCredits = new PictureBox();
            Picture1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picQuit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNewAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDeleteAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCredits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).BeginInit();
            SuspendLayout();
            // 
            // picQuit
            // 
            picQuit.Image = (Image)resources.GetObject("picQuit.Image");
            picQuit.Location = new Point(216, 232);
            picQuit.Name = "picQuit";
            picQuit.Size = new Size(320, 55);
            picQuit.SizeMode = PictureBoxSizeMode.AutoSize;
            picQuit.TabIndex = 5;
            picQuit.TabStop = false;
            picQuit.Click += picQuit_Click;
            // 
            // picNewAccount
            // 
            picNewAccount.Image = (Image)resources.GetObject("picNewAccount.Image");
            picNewAccount.Location = new Point(216, 8);
            picNewAccount.Name = "picNewAccount";
            picNewAccount.Size = new Size(320, 55);
            picNewAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            picNewAccount.TabIndex = 4;
            picNewAccount.TabStop = false;
            picNewAccount.Click += picNewAccount_Click;
            // 
            // picLogin
            // 
            picLogin.Image = (Image)resources.GetObject("picLogin.Image");
            picLogin.Location = new Point(216, 120);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(320, 55);
            picLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            picLogin.TabIndex = 3;
            picLogin.TabStop = false;
            picLogin.Click += picLogin_Click;
            // 
            // picDeleteAccount
            // 
            picDeleteAccount.Image = (Image)resources.GetObject("picDeleteAccount.Image");
            picDeleteAccount.Location = new Point(216, 64);
            picDeleteAccount.Name = "picDeleteAccount";
            picDeleteAccount.Size = new Size(320, 55);
            picDeleteAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            picDeleteAccount.TabIndex = 2;
            picDeleteAccount.TabStop = false;
            picDeleteAccount.Click += picDeleteAccount_Click;
            // 
            // picCredits
            // 
            picCredits.Image = (Image)resources.GetObject("picCredits.Image");
            picCredits.Location = new Point(216, 176);
            picCredits.Name = "picCredits";
            picCredits.Size = new Size(320, 55);
            picCredits.SizeMode = PictureBoxSizeMode.AutoSize;
            picCredits.TabIndex = 1;
            picCredits.TabStop = false;
            picCredits.Click += picCredits_Click;
            // 
            // Picture1
            // 
            Picture1.Image = (Image)resources.GetObject("Picture1.Image");
            Picture1.Location = new Point(0, 0);
            Picture1.Name = "Picture1";
            Picture1.Size = new Size(201, 309);
            Picture1.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture1.TabIndex = 0;
            Picture1.TabStop = false;
            // 
            // frmMainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(546, 304);
            ControlBox = false;
            Controls.Add(picQuit);
            Controls.Add(picNewAccount);
            Controls.Add(picLogin);
            Controls.Add(picDeleteAccount);
            Controls.Add(picCredits);
            Controls.Add(Picture1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mirage Online";
            ((System.ComponentModel.ISupportInitialize)picQuit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNewAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDeleteAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCredits).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picQuit;
		private System.Windows.Forms.PictureBox picNewAccount;
		private System.Windows.Forms.PictureBox picLogin;
		private System.Windows.Forms.PictureBox picDeleteAccount;
		private System.Windows.Forms.PictureBox picCredits;
		private System.Windows.Forms.PictureBox Picture1;
	}
}
