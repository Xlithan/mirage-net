namespace Mirage.Forms
{
	partial class frmNewChar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewChar));
            picCancel = new PictureBox();
            optFemale = new RadioButton();
            optMale = new RadioButton();
            cmbClass = new ComboBox();
            txtName = new TextBox();
            Picture1 = new PictureBox();
            picNewAccount = new PictureBox();
            picAddChar = new PictureBox();
            lblMAGI = new Label();
            lblDEF = new Label();
            lblSP = new Label();
            lblSPEED = new Label();
            lblMP = new Label();
            lblSTR = new Label();
            lblHP = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNewAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAddChar).BeginInit();
            SuspendLayout();
            // 
            // picCancel
            // 
            picCancel.Image = (Image)resources.GetObject("picCancel.Image");
            picCancel.Location = new Point(272, 264);
            picCancel.Name = "picCancel";
            picCancel.Size = new Size(200, 34);
            picCancel.SizeMode = PictureBoxSizeMode.AutoSize;
            picCancel.TabIndex = 24;
            picCancel.TabStop = false;
            picCancel.Click += picCancel_Click;
            // 
            // optFemale
            // 
            optFemale.BackColor = Color.FromArgb(0, 0, 0);
            optFemale.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            optFemale.ForeColor = Color.FromArgb(0, 0, 255);
            optFemale.Location = new Point(392, 144);
            optFemale.Name = "optFemale";
            optFemale.Size = new Size(81, 17);
            optFemale.TabIndex = 9;
            optFemale.Text = "Female";
            optFemale.UseVisualStyleBackColor = false;
            optFemale.Visible = false;
            // 
            // optMale
            // 
            optMale.BackColor = Color.FromArgb(0, 0, 0);
            optMale.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            optMale.ForeColor = Color.FromArgb(0, 0, 255);
            optMale.Location = new Point(312, 144);
            optMale.Name = "optMale";
            optMale.Size = new Size(73, 17);
            optMale.TabIndex = 8;
            optMale.Text = "Male";
            optMale.UseVisualStyleBackColor = false;
            optMale.Visible = false;
            // 
            // cmbClass
            // 
            cmbClass.BackColor = Color.FromArgb(0, 0, 0);
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.FlatStyle = FlatStyle.Flat;
            cmbClass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbClass.ForeColor = Color.FromArgb(192, 192, 255);
            cmbClass.Location = new Point(304, 112);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(225, 27);
            cmbClass.TabIndex = 5;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(0, 0, 64);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(192, 192, 255);
            txtName.Location = new Point(304, 80);
            txtName.MaxLength = 20;
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 19);
            txtName.TabIndex = 3;
            // 
            // Picture1
            // 
            Picture1.Image = (Image)resources.GetObject("Picture1.Image");
            Picture1.Location = new Point(0, 0);
            Picture1.Name = "Picture1";
            Picture1.Size = new Size(201, 309);
            Picture1.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture1.TabIndex = 2;
            Picture1.TabStop = false;
            // 
            // picNewAccount
            // 
            picNewAccount.Image = (Image)resources.GetObject("picNewAccount.Image");
            picNewAccount.Location = new Point(216, 8);
            picNewAccount.Name = "picNewAccount";
            picNewAccount.Size = new Size(320, 55);
            picNewAccount.SizeMode = PictureBoxSizeMode.AutoSize;
            picNewAccount.TabIndex = 1;
            picNewAccount.TabStop = false;
            // 
            // picAddChar
            // 
            picAddChar.Image = (Image)resources.GetObject("picAddChar.Image");
            picAddChar.Location = new Point(272, 232);
            picAddChar.Name = "picAddChar";
            picAddChar.Size = new Size(200, 34);
            picAddChar.SizeMode = PictureBoxSizeMode.AutoSize;
            picAddChar.TabIndex = 0;
            picAddChar.TabStop = false;
            picAddChar.Click += picAddChar_Click;
            // 
            // lblMAGI
            // 
            lblMAGI.BackColor = Color.Transparent;
            lblMAGI.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMAGI.ForeColor = Color.FromArgb(192, 192, 255);
            lblMAGI.Location = new Point(520, 200);
            lblMAGI.Name = "lblMAGI";
            lblMAGI.Size = new Size(25, 25);
            lblMAGI.TabIndex = 23;
            lblMAGI.Text = "0";
            lblMAGI.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDEF
            // 
            lblDEF.BackColor = Color.Transparent;
            lblDEF.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDEF.ForeColor = Color.FromArgb(192, 192, 255);
            lblDEF.Location = new Point(328, 200);
            lblDEF.Name = "lblDEF";
            lblDEF.Size = new Size(25, 25);
            lblDEF.TabIndex = 22;
            lblDEF.Text = "0";
            lblDEF.TextAlign = ContentAlignment.TopRight;
            // 
            // lblSP
            // 
            lblSP.BackColor = Color.Transparent;
            lblSP.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSP.ForeColor = Color.FromArgb(192, 192, 255);
            lblSP.Location = new Point(432, 176);
            lblSP.Name = "lblSP";
            lblSP.Size = new Size(25, 25);
            lblSP.TabIndex = 21;
            lblSP.Text = "0";
            lblSP.TextAlign = ContentAlignment.TopRight;
            // 
            // lblSPEED
            // 
            lblSPEED.BackColor = Color.Transparent;
            lblSPEED.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPEED.ForeColor = Color.FromArgb(192, 192, 255);
            lblSPEED.Location = new Point(432, 200);
            lblSPEED.Name = "lblSPEED";
            lblSPEED.Size = new Size(25, 25);
            lblSPEED.TabIndex = 20;
            lblSPEED.Text = "0";
            lblSPEED.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMP
            // 
            lblMP.BackColor = Color.Transparent;
            lblMP.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMP.ForeColor = Color.FromArgb(192, 192, 255);
            lblMP.Location = new Point(328, 176);
            lblMP.Name = "lblMP";
            lblMP.Size = new Size(25, 25);
            lblMP.TabIndex = 19;
            lblMP.Text = "0";
            lblMP.TextAlign = ContentAlignment.TopRight;
            // 
            // lblSTR
            // 
            lblSTR.BackColor = Color.Transparent;
            lblSTR.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSTR.ForeColor = Color.FromArgb(192, 192, 255);
            lblSTR.Location = new Point(256, 200);
            lblSTR.Name = "lblSTR";
            lblSTR.Size = new Size(25, 25);
            lblSTR.TabIndex = 18;
            lblSTR.Text = "0";
            lblSTR.TextAlign = ContentAlignment.TopRight;
            // 
            // lblHP
            // 
            lblHP.BackColor = Color.Transparent;
            lblHP.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHP.ForeColor = Color.FromArgb(192, 192, 255);
            lblHP.Location = new Point(256, 176);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(25, 25);
            lblHP.TabIndex = 17;
            lblHP.Text = "0";
            lblHP.TextAlign = ContentAlignment.TopRight;
            // 
            // Label10
            // 
            Label10.BackColor = Color.Transparent;
            Label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.ForeColor = Color.FromArgb(0, 0, 255);
            Label10.Location = new Point(376, 200);
            Label10.Name = "Label10";
            Label10.Size = new Size(57, 25);
            Label10.TabIndex = 16;
            Label10.Text = "SPEED";
            // 
            // Label9
            // 
            Label9.BackColor = Color.Transparent;
            Label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.FromArgb(0, 0, 255);
            Label9.Location = new Point(480, 200);
            Label9.Name = "Label9";
            Label9.Size = new Size(41, 25);
            Label9.TabIndex = 15;
            Label9.Text = "MAGI";
            // 
            // Label8
            // 
            Label8.BackColor = Color.Transparent;
            Label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.FromArgb(0, 0, 255);
            Label8.Location = new Point(376, 176);
            Label8.Name = "Label8";
            Label8.Size = new Size(57, 25);
            Label8.TabIndex = 14;
            Label8.Text = "SP";
            // 
            // Label7
            // 
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.FromArgb(0, 0, 255);
            Label7.Location = new Point(224, 176);
            Label7.Name = "Label7";
            Label7.Size = new Size(41, 25);
            Label7.TabIndex = 13;
            Label7.Text = "HP";
            // 
            // Label6
            // 
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.FromArgb(0, 0, 255);
            Label6.Location = new Point(296, 176);
            Label6.Name = "Label6";
            Label6.Size = new Size(33, 25);
            Label6.TabIndex = 12;
            Label6.Text = "MP";
            // 
            // Label5
            // 
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.FromArgb(0, 0, 255);
            Label5.Location = new Point(296, 200);
            Label5.Name = "Label5";
            Label5.Size = new Size(33, 25);
            Label5.TabIndex = 11;
            Label5.Text = "DEF";
            // 
            // Label4
            // 
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.FromArgb(0, 0, 255);
            Label4.Location = new Point(224, 200);
            Label4.Name = "Label4";
            Label4.Size = new Size(41, 25);
            Label4.TabIndex = 10;
            Label4.Text = "STR";
            // 
            // Label3
            // 
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(0, 0, 255);
            Label3.Location = new Point(224, 144);
            Label3.Name = "Label3";
            Label3.Size = new Size(57, 25);
            Label3.TabIndex = 7;
            Label3.Text = "Sex";
            Label3.Visible = false;
            // 
            // Label2
            // 
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(0, 0, 255);
            Label2.Location = new Point(224, 112);
            Label2.Name = "Label2";
            Label2.Size = new Size(57, 25);
            Label2.TabIndex = 6;
            Label2.Text = "Class";
            // 
            // Label1
            // 
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(0, 0, 255);
            Label1.Location = new Point(224, 80);
            Label1.Name = "Label1";
            Label1.Size = new Size(57, 25);
            Label1.TabIndex = 4;
            Label1.Text = "Name";
            // 
            // frmNewChar
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 0);
            ClientSize = new Size(546, 304);
            ControlBox = false;
            Controls.Add(picCancel);
            Controls.Add(optFemale);
            Controls.Add(optMale);
            Controls.Add(cmbClass);
            Controls.Add(txtName);
            Controls.Add(Picture1);
            Controls.Add(picNewAccount);
            Controls.Add(picAddChar);
            Controls.Add(lblMAGI);
            Controls.Add(lblDEF);
            Controls.Add(lblSP);
            Controls.Add(lblSPEED);
            Controls.Add(lblMP);
            Controls.Add(lblSTR);
            Controls.Add(lblHP);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewChar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)picCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNewAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAddChar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.RadioButton optFemale;
		public System.Windows.Forms.RadioButton optMale;
		public System.Windows.Forms.ComboBox cmbClass;
		public System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.PictureBox Picture1;
		private System.Windows.Forms.PictureBox picNewAccount;
		private System.Windows.Forms.PictureBox picAddChar;
		private System.Windows.Forms.Label lblMAGI;
		private System.Windows.Forms.Label lblDEF;
		private System.Windows.Forms.Label lblSP;
		private System.Windows.Forms.Label lblSPEED;
		private System.Windows.Forms.Label lblMP;
		private System.Windows.Forms.Label lblSTR;
		private System.Windows.Forms.Label lblHP;
		private System.Windows.Forms.Label Label10;
		private System.Windows.Forms.Label Label9;
		private System.Windows.Forms.Label Label8;
		private System.Windows.Forms.Label Label7;
		private System.Windows.Forms.Label Label6;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
	}
}
