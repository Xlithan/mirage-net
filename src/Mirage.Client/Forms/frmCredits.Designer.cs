namespace Mirage.Forms
{
	partial class frmCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredits));
            picCredits = new PictureBox();
            picCancel = new PictureBox();
            Picture1 = new PictureBox();
            Label6 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCredits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).BeginInit();
            SuspendLayout();
            // 
            // picCredits
            // 
            picCredits.Image = (Image)resources.GetObject("picCredits.Image");
            picCredits.Location = new Point(216, 8);
            picCredits.Name = "picCredits";
            picCredits.Size = new Size(320, 55);
            picCredits.SizeMode = PictureBoxSizeMode.AutoSize;
            picCredits.TabIndex = 6;
            picCredits.TabStop = false;
            // 
            // picCancel
            // 
            picCancel.Image = (Image)resources.GetObject("picCancel.Image");
            picCancel.Location = new Point(272, 264);
            picCancel.Name = "picCancel";
            picCancel.Size = new Size(200, 34);
            picCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            picCancel.TabIndex = 5;
            picCancel.TabStop = false;
            picCancel.Click += picCancel_Click;
            // 
            // Picture1
            // 
            Picture1.Image = (Image)resources.GetObject("Picture1.Image");
            Picture1.Location = new Point(0, 0);
            Picture1.Name = "Picture1";
            Picture1.Size = new Size(201, 309);
            Picture1.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture1.TabIndex = 0;
            Picture1.TabStop = false;
            // 
            // Label6
            // 
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.FromArgb(0, 0, 255);
            Label6.Location = new Point(224, 184);
            Label6.Name = "Label6";
            Label6.Size = new Size(297, 25);
            Label6.TabIndex = 8;
            Label6.Text = "GUI Art";
            Label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label4
            // 
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.FromArgb(192, 192, 255);
            Label4.Location = new Point(224, 208);
            Label4.Name = "Label4";
            Label4.Size = new Size(297, 25);
            Label4.TabIndex = 7;
            Label4.Text = "Jess Triska (Loken)";
            Label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label5
            // 
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.FromArgb(192, 192, 255);
            Label5.Location = new Point(224, 152);
            Label5.Name = "Label5";
            Label5.Size = new Size(297, 25);
            Label5.TabIndex = 4;
            Label5.Text = "Copyright (c) Square Soft";
            Label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label3
            // 
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(0, 0, 255);
            Label3.Location = new Point(224, 128);
            Label3.Name = "Label3";
            Label3.Size = new Size(297, 25);
            Label3.TabIndex = 3;
            Label3.Text = "Tile/Sprite Art";
            Label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label2
            // 
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(192, 192, 255);
            Label2.Location = new Point(224, 96);
            Label2.Name = "Label2";
            Label2.Size = new Size(297, 25);
            Label2.TabIndex = 2;
            Label2.Text = "Chris Kremer (Torquel/Valient/Consty)";
            Label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label1
            // 
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(0, 0, 255);
            Label1.Location = new Point(224, 72);
            Label1.Name = "Label1";
            Label1.Size = new Size(297, 25);
            Label1.TabIndex = 1;
            Label1.Text = "Programming";
            Label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmCredits
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(546, 304);
            ControlBox = false;
            Controls.Add(picCredits);
            Controls.Add(picCancel);
            Controls.Add(Picture1);
            Controls.Add(Label6);
            Controls.Add(Label4);
            Controls.Add(Label5);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCredits";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mirage Online (Credits)";
            ((System.ComponentModel.ISupportInitialize)picCredits).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picCredits;
		private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.PictureBox Picture1;
		private System.Windows.Forms.Label Label6;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
	}
}
