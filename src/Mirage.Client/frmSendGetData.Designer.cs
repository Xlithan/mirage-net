namespace Mirage
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendGetData));
			lblStatus = new System.Windows.Forms.Label();
			picDeleteAccount = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picDeleteAccount)).BeginInit();
			this.SuspendLayout();
			//
			// lblStatus
			//
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(192, 192, 255);
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(0, 16);
			this.lblStatus.Size = new System.Drawing.Size(321, 25);
			this.lblStatus.TabIndex = 1;
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
			this.picDeleteAccount.Controls.Add(this.lblStatus);
			//
			// frmSendGetData
			//
			this.Name = "frmSendGetData";
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(319, 55);
			this.Text = "Mirage Online";
			this.ControlBox = false;
			this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Controls.Add(this.picDeleteAccount);
			((System.ComponentModel.ISupportInitialize)(this.picDeleteAccount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.PictureBox picDeleteAccount;
	}
}
