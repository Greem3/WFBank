namespace Bank
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.borderlessGroupBox1 = new Bank.BorderlessGroupBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.borderlessGroupBox2 = new Bank.BorderlessGroupBox();
            this.userMail = new System.Windows.Forms.TextBox();
            this.borderlessGroupBox3 = new Bank.BorderlessGroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.borderlessGroupBox1.SuspendLayout();
            this.borderlessGroupBox2.SuspendLayout();
            this.borderlessGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.userImg);
            this.mainPanel.Controls.Add(this.borderlessGroupBox1);
            this.mainPanel.Controls.Add(this.borderlessGroupBox2);
            this.mainPanel.Controls.Add(this.borderlessGroupBox3);
            this.mainPanel.Controls.Add(this.buttonsPanel);
            this.mainPanel.Location = new System.Drawing.Point(51, 53);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(583, 566);
            this.mainPanel.TabIndex = 0;
            // 
            // userImg
            // 
            this.userImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("userImg.ErrorImage")));
            this.userImg.Image = ((System.Drawing.Image)(resources.GetObject("userImg.Image")));
            this.userImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("userImg.InitialImage")));
            this.userImg.Location = new System.Drawing.Point(0, 0);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(128, 128);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 0;
            this.userImg.TabStop = false;
            this.userImg.Click += new System.EventHandler(this.userImg_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(44, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 38);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(217, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 38);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Deshacer";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.saveButton);
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Location = new System.Drawing.Point(117, 428);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(394, 86);
            this.buttonsPanel.TabIndex = 5;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(-1, 0);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(96, 47);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Volver";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // borderlessGroupBox1
            // 
            this.borderlessGroupBox1.Controls.Add(this.userName);
            this.borderlessGroupBox1.Location = new System.Drawing.Point(132, 201);
            this.borderlessGroupBox1.Name = "borderlessGroupBox1";
            this.borderlessGroupBox1.Size = new System.Drawing.Size(243, 46);
            this.borderlessGroupBox1.TabIndex = 1;
            this.borderlessGroupBox1.TabStop = false;
            this.borderlessGroupBox1.Text = "Nombre de usuario";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(-2, 21);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(242, 22);
            this.userName.TabIndex = 0;
            // 
            // borderlessGroupBox2
            // 
            this.borderlessGroupBox2.Controls.Add(this.userMail);
            this.borderlessGroupBox2.Location = new System.Drawing.Point(124, 274);
            this.borderlessGroupBox2.Name = "borderlessGroupBox2";
            this.borderlessGroupBox2.Size = new System.Drawing.Size(243, 46);
            this.borderlessGroupBox2.TabIndex = 2;
            this.borderlessGroupBox2.TabStop = false;
            this.borderlessGroupBox2.Text = "Correo electronico";
            // 
            // userMail
            // 
            this.userMail.Location = new System.Drawing.Point(-2, 21);
            this.userMail.Name = "userMail";
            this.userMail.Size = new System.Drawing.Size(242, 22);
            this.userMail.TabIndex = 0;
            // 
            // borderlessGroupBox3
            // 
            this.borderlessGroupBox3.Controls.Add(this.password);
            this.borderlessGroupBox3.Location = new System.Drawing.Point(127, 340);
            this.borderlessGroupBox3.Name = "borderlessGroupBox3";
            this.borderlessGroupBox3.Size = new System.Drawing.Size(243, 46);
            this.borderlessGroupBox3.TabIndex = 2;
            this.borderlessGroupBox3.TabStop = false;
            this.borderlessGroupBox3.Text = "Contraseña";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(-2, 21);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(242, 22);
            this.password.TabIndex = 0;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 653);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(715, 700);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.borderlessGroupBox1.ResumeLayout(false);
            this.borderlessGroupBox1.PerformLayout();
            this.borderlessGroupBox2.ResumeLayout(false);
            this.borderlessGroupBox2.PerformLayout();
            this.borderlessGroupBox3.ResumeLayout(false);
            this.borderlessGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox userImg;
        private BorderlessGroupBox borderlessGroupBox1;
        private System.Windows.Forms.TextBox userName;
        private BorderlessGroupBox borderlessGroupBox3;
        private System.Windows.Forms.TextBox password;
        private BorderlessGroupBox borderlessGroupBox2;
        private System.Windows.Forms.TextBox userMail;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button returnButton;
    }
}