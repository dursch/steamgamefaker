namespace License
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtPKey0 = new System.Windows.Forms.TextBox();
            this.txtPKey1 = new System.Windows.Forms.TextBox();
            this.txtPKey2 = new System.Windows.Forms.TextBox();
            this.txtPKey3 = new System.Windows.Forms.TextBox();
            this.txtPKey4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 12);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(244, 20);
            this.txtKey.TabIndex = 0;
            this.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtPKey0
            // 
            this.txtPKey0.Location = new System.Drawing.Point(11, 38);
            this.txtPKey0.Name = "txtPKey0";
            this.txtPKey0.Size = new System.Drawing.Size(44, 20);
            this.txtPKey0.TabIndex = 1;
            this.txtPKey0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey0.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtPKey1
            // 
            this.txtPKey1.Location = new System.Drawing.Point(61, 38);
            this.txtPKey1.Name = "txtPKey1";
            this.txtPKey1.Size = new System.Drawing.Size(44, 20);
            this.txtPKey1.TabIndex = 2;
            this.txtPKey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey1.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtPKey2
            // 
            this.txtPKey2.Location = new System.Drawing.Point(111, 38);
            this.txtPKey2.Name = "txtPKey2";
            this.txtPKey2.Size = new System.Drawing.Size(44, 20);
            this.txtPKey2.TabIndex = 3;
            this.txtPKey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey2.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtPKey3
            // 
            this.txtPKey3.Location = new System.Drawing.Point(161, 38);
            this.txtPKey3.Name = "txtPKey3";
            this.txtPKey3.Size = new System.Drawing.Size(44, 20);
            this.txtPKey3.TabIndex = 4;
            this.txtPKey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey3.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // txtPKey4
            // 
            this.txtPKey4.Location = new System.Drawing.Point(211, 38);
            this.txtPKey4.Name = "txtPKey4";
            this.txtPKey4.Size = new System.Drawing.Size(44, 20);
            this.txtPKey4.TabIndex = 5;
            this.txtPKey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPKey4.TextChanged += new System.EventHandler(this.txtPKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lizenzschlüssel | Licencekey";
            // 
            // btnActivate
            // 
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.Location = new System.Drawing.Point(12, 64);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(244, 43);
            this.btnActivate.TabIndex = 7;
            this.btnActivate.Text = "Aktivieren | Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(268, 64);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(236, 43);
            this.txtError.TabIndex = 8;
            this.txtError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 114);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPKey4);
            this.Controls.Add(this.txtPKey3);
            this.Controls.Add(this.txtPKey2);
            this.Controls.Add(this.txtPKey1);
            this.Controls.Add(this.txtPKey0);
            this.Controls.Add(this.txtKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtPKey0;
        private System.Windows.Forms.TextBox txtPKey1;
        private System.Windows.Forms.TextBox txtPKey2;
        private System.Windows.Forms.TextBox txtPKey3;
        private System.Windows.Forms.TextBox txtPKey4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.TextBox txtError;
    }
}