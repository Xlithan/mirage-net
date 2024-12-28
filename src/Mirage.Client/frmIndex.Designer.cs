namespace Mirage
{
	partial class frmIndex
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
			cmdCancel = new System.Windows.Forms.Button();
			cmdOk = new System.Windows.Forms.Button();
			lstIndex = new System.Windows.Forms.ListBox();
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.TabIndex = 2;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.Location = new System.Drawing.Point(184, 256);
			this.cmdCancel.Size = new System.Drawing.Size(161, 33);
			//
			// cmdOk
			//
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Location = new System.Drawing.Point(8, 256);
			this.cmdOk.Size = new System.Drawing.Size(161, 33);
			this.cmdOk.TabIndex = 1;
			this.cmdOk.Text = "Ok";
			//
			// lstIndex
			//
			this.lstIndex.Name = "lstIndex";
			this.lstIndex.Location = new System.Drawing.Point(8, 8);
			this.lstIndex.Size = new System.Drawing.Size(337, 238);
			this.lstIndex.TabIndex = 0;
			//
			// frmIndex
			//
			this.Name = "frmIndex";
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MaximizeBox = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(353, 298);
			this.Text = "Index";
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.lstIndex);
		}

		#endregion

		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.ListBox lstIndex;
	}
}
