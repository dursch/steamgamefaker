namespace Licence_Gen
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
            this.txtPKey0 = new System.Windows.Forms.TextBox();
            this.txtPKey1 = new System.Windows.Forms.TextBox();
            this.txtPKey2 = new System.Windows.Forms.TextBox();
            this.txtPKey3 = new System.Windows.Forms.TextBox();
            this.txtPKey4 = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnMySQLSaveKey = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPKey0
            // 
            this.txtPKey0.Location = new System.Drawing.Point(12, 12);
            this.txtPKey0.Name = "txtPKey0";
            this.txtPKey0.Size = new System.Drawing.Size(44, 20);
            this.txtPKey0.TabIndex = 0;
            this.txtPKey0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey0.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtPKey1
            // 
            this.txtPKey1.Location = new System.Drawing.Point(62, 12);
            this.txtPKey1.Name = "txtPKey1";
            this.txtPKey1.Size = new System.Drawing.Size(44, 20);
            this.txtPKey1.TabIndex = 1;
            this.txtPKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey1.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtPKey2
            // 
            this.txtPKey2.Location = new System.Drawing.Point(112, 12);
            this.txtPKey2.Name = "txtPKey2";
            this.txtPKey2.Size = new System.Drawing.Size(44, 20);
            this.txtPKey2.TabIndex = 2;
            this.txtPKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey2.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtPKey3
            // 
            this.txtPKey3.Location = new System.Drawing.Point(162, 12);
            this.txtPKey3.Name = "txtPKey3";
            this.txtPKey3.Size = new System.Drawing.Size(44, 20);
            this.txtPKey3.TabIndex = 3;
            this.txtPKey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey3.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtPKey4
            // 
            this.txtPKey4.Location = new System.Drawing.Point(212, 12);
            this.txtPKey4.Name = "txtPKey4";
            this.txtPKey4.Size = new System.Drawing.Size(44, 20);
            this.txtPKey4.TabIndex = 4;
            this.txtPKey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey4.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(35, 40);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(195, 20);
            this.txtKey.TabIndex = 5;
            this.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(262, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 48);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "New Key";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnMySQLSaveKey
            // 
            this.btnMySQLSaveKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMySQLSaveKey.Location = new System.Drawing.Point(343, 12);
            this.btnMySQLSaveKey.Name = "btnMySQLSaveKey";
            this.btnMySQLSaveKey.Size = new System.Drawing.Size(75, 48);
            this.btnMySQLSaveKey.TabIndex = 7;
            this.btnMySQLSaveKey.Text = "Save in Database";
            this.btnMySQLSaveKey.UseVisualStyleBackColor = true;
            this.btnMySQLSaveKey.Click += new System.EventHandler(this.btnMySQLSaveKey_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(343, 69);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(75, 20);
            this.txtTime.TabIndex = 8;
            this.txtTime.Text = "0";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Laufzeit (0 = <>)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnMySQLSaveKey);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtPKey4);
            this.Controls.Add(this.txtPKey3);
            this.Controls.Add(this.txtPKey2);
            this.Controls.Add(this.txtPKey1);
            this.Controls.Add(this.txtPKey0);
            this.Name = "Main";
            this.Text = "License Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPKey0;
        private System.Windows.Forms.TextBox txtPKey1;
        private System.Windows.Forms.TextBox txtPKey2;
        private System.Windows.Forms.TextBox txtPKey3;
        private System.Windows.Forms.TextBox txtPKey4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnMySQLSaveKey;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
    }
}

