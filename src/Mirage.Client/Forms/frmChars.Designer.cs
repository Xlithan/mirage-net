namespace Mirage.Forms
{
	partial class frmChars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChars));
            picDelChar = new PictureBox();
            picUseChar = new PictureBox();
            picNewChar = new PictureBox();
            picCancel = new PictureBox();
            lstChars = new ListBox();
            picNewAccount = new PictureBox();
            Picture1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDelChar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUseChar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNewChar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNewAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).BeginInit();
            SuspendLayout();
            // 
            // picDelChar
            // 
            picDelChar.Image = (Image)resources.GetObject("picDelChar.Image");
            picDelChar.Location = new Point(272, 232);
            picDelChar.Name = "picDelChar";
            picDelChar.Size = new Size(200, 34);
            picDelChar.SizeMode = PictureBoxSizeMode.AutoSize;
            picDelChar.TabIndex = 6;
            picDelChar.TabStop = false;
            picDelChar.Click += picDelChar_Click;
            // 
            // picUseChar
            // 
            picUseChar.Image = (Image)resources.GetObject("picUseChar.Image");
            picUseChar.Location = new Point(272, 168);
            picUseChar.Name = "picUseChar";
            picUseChar.Size = new Size(200, 34);
            picUseChar.SizeMode = PictureBoxSizeMode.AutoSize;
            picUseChar.TabIndex = 5;
            picUseChar.TabStop = false;
            picUseChar.Click += picUseChar_Click;
            // 
            // picNewChar
            // 
            picNewChar.Image = (Image)resources.GetObject("picNewChar.Image");
            picNewChar.Location = new Point(272, 200);
            picNewChar.Name = "picNewChar";
            picNewChar.Size = new Size(200, 34);
            picNewChar.SizeMode = PictureBoxSizeMode.AutoSize;
            picNewChar.TabIndex = 4;
            picNewChar.TabStop = false;
            picNewChar.Click += picNewChar_Click;
            // 
            // picCancel
            // 
            picCancel.Image = (Image)resources.GetObject("picCancel.Image");
            picCancel.Location = new Point(272, 264);
            picCancel.Name = "picCancel";
            picCancel.Size = new Size(200, 34);
            picCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            picCancel.TabIndex = 3;
            picCancel.TabStop = false;
            picCancel.Click += picCancel_Click;
            // 
            // lstChars
            // 
            lstChars.BackColor = Color.FromArgb(0, 0, 0);
            lstChars.BorderStyle = BorderStyle.FixedSingle;
            lstChars.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstChars.ForeColor = Color.FromArgb(192, 192, 255);
            lstChars.Location = new Point(208, 72);
            lstChars.Name = "lstChars";
            lstChars.Size = new Size(305, 78);
            lstChars.TabIndex = 2;
            // 
            // picNewAccount
            // 
            picNewAccount.Image = (Image)resources.GetObject("picNewAccount.Image");
            picNewAccount.Location = new Point(216, 8);
            picNewAccount.Name = "picNewAccount";
            picNewAccount.Size = new Size(320, 55);
            picNewAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            picNewAccount.TabIndex = 1;
            picNewAccount.TabStop = false;
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
            // frmChars
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(546, 304);
            ControlBox = false;
            Controls.Add(picDelChar);
            Controls.Add(picUseChar);
            Controls.Add(picNewChar);
            Controls.Add(picCancel);
            Controls.Add(lstChars);
            Controls.Add(picNewAccount);
            Controls.Add(Picture1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)picDelChar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUseChar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNewChar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNewAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picDelChar;
		private System.Windows.Forms.PictureBox picUseChar;
		private System.Windows.Forms.PictureBox picNewChar;
		private System.Windows.Forms.PictureBox picCancel;
		public System.Windows.Forms.ListBox lstChars;
		private System.Windows.Forms.PictureBox picNewAccount;
		private System.Windows.Forms.PictureBox Picture1;
	}
}
