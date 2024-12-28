namespace Mirage
{
	partial class frmSpellEditor
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
			scrlLevelReq = new System.Windows.Forms.HScrollBar();
			cmbClassReq = new System.Windows.Forms.ComboBox();
			scrlItemValue = new System.Windows.Forms.HScrollBar();
			scrlItemNum = new System.Windows.Forms.HScrollBar();
			lblItemValue = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			lblItemNum = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			fraGiveItem = new System.Windows.Forms.GroupBox();
			cmdOk = new System.Windows.Forms.Button();
			cmdCancel = new System.Windows.Forms.Button();
			cmbType = new System.Windows.Forms.ComboBox();
			scrlVitalMod = new System.Windows.Forms.HScrollBar();
			Label4 = new System.Windows.Forms.Label();
			lblVitalMod = new System.Windows.Forms.Label();
			fraVitals = new System.Windows.Forms.GroupBox();
			txtName = new System.Windows.Forms.TextBox();
			lblLevelReq = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			//
			// scrlLevelReq
			//
			this.scrlLevelReq.Name = "scrlLevelReq";
			this.scrlLevelReq.Value = 1;
			this.scrlLevelReq.Location = new System.Drawing.Point(64, 88);
			this.scrlLevelReq.Size = new System.Drawing.Size(233, 25);
			this.scrlLevelReq.TabIndex = 18;
			this.scrlLevelReq.Maximum = 255;
			//
			// cmbClassReq
			//
			this.cmbClassReq.Name = "cmbClassReq";
			this.cmbClassReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClassReq.FormattingEnabled = true;
			this.cmbClassReq.Location = new System.Drawing.Point(8, 48);
			this.cmbClassReq.Size = new System.Drawing.Size(321, 26);
			this.cmbClassReq.TabIndex = 16;
			this.cmbClassReq.Items.AddRange(new object[] {

		});
			//
			// scrlItemValue
			//
			this.scrlItemValue.Name = "scrlItemValue";
			this.scrlItemValue.Location = new System.Drawing.Point(88, 56);
			this.scrlItemValue.Size = new System.Drawing.Size(193, 25);
			this.scrlItemValue.TabIndex = 14;
			//
			// scrlItemNum
			//
			this.scrlItemNum.Name = "scrlItemNum";
			this.scrlItemNum.Location = new System.Drawing.Point(88, 24);
			this.scrlItemNum.Size = new System.Drawing.Size(193, 25);
			this.scrlItemNum.TabIndex = 10;
			this.scrlItemNum.Maximum = 255;
			this.scrlItemNum.Value = 1;
			//
			// lblItemValue
			//
			this.lblItemValue.Name = "lblItemValue";
			this.lblItemValue.TabIndex = 15;
			this.lblItemValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblItemValue.Text = "0";
			this.lblItemValue.Location = new System.Drawing.Point(280, 56);
			this.lblItemValue.Size = new System.Drawing.Size(33, 25);
			//
			// Label5
			//
			this.Label5.Name = "Label5";
			this.Label5.Location = new System.Drawing.Point(8, 56);
			this.Label5.Size = new System.Drawing.Size(73, 25);
			this.Label5.TabIndex = 13;
			this.Label5.Text = "Value";
			//
			// lblItemNum
			//
			this.lblItemNum.Name = "lblItemNum";
			this.lblItemNum.Size = new System.Drawing.Size(33, 25);
			this.lblItemNum.TabIndex = 12;
			this.lblItemNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblItemNum.Text = "1";
			this.lblItemNum.Location = new System.Drawing.Point(280, 24);
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Location = new System.Drawing.Point(8, 24);
			this.Label2.Size = new System.Drawing.Size(73, 25);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "Item";
			//
			// fraGiveItem
			//
			this.fraGiveItem.Name = "fraGiveItem";
			this.fraGiveItem.Size = new System.Drawing.Size(321, 97);
			this.fraGiveItem.TabIndex = 9;
			this.fraGiveItem.Text = "Give Item";
			this.fraGiveItem.Visible = false;
			this.fraGiveItem.Location = new System.Drawing.Point(8, 176);
			this.fraGiveItem.Controls.Add(this.scrlItemValue);
			this.fraGiveItem.Controls.Add(this.scrlItemNum);
			this.fraGiveItem.Controls.Add(this.lblItemValue);
			this.fraGiveItem.Controls.Add(this.Label5);
			this.fraGiveItem.Controls.Add(this.lblItemNum);
			this.fraGiveItem.Controls.Add(this.Label2);
			//
			// cmdOk
			//
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Location = new System.Drawing.Point(8, 288);
			this.cmdOk.Size = new System.Drawing.Size(153, 33);
			this.cmdOk.TabIndex = 8;
			this.cmdOk.Text = "Ok";
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Location = new System.Drawing.Point(176, 288);
			this.cmdCancel.Size = new System.Drawing.Size(153, 33);
			this.cmdCancel.TabIndex = 7;
			this.cmdCancel.Text = "Cancel";
			//
			// cmbType
			//
			this.cmbType.Name = "cmbType";
			this.cmbType.TabIndex = 6;
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Location = new System.Drawing.Point(8, 136);
			this.cmbType.Size = new System.Drawing.Size(321, 26);
			this.cmbType.Items.AddRange(new object[] {
			"Add HP",
			"Add MP",
			"Add SP",
			"Sub HP",
			"Sub MP",
			"Sub SP",
			"Give Item"
		});
			//
			// scrlVitalMod
			//
			this.scrlVitalMod.Name = "scrlVitalMod";
			this.scrlVitalMod.Location = new System.Drawing.Point(88, 24);
			this.scrlVitalMod.Size = new System.Drawing.Size(193, 25);
			this.scrlVitalMod.TabIndex = 3;
			this.scrlVitalMod.Maximum = 255;
			this.scrlVitalMod.Value = 1;
			//
			// Label4
			//
			this.Label4.Name = "Label4";
			this.Label4.Location = new System.Drawing.Point(8, 24);
			this.Label4.Size = new System.Drawing.Size(73, 25);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "Vital Mod";
			//
			// lblVitalMod
			//
			this.lblVitalMod.Name = "lblVitalMod";
			this.lblVitalMod.Location = new System.Drawing.Point(280, 24);
			this.lblVitalMod.Size = new System.Drawing.Size(33, 25);
			this.lblVitalMod.TabIndex = 4;
			this.lblVitalMod.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblVitalMod.Text = "1";
			//
			// fraVitals
			//
			this.fraVitals.Name = "fraVitals";
			this.fraVitals.Size = new System.Drawing.Size(321, 97);
			this.fraVitals.TabIndex = 2;
			this.fraVitals.Text = "Vitals Data";
			this.fraVitals.Visible = false;
			this.fraVitals.Location = new System.Drawing.Point(8, 176);
			this.fraVitals.Controls.Add(this.scrlVitalMod);
			this.fraVitals.Controls.Add(this.Label4);
			this.fraVitals.Controls.Add(this.lblVitalMod);
			//
			// txtName
			//
			this.txtName.Name = "txtName";
			this.txtName.Location = new System.Drawing.Point(64, 8);
			this.txtName.Size = new System.Drawing.Size(265, 26);
			this.txtName.TabIndex = 0;
			//
			// lblLevelReq
			//
			this.lblLevelReq.Name = "lblLevelReq";
			this.lblLevelReq.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblLevelReq.Text = "1";
			this.lblLevelReq.Location = new System.Drawing.Point(296, 88);
			this.lblLevelReq.Size = new System.Drawing.Size(33, 25);
			this.lblLevelReq.TabIndex = 19;
			//
			// Label3
			//
			this.Label3.Name = "Label3";
			this.Label3.Text = "Level";
			this.Label3.Location = new System.Drawing.Point(8, 88);
			this.Label3.Size = new System.Drawing.Size(49, 25);
			this.Label3.TabIndex = 17;
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Size = new System.Drawing.Size(49, 25);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Name";
			//
			// frmSpellEditor
			//
			this.Name = "frmSpellEditor";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(337, 329);
			this.Text = "Spell Editor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ControlBox = false;
			this.MinimizeBox = false;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.MaximizeBox = false;
			this.Controls.Add(this.scrlLevelReq);
			this.Controls.Add(this.cmbClassReq);
			this.Controls.Add(this.fraGiveItem);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.fraVitals);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblLevelReq);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label1);
		}

		#endregion

		private System.Windows.Forms.HScrollBar scrlLevelReq;
		private System.Windows.Forms.ComboBox cmbClassReq;
		private System.Windows.Forms.HScrollBar scrlItemValue;
		private System.Windows.Forms.HScrollBar scrlItemNum;
		private System.Windows.Forms.Label lblItemValue;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label lblItemNum;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.GroupBox fraGiveItem;
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.HScrollBar scrlVitalMod;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label lblVitalMod;
		private System.Windows.Forms.GroupBox fraVitals;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblLevelReq;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label1;
	}
}
