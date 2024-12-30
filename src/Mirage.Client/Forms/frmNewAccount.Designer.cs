namespace Mirage.Forms
{
	partial class frmNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccount));
            picCancel = new PictureBox();
            picConnect = new PictureBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            picNewAccount = new PictureBox();
            Picture1 = new PictureBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picConnect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNewAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).BeginInit();
            SuspendLayout();
            // 
            // picCancel
            // 
            picCancel.Image = (Image)resources.GetObject("picCancel.Image");
            picCancel.Location = new Point(272, 264);
            picCancel.Name = "picCancel";
            picCancel.Size = new Size(200, 34);
            picCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            picCancel.TabIndex = 8;
            picCancel.TabStop = false;
            picCancel.Click += picCancel_Click;
            // 
            // picConnect
            // 
            picConnect.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            picConnect.Image = (Image)resources.GetObject("picConnect.Image");
            picConnect.Location = new Point(272, 232);
            picConnect.Name = "picConnect";
            picConnect.Size = new Size(200, 34);
            picConnect.SizeMode = PictureBoxSizeMode.AutoSize;
            picConnect.TabIndex = 7;
            picConnect.TabStop = false;
            picConnect.Click += picConnect_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(0, 0, 64);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(192, 192, 255);
            txtPassword.Location = new Point(312, 200);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(225, 19);
            txtPassword.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(0, 0, 64);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(192, 192, 255);
            txtName.Location = new Point(312, 160);
            txtName.MaxLength = 20;
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 19);
            txtName.TabIndex = 0;
            // 
            // picNewAccount
            // 
            picNewAccount.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            picNewAccount.Image = (Image)resources.GetObject("picNewAccount.Image");
            picNewAccount.Location = new Point(216, 8);
            picNewAccount.Name = "picNewAccount";
            picNewAccount.Size = new Size(320, 55);
            picNewAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            picNewAccount.TabIndex = 3;
            picNewAccount.TabStop = false;
            // 
            // Picture1
            // 
            Picture1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Picture1.Image = (Image)resources.GetObject("Picture1.Image");
            Picture1.Location = new Point(0, 0);
            Picture1.Name = "Picture1";
            Picture1.Size = new Size(201, 309);
            Picture1.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture1.TabIndex = 2;
            Picture1.TabStop = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(0, 0, 255);
            Label3.Location = new Point(224, 200);
            Label3.Name = "Label3";
            Label3.Size = new Size(86, 19);
            Label3.TabIndex = 6;
            Label3.Text = "Password";
            // 
            // Label2
            // 
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(0, 0, 255);
            Label2.Location = new Point(224, 72);
            Label2.Name = "Label2";
            Label2.Size = new Size(305, 73);
            Label2.TabIndex = 5;
            Label2.Text = "Enter a account name and password.  You can name yourself whatever you want, we have no restrictions on names.";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(0, 0, 255);
            Label1.Location = new Point(224, 160);
            Label1.Name = "Label1";
            Label1.Size = new Size(53, 19);
            Label1.TabIndex = 4;
            Label1.Text = "Name";
            // 
            // frmNewAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(546, 304);
            ControlBox = false;
            Controls.Add(picCancel);
            Controls.Add(picConnect);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(picNewAccount);
            Controls.Add(Picture1);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mirage Online (New Account)";
            ((System.ComponentModel.ISupportInitialize)picCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)picConnect).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNewAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.PictureBox picConnect;
		public System.Windows.Forms.TextBox txtPassword;
		public System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.PictureBox picNewAccount;
		private System.Windows.Forms.PictureBox Picture1;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
	}
}
