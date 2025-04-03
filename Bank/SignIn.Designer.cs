namespace Bank
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.borderlessGroupBox1 = new Bank.BorderlessGroupBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.borderlessGroupBox2 = new Bank.BorderlessGroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.borderlessGroupBox3 = new Bank.BorderlessGroupBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.borderlessGroupBox4 = new Bank.BorderlessGroupBox();
            this.keyCard = new System.Windows.Forms.TextBox();
            this.borderlessGroupBox5 = new Bank.BorderlessGroupBox();
            this.keyCode = new System.Windows.Forms.TextBox();
            this.keepSesion = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.signInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.borderlessGroupBox1.SuspendLayout();
            this.borderlessGroupBox2.SuspendLayout();
            this.borderlessGroupBox3.SuspendLayout();
            this.borderlessGroupBox4.SuspendLayout();
            this.borderlessGroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.infoPanel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 855);
            this.splitContainer1.SplitterDistance = 584;
            this.splitContainer1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.Controls.Add(this.borderlessGroupBox1);
            this.infoPanel.Controls.Add(this.borderlessGroupBox2);
            this.infoPanel.Controls.Add(this.borderlessGroupBox3);
            this.infoPanel.Controls.Add(this.borderlessGroupBox4);
            this.infoPanel.Controls.Add(this.borderlessGroupBox5);
            this.infoPanel.Controls.Add(this.keepSesion);
            this.infoPanel.Controls.Add(this.linkLabel1);
            this.infoPanel.Controls.Add(this.signInButton);
            this.infoPanel.Location = new System.Drawing.Point(58, 90);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(334, 575);
            this.infoPanel.TabIndex = 13;
            // 
            // borderlessGroupBox1
            // 
            this.borderlessGroupBox1.Controls.Add(this.mail);
            this.borderlessGroupBox1.Location = new System.Drawing.Point(30, 37);
            this.borderlessGroupBox1.Name = "borderlessGroupBox1";
            this.borderlessGroupBox1.Size = new System.Drawing.Size(265, 50);
            this.borderlessGroupBox1.TabIndex = 5;
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
            this.borderlessGroupBox2.Location = new System.Drawing.Point(29, 107);
            this.borderlessGroupBox2.Name = "borderlessGroupBox2";
            this.borderlessGroupBox2.Size = new System.Drawing.Size(262, 50);
            this.borderlessGroupBox2.TabIndex = 6;
            this.borderlessGroupBox2.TabStop = false;
            this.borderlessGroupBox2.Text = "Contraseña";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(-1, 21);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(263, 22);
            this.password.TabIndex = 0;
            // 
            // borderlessGroupBox3
            // 
            this.borderlessGroupBox3.Controls.Add(this.userName);
            this.borderlessGroupBox3.Location = new System.Drawing.Point(29, 190);
            this.borderlessGroupBox3.Name = "borderlessGroupBox3";
            this.borderlessGroupBox3.Size = new System.Drawing.Size(263, 50);
            this.borderlessGroupBox3.TabIndex = 7;
            this.borderlessGroupBox3.TabStop = false;
            this.borderlessGroupBox3.Text = "Nombre de usuario";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(-1, 21);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(263, 22);
            this.userName.TabIndex = 0;
            // 
            // borderlessGroupBox4
            // 
            this.borderlessGroupBox4.Controls.Add(this.keyCard);
            this.borderlessGroupBox4.Location = new System.Drawing.Point(30, 276);
            this.borderlessGroupBox4.Name = "borderlessGroupBox4";
            this.borderlessGroupBox4.Size = new System.Drawing.Size(265, 50);
            this.borderlessGroupBox4.TabIndex = 7;
            this.borderlessGroupBox4.TabStop = false;
            this.borderlessGroupBox4.Text = "Número de tarjeta";
            // 
            // keyCard
            // 
            this.keyCard.Location = new System.Drawing.Point(-1, 21);
            this.keyCard.Name = "keyCard";
            this.keyCard.Size = new System.Drawing.Size(263, 22);
            this.keyCard.TabIndex = 0;
            // 
            // borderlessGroupBox5
            // 
            this.borderlessGroupBox5.Controls.Add(this.keyCode);
            this.borderlessGroupBox5.Location = new System.Drawing.Point(33, 344);
            this.borderlessGroupBox5.Name = "borderlessGroupBox5";
            this.borderlessGroupBox5.Size = new System.Drawing.Size(262, 50);
            this.borderlessGroupBox5.TabIndex = 8;
            this.borderlessGroupBox5.TabStop = false;
            this.borderlessGroupBox5.Text = "Contraseña de tarjeta";
            // 
            // keyCode
            // 
            this.keyCode.Location = new System.Drawing.Point(-1, 21);
            this.keyCode.Name = "keyCode";
            this.keyCode.PasswordChar = '*';
            this.keyCode.Size = new System.Drawing.Size(263, 22);
            this.keyCode.TabIndex = 0;
            // 
            // keepSesion
            // 
            this.keepSesion.AutoSize = true;
            this.keepSesion.Location = new System.Drawing.Point(80, 410);
            this.keepSesion.Name = "keepSesion";
            this.keepSesion.Size = new System.Drawing.Size(178, 20);
            this.keepSesion.TabIndex = 9;
            this.keepSesion.Text = "Mantener sesión iniciada";
            this.keepSesion.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(77, 476);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 16);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ya tengo una cuenta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(92, 517);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(149, 55);
            this.signInButton.TabIndex = 11;
            this.signInButton.Text = "Registrarse";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registrandote en SB";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 855);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1073, 902);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.borderlessGroupBox1.ResumeLayout(false);
            this.borderlessGroupBox1.PerformLayout();
            this.borderlessGroupBox2.ResumeLayout(false);
            this.borderlessGroupBox2.PerformLayout();
            this.borderlessGroupBox3.ResumeLayout(false);
            this.borderlessGroupBox3.PerformLayout();
            this.borderlessGroupBox4.ResumeLayout(false);
            this.borderlessGroupBox4.PerformLayout();
            this.borderlessGroupBox5.ResumeLayout(false);
            this.borderlessGroupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BorderlessGroupBox borderlessGroupBox5;
        private System.Windows.Forms.TextBox keyCode;
        private BorderlessGroupBox borderlessGroupBox4;
        private System.Windows.Forms.TextBox keyCard;
        private BorderlessGroupBox borderlessGroupBox3;
        private System.Windows.Forms.TextBox userName;
        private BorderlessGroupBox borderlessGroupBox2;
        private System.Windows.Forms.TextBox password;
        private BorderlessGroupBox borderlessGroupBox1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.CheckBox keepSesion;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label label1;
    }
}