namespace Mirage
{
	partial class frmLogin
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			Picture1 = new System.Windows.Forms.PictureBox();
			picNewAccount = new System.Windows.Forms.PictureBox();
			txtName = new System.Windows.Forms.TextBox();
			txtPassword = new System.Windows.Forms.TextBox();
			picConnect = new System.Windows.Forms.PictureBox();
			picCancel = new System.Windows.Forms.PictureBox();
			Label1 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picConnect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
			this.SuspendLayout();
			//
			// Picture1
			//
			this.Picture1.Name = "Picture1";
			this.Picture1.Location = new System.Drawing.Point(0, 0);
			this.Picture1.Size = new System.Drawing.Size(201, 309);
			this.Picture1.TabIndex = 5;
			this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
			this.Picture1.TabStop = false;
			//
			// picNewAccount
			//
			this.picNewAccount.Name = "picNewAccount";
			this.picNewAccount.Location = new System.Drawing.Point(216, 8);
			this.picNewAccount.Size = new System.Drawing.Size(320, 55);
			this.picNewAccount.TabIndex = 4;
			this.picNewAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picNewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("picNewAccount.Image")));
			this.picNewAccount.TabStop = false;
			//
			// txtName
			//
			this.txtName.Name = "txtName";
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(192, 192, 255);
			this.txtName.MaxLength = 20;
			this.txtName.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
			this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(312, 160);
			this.txtName.Size = new System.Drawing.Size(225, 26);
			this.txtName.TabIndex = 0;
			//
			// txtPassword
			//
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
			this.txtPassword.Location = new System.Drawing.Point(312, 200);
			this.txtPassword.MaxLength = 20;
			this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Size = new System.Drawing.Size(225, 26);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(192, 192, 255);
			this.txtPassword.PasswordChar = '*';
			//
			// picConnect
			//
			this.picConnect.Name = "picConnect";
			this.picConnect.TabStop = false;
			this.picConnect.Location = new System.Drawing.Point(272, 232);
			this.picConnect.Size = new System.Drawing.Size(200, 34);
			this.picConnect.TabIndex = 3;
			this.picConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picConnect.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picConnect.Image = ((System.Drawing.Image)(resources.GetObject("picConnect.Image")));
			//
			// picCancel
			//
			this.picCancel.Name = "picCancel";
			this.picCancel.Size = new System.Drawing.Size(200, 34);
			this.picCancel.TabIndex = 2;
			this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picCancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picCancel.Image = ((System.Drawing.Image)(resources.GetObject("picCancel.Image")));
			this.picCancel.TabStop = false;
			this.picCancel.Location = new System.Drawing.Point(272, 264);
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Location = new System.Drawing.Point(224, 160);
			this.Label1.Size = new System.Drawing.Size(57, 25);
			this.Label1.TabIndex = 8;
			this.Label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
			this.Label1.Text = "Name";
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 7;
			this.Label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
			this.Label2.Text = "Enter a account name and password.  ";
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(224, 72);
			this.Label2.Size = new System.Drawing.Size(305, 57);
			//
			// Label3
			//
			this.Label3.Name = "Label3";
			this.Label3.Text = "Password";
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(224, 200);
			this.Label3.Size = new System.Drawing.Size(81, 25);
			this.Label3.TabIndex = 6;
			this.Label3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
			//
			// frmLogin
			//
			this.Name = "frmLogin";
			this.MinimizeBox = false;
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(546, 304);
			this.Text = " ";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Controls.Add(this.Picture1);
			this.Controls.Add(this.picNewAccount);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.picConnect);
			this.Controls.Add(this.picCancel);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label3);
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picConnect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.PictureBox Picture1;
		private System.Windows.Forms.PictureBox picNewAccount;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.PictureBox picConnect;
		private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label3;
	}
}
