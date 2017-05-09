namespace SteamGameFaker
{
    partial class getHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(getHelp));
            this.btnSendSystemInformations = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.wBrowser = new System.Windows.Forms.WebBrowser();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.gbChangeLog = new System.Windows.Forms.GroupBox();
            this.gbContact.SuspendLayout();
            this.gbChangeLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendSystemInformations
            // 
            this.btnSendSystemInformations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendSystemInformations.Location = new System.Drawing.Point(6, 146);
            this.btnSendSystemInformations.Name = "btnSendSystemInformations";
            this.btnSendSystemInformations.Size = new System.Drawing.Size(275, 64);
            this.btnSendSystemInformations.TabIndex = 0;
            this.btnSendSystemInformations.Text = "Send my Data to the Developer";
            this.btnSendSystemInformations.UseVisualStyleBackColor = true;
            this.btnSendSystemInformations.Click += new System.EventHandler(this.btnSendSystemInformations_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(6, 35);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(275, 105);
            this.txtComment.TabIndex = 1;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(6, 16);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "Comment:";
            // 
            // wBrowser
            // 
            this.wBrowser.Location = new System.Drawing.Point(6, 19);
            this.wBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBrowser.Name = "wBrowser";
            this.wBrowser.ScriptErrorsSuppressed = true;
            this.wBrowser.Size = new System.Drawing.Size(266, 194);
            this.wBrowser.TabIndex = 3;
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.lblComment);
            this.gbContact.Controls.Add(this.btnSendSystemInformations);
            this.gbContact.Controls.Add(this.txtComment);
            this.gbContact.Location = new System.Drawing.Point(15, 12);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(293, 219);
            this.gbContact.TabIndex = 4;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Contact";
            // 
            // gbChangeLog
            // 
            this.gbChangeLog.Controls.Add(this.wBrowser);
            this.gbChangeLog.Location = new System.Drawing.Point(314, 12);
            this.gbChangeLog.Name = "gbChangeLog";
            this.gbChangeLog.Size = new System.Drawing.Size(278, 219);
            this.gbChangeLog.TabIndex = 5;
            this.gbChangeLog.TabStop = false;
            this.gbChangeLog.Text = "Changelog";
            // 
            // getHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 238);
            this.Controls.Add(this.gbChangeLog);
            this.Controls.Add(this.gbContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 120);
            this.Name = "getHelp";
            this.Text = "Help Window";
            this.Load += new System.EventHandler(this.getHelp_Load);
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbChangeLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendSystemInformations;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.WebBrowser wBrowser;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.GroupBox gbChangeLog;
    }
}