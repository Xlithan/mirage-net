namespace Mirage
{
	partial class frmServer
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
            components = new System.ComponentModel.Container();
            lstAccounts = new System.Windows.Forms.ListBox();
            lstPlayers = new System.Windows.Forms.ListBox();
            tmrShutdown = new System.Windows.Forms.Timer(components);
            tmrGameAI = new System.Windows.Forms.Timer(components);
            tmrSpawnMapItems = new System.Windows.Forms.Timer(components);
            tmrPlayerSave = new System.Windows.Forms.Timer(components);
            txtChat = new System.Windows.Forms.TextBox();
            txtText = new System.Windows.Forms.TextBox();
            Label2 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            mnuShutdown = new System.Windows.Forms.ToolStripMenuItem();
            mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuReloadClasses = new System.Windows.Forms.ToolStripMenuItem();
            mnuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            mnuServerLog = new System.Windows.Forms.ToolStripMenuItem();
            mnuLog = new System.Windows.Forms.ToolStripMenuItem();
            mainMenu1 = new System.Windows.Forms.MenuStrip();
            mainMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // lstAccounts
            // 
            lstAccounts.Location = new System.Drawing.Point(504, 48);
            lstAccounts.Name = "lstAccounts";
            lstAccounts.Size = new System.Drawing.Size(113, 154);
            lstAccounts.TabIndex = 3;
            // 
            // lstPlayers
            // 
            lstPlayers.Location = new System.Drawing.Point(624, 48);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new System.Drawing.Size(113, 154);
            lstPlayers.TabIndex = 2;
            // 
            // tmrShutdown
            // 
            tmrShutdown.Interval = 5000;
            // 
            // tmrGameAI
            // 
            tmrGameAI.Interval = 500;
            // 
            // tmrSpawnMapItems
            // 
            tmrSpawnMapItems.Interval = 1000;
            // 
            // tmrPlayerSave
            // 
            tmrPlayerSave.Interval = 60000;
            // 
            // txtChat
            // 
            txtChat.Location = new System.Drawing.Point(0, 184);
            txtChat.Name = "txtChat";
            txtChat.Size = new System.Drawing.Size(497, 23);
            txtChat.TabIndex = 1;
            // 
            // txtText
            // 
            txtText.Location = new System.Drawing.Point(0, 24);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new System.Drawing.Size(497, 153);
            txtText.TabIndex = 0;
            // 
            // Label2
            // 
            Label2.Location = new System.Drawing.Point(656, 25);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(51, 13);
            Label2.TabIndex = 5;
            Label2.Text = "Characters";
            // 
            // Label1
            // 
            Label1.Location = new System.Drawing.Point(536, 25);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(45, 13);
            Label1.TabIndex = 4;
            Label1.Text = "Accounts";
            // 
            // mnuShutdown
            // 
            mnuShutdown.Name = "mnuShutdown";
            mnuShutdown.Size = new System.Drawing.Size(128, 22);
            mnuShutdown.Text = "Shutdown";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new System.Drawing.Size(128, 22);
            mnuExit.Text = "&Exit";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuShutdown, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuReloadClasses
            // 
            mnuReloadClasses.Name = "mnuReloadClasses";
            mnuReloadClasses.Size = new System.Drawing.Size(151, 22);
            mnuReloadClasses.Text = "Reload Classes";
            // 
            // mnuDatabase
            // 
            mnuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuReloadClasses });
            mnuDatabase.Name = "mnuDatabase";
            mnuDatabase.Size = new System.Drawing.Size(67, 20);
            mnuDatabase.Text = "&Database";
            // 
            // mnuServerLog
            // 
            mnuServerLog.Name = "mnuServerLog";
            mnuServerLog.Size = new System.Drawing.Size(129, 22);
            mnuServerLog.Text = "Server Log";
            // 
            // mnuLog
            // 
            mnuLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuServerLog });
            mnuLog.Name = "mnuLog";
            mnuLog.Size = new System.Drawing.Size(39, 20);
            mnuLog.Text = "&Log";
            // 
            // mainMenu1
            // 
            mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFile, mnuDatabase, mnuLog });
            mainMenu1.Location = new System.Drawing.Point(0, 0);
            mainMenu1.Name = "mainMenu1";
            mainMenu1.Size = new System.Drawing.Size(739, 24);
            mainMenu1.TabIndex = 0;
            // 
            // frmServer
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(739, 211);
            Controls.Add(mainMenu1);
            Controls.Add(lstAccounts);
            Controls.Add(lstPlayers);
            Controls.Add(txtChat);
            Controls.Add(txtText);
            Controls.Add(Label2);
            Controls.Add(Label1);
            MaximizeBox = false;
            Name = "frmServer";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mirage Server";
            mainMenu1.ResumeLayout(false);
            mainMenu1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstAccounts;
		private System.Windows.Forms.ListBox lstPlayers;
		private System.Windows.Forms.Timer tmrShutdown;
		private System.Windows.Forms.Timer tmrGameAI;
		private System.Windows.Forms.Timer tmrSpawnMapItems;
		private System.Windows.Forms.Timer tmrPlayerSave;
		private System.Windows.Forms.TextBox txtChat;
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ToolStripMenuItem mnuShutdown;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuReloadClasses;
		private System.Windows.Forms.ToolStripMenuItem mnuDatabase;
		private System.Windows.Forms.ToolStripMenuItem mnuServerLog;
		private System.Windows.Forms.ToolStripMenuItem mnuLog;
		private System.Windows.Forms.MenuStrip mainMenu1;
	}
}
