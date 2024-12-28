namespace Mirage
{
	partial class frmLoad
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
			lblStatus = new System.Windows.Forms.Label();
			//
			// lblStatus
			//
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Location = new System.Drawing.Point(8, 8);
			this.lblStatus.Size = new System.Drawing.Size(393, 25);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblStatus.Font = new System.Drawing.Font("MS Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// frmLoad
			//
			this.Name = "frmLoad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(410, 42);
			this.Text = "Mirage Server";
			this.Controls.Add(this.lblStatus);
		}

		#endregion

		private System.Windows.Forms.Label lblStatus;
	}
}
