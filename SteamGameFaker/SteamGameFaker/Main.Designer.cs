namespace SteamGameFaker
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtGameID = new System.Windows.Forms.TextBox();
            this.lblsglGameID = new System.Windows.Forms.Label();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.gameList = new System.Windows.Forms.ListView();
            this.gameListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tickAllGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untickAllGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblsglGameName = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.btnSingleStart = new System.Windows.Forms.Button();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.btnFillListFromSteamCommunity = new System.Windows.Forms.Button();
            this.txtSteamLink = new System.Windows.Forms.TextBox();
            this.btnKillIdlers = new System.Windows.Forms.Button();
            this.rbStartHidden = new System.Windows.Forms.RadioButton();
            this.rbStartMin = new System.Windows.Forms.RadioButton();
            this.lblActiveIdlers = new System.Windows.Forms.LinkLabel();
            this.tmrChkActiveIdlers = new System.Windows.Forms.Timer(this.components);
            this.pb_lang_us = new System.Windows.Forms.PictureBox();
            this.pb_lang_de = new System.Windows.Forms.PictureBox();
            this.chkBeta = new System.Windows.Forms.CheckBox();
            this.gbSelectedGame = new System.Windows.Forms.GroupBox();
            this.lblSelectedGame = new System.Windows.Forms.Label();
            this.gbAddGame = new System.Windows.Forms.GroupBox();
            this.gbSteamcommunity = new System.Windows.Forms.GroupBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cbSorting = new System.Windows.Forms.ComboBox();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.tmrLic = new System.Windows.Forms.Timer(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.btnTradingCardBot = new System.Windows.Forms.Button();
            this.gameListMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lang_us)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lang_de)).BeginInit();
            this.gbSelectedGame.SuspendLayout();
            this.gbAddGame.SuspendLayout();
            this.gbSteamcommunity.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGameID
            // 
            this.txtGameID.Location = new System.Drawing.Point(205, 17);
            this.txtGameID.Name = "txtGameID";
            this.txtGameID.Size = new System.Drawing.Size(65, 20);
            this.txtGameID.TabIndex = 3;
            // 
            // lblsglGameID
            // 
            this.lblsglGameID.AutoSize = true;
            this.lblsglGameID.Location = new System.Drawing.Point(276, 20);
            this.lblsglGameID.Name = "lblsglGameID";
            this.lblsglGameID.Size = new System.Drawing.Size(40, 13);
            this.lblsglGameID.TabIndex = 4;
            this.lblsglGameID.Text = "App-ID";
            // 
            // btnAddGame
            // 
            this.btnAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGame.Location = new System.Drawing.Point(6, 43);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(310, 23);
            this.btnAddGame.TabIndex = 5;
            this.btnAddGame.Text = "Add to List";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            this.btnAddGame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // gameList
            // 
            this.gameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameList.CheckBoxes = true;
            this.gameList.ContextMenuStrip = this.gameListMenu;
            this.gameList.Location = new System.Drawing.Point(12, 185);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(378, 180);
            this.gameList.TabIndex = 6;
            this.gameList.UseCompatibleStateImageBehavior = false;
            this.gameList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.gameList_ItemChecked);
            this.gameList.SelectedIndexChanged += new System.EventHandler(this.gameList_SelectedIndexChanged);
            this.gameList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // gameListMenu
            // 
            this.gameListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tickAllGamesToolStripMenuItem,
            this.untickAllGamesToolStripMenuItem});
            this.gameListMenu.Name = "gameListMenu";
            this.gameListMenu.Size = new System.Drawing.Size(162, 48);
            // 
            // tickAllGamesToolStripMenuItem
            // 
            this.tickAllGamesToolStripMenuItem.Name = "tickAllGamesToolStripMenuItem";
            this.tickAllGamesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tickAllGamesToolStripMenuItem.Text = "Tick all games";
            this.tickAllGamesToolStripMenuItem.Click += new System.EventHandler(this.tickAllGamesToolStripMenuItem_Click);
            // 
            // untickAllGamesToolStripMenuItem
            // 
            this.untickAllGamesToolStripMenuItem.Name = "untickAllGamesToolStripMenuItem";
            this.untickAllGamesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.untickAllGamesToolStripMenuItem.Text = "Untick all games";
            this.untickAllGamesToolStripMenuItem.Click += new System.EventHandler(this.untickAllGamesToolStripMenuItem_Click);
            // 
            // lblsglGameName
            // 
            this.lblsglGameName.AutoSize = true;
            this.lblsglGameName.Location = new System.Drawing.Point(164, 20);
            this.lblsglGameName.Name = "lblsglGameName";
            this.lblsglGameName.Size = new System.Drawing.Size(35, 13);
            this.lblsglGameName.TabIndex = 8;
            this.lblsglGameName.Text = "Name";
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(6, 17);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(151, 20);
            this.txtGameName.TabIndex = 7;
            // 
            // btnDelItem
            // 
            this.btnDelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelItem.Location = new System.Drawing.Point(9, 48);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(87, 23);
            this.btnDelItem.TabIndex = 9;
            this.btnDelItem.Text = "Delete";
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            this.btnDelItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnSingleStart
            // 
            this.btnSingleStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleStart.Location = new System.Drawing.Point(102, 48);
            this.btnSingleStart.Name = "btnSingleStart";
            this.btnSingleStart.Size = new System.Drawing.Size(92, 23);
            this.btnSingleStart.TabIndex = 11;
            this.btnSingleStart.Text = "Start selected";
            this.btnSingleStart.UseVisualStyleBackColor = true;
            this.btnSingleStart.Click += new System.EventHandler(this.btnSingleStart_Click);
            this.btnSingleStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnStartAll
            // 
            this.btnStartAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAll.Location = new System.Drawing.Point(392, 185);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(156, 82);
            this.btnStartAll.TabIndex = 12;
            this.btnStartAll.Text = "Start all Games\r\nClose all Idlers before you start.\r\n";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            this.btnStartAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // btnFillListFromSteamCommunity
            // 
            this.btnFillListFromSteamCommunity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillListFromSteamCommunity.Location = new System.Drawing.Point(6, 45);
            this.btnFillListFromSteamCommunity.Name = "btnFillListFromSteamCommunity";
            this.btnFillListFromSteamCommunity.Size = new System.Drawing.Size(208, 38);
            this.btnFillListFromSteamCommunity.TabIndex = 13;
            this.btnFillListFromSteamCommunity.Text = "Fill List from Steamcommunity";
            this.btnFillListFromSteamCommunity.UseVisualStyleBackColor = true;
            this.btnFillListFromSteamCommunity.Click += new System.EventHandler(this.btnFillListFromSteamCommunity_Click);
            this.btnFillListFromSteamCommunity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // txtSteamLink
            // 
            this.txtSteamLink.Location = new System.Drawing.Point(6, 19);
            this.txtSteamLink.Name = "txtSteamLink";
            this.txtSteamLink.Size = new System.Drawing.Size(208, 20);
            this.txtSteamLink.TabIndex = 14;
            this.txtSteamLink.Text = "http://steamcommunity.com/id/chiller1o1/";
            this.txtSteamLink.TextChanged += new System.EventHandler(this.txtSteamLink_TextChanged);
            // 
            // btnKillIdlers
            // 
            this.btnKillIdlers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillIdlers.Location = new System.Drawing.Point(392, 273);
            this.btnKillIdlers.Name = "btnKillIdlers";
            this.btnKillIdlers.Size = new System.Drawing.Size(156, 69);
            this.btnKillIdlers.TabIndex = 16;
            this.btnKillIdlers.Text = "Kill all Idlers";
            this.btnKillIdlers.UseVisualStyleBackColor = true;
            this.btnKillIdlers.Click += new System.EventHandler(this.btnKillIdlers_Click);
            this.btnKillIdlers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // rbStartHidden
            // 
            this.rbStartHidden.AutoSize = true;
            this.rbStartHidden.Location = new System.Drawing.Point(6, 17);
            this.rbStartHidden.Name = "rbStartHidden";
            this.rbStartHidden.Size = new System.Drawing.Size(82, 17);
            this.rbStartHidden.TabIndex = 17;
            this.rbStartHidden.Text = "Start hidden";
            this.rbStartHidden.UseVisualStyleBackColor = true;
            this.rbStartHidden.CheckedChanged += new System.EventHandler(this.rb_chkchg);
            // 
            // rbStartMin
            // 
            this.rbStartMin.AutoSize = true;
            this.rbStartMin.Location = new System.Drawing.Point(111, 17);
            this.rbStartMin.Name = "rbStartMin";
            this.rbStartMin.Size = new System.Drawing.Size(95, 17);
            this.rbStartMin.TabIndex = 18;
            this.rbStartMin.Text = "Start minimized";
            this.rbStartMin.UseVisualStyleBackColor = true;
            this.rbStartMin.CheckedChanged += new System.EventHandler(this.rb_chkchg);
            // 
            // lblActiveIdlers
            // 
            this.lblActiveIdlers.AutoSize = true;
            this.lblActiveIdlers.Location = new System.Drawing.Point(392, 345);
            this.lblActiveIdlers.Name = "lblActiveIdlers";
            this.lblActiveIdlers.Size = new System.Drawing.Size(76, 13);
            this.lblActiveIdlers.TabIndex = 19;
            this.lblActiveIdlers.TabStop = true;
            this.lblActiveIdlers.Text = "Active Games:";
            this.lblActiveIdlers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblActiveIdlers_LinkClicked);
            // 
            // tmrChkActiveIdlers
            // 
            this.tmrChkActiveIdlers.Enabled = true;
            this.tmrChkActiveIdlers.Interval = 2500;
            this.tmrChkActiveIdlers.Tick += new System.EventHandler(this.tmrChkActiveIdlers_Tick);
            // 
            // pb_lang_us
            // 
            this.pb_lang_us.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_lang_us.Image = ((System.Drawing.Image)(resources.GetObject("pb_lang_us.Image")));
            this.pb_lang_us.Location = new System.Drawing.Point(240, 17);
            this.pb_lang_us.Name = "pb_lang_us";
            this.pb_lang_us.Size = new System.Drawing.Size(50, 30);
            this.pb_lang_us.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_lang_us.TabIndex = 20;
            this.pb_lang_us.TabStop = false;
            this.pb_lang_us.Click += new System.EventHandler(this.pb_lang_us_Click);
            // 
            // pb_lang_de
            // 
            this.pb_lang_de.Image = ((System.Drawing.Image)(resources.GetObject("pb_lang_de.Image")));
            this.pb_lang_de.Location = new System.Drawing.Point(240, 53);
            this.pb_lang_de.Name = "pb_lang_de";
            this.pb_lang_de.Size = new System.Drawing.Size(50, 30);
            this.pb_lang_de.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_lang_de.TabIndex = 21;
            this.pb_lang_de.TabStop = false;
            this.pb_lang_de.Click += new System.EventHandler(this.pb_lang_us_Click);
            // 
            // chkBeta
            // 
            this.chkBeta.AutoSize = true;
            this.chkBeta.Checked = true;
            this.chkBeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBeta.Enabled = false;
            this.chkBeta.Location = new System.Drawing.Point(6, 40);
            this.chkBeta.Name = "chkBeta";
            this.chkBeta.Size = new System.Drawing.Size(149, 17);
            this.chkBeta.TabIndex = 22;
            this.chkBeta.Text = "Safe start (Start all games)";
            this.chkBeta.UseVisualStyleBackColor = true;
            // 
            // gbSelectedGame
            // 
            this.gbSelectedGame.Controls.Add(this.lblSelectedGame);
            this.gbSelectedGame.Controls.Add(this.btnDelItem);
            this.gbSelectedGame.Controls.Add(this.btnSingleStart);
            this.gbSelectedGame.Location = new System.Drawing.Point(348, 7);
            this.gbSelectedGame.Name = "gbSelectedGame";
            this.gbSelectedGame.Size = new System.Drawing.Size(200, 77);
            this.gbSelectedGame.TabIndex = 23;
            this.gbSelectedGame.TabStop = false;
            this.gbSelectedGame.Text = "Selected game:";
            // 
            // lblSelectedGame
            // 
            this.lblSelectedGame.AutoSize = true;
            this.lblSelectedGame.Location = new System.Drawing.Point(6, 16);
            this.lblSelectedGame.Name = "lblSelectedGame";
            this.lblSelectedGame.Size = new System.Drawing.Size(25, 13);
            this.lblSelectedGame.TabIndex = 10;
            this.lblSelectedGame.Text = "Null";
            // 
            // gbAddGame
            // 
            this.gbAddGame.Controls.Add(this.lblsglGameName);
            this.gbAddGame.Controls.Add(this.btnAddGame);
            this.gbAddGame.Controls.Add(this.txtGameID);
            this.gbAddGame.Controls.Add(this.lblsglGameID);
            this.gbAddGame.Controls.Add(this.txtGameName);
            this.gbAddGame.Location = new System.Drawing.Point(12, 7);
            this.gbAddGame.Name = "gbAddGame";
            this.gbAddGame.Size = new System.Drawing.Size(330, 77);
            this.gbAddGame.TabIndex = 24;
            this.gbAddGame.TabStop = false;
            this.gbAddGame.Text = "Add single game";
            // 
            // gbSteamcommunity
            // 
            this.gbSteamcommunity.Controls.Add(this.txtSteamLink);
            this.gbSteamcommunity.Controls.Add(this.btnFillListFromSteamCommunity);
            this.gbSteamcommunity.Location = new System.Drawing.Point(12, 90);
            this.gbSteamcommunity.Name = "gbSteamcommunity";
            this.gbSteamcommunity.Size = new System.Drawing.Size(227, 89);
            this.gbSteamcommunity.TabIndex = 25;
            this.gbSteamcommunity.TabStop = false;
            this.gbSteamcommunity.Text = "Steamcommunity";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btnHelp);
            this.gbSettings.Controls.Add(this.rbStartMin);
            this.gbSettings.Controls.Add(this.cbSorting);
            this.gbSettings.Controls.Add(this.rbStartHidden);
            this.gbSettings.Controls.Add(this.chkBeta);
            this.gbSettings.Controls.Add(this.pb_lang_de);
            this.gbSettings.Controls.Add(this.pb_lang_us);
            this.gbSettings.Location = new System.Drawing.Point(246, 90);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(296, 89);
            this.gbSettings.TabIndex = 26;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(191, 36);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(43, 23);
            this.btnHelp.TabIndex = 28;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            // 
            // cbSorting
            // 
            this.cbSorting.FormattingEnabled = true;
            this.cbSorting.Location = new System.Drawing.Point(6, 62);
            this.cbSorting.Name = "cbSorting";
            this.cbSorting.Size = new System.Drawing.Size(228, 21);
            this.cbSorting.TabIndex = 27;
            this.cbSorting.SelectedIndexChanged += new System.EventHandler(this.cbSorting_SelectedIndexChanged);
            this.cbSorting.SelectedValueChanged += new System.EventHandler(this.cbSorting_SelectedValueChanged);
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 500;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // tmrLic
            // 
            this.tmrLic.Enabled = true;
            this.tmrLic.Interval = 1200000;
            this.tmrLic.Tick += new System.EventHandler(this.tmrLic_Tick);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 365);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(36, 13);
            this.lblState.TabIndex = 27;
            this.lblState.Text = "$temp";
            // 
            // btnTradingCardBot
            // 
            this.btnTradingCardBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTradingCardBot.Location = new System.Drawing.Point(392, 365);
            this.btnTradingCardBot.Name = "btnTradingCardBot";
            this.btnTradingCardBot.Size = new System.Drawing.Size(156, 23);
            this.btnTradingCardBot.TabIndex = 28;
            this.btnTradingCardBot.Text = "Start_Trading_Card_Bot (Beta)";
            this.btnTradingCardBot.UseVisualStyleBackColor = true;
            this.btnTradingCardBot.Click += new System.EventHandler(this.btnTradingCardBot_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 396);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbSteamcommunity);
            this.Controls.Add(this.gbAddGame);
            this.Controls.Add(this.gbSelectedGame);
            this.Controls.Add(this.lblActiveIdlers);
            this.Controls.Add(this.btnKillIdlers);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.gameList);
            this.Controls.Add(this.btnTradingCardBot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(575, 435);
            this.Name = "Main";
            this.Text = "SteamGameFaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.gameListMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_lang_us)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lang_de)).EndInit();
            this.gbSelectedGame.ResumeLayout(false);
            this.gbSelectedGame.PerformLayout();
            this.gbAddGame.ResumeLayout(false);
            this.gbAddGame.PerformLayout();
            this.gbSteamcommunity.ResumeLayout(false);
            this.gbSteamcommunity.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameID;
        private System.Windows.Forms.Label lblsglGameID;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.ListView gameList;
        private System.Windows.Forms.Label lblsglGameName;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.Button btnSingleStart;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.Button btnFillListFromSteamCommunity;
        private System.Windows.Forms.TextBox txtSteamLink;
        private System.Windows.Forms.Button btnKillIdlers;
        private System.Windows.Forms.RadioButton rbStartHidden;
        private System.Windows.Forms.RadioButton rbStartMin;
        private System.Windows.Forms.LinkLabel lblActiveIdlers;
        private System.Windows.Forms.Timer tmrChkActiveIdlers;
        private System.Windows.Forms.PictureBox pb_lang_us;
        private System.Windows.Forms.PictureBox pb_lang_de;
        private System.Windows.Forms.CheckBox chkBeta;
        private System.Windows.Forms.GroupBox gbSelectedGame;
        private System.Windows.Forms.Label lblSelectedGame;
        private System.Windows.Forms.GroupBox gbAddGame;
        private System.Windows.Forms.GroupBox gbSteamcommunity;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.ComboBox cbSorting;
        private System.Windows.Forms.ContextMenuStrip gameListMenu;
        private System.Windows.Forms.ToolStripMenuItem tickAllGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untickAllGamesToolStripMenuItem;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.Timer tmrLic;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnTradingCardBot;
    }
}

