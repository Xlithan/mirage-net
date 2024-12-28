namespace Mirage
{
	partial class frmMapWarp
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
			scrlX = new System.Windows.Forms.HScrollBar();
			scrlY = new System.Windows.Forms.HScrollBar();
			cmdOk = new System.Windows.Forms.Button();
			cmdCancel = new System.Windows.Forms.Button();
			txtMap = new System.Windows.Forms.TextBox();
			Label1 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			lblX = new System.Windows.Forms.Label();
			lblY = new System.Windows.Forms.Label();
			//
			// scrlX
			//
			this.scrlX.Name = "scrlX";
			this.scrlX.Location = new System.Drawing.Point(48, 40);
			this.scrlX.Size = new System.Drawing.Size(217, 17);
			this.scrlX.TabIndex = 4;
			this.scrlX.Maximum = 15;
			//
			// scrlY
			//
			this.scrlY.Name = "scrlY";
			this.scrlY.Location = new System.Drawing.Point(48, 64);
			this.scrlY.Size = new System.Drawing.Size(217, 17);
			this.scrlY.TabIndex = 3;
			this.scrlY.Maximum = 11;
			//
			// cmdOk
			//
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Location = new System.Drawing.Point(8, 96);
			this.cmdOk.Size = new System.Drawing.Size(137, 33);
			this.cmdOk.TabIndex = 2;
			this.cmdOk.Text = "Ok";
			this.cmdOk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancel.Location = new System.Drawing.Point(168, 96);
			this.cmdCancel.Size = new System.Drawing.Size(137, 33);
			this.cmdCancel.TabIndex = 1;
			this.cmdCancel.Text = "Cancel";
			//
			// txtMap
			//
			this.txtMap.Name = "txtMap";
			this.txtMap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMap.Location = new System.Drawing.Point(48, 8);
			this.txtMap.Size = new System.Drawing.Size(257, 26);
			this.txtMap.TabIndex = 0;
			this.txtMap.Text = "1";
			this.txtMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Text = "Map";
			this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Size = new System.Drawing.Size(33, 17);
			this.Label1.TabIndex = 9;
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(8, 40);
			this.Label2.Size = new System.Drawing.Size(33, 17);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "X";
			//
			// Label3
			//
			this.Label3.Name = "Label3";
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Y";
			this.Label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(8, 64);
			this.Label3.Size = new System.Drawing.Size(33, 17);
			//
			// lblX
			//
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(33, 17);
			this.lblX.TabIndex = 6;
			this.lblX.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblX.Text = "0";
			this.lblX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX.Location = new System.Drawing.Point(272, 40);
			//
			// lblY
			//
			this.lblY.Name = "lblY";
			this.lblY.Text = "0";
			this.lblY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblY.Location = new System.Drawing.Point(272, 64);
			this.lblY.Size = new System.Drawing.Size(33, 17);
			this.lblY.TabIndex = 5;
			this.lblY.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			// frmMapWarp
			//
			this.Name = "frmMapWarp";
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(314, 138);
			this.Text = "Map Warp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Controls.Add(this.scrlX);
			this.Controls.Add(this.scrlY);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.txtMap);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.lblX);
			this.Controls.Add(this.lblY);
		}

		#endregion

		private System.Windows.Forms.HScrollBar scrlX;
		private System.Windows.Forms.HScrollBar scrlY;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.TextBox txtMap;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.Label lblY;
	}
}
