namespace Mirage
{
	partial class frmKeyOpen
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
			scrlY = new System.Windows.Forms.HScrollBar();
			scrlX = new System.Windows.Forms.HScrollBar();
			lblY = new System.Windows.Forms.Label();
			lblX = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancel.Location = new System.Drawing.Point(168, 88);
			this.cmdCancel.Size = new System.Drawing.Size(145, 33);
			this.cmdCancel.TabIndex = 5;
			this.cmdCancel.Text = "Cancel";
			//
			// cmdOk
			//
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdOk.Location = new System.Drawing.Point(8, 88);
			this.cmdOk.Size = new System.Drawing.Size(145, 33);
			this.cmdOk.TabIndex = 4;
			this.cmdOk.Text = "Ok";
			//
			// scrlY
			//
			this.scrlY.Name = "scrlY";
			this.scrlY.Location = new System.Drawing.Point(32, 48);
			this.scrlY.Size = new System.Drawing.Size(249, 25);
			this.scrlY.TabIndex = 3;
			this.scrlY.Maximum = 11;
			//
			// scrlX
			//
			this.scrlX.Name = "scrlX";
			this.scrlX.TabIndex = 2;
			this.scrlX.Maximum = 15;
			this.scrlX.Location = new System.Drawing.Point(32, 16);
			this.scrlX.Size = new System.Drawing.Size(249, 25);
			//
			// lblY
			//
			this.lblY.Name = "lblY";
			this.lblY.Text = "0";
			this.lblY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblY.Location = new System.Drawing.Point(288, 48);
			this.lblY.Size = new System.Drawing.Size(25, 25);
			this.lblY.TabIndex = 7;
			this.lblY.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			// lblX
			//
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(25, 25);
			this.lblX.TabIndex = 6;
			this.lblX.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblX.Text = "0";
			this.lblX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX.Location = new System.Drawing.Point(288, 16);
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Location = new System.Drawing.Point(8, 48);
			this.Label2.Size = new System.Drawing.Size(17, 25);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Y";
			this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.Size = new System.Drawing.Size(17, 25);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "X";
			//
			// frmKeyOpen
			//
			this.Name = "frmKeyOpen";
			this.MinimizeBox = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(321, 130);
			this.ControlBox = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MaximizeBox = false;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Text = "Key Open";
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.scrlY);
			this.Controls.Add(this.scrlX);
			this.Controls.Add(this.lblY);
			this.Controls.Add(this.lblX);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
		}

		#endregion

		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.HScrollBar scrlY;
		private System.Windows.Forms.HScrollBar scrlX;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
	}
}
