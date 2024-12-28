namespace Mirage
{
	partial class frmFixItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFixItem));
			cmbItem = new System.Windows.Forms.ComboBox();
			picCancel = new System.Windows.Forms.PictureBox();
			chkFix = new System.Windows.Forms.PictureBox();
			picNewAccount = new System.Windows.Forms.PictureBox();
			Picture1 = new System.Windows.Forms.PictureBox();
			Label1 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFix)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
			this.SuspendLayout();
			//
			// cmbItem
			//
			this.cmbItem.Name = "cmbItem";
			this.cmbItem.Location = new System.Drawing.Point(280, 120);
			this.cmbItem.Size = new System.Drawing.Size(249, 27);
			this.cmbItem.TabIndex = 4;
			this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbItem.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.cmbItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// picCancel
			//
			this.picCancel.Name = "picCancel";
			this.picCancel.Image = ((System.Drawing.Image)(resources.GetObject("picCancel.Image")));
			this.picCancel.TabStop = false;
			this.picCancel.Location = new System.Drawing.Point(272, 264);
			this.picCancel.Size = new System.Drawing.Size(200, 34);
			this.picCancel.TabIndex = 3;
			this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picCancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			//
			// chkFix
			//
			this.chkFix.Name = "chkFix";
			this.chkFix.Location = new System.Drawing.Point(272, 232);
			this.chkFix.Size = new System.Drawing.Size(200, 34);
			this.chkFix.TabIndex = 2;
			this.chkFix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.chkFix.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.chkFix.Image = ((System.Drawing.Image)(resources.GetObject("chkFix.Image")));
			this.chkFix.TabStop = false;
			//
			// picNewAccount
			//
			this.picNewAccount.Name = "picNewAccount";
			this.picNewAccount.Size = new System.Drawing.Size(320, 55);
			this.picNewAccount.TabIndex = 1;
			this.picNewAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picNewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("picNewAccount.Image")));
			this.picNewAccount.TabStop = false;
			this.picNewAccount.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picNewAccount.Location = new System.Drawing.Point(216, 8);
			//
			// Picture1
			//
			this.Picture1.Name = "Picture1";
			this.Picture1.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Picture1.Location = new System.Drawing.Point(0, 0);
			this.Picture1.Size = new System.Drawing.Size(201, 309);
			this.Picture1.TabIndex = 0;
			this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
			this.Picture1.TabStop = false;
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(305, 25);
			this.Label1.TabIndex = 6;
			this.Label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
			this.Label1.Text = "Please select the item you wish to fix.";
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(224, 80);
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Location = new System.Drawing.Point(224, 120);
			this.Label2.Size = new System.Drawing.Size(57, 25);
			this.Label2.TabIndex = 5;
			this.Label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
			this.Label2.Text = "Item";
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// frmFixItem
			//
			this.Name = "frmFixItem";
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MinimizeBox = false;
			this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(546, 304);
			this.Text = " ";
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.Controls.Add(this.cmbItem);
			this.Controls.Add(this.picCancel);
			this.Controls.Add(this.chkFix);
			this.Controls.Add(this.picNewAccount);
			this.Controls.Add(this.Picture1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label2);
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFix)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ComboBox cmbItem;
		private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.PictureBox chkFix;
		private System.Windows.Forms.PictureBox picNewAccount;
		private System.Windows.Forms.PictureBox Picture1;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label2;
	}
}
