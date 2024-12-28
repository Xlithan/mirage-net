namespace Mirage
{
	partial class frmTraining
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraining));
			cmbStat = new System.Windows.Forms.ComboBox();
			picCancel = new System.Windows.Forms.PictureBox();
			picTrain = new System.Windows.Forms.PictureBox();
			picTraining = new System.Windows.Forms.PictureBox();
			Picture1 = new System.Windows.Forms.PictureBox();
			Label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTraining)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
			this.SuspendLayout();
			//
			// cmbStat
			//
			this.cmbStat.Name = "cmbStat";
			this.cmbStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStat.FormattingEnabled = true;
			this.cmbStat.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.cmbStat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbStat.Location = new System.Drawing.Point(224, 144);
			this.cmbStat.Size = new System.Drawing.Size(305, 27);
			this.cmbStat.TabIndex = 5;
			this.cmbStat.Items.AddRange(new object[] {
			"Strength",
			"Defense",
			"Magic",
			"Speed"
		});
			//
			// picCancel
			//
			this.picCancel.Name = "picCancel";
			this.picCancel.TabStop = false;
			this.picCancel.Location = new System.Drawing.Point(272, 264);
			this.picCancel.Size = new System.Drawing.Size(200, 34);
			this.picCancel.TabIndex = 3;
			this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picCancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picCancel.Image = ((System.Drawing.Image)(resources.GetObject("picCancel.Image")));
			//
			// picTrain
			//
			this.picTrain.Name = "picTrain";
			this.picTrain.Size = new System.Drawing.Size(200, 34);
			this.picTrain.TabIndex = 2;
			this.picTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picTrain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picTrain.Image = ((System.Drawing.Image)(resources.GetObject("picTrain.Image")));
			this.picTrain.TabStop = false;
			this.picTrain.Location = new System.Drawing.Point(272, 232);
			//
			// picTraining
			//
			this.picTraining.Name = "picTraining";
			this.picTraining.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picTraining.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picTraining.Image = ((System.Drawing.Image)(resources.GetObject("picTraining.Image")));
			this.picTraining.TabStop = false;
			this.picTraining.Location = new System.Drawing.Point(216, 8);
			this.picTraining.Size = new System.Drawing.Size(320, 55);
			this.picTraining.TabIndex = 1;
			//
			// Picture1
			//
			this.Picture1.Name = "Picture1";
			this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Picture1.Image = ((System.Drawing.Image)(resources.GetObject("Picture1.Image")));
			this.Picture1.TabStop = false;
			this.Picture1.Location = new System.Drawing.Point(0, 0);
			this.Picture1.Size = new System.Drawing.Size(201, 309);
			this.Picture1.TabIndex = 0;
			this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(224, 72);
			this.Label2.Size = new System.Drawing.Size(305, 65);
			this.Label2.TabIndex = 4;
			this.Label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
			this.Label2.Text = "What stat would you like to train?";
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			//
			// frmTraining
			//
			this.Name = "frmTraining";
			this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(546, 304);
			this.MinimizeBox = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Text = " ";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.Controls.Add(this.cmbStat);
			this.Controls.Add(this.picCancel);
			this.Controls.Add(this.picTrain);
			this.Controls.Add(this.picTraining);
			this.Controls.Add(this.Picture1);
			this.Controls.Add(this.Label2);
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTraining)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ComboBox cmbStat;
		private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.PictureBox picTrain;
		private System.Windows.Forms.PictureBox picTraining;
		private System.Windows.Forms.PictureBox Picture1;
		private System.Windows.Forms.Label Label2;
	}
}
