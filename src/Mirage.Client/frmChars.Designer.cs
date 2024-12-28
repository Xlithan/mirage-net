namespace Mirage
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChars));
			picDelChar = new System.Windows.Forms.PictureBox();
			picUseChar = new System.Windows.Forms.PictureBox();
			picNewChar = new System.Windows.Forms.PictureBox();
			picCancel = new System.Windows.Forms.PictureBox();
			lstChars = new System.Windows.Forms.ListBox();
			picNewAccount = new System.Windows.Forms.PictureBox();
			Picture1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picDelChar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picUseChar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewChar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
			this.SuspendLayout();
			//
			// picDelChar
			//
			this.picDelChar.Name = "picDelChar";
			this.picDelChar.Location = new System.Drawing.Point(272, 232);
			this.picDelChar.Size = new System.Drawing.Size(200, 34);
			this.picDelChar.TabIndex = 6;
			this.picDelChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picDelChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picDelChar.Image = ((System.Drawing.Image)(resources.GetObject("picDelChar.Image")));
			this.picDelChar.TabStop = false;
			//
			// picUseChar
			//
			this.picUseChar.Name = "picUseChar";
			this.picUseChar.TabStop = false;
			this.picUseChar.Location = new System.Drawing.Point(272, 168);
			this.picUseChar.Size = new System.Drawing.Size(200, 34);
			this.picUseChar.TabIndex = 5;
			this.picUseChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picUseChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picUseChar.Image = ((System.Drawing.Image)(resources.GetObject("picUseChar.Image")));
			//
			// picNewChar
			//
			this.picNewChar.Name = "picNewChar";
			this.picNewChar.Image = ((System.Drawing.Image)(resources.GetObject("picNewChar.Image")));
			this.picNewChar.TabStop = false;
			this.picNewChar.Location = new System.Drawing.Point(272, 200);
			this.picNewChar.Size = new System.Drawing.Size(200, 34);
			this.picNewChar.TabIndex = 4;
			this.picNewChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picNewChar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			//
			// picCancel
			//
			this.picCancel.Name = "picCancel";
			this.picCancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picCancel.Image = ((System.Drawing.Image)(resources.GetObject("picCancel.Image")));
			this.picCancel.TabStop = false;
			this.picCancel.Location = new System.Drawing.Point(272, 264);
			this.picCancel.Size = new System.Drawing.Size(200, 34);
			this.picCancel.TabIndex = 3;
			this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			//
			// lstChars
			//
			this.lstChars.Name = "lstChars";
			this.lstChars.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.lstChars.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstChars.Location = new System.Drawing.Point(208, 72);
			this.lstChars.Size = new System.Drawing.Size(305, 78);
			this.lstChars.TabIndex = 2;
			this.lstChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstChars.Items.AddRange(new object[] {

		});
			//
			// picNewAccount
			//
			this.picNewAccount.Name = "picNewAccount";
			this.picNewAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picNewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("picNewAccount.Image")));
			this.picNewAccount.TabStop = false;
			this.picNewAccount.Location = new System.Drawing.Point(216, 8);
			this.picNewAccount.Size = new System.Drawing.Size(320, 55);
			this.picNewAccount.TabIndex = 1;
			//
			// Picture1
			//
			this.Picture1.Name = "Picture1";
			this.Picture1.TabIndex = 0;
			this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
			this.Picture1.TabStop = false;
			this.Picture1.Location = new System.Drawing.Point(0, 0);
			this.Picture1.Size = new System.Drawing.Size(201, 309);
			//
			// frmChars
			//
			this.Name = "frmChars";
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.Text = " ";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(546, 304);
			this.MaximizeBox = false;
			this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.picDelChar);
			this.Controls.Add(this.picUseChar);
			this.Controls.Add(this.picNewChar);
			this.Controls.Add(this.picCancel);
			this.Controls.Add(this.lstChars);
			this.Controls.Add(this.picNewAccount);
			this.Controls.Add(this.Picture1);
			((System.ComponentModel.ISupportInitialize)(this.picDelChar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picUseChar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewChar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.PictureBox picDelChar;
		private System.Windows.Forms.PictureBox picUseChar;
		private System.Windows.Forms.PictureBox picNewChar;
		private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.ListBox lstChars;
		private System.Windows.Forms.PictureBox picNewAccount;
		private System.Windows.Forms.PictureBox Picture1;
	}
}
