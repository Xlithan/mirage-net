namespace Mirage
{
	partial class frmMirage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMirage));
			optLayers = new System.Windows.Forms.RadioButton();
			optAttribs = new System.Windows.Forms.RadioButton();
			cmdCancel = new System.Windows.Forms.Button();
			cmdSend = new System.Windows.Forms.Button();
			cmdProperties = new System.Windows.Forms.Button();
			scrlPicture = new System.Windows.Forms.VScrollBar();
			picBackSelect = new System.Windows.Forms.PictureBox();
			picBack = new System.Windows.Forms.PictureBox();
			picSelect = new System.Windows.Forms.PictureBox();
			cmdFill = new System.Windows.Forms.Button();
			optGround = new System.Windows.Forms.RadioButton();
			optMask = new System.Windows.Forms.RadioButton();
			optAnim = new System.Windows.Forms.RadioButton();
			optFringe = new System.Windows.Forms.RadioButton();
			cmdClear = new System.Windows.Forms.Button();
			fraLayers = new System.Windows.Forms.GroupBox();
			optPass = new System.Windows.Forms.RadioButton();
			optKeyOpen = new System.Windows.Forms.RadioButton();
			optBlocked = new System.Windows.Forms.RadioButton();
			optWarp = new System.Windows.Forms.RadioButton();
			cmdClear2 = new System.Windows.Forms.Button();
			optItem = new System.Windows.Forms.RadioButton();
			optNpcAvoid = new System.Windows.Forms.RadioButton();
			optKey = new System.Windows.Forms.RadioButton();
			fraAttribs = new System.Windows.Forms.GroupBox();
			picMapEditor = new System.Windows.Forms.PictureBox();
			txtChat = new System.Windows.Forms.RichTextBox();
			picScreen = new System.Windows.Forms.PictureBox();
			lstInv = new System.Windows.Forms.ListBox();
			lblCancel = new System.Windows.Forms.Label();
			lblDropItem = new System.Windows.Forms.Label();
			lblUseItem = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			picInv = new System.Windows.Forms.PictureBox();
			lstSpells = new System.Windows.Forms.ListBox();
			Label5 = new System.Windows.Forms.Label();
			lblCast = new System.Windows.Forms.Label();
			lblSpellsCancel = new System.Windows.Forms.Label();
			picPlayerSpells = new System.Windows.Forms.PictureBox();
			picInventory = new System.Windows.Forms.PictureBox();
			picSpells = new System.Windows.Forms.PictureBox();
			picStats = new System.Windows.Forms.PictureBox();
			picTrain = new System.Windows.Forms.PictureBox();
			picTrade = new System.Windows.Forms.PictureBox();
			picQuit = new System.Windows.Forms.PictureBox();
			lblName = new System.Windows.Forms.Label();
			lblHP = new System.Windows.Forms.Label();
			lblMP = new System.Windows.Forms.Label();
			lblSP = new System.Windows.Forms.Label();
			picGUI = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picMapEditor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBackSelect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSelect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picInv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerSpells)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picGUI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picInventory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSpells)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picStats)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picQuit)).BeginInit();
			this.SuspendLayout();
			//
			// optLayers
			//
			this.optLayers.Name = "optLayers";
			this.optLayers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optLayers.Location = new System.Drawing.Point(120, 248);
			this.optLayers.Size = new System.Drawing.Size(105, 17);
			this.optLayers.TabIndex = 22;
			this.optLayers.Text = "Layers";
			//
			// optAttribs
			//
			this.optAttribs.Name = "optAttribs";
			this.optAttribs.Location = new System.Drawing.Point(120, 264);
			this.optAttribs.Size = new System.Drawing.Size(105, 17);
			this.optAttribs.TabIndex = 21;
			this.optAttribs.Text = "Attributes";
			this.optAttribs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// cmdCancel
			//
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.TabIndex = 20;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancel.Location = new System.Drawing.Point(136, 399);
			this.cmdCancel.Size = new System.Drawing.Size(113, 18);
			//
			// cmdSend
			//
			this.cmdSend.Name = "cmdSend";
			this.cmdSend.TabIndex = 19;
			this.cmdSend.Text = "Send";
			this.cmdSend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSend.Location = new System.Drawing.Point(8, 399);
			this.cmdSend.Size = new System.Drawing.Size(113, 18);
			//
			// cmdProperties
			//
			this.cmdProperties.Name = "cmdProperties";
			this.cmdProperties.Location = new System.Drawing.Point(160, 304);
			this.cmdProperties.Size = new System.Drawing.Size(89, 33);
			this.cmdProperties.TabIndex = 18;
			this.cmdProperties.Text = "Properties";
			this.cmdProperties.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// scrlPicture
			//
			this.scrlPicture.Name = "scrlPicture";
			this.scrlPicture.Location = new System.Drawing.Point(232, 8);
			this.scrlPicture.Size = new System.Drawing.Size(17, 225);
			this.scrlPicture.TabIndex = 17;
			this.scrlPicture.Maximum = 255;
			//
			// picBackSelect
			//
			this.picBackSelect.Name = "picBackSelect";
			this.picBackSelect.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.picBackSelect.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picBackSelect.Location = new System.Drawing.Point(0, 0);
			this.picBackSelect.Size = new System.Drawing.Size(64, 64);
			this.picBackSelect.TabIndex = 16;
			this.picBackSelect.TabStop = false;
			//
			// picBack
			//
			this.picBack.Name = "picBack";
			this.picBack.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.picBack.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picBack.Location = new System.Drawing.Point(8, 8);
			this.picBack.Size = new System.Drawing.Size(224, 224);
			this.picBack.TabIndex = 15;
			this.picBack.TabStop = false;
			this.picBack.Controls.Add(this.picBackSelect);
			//
			// picSelect
			//
			this.picSelect.Name = "picSelect";
			this.picSelect.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picSelect.Location = new System.Drawing.Point(120, 304);
			this.picSelect.Size = new System.Drawing.Size(32, 32);
			this.picSelect.TabIndex = 14;
			this.picSelect.TabStop = false;
			this.picSelect.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			//
			// cmdFill
			//
			this.cmdFill.Name = "cmdFill";
			this.cmdFill.Text = "Fill";
			this.cmdFill.Visible = false;
			this.cmdFill.Location = new System.Drawing.Point(8, 104);
			this.cmdFill.Size = new System.Drawing.Size(81, 17);
			this.cmdFill.TabIndex = 49;
			//
			// optGround
			//
			this.optGround.Name = "optGround";
			this.optGround.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optGround.Location = new System.Drawing.Point(8, 24);
			this.optGround.Size = new System.Drawing.Size(81, 17);
			this.optGround.TabIndex = 35;
			this.optGround.Text = "Ground";
			//
			// optMask
			//
			this.optMask.Name = "optMask";
			this.optMask.Size = new System.Drawing.Size(81, 17);
			this.optMask.TabIndex = 34;
			this.optMask.Text = "Mask";
			this.optMask.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optMask.Location = new System.Drawing.Point(8, 40);
			//
			// optAnim
			//
			this.optAnim.Name = "optAnim";
			this.optAnim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optAnim.Location = new System.Drawing.Point(8, 56);
			this.optAnim.Size = new System.Drawing.Size(81, 17);
			this.optAnim.TabIndex = 33;
			this.optAnim.Text = "Animation";
			//
			// optFringe
			//
			this.optFringe.Name = "optFringe";
			this.optFringe.Text = "Fringe";
			this.optFringe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optFringe.Location = new System.Drawing.Point(8, 72);
			this.optFringe.Size = new System.Drawing.Size(81, 17);
			this.optFringe.TabIndex = 32;
			//
			// cmdClear
			//
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size(81, 18);
			this.cmdClear.TabIndex = 31;
			this.cmdClear.Text = "Clear";
			this.cmdClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdClear.Location = new System.Drawing.Point(8, 128);
			//
			// fraLayers
			//
			this.fraLayers.Name = "fraLayers";
			this.fraLayers.Size = new System.Drawing.Size(97, 153);
			this.fraLayers.TabIndex = 30;
			this.fraLayers.Text = "Layers";
			this.fraLayers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fraLayers.Location = new System.Drawing.Point(8, 240);
			this.fraLayers.Controls.Add(this.cmdFill);
			this.fraLayers.Controls.Add(this.optGround);
			this.fraLayers.Controls.Add(this.optMask);
			this.fraLayers.Controls.Add(this.optAnim);
			this.fraLayers.Controls.Add(this.optFringe);
			this.fraLayers.Controls.Add(this.cmdClear);
			//
			// optPass
			//
			this.optPass.Name = "optPass";
			this.optPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optPass.Location = new System.Drawing.Point(8, 112);
			this.optPass.Size = new System.Drawing.Size(81, 17);
			this.optPass.TabIndex = 48;
			this.optPass.Text = "Passable";
			//
			// optKeyOpen
			//
			this.optKeyOpen.Name = "optKeyOpen";
			this.optKeyOpen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optKeyOpen.Location = new System.Drawing.Point(8, 96);
			this.optKeyOpen.Size = new System.Drawing.Size(81, 16);
			this.optKeyOpen.TabIndex = 47;
			this.optKeyOpen.Text = "Key Open";
			//
			// optBlocked
			//
			this.optBlocked.Name = "optBlocked";
			this.optBlocked.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optBlocked.Location = new System.Drawing.Point(8, 16);
			this.optBlocked.Size = new System.Drawing.Size(81, 17);
			this.optBlocked.TabIndex = 29;
			this.optBlocked.Text = "Blocked";
			//
			// optWarp
			//
			this.optWarp.Name = "optWarp";
			this.optWarp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optWarp.Location = new System.Drawing.Point(8, 32);
			this.optWarp.Size = new System.Drawing.Size(81, 17);
			this.optWarp.TabIndex = 28;
			this.optWarp.Text = "Warp";
			//
			// cmdClear2
			//
			this.cmdClear2.Name = "cmdClear2";
			this.cmdClear2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdClear2.Location = new System.Drawing.Point(8, 128);
			this.cmdClear2.Size = new System.Drawing.Size(81, 18);
			this.cmdClear2.TabIndex = 27;
			this.cmdClear2.Text = "Clear";
			//
			// optItem
			//
			this.optItem.Name = "optItem";
			this.optItem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optItem.Location = new System.Drawing.Point(8, 48);
			this.optItem.Size = new System.Drawing.Size(81, 18);
			this.optItem.TabIndex = 26;
			this.optItem.Text = "Item";
			//
			// optNpcAvoid
			//
			this.optNpcAvoid.Name = "optNpcAvoid";
			this.optNpcAvoid.Text = "Npc Avoid";
			this.optNpcAvoid.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optNpcAvoid.Location = new System.Drawing.Point(8, 64);
			this.optNpcAvoid.Size = new System.Drawing.Size(81, 18);
			this.optNpcAvoid.TabIndex = 25;
			//
			// optKey
			//
			this.optKey.Name = "optKey";
			this.optKey.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optKey.Location = new System.Drawing.Point(8, 80);
			this.optKey.Size = new System.Drawing.Size(81, 18);
			this.optKey.TabIndex = 24;
			this.optKey.Text = "Key";
			//
			// fraAttribs
			//
			this.fraAttribs.Name = "fraAttribs";
			this.fraAttribs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fraAttribs.Location = new System.Drawing.Point(8, 240);
			this.fraAttribs.Size = new System.Drawing.Size(97, 153);
			this.fraAttribs.TabIndex = 23;
			this.fraAttribs.Text = "Attributes";
			this.fraAttribs.Visible = false;
			this.fraAttribs.Controls.Add(this.optPass);
			this.fraAttribs.Controls.Add(this.optKeyOpen);
			this.fraAttribs.Controls.Add(this.optBlocked);
			this.fraAttribs.Controls.Add(this.optWarp);
			this.fraAttribs.Controls.Add(this.cmdClear2);
			this.fraAttribs.Controls.Add(this.optItem);
			this.fraAttribs.Controls.Add(this.optNpcAvoid);
			this.fraAttribs.Controls.Add(this.optKey);
			//
			// picMapEditor
			//
			this.picMapEditor.Name = "picMapEditor";
			this.picMapEditor.TabStop = false;
			this.picMapEditor.Visible = false;
			this.picMapEditor.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picMapEditor.Location = new System.Drawing.Point(512, 0);
			this.picMapEditor.Size = new System.Drawing.Size(257, 427);
			this.picMapEditor.TabIndex = 13;
			this.picMapEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picMapEditor.Controls.Add(this.optLayers);
			this.picMapEditor.Controls.Add(this.optAttribs);
			this.picMapEditor.Controls.Add(this.cmdCancel);
			this.picMapEditor.Controls.Add(this.cmdSend);
			this.picMapEditor.Controls.Add(this.cmdProperties);
			this.picMapEditor.Controls.Add(this.scrlPicture);
			this.picMapEditor.Controls.Add(this.picBack);
			this.picMapEditor.Controls.Add(this.picSelect);
			this.picMapEditor.Controls.Add(this.fraLayers);
			this.picMapEditor.Controls.Add(this.fraAttribs);
			//
			// txtChat
			//
			this.txtChat.Name = "txtChat";
			this.txtChat.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.txtChat.Location = new System.Drawing.Point(0, 384);
			this.txtChat.Size = new System.Drawing.Size(641, 121);
			this.txtChat.TabIndex = 1;
			this.txtChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			//
			// picScreen
			//
			this.picScreen.Name = "picScreen";
			this.picScreen.TabIndex = 0;
			this.picScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picScreen.TabStop = false;
			this.picScreen.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.picScreen.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picScreen.Location = new System.Drawing.Point(0, 0);
			this.picScreen.Size = new System.Drawing.Size(512, 384);
			//
			// lstInv
			//
			this.lstInv.Name = "lstInv";
			this.lstInv.Location = new System.Drawing.Point(0, 16);
			this.lstInv.Size = new System.Drawing.Size(257, 128);
			this.lstInv.TabIndex = 38;
			this.lstInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstInv.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.lstInv.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstInv.Items.AddRange(new object[] {

		});
			//
			// lblCancel
			//
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.TabIndex = 41;
			this.lblCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblCancel.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			this.lblCancel.Text = "Cancel";
			this.lblCancel.BackColor = System.Drawing.Color.Transparent;
			this.lblCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCancel.Location = new System.Drawing.Point(0, 192);
			this.lblCancel.Size = new System.Drawing.Size(129, 17);
			//
			// lblDropItem
			//
			this.lblDropItem.Name = "lblDropItem";
			this.lblDropItem.BackColor = System.Drawing.Color.Transparent;
			this.lblDropItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDropItem.Location = new System.Drawing.Point(0, 168);
			this.lblDropItem.Size = new System.Drawing.Size(129, 17);
			this.lblDropItem.TabIndex = 40;
			this.lblDropItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblDropItem.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			this.lblDropItem.Text = "Drop Item";
			//
			// lblUseItem
			//
			this.lblUseItem.Name = "lblUseItem";
			this.lblUseItem.Location = new System.Drawing.Point(0, 144);
			this.lblUseItem.Size = new System.Drawing.Size(129, 17);
			this.lblUseItem.TabIndex = 39;
			this.lblUseItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblUseItem.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			this.lblUseItem.Text = "Use Item";
			this.lblUseItem.BackColor = System.Drawing.Color.Transparent;
			this.lblUseItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// Label1
			//
			this.Label1.Name = "Label1";
			this.Label1.Text = "Backpack";
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(0, 0);
			this.Label1.Size = new System.Drawing.Size(129, 17);
			this.Label1.TabIndex = 37;
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Label1.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			//
			// picInv
			//
			this.picInv.Name = "picInv";
			this.picInv.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
			this.picInv.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picInv.Location = new System.Drawing.Point(512, 168);
			this.picInv.Size = new System.Drawing.Size(257, 219);
			this.picInv.TabIndex = 36;
			this.picInv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picInv.TabStop = false;
			this.picInv.Visible = false;
			this.picInv.Controls.Add(this.lstInv);
			this.picInv.Controls.Add(this.lblCancel);
			this.picInv.Controls.Add(this.lblDropItem);
			this.picInv.Controls.Add(this.lblUseItem);
			this.picInv.Controls.Add(this.Label1);
			//
			// lstSpells
			//
			this.lstSpells.Name = "lstSpells";
			this.lstSpells.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.lstSpells.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstSpells.Location = new System.Drawing.Point(0, 16);
			this.lstSpells.Size = new System.Drawing.Size(257, 128);
			this.lstSpells.TabIndex = 43;
			this.lstSpells.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstSpells.Items.AddRange(new object[] {

		});
			//
			// Label5
			//
			this.Label5.Name = "Label5";
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label5.Location = new System.Drawing.Point(0, 0);
			this.Label5.Size = new System.Drawing.Size(129, 17);
			this.Label5.TabIndex = 46;
			this.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Label5.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			this.Label5.Text = "Spells";
			//
			// lblCast
			//
			this.lblCast.Name = "lblCast";
			this.lblCast.BackColor = System.Drawing.Color.Transparent;
			this.lblCast.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCast.Location = new System.Drawing.Point(0, 168);
			this.lblCast.Size = new System.Drawing.Size(129, 17);
			this.lblCast.TabIndex = 45;
			this.lblCast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblCast.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			this.lblCast.Text = "Cast";
			//
			// lblSpellsCancel
			//
			this.lblSpellsCancel.Name = "lblSpellsCancel";
			this.lblSpellsCancel.Text = "Cancel";
			this.lblSpellsCancel.BackColor = System.Drawing.Color.Transparent;
			this.lblSpellsCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpellsCancel.Location = new System.Drawing.Point(0, 192);
			this.lblSpellsCancel.Size = new System.Drawing.Size(129, 17);
			this.lblSpellsCancel.TabIndex = 44;
			this.lblSpellsCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblSpellsCancel.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			//
			// picPlayerSpells
			//
			this.picPlayerSpells.Name = "picPlayerSpells";
			this.picPlayerSpells.Visible = false;
			this.picPlayerSpells.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
			this.picPlayerSpells.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picPlayerSpells.Location = new System.Drawing.Point(512, 168);
			this.picPlayerSpells.Size = new System.Drawing.Size(257, 219);
			this.picPlayerSpells.TabIndex = 42;
			this.picPlayerSpells.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picPlayerSpells.TabStop = false;
			this.picPlayerSpells.Controls.Add(this.lstSpells);
			this.picPlayerSpells.Controls.Add(this.Label5);
			this.picPlayerSpells.Controls.Add(this.lblCast);
			this.picPlayerSpells.Controls.Add(this.lblSpellsCancel);
			//
			// picInventory
			//
			this.picInventory.Name = "picInventory";
			this.picInventory.Size = new System.Drawing.Size(42, 42);
			this.picInventory.TabIndex = 8;
			this.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picInventory.Image = ((System.Drawing.Image)(resources.GetObject("picInventory.Image")));
			this.picInventory.TabStop = false;
			this.picInventory.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picInventory.Location = new System.Drawing.Point(16, 200);
			//
			// picSpells
			//
			this.picSpells.Name = "picSpells";
			this.picSpells.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picSpells.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picSpells.Image = ((System.Drawing.Image)(resources.GetObject("picSpells.Image")));
			this.picSpells.TabStop = false;
			this.picSpells.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picSpells.Location = new System.Drawing.Point(72, 200);
			this.picSpells.Size = new System.Drawing.Size(42, 42);
			this.picSpells.TabIndex = 7;
			//
			// picStats
			//
			this.picStats.Name = "picStats";
			this.picStats.TabStop = false;
			this.picStats.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picStats.Location = new System.Drawing.Point(16, 256);
			this.picStats.Size = new System.Drawing.Size(42, 42);
			this.picStats.TabIndex = 6;
			this.picStats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picStats.Image = ((System.Drawing.Image)(resources.GetObject("picStats.Image")));
			//
			// picTrain
			//
			this.picTrain.Name = "picTrain";
			this.picTrain.Size = new System.Drawing.Size(42, 42);
			this.picTrain.TabIndex = 5;
			this.picTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picTrain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picTrain.Image = ((System.Drawing.Image)(resources.GetObject("picTrain.Image")));
			this.picTrain.TabStop = false;
			this.picTrain.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picTrain.Location = new System.Drawing.Point(72, 256);
			//
			// picTrade
			//
			this.picTrade.Name = "picTrade";
			this.picTrade.Size = new System.Drawing.Size(42, 42);
			this.picTrade.TabIndex = 4;
			this.picTrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picTrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picTrade.Image = ((System.Drawing.Image)(resources.GetObject("picTrade.Image")));
			this.picTrade.TabStop = false;
			this.picTrade.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picTrade.Location = new System.Drawing.Point(16, 312);
			//
			// picQuit
			//
			this.picQuit.Name = "picQuit";
			this.picQuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picQuit.Image = ((System.Drawing.Image)(resources.GetObject("picQuit.Image")));
			this.picQuit.TabStop = false;
			this.picQuit.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picQuit.Location = new System.Drawing.Point(72, 312);
			this.picQuit.Size = new System.Drawing.Size(42, 42);
			this.picQuit.TabIndex = 3;
			this.picQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			//
			// lblName
			//
			this.lblName.Name = "lblName";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			this.lblName.Text = "Mirage Online";
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(0, 8);
			this.lblName.Size = new System.Drawing.Size(129, 17);
			this.lblName.TabIndex = 12;
			//
			// lblHP
			//
			this.lblHP.Name = "lblHP";
			this.lblHP.Location = new System.Drawing.Point(24, 120);
			this.lblHP.Size = new System.Drawing.Size(105, 17);
			this.lblHP.TabIndex = 11;
			this.lblHP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblHP.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
			this.lblHP.Text = "0%";
			this.lblHP.BackColor = System.Drawing.Color.Transparent;
			this.lblHP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// lblMP
			//
			this.lblMP.Name = "lblMP";
			this.lblMP.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
			this.lblMP.Text = "0%";
			this.lblMP.BackColor = System.Drawing.Color.Transparent;
			this.lblMP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMP.Location = new System.Drawing.Point(24, 144);
			this.lblMP.Size = new System.Drawing.Size(105, 17);
			this.lblMP.TabIndex = 10;
			this.lblMP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			// lblSP
			//
			this.lblSP.Name = "lblSP";
			this.lblSP.Location = new System.Drawing.Point(24, 168);
			this.lblSP.Size = new System.Drawing.Size(105, 17);
			this.lblSP.TabIndex = 9;
			this.lblSP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblSP.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255);
			this.lblSP.Text = "0%";
			this.lblSP.BackColor = System.Drawing.Color.Transparent;
			this.lblSP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//
			// picGUI
			//
			this.picGUI.Name = "picGUI";
			this.picGUI.Image = ((System.Drawing.Image)(resources.GetObject("picGUI.Image")));
			this.picGUI.TabStop = false;
			this.picGUI.Font = new System.Drawing.Font("MS Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.picGUI.Location = new System.Drawing.Point(512, 0);
			this.picGUI.Size = new System.Drawing.Size(130, 386);
			this.picGUI.TabIndex = 2;
			this.picGUI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picGUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.picGUI.Controls.Add(this.picInventory);
			this.picGUI.Controls.Add(this.picSpells);
			this.picGUI.Controls.Add(this.picStats);
			this.picGUI.Controls.Add(this.picTrain);
			this.picGUI.Controls.Add(this.picTrade);
			this.picGUI.Controls.Add(this.picQuit);
			this.picGUI.Controls.Add(this.lblName);
			this.picGUI.Controls.Add(this.lblHP);
			this.picGUI.Controls.Add(this.lblMP);
			this.picGUI.Controls.Add(this.lblSP);
			//
			// frmMirage
			//
			this.Name = "frmMirage";
			this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.Font = new System.Drawing.Font("MS Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(641, 505);
			this.Text = "Mirage Online";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Visible = false;
			this.Controls.Add(this.picMapEditor);
			this.Controls.Add(this.txtChat);
			this.Controls.Add(this.picScreen);
			this.Controls.Add(this.picInv);
			this.Controls.Add(this.picPlayerSpells);
			this.Controls.Add(this.picGUI);
			((System.ComponentModel.ISupportInitialize)(this.picMapEditor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBackSelect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSelect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picInv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerSpells)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picGUI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picInventory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSpells)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picStats)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTrade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picQuit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.RadioButton optLayers;
		private System.Windows.Forms.RadioButton optAttribs;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdSend;
		private System.Windows.Forms.Button cmdProperties;
		private System.Windows.Forms.VScrollBar scrlPicture;
		private System.Windows.Forms.PictureBox picBackSelect;
		private System.Windows.Forms.PictureBox picBack;
		private System.Windows.Forms.PictureBox picSelect;
		private System.Windows.Forms.Button cmdFill;
		private System.Windows.Forms.RadioButton optGround;
		private System.Windows.Forms.RadioButton optMask;
		private System.Windows.Forms.RadioButton optAnim;
		private System.Windows.Forms.RadioButton optFringe;
		private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.GroupBox fraLayers;
		private System.Windows.Forms.RadioButton optPass;
		private System.Windows.Forms.RadioButton optKeyOpen;
		private System.Windows.Forms.RadioButton optBlocked;
		private System.Windows.Forms.RadioButton optWarp;
		private System.Windows.Forms.Button cmdClear2;
		private System.Windows.Forms.RadioButton optItem;
		private System.Windows.Forms.RadioButton optNpcAvoid;
		private System.Windows.Forms.RadioButton optKey;
		private System.Windows.Forms.GroupBox fraAttribs;
		private System.Windows.Forms.PictureBox picMapEditor;
		private System.Windows.Forms.RichTextBox txtChat;
		private System.Windows.Forms.PictureBox picScreen;
		private System.Windows.Forms.ListBox lstInv;
		private System.Windows.Forms.Label lblCancel;
		private System.Windows.Forms.Label lblDropItem;
		private System.Windows.Forms.Label lblUseItem;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.PictureBox picInv;
		private System.Windows.Forms.ListBox lstSpells;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label lblCast;
		private System.Windows.Forms.Label lblSpellsCancel;
		private System.Windows.Forms.PictureBox picPlayerSpells;
		private System.Windows.Forms.PictureBox picInventory;
		private System.Windows.Forms.PictureBox picSpells;
		private System.Windows.Forms.PictureBox picStats;
		private System.Windows.Forms.PictureBox picTrain;
		private System.Windows.Forms.PictureBox picTrade;
		private System.Windows.Forms.PictureBox picQuit;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblHP;
		private System.Windows.Forms.Label lblMP;
		private System.Windows.Forms.Label lblSP;
		private System.Windows.Forms.PictureBox picGUI;
	}
}
