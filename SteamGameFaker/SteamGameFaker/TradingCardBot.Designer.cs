namespace SteamGameFaker
{
    partial class TradingCardBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradingCardBot));
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.tConsole = new System.Windows.Forms.TextBox();
            this.tmrMainLoop = new System.Windows.Forms.Timer(this.components);
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(184, 58);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.Size = new System.Drawing.Size(417, 503);
            this.Browser.TabIndex = 1;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // tConsole
            // 
            this.tConsole.Location = new System.Drawing.Point(12, 8);
            this.tConsole.Multiline = true;
            this.tConsole.Name = "tConsole";
            this.tConsole.ReadOnly = true;
            this.tConsole.Size = new System.Drawing.Size(601, 562);
            this.tConsole.TabIndex = 2;
            // 
            // tmrMainLoop
            // 
            this.tmrMainLoop.Interval = 10000;
            this.tmrMainLoop.Tick += new System.EventHandler(this.tmrMainLoop_Tick);
            // 
            // txtInput
            // 
            this.txtInput.AutoCompleteCustomSource.AddRange(new string[] {
            "Help",
            "Commands",
            "Clear",
            "Reload TradingCards",
            "Hide Form",
            "Hide Browser",
            "Hide Input",
            "Hide Console",
            "Show Console",
            "Show Form",
            "Show Browser",
            "Show SGF",
            "Show Main",
            "Show Licence",
            "Show URL",
            "Terminate Form",
            "Terminate SGF",
            "Exit Form",
            "Exit SGF",
            "Close Form",
            "Close SGF",
            "Min Form",
            "Min SGF",
            "Restart Form",
            "Restart SGF",
            "Loop Start",
            "Loop Stop",
            "StartGame APPID",
            "CloseAllGames",
            "Set BadgeURL URL",
            "Block APPID|BADGEID",
            "UnBlock APPID|BADGEID"});
            this.txtInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInput.Location = new System.Drawing.Point(12, 576);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(518, 20);
            this.txtInput.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(536, 574);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // TradingCardBot
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 602);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.tConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TradingCardBot";
            this.Text = "TradingCardBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TradingCardBot_FormClosing);
            this.Load += new System.EventHandler(this.TradingCardBot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.TextBox tConsole;
        private System.Windows.Forms.Timer tmrMainLoop;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
    }
}