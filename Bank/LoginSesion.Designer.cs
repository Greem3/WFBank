using System.Drawing;

namespace Bank
{
    partial class LoginSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSesion));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.logIn = new System.Windows.Forms.Button();
            this.signIn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.borderlessGroupBox1 = new Bank.BorderlessGroupBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.borderlessGroupBox2 = new Bank.BorderlessGroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.borderlessGroupBox1.SuspendLayout();
            this.borderlessGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttonsPanel);
            this.mainPanel.Controls.Add(this.title);
            this.mainPanel.Controls.Add(this.borderlessGroupBox1);
            this.mainPanel.Controls.Add(this.borderlessGroupBox2);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Location = new System.Drawing.Point(127, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(543, 663);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.logIn);
            this.buttonsPanel.Controls.Add(this.signIn);
            this.buttonsPanel.Location = new System.Drawing.Point(38, 536);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(464, 89);
            this.buttonsPanel.TabIndex = 8;
            // 
            // logIn
            // 
            this.logIn.Location = new System.Drawing.Point(17, 23);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(133, 46);
            this.logIn.TabIndex = 6;
            this.logIn.Text = "Iniciar Sesión";
            this.logIn.UseVisualStyleBackColor = true;
            // 
            // signIn
            // 
            this.signIn.Location = new System.Drawing.Point(315, 23);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(133, 46);
            this.signIn.TabIndex = 7;
            this.signIn.Text = "Registrarse";
            this.signIn.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(103, 211);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(310, 54);
            this.title.TabIndex = 5;
            this.title.Text = "Iniciar sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // borderlessGroupBox1
            // 
            this.borderlessGroupBox1.Controls.Add(this.mail);
            this.borderlessGroupBox1.Location = new System.Drawing.Point(97, 307);
            this.borderlessGroupBox1.Name = "borderlessGroupBox1";
            this.borderlessGroupBox1.Size = new System.Drawing.Size(263, 50);
            this.borderlessGroupBox1.TabIndex = 4;
            this.borderlessGroupBox1.TabStop = false;
            this.borderlessGroupBox1.Text = "Correo Electronico";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(-1, 21);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(263, 22);
            this.mail.TabIndex = 0;
            // 
            // borderlessGroupBox2
            // 
            this.borderlessGroupBox2.Controls.Add(this.password);
            this.borderlessGroupBox2.Location = new System.Drawing.Point(98, 385);
            this.borderlessGroupBox2.Name = "borderlessGroupBox2";
            this.borderlessGroupBox2.Size = new System.Drawing.Size(262, 48);
            this.borderlessGroupBox2.TabIndex = 4;
            this.borderlessGroupBox2.TabStop = false;
            this.borderlessGroupBox2.Text = "Contraseña";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(-1, 21);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(263, 22);
            this.password.TabIndex = 0;
            // 
            // LoginSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 808);
            this.Controls.Add(this.mainPanel);
            this.Name = "LoginSesion";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.borderlessGroupBox1.ResumeLayout(false);
            this.borderlessGroupBox1.PerformLayout();
            this.borderlessGroupBox2.ResumeLayout(false);
            this.borderlessGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private BorderlessGroupBox borderlessGroupBox1;
        private System.Windows.Forms.TextBox mail;
        private BorderlessGroupBox borderlessGroupBox2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Panel buttonsPanel;
    }
}

