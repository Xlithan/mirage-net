namespace Mirage
{
	partial class frmMapItem
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
			scrlValue = new System.Windows.Forms.HScrollBar();
			scrlItem = new System.Windows.Forms.HScrollBar();
			lblName = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			lblValue = new System.Windows.Forms.Label();
			lblItem = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Location = new System.Drawing.Point(176, 96);
			this.cmdCancel.Size = new System.Drawing.Size(153, 33);
			this.cmdCancel.TabIndex = 3;
			this.cmdCancel.Text = "Cancel";
			//
			// cmdOk
			//
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.TabIndex = 2;
			this.cmdOk.Text = "Ok";
			this.cmdOk.Location = new System.Drawing.Point(8, 96);
			this.cmdOk.Size = new System.Drawing.Size(153, 33);
			//
			// scrlValue
			//
			this.scrlValue.Name = "scrlValue";
			this.scrlValue.TabIndex = 1;
			this.scrlValue.Value = 1;
			this.scrlValue.Location = new System.Drawing.Point(56, 64);
			this.scrlValue.Size = new System.Drawing.Size(217, 17);
			//
			// scrlItem
			//
			this.scrlItem.Name = "scrlItem";
			this.scrlItem.Maximum = 255;
			this.scrlItem.Value = 1;
			this.scrlItem.Location = new System.Drawing.Point(56, 40);
			this.scrlItem.Size = new System.Drawing.Size(217, 17);
			this.scrlItem.TabIndex = 0;
			//
			// lblName
			//
			this.lblName.Name = "lblName";
			this.lblName.TabIndex = 9;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Location = new System.Drawing.Point(56, 8);
			this.lblName.Size = new System.Drawing.Size(249, 25);
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Size = new System.Drawing.Size(41, 17);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Item";
			//
			// lblValue
			//
			this.lblValue.Name = "lblValue";
			this.lblValue.Location = new System.Drawing.Point(272, 64);
			this.lblValue.Size = new System.Drawing.Size(57, 17);
			this.lblValue.TabIndex = 7;
			this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblValue.Text = "0";
			//
			// lblItem
			//
			this.lblItem.Name = "lblItem";
			this.lblItem.Location = new System.Drawing.Point(272, 40);
			this.lblItem.Size = new System.Drawing.Size(57, 17);
			this.lblItem.TabIndex = 6;
			this.lblItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblItem.Text = "0";
			//
			// Label3
			//
			this.Label3.Name = "Label3";
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Value";
			this.Label3.Location = new System.Drawing.Point(8, 64);
			this.Label3.Size = new System.Drawing.Size(41, 17);
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Item";
			this.Label2.Location = new System.Drawing.Point(8, 40);
			this.Label2.Size = new System.Drawing.Size(41, 17);
			//
			// frmMapItem
			//
			this.Name = "frmMapItem";
			this.Text = "Map Item";
			this.MinimizeBox = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(338, 139);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.scrlValue);
			this.Controls.Add(this.scrlItem);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.lblItem);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
		}

		#endregion

		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.HScrollBar scrlValue;
		private System.Windows.Forms.HScrollBar scrlItem;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.Label lblItem;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
	}
}
