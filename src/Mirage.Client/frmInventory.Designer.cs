namespace Mirage
{
	partial class frmInventory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
			picCancel = new System.Windows.Forms.PictureBox();
			picDropItem = new System.Windows.Forms.PictureBox();
			picUseItem = new System.Windows.Forms.PictureBox();
			lstInv = new System.Windows.Forms.ListBox();
			picNewAccount = new System.Windows.Forms.PictureBox();
			Picture1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDropItem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picUseItem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
			this.SuspendLayout();
			//
			// picCancel
			//
			this.picCancel.Name = "picCancel";
			this.picCancel.Image = ((System.Drawing.Image)(resources.GetObject("picCancel.Image")));
			this.picCancel.TabStop = false;
			this.picCancel.Location = new System.Drawing.Point(256, 264);
			this.picCancel.Size = new System.Drawing.Size(200, 34);
			this.picCancel.TabIndex = 5;
			this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picCancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			//
			// picDropItem
			//
			this.picDropItem.Name = "picDropItem";
			this.picDropItem.Location = new System.Drawing.Point(256, 232);
			this.picDropItem.Size = new System.Drawing.Size(200, 34);
			this.picDropItem.TabIndex = 4;
			this.picDropItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picDropItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picDropItem.Image = ((System.Drawing.Image)(resources.GetObject("picDropItem.Image")));
			this.picDropItem.TabStop = false;
			//
			// picUseItem
			//
			this.picUseItem.Name = "picUseItem";
			this.picUseItem.Location = new System.Drawing.Point(256, 200);
			this.picUseItem.Size = new System.Drawing.Size(200, 34);
			this.picUseItem.TabIndex = 3;
			this.picUseItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picUseItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picUseItem.Image = ((System.Drawing.Image)(resources.GetObject("picUseItem.Image")));
			this.picUseItem.TabStop = false;
			//
			// lstInv
			//
			this.lstInv.Name = "lstInv";
			this.lstInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstInv.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.lstInv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstInv.Location = new System.Drawing.Point(208, 64);
			this.lstInv.Size = new System.Drawing.Size(193, 128);
			this.lstInv.TabIndex = 2;
			this.lstInv.Items.AddRange(new object[] {

		});
			//
			// picNewAccount
			//
			this.picNewAccount.Name = "picNewAccount";
			this.picNewAccount.Location = new System.Drawing.Point(200, 8);
			this.picNewAccount.Size = new System.Drawing.Size(320, 55);
			this.picNewAccount.TabIndex = 1;
			this.picNewAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picNewAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picNewAccount.Image = ((System.Drawing.Image)(resources.GetObject("picNewAccount.Image")));
			this.picNewAccount.TabStop = false;
			this.picNewAccount.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// Picture1
			//
			this.Picture1.Name = "Picture1";
			this.Picture1.TabStop = false;
			this.Picture1.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Picture1.Location = new System.Drawing.Point(0, 0);
			this.Picture1.Size = new System.Drawing.Size(200, 274);
			this.Picture1.TabIndex = 0;
			this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
			//
			// frmInventory
			//
			this.Name = "frmInventory";
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Text = "Mirage Online (Inventory)";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(546, 304);
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.Controls.Add(this.picCancel);
			this.Controls.Add(this.picDropItem);
			this.Controls.Add(this.picUseItem);
			this.Controls.Add(this.lstInv);
			this.Controls.Add(this.picNewAccount);
			this.Controls.Add(this.Picture1);
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDropItem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picUseItem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.PictureBox picDropItem;
		private System.Windows.Forms.PictureBox picUseItem;
		private System.Windows.Forms.ListBox lstInv;
		private System.Windows.Forms.PictureBox picNewAccount;
		private System.Windows.Forms.PictureBox Picture1;
	}
}
