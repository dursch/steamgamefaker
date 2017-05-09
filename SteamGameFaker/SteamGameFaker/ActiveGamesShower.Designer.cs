namespace SteamGameFaker
{
    partial class ActiveGamesShower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveGamesShower));
            this.activeGameList = new System.Windows.Forms.ListView();
            this.ActiveGameListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dELFROMLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kILLIDLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmRefresh = new System.Windows.Forms.Timer(this.components);
            this.chkRefresh = new System.Windows.Forms.CheckBox();
            this.ActiveGameListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // activeGameList
            // 
            this.activeGameList.ContextMenuStrip = this.ActiveGameListMenu;
            this.activeGameList.Location = new System.Drawing.Point(12, 12);
            this.activeGameList.Name = "activeGameList";
            this.activeGameList.Size = new System.Drawing.Size(354, 362);
            this.activeGameList.TabIndex = 0;
            this.activeGameList.UseCompatibleStateImageBehavior = false;
            // 
            // ActiveGameListMenu
            // 
            this.ActiveGameListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELFROMLISTToolStripMenuItem,
            this.kILLIDLERToolStripMenuItem});
            this.ActiveGameListMenu.Name = "gameListMenu";
            this.ActiveGameListMenu.Size = new System.Drawing.Size(160, 48);
            // 
            // dELFROMLISTToolStripMenuItem
            // 
            this.dELFROMLISTToolStripMenuItem.Name = "dELFROMLISTToolStripMenuItem";
            this.dELFROMLISTToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dELFROMLISTToolStripMenuItem.Text = "DEL_FROM_LIST";
            this.dELFROMLISTToolStripMenuItem.Click += new System.EventHandler(this.dELFROMLISTToolStripMenuItem_Click);
            // 
            // kILLIDLERToolStripMenuItem
            // 
            this.kILLIDLERToolStripMenuItem.Name = "kILLIDLERToolStripMenuItem";
            this.kILLIDLERToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kILLIDLERToolStripMenuItem.Text = "KILL_IDLER";
            this.kILLIDLERToolStripMenuItem.Click += new System.EventHandler(this.kILLIDLERToolStripMenuItem_Click);
            // 
            // tmRefresh
            // 
            this.tmRefresh.Enabled = true;
            this.tmRefresh.Interval = 1000;
            this.tmRefresh.Tick += new System.EventHandler(this.tmRefresh_Tick);
            // 
            // chkRefresh
            // 
            this.chkRefresh.AutoSize = true;
            this.chkRefresh.Checked = true;
            this.chkRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRefresh.Location = new System.Drawing.Point(12, 380);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Size = new System.Drawing.Size(63, 17);
            this.chkRefresh.TabIndex = 1;
            this.chkRefresh.Text = "Refresh";
            this.chkRefresh.UseVisualStyleBackColor = true;
            // 
            // ActiveGamesShower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 406);
            this.Controls.Add(this.chkRefresh);
            this.Controls.Add(this.activeGameList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActiveGamesShower";
            this.Text = "ActiveGamesView";
            this.Load += new System.EventHandler(this.ActiveGamesShower_Load);
            this.ActiveGameListMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView activeGameList;
        private System.Windows.Forms.Timer tmRefresh;
        private System.Windows.Forms.CheckBox chkRefresh;
        private System.Windows.Forms.ContextMenuStrip ActiveGameListMenu;
        private System.Windows.Forms.ToolStripMenuItem dELFROMLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kILLIDLERToolStripMenuItem;
    }
}