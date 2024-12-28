namespace Mirage
{
	partial class frmItemEditor
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
			chkLocked = new System.Windows.Forms.CheckBox();
			chkDisabled = new System.Windows.Forms.CheckBox();
			chkUnBreakable = new System.Windows.Forms.CheckBox();
			scrlSpell = new System.Windows.Forms.HScrollBar();
			lblSpellName = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			Label7 = new System.Windows.Forms.Label();
			lblSpell = new System.Windows.Forms.Label();
			fraSpell = new System.Windows.Forms.GroupBox();
			tmrPic = new System.Windows.Forms.Timer(this.components);
			picItems = new System.Windows.Forms.PictureBox();
			picPic = new System.Windows.Forms.PictureBox();
			scrlPic = new System.Windows.Forms.HScrollBar();
			cmdCancel = new System.Windows.Forms.Button();
			cmdOk = new System.Windows.Forms.Button();
			scrlVitalMod = new System.Windows.Forms.HScrollBar();
			lblVitalMod = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			fraVitals = new System.Windows.Forms.GroupBox();
			scrlStrength = new System.Windows.Forms.HScrollBar();
			scrlDurability = new System.Windows.Forms.HScrollBar();
			lblStrength = new System.Windows.Forms.Label();
			lblDurability = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			fraEquipment = new System.Windows.Forms.GroupBox();
			txtName = new System.Windows.Forms.TextBox();
			cmbType = new System.Windows.Forms.ComboBox();
			lbAssigned = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			lblPic = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPic)).BeginInit();
			this.SuspendLayout();
			//
			// chkLocked
			//
			this.chkLocked.Name = "chkLocked";
			this.chkLocked.Location = new System.Drawing.Point(248, 232);
			this.chkLocked.Size = new System.Drawing.Size(81, 18);
			this.chkLocked.TabIndex = 29;
			this.chkLocked.Text = "Locked";
			//
			// chkDisabled
			//
			this.chkDisabled.Name = "chkDisabled";
			this.chkDisabled.Location = new System.Drawing.Point(144, 232);
			this.chkDisabled.Size = new System.Drawing.Size(89, 18);
			this.chkDisabled.TabIndex = 28;
			this.chkDisabled.Text = "Disabled";
			//
			// chkUnBreakable
			//
			this.chkUnBreakable.Name = "chkUnBreakable";
			this.chkUnBreakable.Text = "Unbreakable";
			this.chkUnBreakable.Location = new System.Drawing.Point(8, 232);
			this.chkUnBreakable.Size = new System.Drawing.Size(113, 18);
			this.chkUnBreakable.TabIndex = 27;
			//
			// scrlSpell
			//
			this.scrlSpell.Name = "scrlSpell";
			this.scrlSpell.Location = new System.Drawing.Point(88, 56);
			this.scrlSpell.Size = new System.Drawing.Size(193, 25);
			this.scrlSpell.TabIndex = 22;
			this.scrlSpell.Maximum = 255;
			this.scrlSpell.Value = 1;
			//
			// lblSpellName
			//
			this.lblSpellName.Name = "lblSpellName";
			this.lblSpellName.Location = new System.Drawing.Point(88, 24);
			this.lblSpellName.Size = new System.Drawing.Size(225, 25);
			this.lblSpellName.TabIndex = 26;
			//
			// Label6
			//
			this.Label6.Name = "Label6";
			this.Label6.Location = new System.Drawing.Point(8, 24);
			this.Label6.Size = new System.Drawing.Size(73, 25);
			this.Label6.TabIndex = 25;
			this.Label6.Text = "Name";
			//
			// Label7
			//
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(73, 25);
			this.Label7.TabIndex = 24;
			this.Label7.Text = "Num";
			this.Label7.Location = new System.Drawing.Point(8, 56);
			//
			// lblSpell
			//
			this.lblSpell.Name = "lblSpell";
			this.lblSpell.TabIndex = 23;
			this.lblSpell.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblSpell.Text = "1";
			this.lblSpell.Location = new System.Drawing.Point(280, 56);
			this.lblSpell.Size = new System.Drawing.Size(33, 25);
			//
			// fraSpell
			//
			this.fraSpell.Name = "fraSpell";
			this.fraSpell.Text = "Spell Data";
			this.fraSpell.Visible = false;
			this.fraSpell.Location = new System.Drawing.Point(8, 128);
			this.fraSpell.Size = new System.Drawing.Size(321, 97);
			this.fraSpell.TabIndex = 21;
			this.fraSpell.Controls.Add(this.scrlSpell);
			this.fraSpell.Controls.Add(this.lblSpellName);
			this.fraSpell.Controls.Add(this.Label6);
			this.fraSpell.Controls.Add(this.Label7);
			this.fraSpell.Controls.Add(this.lblSpell);
			//
			// tmrPic
			//
			this.tmrPic.Interval = 50;
			//
			// picItems
			//
			this.picItems.Name = "picItems";
			this.picItems.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.picItems.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picItems.Location = new System.Drawing.Point(72, 400);
			this.picItems.Size = new System.Drawing.Size(32, 32);
			this.picItems.TabIndex = 20;
			this.picItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picItems.TabStop = false;
			//
			// picPic
			//
			this.picPic.Name = "picPic";
			this.picPic.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.picPic.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picPic.Location = new System.Drawing.Point(296, 40);
			this.picPic.Size = new System.Drawing.Size(32, 32);
			this.picPic.TabIndex = 19;
			this.picPic.TabStop = false;
			//
			// scrlPic
			//
			this.scrlPic.Name = "scrlPic";
			this.scrlPic.Location = new System.Drawing.Point(64, 40);
			this.scrlPic.Size = new System.Drawing.Size(193, 25);
			this.scrlPic.TabIndex = 17;
			this.scrlPic.Maximum = 255;
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.Location = new System.Drawing.Point(264, 288);
			this.cmdCancel.Size = new System.Drawing.Size(65, 18);
			this.cmdCancel.TabIndex = 15;
			//
			// cmdOk
			//
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Size = new System.Drawing.Size(65, 18);
			this.cmdOk.TabIndex = 14;
			this.cmdOk.Text = "Ok";
			this.cmdOk.Location = new System.Drawing.Point(264, 264);
			//
			// scrlVitalMod
			//
			this.scrlVitalMod.Name = "scrlVitalMod";
			this.scrlVitalMod.Value = 1;
			this.scrlVitalMod.Location = new System.Drawing.Point(88, 24);
			this.scrlVitalMod.Size = new System.Drawing.Size(193, 25);
			this.scrlVitalMod.TabIndex = 12;
			this.scrlVitalMod.Maximum = 255;
			//
			// lblVitalMod
			//
			this.lblVitalMod.Name = "lblVitalMod";
			this.lblVitalMod.Location = new System.Drawing.Point(280, 24);
			this.lblVitalMod.Size = new System.Drawing.Size(33, 25);
			this.lblVitalMod.TabIndex = 13;
			this.lblVitalMod.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblVitalMod.Text = "1";
			//
			// Label4
			//
			this.Label4.Name = "Label4";
			this.Label4.Location = new System.Drawing.Point(8, 24);
			this.Label4.Size = new System.Drawing.Size(73, 25);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "Vital Mod";
			//
			// fraVitals
			//
			this.fraVitals.Name = "fraVitals";
			this.fraVitals.Visible = false;
			this.fraVitals.Location = new System.Drawing.Point(8, 128);
			this.fraVitals.Size = new System.Drawing.Size(321, 97);
			this.fraVitals.TabIndex = 10;
			this.fraVitals.Text = "Vitals Data";
			this.fraVitals.Controls.Add(this.scrlVitalMod);
			this.fraVitals.Controls.Add(this.lblVitalMod);
			this.fraVitals.Controls.Add(this.Label4);
			//
			// scrlStrength
			//
			this.scrlStrength.Name = "scrlStrength";
			this.scrlStrength.Maximum = 255;
			this.scrlStrength.Value = 1;
			this.scrlStrength.Location = new System.Drawing.Point(88, 64);
			this.scrlStrength.Size = new System.Drawing.Size(193, 25);
			this.scrlStrength.TabIndex = 8;
			//
			// scrlDurability
			//
			this.scrlDurability.Name = "scrlDurability";
			this.scrlDurability.Value = 1;
			this.scrlDurability.Location = new System.Drawing.Point(88, 32);
			this.scrlDurability.Size = new System.Drawing.Size(193, 25);
			this.scrlDurability.TabIndex = 6;
			this.scrlDurability.Maximum = 255;
			//
			// lblStrength
			//
			this.lblStrength.Name = "lblStrength";
			this.lblStrength.Text = "1";
			this.lblStrength.Location = new System.Drawing.Point(280, 64);
			this.lblStrength.Size = new System.Drawing.Size(33, 25);
			this.lblStrength.TabIndex = 9;
			this.lblStrength.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			// lblDurability
			//
			this.lblDurability.Name = "lblDurability";
			this.lblDurability.Location = new System.Drawing.Point(280, 32);
			this.lblDurability.Size = new System.Drawing.Size(33, 25);
			this.lblDurability.TabIndex = 7;
			this.lblDurability.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblDurability.Text = "1";
			//
			// Label3
			//
			this.Label3.Name = "Label3";
			this.Label3.Location = new System.Drawing.Point(8, 64);
			this.Label3.Size = new System.Drawing.Size(65, 25);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Strength";
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Text = "Durability";
			this.Label2.Location = new System.Drawing.Point(8, 32);
			this.Label2.Size = new System.Drawing.Size(73, 25);
			this.Label2.TabIndex = 4;
			//
			// fraEquipment
			//
			this.fraEquipment.Name = "fraEquipment";
			this.fraEquipment.TabIndex = 3;
			this.fraEquipment.Text = "Equipment Data";
			this.fraEquipment.Visible = false;
			this.fraEquipment.Location = new System.Drawing.Point(8, 128);
			this.fraEquipment.Size = new System.Drawing.Size(321, 97);
			this.fraEquipment.Controls.Add(this.scrlStrength);
			this.fraEquipment.Controls.Add(this.scrlDurability);
			this.fraEquipment.Controls.Add(this.lblStrength);
			this.fraEquipment.Controls.Add(this.lblDurability);
			this.fraEquipment.Controls.Add(this.Label3);
			this.fraEquipment.Controls.Add(this.Label2);
			//
			// txtName
			//
			this.txtName.Name = "txtName";
			this.txtName.Location = new System.Drawing.Point(64, 8);
			this.txtName.Size = new System.Drawing.Size(265, 26);
			this.txtName.TabIndex = 1;
			//
			// cmbType
			//
			this.cmbType.Name = "cmbType";
			this.cmbType.Location = new System.Drawing.Point(8, 88);
			this.cmbType.Size = new System.Drawing.Size(321, 26);
			this.cmbType.TabIndex = 0;
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
			"None",
			"Weapon",
			"Armor",
			"Helmet",
			"Shield",
			"Potion Add HP",
			"Potion Add MP",
			"Potion Add SP",
			"Potion Sub HP",
			"Potion Sub MP",
			"Potion Sub SP",
			"Key",
			"Currency",
			"Spell"
		});
			//
			// lbAssigned
			//
			this.lbAssigned.Name = "lbAssigned";
			this.lbAssigned.Size = new System.Drawing.Size(4, 18);
			this.lbAssigned.TabIndex = 31;
			this.lbAssigned.Location = new System.Drawing.Point(112, 272);
			//
			// Label8
			//
			this.Label8.Name = "Label8";
			this.Label8.Text = "Assigned To:";
			this.Label8.Location = new System.Drawing.Point(8, 272);
			this.Label8.Size = new System.Drawing.Size(92, 18);
			this.Label8.TabIndex = 30;
			//
			// lblPic
			//
			this.lblPic.Name = "lblPic";
			this.lblPic.Location = new System.Drawing.Point(256, 40);
			this.lblPic.Size = new System.Drawing.Size(33, 25);
			this.lblPic.TabIndex = 18;
			this.lblPic.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblPic.Text = "0";
			//
			// Label5
			//
			this.Label5.Name = "Label5";
			this.Label5.Location = new System.Drawing.Point(8, 40);
			this.Label5.Size = new System.Drawing.Size(57, 25);
			this.Label5.TabIndex = 16;
			this.Label5.Text = "Pic";
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Size = new System.Drawing.Size(49, 25);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Name";
			//
			// frmItemEditor
			//
			this.Name = "frmItemEditor";
			this.ControlBox = false;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ClientSize = new System.Drawing.Size(337, 310);
			this.Text = "Item Editor";
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.Controls.Add(this.chkLocked);
			this.Controls.Add(this.chkDisabled);
			this.Controls.Add(this.chkUnBreakable);
			this.Controls.Add(this.fraSpell);
			this.Controls.Add(this.picItems);
			this.Controls.Add(this.picPic);
			this.Controls.Add(this.scrlPic);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.fraVitals);
			this.Controls.Add(this.fraEquipment);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.lbAssigned);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.lblPic);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label1);
			((System.ComponentModel.ISupportInitialize)(this.picItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.CheckBox chkLocked;
		private System.Windows.Forms.CheckBox chkDisabled;
		private System.Windows.Forms.CheckBox chkUnBreakable;
		private System.Windows.Forms.HScrollBar scrlSpell;
		private System.Windows.Forms.Label lblSpellName;
		private System.Windows.Forms.Label Label6;
		private System.Windows.Forms.Label Label7;
		private System.Windows.Forms.Label lblSpell;
		private System.Windows.Forms.GroupBox fraSpell;
		private System.Windows.Forms.Timer tmrPic;
		private System.Windows.Forms.PictureBox picItems;
		private System.Windows.Forms.PictureBox picPic;
		private System.Windows.Forms.HScrollBar scrlPic;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.HScrollBar scrlVitalMod;
		private System.Windows.Forms.Label lblVitalMod;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.GroupBox fraVitals;
		private System.Windows.Forms.HScrollBar scrlStrength;
		private System.Windows.Forms.HScrollBar scrlDurability;
		private System.Windows.Forms.Label lblStrength;
		private System.Windows.Forms.Label lblDurability;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.GroupBox fraEquipment;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Label lbAssigned;
		private System.Windows.Forms.Label Label8;
		private System.Windows.Forms.Label lblPic;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label Label1;
	}
}
