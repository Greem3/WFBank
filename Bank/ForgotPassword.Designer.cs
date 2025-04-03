namespace Bank
{
    partial class ForgotPassword
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
            this.options = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.borderlessGroupBox1 = new Bank.BorderlessGroupBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.options.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.borderlessGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // options
            // 
            this.options.Controls.Add(this.buttonsPanel);
            this.options.Controls.Add(this.borderlessGroupBox1);
            this.options.Location = new System.Drawing.Point(45, 37);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(394, 178);
            this.options.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.cancel);
            this.buttonsPanel.Controls.Add(this.accept);
            this.buttonsPanel.Location = new System.Drawing.Point(8, 116);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(286, 44);
            this.buttonsPanel.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(156, 9);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(127, 32);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(3, 9);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(127, 32);
            this.accept.TabIndex = 1;
            this.accept.Text = "Enviar código";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // borderlessGroupBox1
            // 
            this.borderlessGroupBox1.Controls.Add(this.mail);
            this.borderlessGroupBox1.Location = new System.Drawing.Point(17, 25);
            this.borderlessGroupBox1.Name = "borderlessGroupBox1";
            this.borderlessGroupBox1.Size = new System.Drawing.Size(227, 45);
            this.borderlessGroupBox1.TabIndex = 0;
            this.borderlessGroupBox1.TabStop = false;
            this.borderlessGroupBox1.Text = "Correo electrónico";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(0, 21);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(225, 22);
            this.mail.TabIndex = 0;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 242);
            this.Controls.Add(this.options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.options.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.borderlessGroupBox1.ResumeLayout(false);
            this.borderlessGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel options;
        private BorderlessGroupBox borderlessGroupBox1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
    }
}