namespace Mirage
{
	partial class frmMapKey
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
			chkTake = new System.Windows.Forms.CheckBox();
			scrlItem = new System.Windows.Forms.HScrollBar();
			cmdOk = new System.Windows.Forms.Button();
			cmdCancel = new System.Windows.Forms.Button();
			Label2 = new System.Windows.Forms.Label();
			lblItem = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			lblName = new System.Windows.Forms.Label();
			//
			// chkTake
			//
			this.chkTake.Name = "chkTake";
			this.chkTake.Location = new System.Drawing.Point(8, 72);
			this.chkTake.Size = new System.Drawing.Size(297, 25);
			this.chkTake.TabIndex = 7;
			this.chkTake.Text = "Take key away upon use";
			this.chkTake.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// scrlItem
			//
			this.scrlItem.Name = "scrlItem";
			this.scrlItem.TabIndex = 2;
			this.scrlItem.Maximum = 255;
			this.scrlItem.Value = 1;
			this.scrlItem.Location = new System.Drawing.Point(56, 40);
			this.scrlItem.Size = new System.Drawing.Size(217, 17);
			//
			// cmdOk
			//
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdOk.Location = new System.Drawing.Point(8, 112);
			this.cmdOk.Size = new System.Drawing.Size(145, 33);
			this.cmdOk.TabIndex = 1;
			this.cmdOk.Text = "Ok";
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancel.Location = new System.Drawing.Point(168, 112);
			this.cmdCancel.Size = new System.Drawing.Size(145, 33);
			this.cmdCancel.TabIndex = 0;
			this.cmdCancel.Text = "Cancel";
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(8, 40);
			this.Label2.Size = new System.Drawing.Size(41, 17);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Item";
			//
			// lblItem
			//
			this.lblItem.Name = "lblItem";
			this.lblItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblItem.Location = new System.Drawing.Point(272, 40);
			this.lblItem.Size = new System.Drawing.Size(33, 17);
			this.lblItem.TabIndex = 5;
			this.lblItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblItem.Text = "1";
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Size = new System.Drawing.Size(41, 17);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Item";
			//
			// lblName
			//
			this.lblName.Name = "lblName";
			this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(56, 8);
			this.lblName.Size = new System.Drawing.Size(249, 25);
			this.lblName.TabIndex = 3;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			//
			// frmMapKey
			//
			this.Name = "frmMapKey";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(321, 154);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Text = "Map Key";
			this.ControlBox = false;
			this.Controls.Add(this.chkTake);
			this.Controls.Add(this.scrlItem);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.lblItem);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lblName);
		}

		#endregion

		private System.Windows.Forms.CheckBox chkTake;
		private System.Windows.Forms.HScrollBar scrlItem;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label lblItem;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label lblName;
	}
}
