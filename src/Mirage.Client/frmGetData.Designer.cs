namespace Mirage
{
	partial class frmGetData
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetData));
			picDeleteAccount = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picDeleteAccount)).BeginInit();
			this.SuspendLayout();
			//
			// picDeleteAccount
			//
			this.picDeleteAccount.Name = "picDeleteAccount";
			this.picDeleteAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("picDeleteAccount.Image")));
			this.picDeleteAccount.TabStop = false;
			this.picDeleteAccount.Location = new System.Drawing.Point(0, 0);
			this.picDeleteAccount.Size = new System.Drawing.Size(320, 55);
			this.picDeleteAccount.TabIndex = 0;
			this.picDeleteAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			//
			// frmGetData
			//
			this.Name = "frmGetData";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(319, 55);
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Text = "Mirage Online";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MinimizeBox = false;
			this.Controls.Add(this.picDeleteAccount);
			((System.ComponentModel.ISupportInitialize)(this.picDeleteAccount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.PictureBox picDeleteAccount;
	}
}
