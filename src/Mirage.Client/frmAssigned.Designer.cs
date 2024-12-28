namespace Mirage
{
	partial class frmAssigned
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
			chkUnAssign = new System.Windows.Forms.CheckBox();
			cmdCancel = new System.Windows.Forms.Button();
			cmdOK = new System.Windows.Forms.Button();
			cboCharacter = new System.Windows.Forms.ComboBox();
			cboTo = new System.Windows.Forms.ComboBox();
			cboFrom = new System.Windows.Forms.ComboBox();
			cboType = new System.Windows.Forms.ComboBox();
			Label3 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			//
			// chkUnAssign
			//
			this.chkUnAssign.Name = "chkUnAssign";
			this.chkUnAssign.Location = new System.Drawing.Point(8, 104);
			this.chkUnAssign.Size = new System.Drawing.Size(73, 17);
			this.chkUnAssign.TabIndex = 9;
			this.chkUnAssign.Text = "UnAssign";
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(49, 17);
			this.cmdCancel.TabIndex = 8;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.Location = new System.Drawing.Point(128, 104);
			//
			// cmdOK
			//
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Location = new System.Drawing.Point(184, 104);
			this.cmdOK.Size = new System.Drawing.Size(49, 17);
			this.cmdOK.TabIndex = 7;
			this.cmdOK.Text = "OK";
			//
			// cboCharacter
			//
			this.cboCharacter.Name = "cboCharacter";
			this.cboCharacter.Location = new System.Drawing.Point(64, 72);
			this.cboCharacter.Size = new System.Drawing.Size(169, 21);
			this.cboCharacter.TabIndex = 6;
			this.cboCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			//
			// cboTo
			//
			this.cboTo.Name = "cboTo";
			this.cboTo.TabIndex = 4;
			this.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTo.Location = new System.Drawing.Point(168, 40);
			this.cboTo.Size = new System.Drawing.Size(65, 21);
			//
			// cboFrom
			//
			this.cboFrom.Name = "cboFrom";
			this.cboFrom.Location = new System.Drawing.Point(56, 40);
			this.cboFrom.Size = new System.Drawing.Size(65, 21);
			this.cboFrom.TabIndex = 3;
			this.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			//
			// cboType
			//
			this.cboType.Name = "cboType";
			this.cboType.Location = new System.Drawing.Point(8, 8);
			this.cboType.Size = new System.Drawing.Size(225, 21);
			this.cboType.TabIndex = 0;
			this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			//
			// Label3
			//
			this.Label3.Name = "Label3";
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Character:";
			this.Label3.Location = new System.Drawing.Point(8, 80);
			this.Label3.Size = new System.Drawing.Size(49, 13);
			//
			// Label2
			//
			this.Label2.Name = "Label2";
			this.Label2.Location = new System.Drawing.Point(136, 48);
			this.Label2.Size = new System.Drawing.Size(16, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "To:";
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Location = new System.Drawing.Point(8, 48);
			this.Label1.Size = new System.Drawing.Size(26, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "From:";
			//
			// frmAssigned
			//
			this.Name = "frmAssigned";
			this.ClientSize = new System.Drawing.Size(236, 126);
			this.Text = "Assignments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
			this.MinimizeBox = false;
			this.MaximizeBox = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.chkUnAssign);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.cboCharacter);
			this.Controls.Add(this.cboTo);
			this.Controls.Add(this.cboFrom);
			this.Controls.Add(this.cboType);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
		}

		#endregion

		private System.Windows.Forms.CheckBox chkUnAssign;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.ComboBox cboCharacter;
		private System.Windows.Forms.ComboBox cboTo;
		private System.Windows.Forms.ComboBox cboFrom;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
	}
}
