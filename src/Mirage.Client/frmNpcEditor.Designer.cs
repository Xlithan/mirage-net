namespace Mirage
{
	partial class frmNpcEditor
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
			txtSpawnSecs = new System.Windows.Forms.TextBox();
			txtAttackSay = new System.Windows.Forms.TextBox();
			tmrSprite = new System.Windows.Forms.Timer(this.components);
			picSprites = new System.Windows.Forms.PictureBox();
			cmdCancel = new System.Windows.Forms.Button();
			cmdOk = new System.Windows.Forms.Button();
			scrlValue = new System.Windows.Forms.HScrollBar();
			scrlNum = new System.Windows.Forms.HScrollBar();
			txtChance = new System.Windows.Forms.TextBox();
			scrlMAGI = new System.Windows.Forms.HScrollBar();
			scrlSPEED = new System.Windows.Forms.HScrollBar();
			scrlDEF = new System.Windows.Forms.HScrollBar();
			scrlSTR = new System.Windows.Forms.HScrollBar();
			scrlRange = new System.Windows.Forms.HScrollBar();
			cmbBehavior = new System.Windows.Forms.ComboBox();
			txtName = new System.Windows.Forms.TextBox();
			scrlSprite = new System.Windows.Forms.HScrollBar();
			picSprite = new System.Windows.Forms.PictureBox();
			Label16 = new System.Windows.Forms.Label();
			Label14 = new System.Windows.Forms.Label();
			lblExpGiven = new System.Windows.Forms.Label();
			Label15 = new System.Windows.Forms.Label();
			lblStartHP = new System.Windows.Forms.Label();
			Label13 = new System.Windows.Forms.Label();
			lblValue = new System.Windows.Forms.Label();
			Label7 = new System.Windows.Forms.Label();
			lblItemName = new System.Windows.Forms.Label();
			Label11 = new System.Windows.Forms.Label();
			Label9 = new System.Windows.Forms.Label();
			lblNum = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			Label12 = new System.Windows.Forms.Label();
			lblMAGI = new System.Windows.Forms.Label();
			Label10 = new System.Windows.Forms.Label();
			lblSPEED = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			lblDEF = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			lblSTR = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			lblRange = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			lblSprite = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picSprites)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
			this.SuspendLayout();
			//
			// txtSpawnSecs
			//
			this.txtSpawnSecs.Name = "txtSpawnSecs";
			this.txtSpawnSecs.Location = new System.Drawing.Point(216, 352);
			this.txtSpawnSecs.Size = new System.Drawing.Size(121, 26);
			this.txtSpawnSecs.TabIndex = 43;
			this.txtSpawnSecs.Text = "0";
			this.txtSpawnSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			// txtAttackSay
			//
			this.txtAttackSay.Name = "txtAttackSay";
			this.txtAttackSay.Location = new System.Drawing.Point(64, 40);
			this.txtAttackSay.Size = new System.Drawing.Size(265, 26);
			this.txtAttackSay.TabIndex = 41;
			//
			// tmrSprite
			//
			this.tmrSprite.Interval = 50;
			//
			// picSprites
			//
			this.picSprites.Name = "picSprites";
			this.picSprites.TabStop = false;
			this.picSprites.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.picSprites.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picSprites.Location = new System.Drawing.Point(8, 624);
			this.picSprites.Size = new System.Drawing.Size(32, 32);
			this.picSprites.TabIndex = 35;
			this.picSprites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Location = new System.Drawing.Point(176, 544);
			this.cmdCancel.Size = new System.Drawing.Size(161, 41);
			this.cmdCancel.TabIndex = 34;
			this.cmdCancel.Text = "Cancel";
			//
			// cmdOk
			//
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Location = new System.Drawing.Point(8, 544);
			this.cmdOk.Size = new System.Drawing.Size(161, 41);
			this.cmdOk.TabIndex = 33;
			this.cmdOk.Text = "Ok";
			//
			// scrlValue
			//
			this.scrlValue.Name = "scrlValue";
			this.scrlValue.Location = new System.Drawing.Point(72, 464);
			this.scrlValue.Size = new System.Drawing.Size(225, 25);
			this.scrlValue.TabIndex = 31;
			this.scrlValue.Maximum = 255;
			this.scrlValue.Value = 1;
			//
			// scrlNum
			//
			this.scrlNum.Name = "scrlNum";
			this.scrlNum.Maximum = 255;
			this.scrlNum.Value = 1;
			this.scrlNum.Location = new System.Drawing.Point(72, 432);
			this.scrlNum.Size = new System.Drawing.Size(225, 25);
			this.scrlNum.TabIndex = 25;
			//
			// txtChance
			//
			this.txtChance.Name = "txtChance";
			this.txtChance.Text = "0";
			this.txtChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtChance.Location = new System.Drawing.Point(216, 320);
			this.txtChance.Size = new System.Drawing.Size(121, 26);
			this.txtChance.TabIndex = 24;
			//
			// scrlMAGI
			//
			this.scrlMAGI.Name = "scrlMAGI";
			this.scrlMAGI.Location = new System.Drawing.Point(72, 240);
			this.scrlMAGI.Size = new System.Drawing.Size(193, 25);
			this.scrlMAGI.TabIndex = 20;
			this.scrlMAGI.Maximum = 255;
			//
			// scrlSPEED
			//
			this.scrlSPEED.Name = "scrlSPEED";
			this.scrlSPEED.Location = new System.Drawing.Point(72, 208);
			this.scrlSPEED.Size = new System.Drawing.Size(193, 25);
			this.scrlSPEED.TabIndex = 17;
			this.scrlSPEED.Maximum = 255;
			//
			// scrlDEF
			//
			this.scrlDEF.Name = "scrlDEF";
			this.scrlDEF.Location = new System.Drawing.Point(72, 176);
			this.scrlDEF.Size = new System.Drawing.Size(193, 25);
			this.scrlDEF.TabIndex = 14;
			this.scrlDEF.Maximum = 255;
			//
			// scrlSTR
			//
			this.scrlSTR.Name = "scrlSTR";
			this.scrlSTR.TabIndex = 11;
			this.scrlSTR.Maximum = 255;
			this.scrlSTR.Location = new System.Drawing.Point(72, 144);
			this.scrlSTR.Size = new System.Drawing.Size(193, 25);
			//
			// scrlRange
			//
			this.scrlRange.Name = "scrlRange";
			this.scrlRange.Maximum = 255;
			this.scrlRange.Value = 1;
			this.scrlRange.Location = new System.Drawing.Point(72, 112);
			this.scrlRange.Size = new System.Drawing.Size(193, 25);
			this.scrlRange.TabIndex = 8;
			//
			// cmbBehavior
			//
			this.cmbBehavior.Name = "cmbBehavior";
			this.cmbBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBehavior.FormattingEnabled = true;
			this.cmbBehavior.Location = new System.Drawing.Point(96, 280);
			this.cmbBehavior.Size = new System.Drawing.Size(241, 26);
			this.cmbBehavior.TabIndex = 7;
			this.cmbBehavior.Items.AddRange(new object[] {
			"Attack on sight",
			"Attack when attacked",
			"Friendly",
			"Shop keeper",
			"Guard"
		});
			//
			// txtName
			//
			this.txtName.Name = "txtName";
			this.txtName.Location = new System.Drawing.Point(64, 8);
			this.txtName.Size = new System.Drawing.Size(265, 26);
			this.txtName.TabIndex = 2;
			//
			// scrlSprite
			//
			this.scrlSprite.Name = "scrlSprite";
			this.scrlSprite.Location = new System.Drawing.Point(72, 80);
			this.scrlSprite.Size = new System.Drawing.Size(193, 25);
			this.scrlSprite.TabIndex = 1;
			this.scrlSprite.Maximum = 255;
			//
			// picSprite
			//
			this.picSprite.Name = "picSprite";
			this.picSprite.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picSprite.Location = new System.Drawing.Point(304, 80);
			this.picSprite.Size = new System.Drawing.Size(32, 32);
			this.picSprite.TabIndex = 0;
			this.picSprite.TabStop = false;
			this.picSprite.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			//
			// Label16
			//
			this.Label16.Name = "Label16";
			this.Label16.TabIndex = 42;
			this.Label16.Text = "Spawn Rate (in seconds)";
			this.Label16.Location = new System.Drawing.Point(16, 352);
			this.Label16.Size = new System.Drawing.Size(193, 25);
			//
			// Label14
			//
			this.Label14.Name = "Label14";
			this.Label14.Location = new System.Drawing.Point(8, 40);
			this.Label14.Size = new System.Drawing.Size(49, 25);
			this.Label14.TabIndex = 40;
			this.Label14.Text = "Say";
			//
			// lblExpGiven
			//
			this.lblExpGiven.Name = "lblExpGiven";
			this.lblExpGiven.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblExpGiven.Text = "0";
			this.lblExpGiven.Location = new System.Drawing.Point(264, 504);
			this.lblExpGiven.Size = new System.Drawing.Size(73, 25);
			this.lblExpGiven.TabIndex = 39;
			//
			// Label15
			//
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(81, 25);
			this.Label15.TabIndex = 38;
			this.Label15.Text = "Exp Given";
			this.Label15.Location = new System.Drawing.Point(176, 504);
			//
			// lblStartHP
			//
			this.lblStartHP.Name = "lblStartHP";
			this.lblStartHP.TabIndex = 37;
			this.lblStartHP.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblStartHP.Text = "0";
			this.lblStartHP.Location = new System.Drawing.Point(88, 504);
			this.lblStartHP.Size = new System.Drawing.Size(73, 25);
			//
			// Label13
			//
			this.Label13.Name = "Label13";
			this.Label13.Location = new System.Drawing.Point(16, 504);
			this.Label13.Size = new System.Drawing.Size(65, 25);
			this.Label13.TabIndex = 36;
			this.Label13.Text = "Start HP";
			//
			// lblValue
			//
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(33, 25);
			this.lblValue.TabIndex = 32;
			this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblValue.Text = "0";
			this.lblValue.Location = new System.Drawing.Point(304, 464);
			//
			// Label7
			//
			this.Label7.Name = "Label7";
			this.Label7.Location = new System.Drawing.Point(16, 464);
			this.Label7.Size = new System.Drawing.Size(49, 25);
			this.Label7.TabIndex = 30;
			this.Label7.Text = "Value";
			//
			// lblItemName
			//
			this.lblItemName.Name = "lblItemName";
			this.lblItemName.Location = new System.Drawing.Point(64, 400);
			this.lblItemName.Size = new System.Drawing.Size(273, 25);
			this.lblItemName.TabIndex = 29;
			//
			// Label11
			//
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(41, 25);
			this.Label11.TabIndex = 28;
			this.Label11.Text = "Item";
			this.Label11.Location = new System.Drawing.Point(16, 400);
			//
			// Label9
			//
			this.Label9.Name = "Label9";
			this.Label9.Location = new System.Drawing.Point(16, 432);
			this.Label9.Size = new System.Drawing.Size(57, 25);
			this.Label9.TabIndex = 27;
			this.Label9.Text = "Num";
			//
			// lblNum
			//
			this.lblNum.Name = "lblNum";
			this.lblNum.Size = new System.Drawing.Size(33, 25);
			this.lblNum.TabIndex = 26;
			this.lblNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblNum.Text = "0";
			this.lblNum.Location = new System.Drawing.Point(304, 432);
			//
			// Label3
			//
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(193, 25);
			this.Label3.TabIndex = 23;
			this.Label3.Text = "Drop Item Chance 1 out of";
			this.Label3.Location = new System.Drawing.Point(16, 320);
			//
			// Label12
			//
			this.Label12.Name = "Label12";
			this.Label12.TabIndex = 22;
			this.Label12.Text = "MAGI";
			this.Label12.Location = new System.Drawing.Point(16, 240);
			this.Label12.Size = new System.Drawing.Size(57, 25);
			//
			// lblMAGI
			//
			this.lblMAGI.Name = "lblMAGI";
			this.lblMAGI.Location = new System.Drawing.Point(264, 240);
			this.lblMAGI.Size = new System.Drawing.Size(33, 25);
			this.lblMAGI.TabIndex = 21;
			this.lblMAGI.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblMAGI.Text = "0";
			//
			// Label10
			//
			this.Label10.Name = "Label10";
			this.Label10.Location = new System.Drawing.Point(16, 208);
			this.Label10.Size = new System.Drawing.Size(57, 25);
			this.Label10.TabIndex = 19;
			this.Label10.Text = "SPD";
			//
			// lblSPEED
			//
			this.lblSPEED.Name = "lblSPEED";
			this.lblSPEED.TabIndex = 18;
			this.lblSPEED.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblSPEED.Text = "0";
			this.lblSPEED.Location = new System.Drawing.Point(264, 208);
			this.lblSPEED.Size = new System.Drawing.Size(33, 25);
			//
			// Label8
			//
			this.Label8.Name = "Label8";
			this.Label8.Location = new System.Drawing.Point(16, 176);
			this.Label8.Size = new System.Drawing.Size(57, 25);
			this.Label8.TabIndex = 16;
			this.Label8.Text = "DEF";
			//
			// lblDEF
			//
			this.lblDEF.Name = "lblDEF";
			this.lblDEF.Size = new System.Drawing.Size(33, 25);
			this.lblDEF.TabIndex = 15;
			this.lblDEF.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblDEF.Text = "0";
			this.lblDEF.Location = new System.Drawing.Point(264, 176);
			//
			// Label6
			//
			this.Label6.Name = "Label6";
			this.Label6.TabIndex = 13;
			this.Label6.Text = "STR";
			this.Label6.Location = new System.Drawing.Point(16, 144);
			this.Label6.Size = new System.Drawing.Size(57, 25);
			//
			// lblSTR
			//
			this.lblSTR.Name = "lblSTR";
			this.lblSTR.Text = "0";
			this.lblSTR.Location = new System.Drawing.Point(264, 144);
			this.lblSTR.Size = new System.Drawing.Size(33, 25);
			this.lblSTR.TabIndex = 12;
			this.lblSTR.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			// Label4
			//
			this.Label4.Name = "Label4";
			this.Label4.Location = new System.Drawing.Point(16, 112);
			this.Label4.Size = new System.Drawing.Size(57, 25);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "Range";
			//
			// lblRange
			//
			this.lblRange.Name = "lblRange";
			this.lblRange.TabIndex = 9;
			this.lblRange.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblRange.Text = "0";
			this.lblRange.Location = new System.Drawing.Point(264, 112);
			this.lblRange.Size = new System.Drawing.Size(33, 25);
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Location = new System.Drawing.Point(16, 280);
			this.Label2.Size = new System.Drawing.Size(73, 25);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Behavior";
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Size = new System.Drawing.Size(49, 25);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Name";
			//
			// Label5
			//
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(57, 25);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Sprite";
			this.Label5.Location = new System.Drawing.Point(16, 80);
			//
			// lblSprite
			//
			this.lblSprite.Name = "lblSprite";
			this.lblSprite.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblSprite.Text = "0";
			this.lblSprite.Location = new System.Drawing.Point(264, 80);
			this.lblSprite.Size = new System.Drawing.Size(33, 25);
			this.lblSprite.TabIndex = 3;
			//
			// frmNpcEditor
			//
			this.Name = "frmNpcEditor";
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(345, 594);
			this.Text = "Npc Editor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.txtSpawnSecs);
			this.Controls.Add(this.txtAttackSay);
			this.Controls.Add(this.picSprites);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.scrlValue);
			this.Controls.Add(this.scrlNum);
			this.Controls.Add(this.txtChance);
			this.Controls.Add(this.scrlMAGI);
			this.Controls.Add(this.scrlSPEED);
			this.Controls.Add(this.scrlDEF);
			this.Controls.Add(this.scrlSTR);
			this.Controls.Add(this.scrlRange);
			this.Controls.Add(this.cmbBehavior);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.scrlSprite);
			this.Controls.Add(this.picSprite);
			this.Controls.Add(this.Label16);
			this.Controls.Add(this.Label14);
			this.Controls.Add(this.lblExpGiven);
			this.Controls.Add(this.Label15);
			this.Controls.Add(this.lblStartHP);
			this.Controls.Add(this.Label13);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.lblItemName);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.lblNum);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.lblMAGI);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.lblSPEED);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.lblDEF);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.lblSTR);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.lblRange);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.lblSprite);
			((System.ComponentModel.ISupportInitialize)(this.picSprites)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox txtSpawnSecs;
		private System.Windows.Forms.TextBox txtAttackSay;
		private System.Windows.Forms.Timer tmrSprite;
		private System.Windows.Forms.PictureBox picSprites;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.HScrollBar scrlValue;
		private System.Windows.Forms.HScrollBar scrlNum;
		private System.Windows.Forms.TextBox txtChance;
		private System.Windows.Forms.HScrollBar scrlMAGI;
		private System.Windows.Forms.HScrollBar scrlSPEED;
		private System.Windows.Forms.HScrollBar scrlDEF;
		private System.Windows.Forms.HScrollBar scrlSTR;
		private System.Windows.Forms.HScrollBar scrlRange;
		private System.Windows.Forms.ComboBox cmbBehavior;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.HScrollBar scrlSprite;
		private System.Windows.Forms.PictureBox picSprite;
		private System.Windows.Forms.Label Label16;
		private System.Windows.Forms.Label Label14;
		private System.Windows.Forms.Label lblExpGiven;
		private System.Windows.Forms.Label Label15;
		private System.Windows.Forms.Label lblStartHP;
		private System.Windows.Forms.Label Label13;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.Label Label7;
		private System.Windows.Forms.Label lblItemName;
		private System.Windows.Forms.Label Label11;
		private System.Windows.Forms.Label Label9;
		private System.Windows.Forms.Label lblNum;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label12;
		private System.Windows.Forms.Label lblMAGI;
		private System.Windows.Forms.Label Label10;
		private System.Windows.Forms.Label lblSPEED;
		private System.Windows.Forms.Label Label8;
		private System.Windows.Forms.Label lblDEF;
		private System.Windows.Forms.Label Label6;
		private System.Windows.Forms.Label lblSTR;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label lblRange;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label lblSprite;
	}
}
