namespace Mirage
{
	partial class frmDebug
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
			txtDebug = new System.Windows.Forms.TextBox();
			//
			// txtDebug
			//
			this.txtDebug.Name = "txtDebug";
			this.txtDebug.TabIndex = 0;
			this.txtDebug.Multiline = true;
			this.txtDebug.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDebug.Location = new System.Drawing.Point(8, 8);
			this.txtDebug.Size = new System.Drawing.Size(513, 497);
			//
			// frmDebug
			//
			this.Name = "frmDebug";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MinimizeBox = false;
			this.Visible = false;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClientSize = new System.Drawing.Size(529, 515);
			this.Text = " ";
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.Controls.Add(this.txtDebug);
		}

		#endregion

		private System.Windows.Forms.TextBox txtDebug;
	}
}
