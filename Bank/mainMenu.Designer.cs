namespace Bank
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sections = new System.Windows.Forms.Panel();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.section1 = new System.Windows.Forms.Panel();
            this.sectionIcon1 = new System.Windows.Forms.PictureBox();
            this.sectionName1 = new System.Windows.Forms.Label();
            this.examplebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.sections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            this.section1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionIcon1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.sections);
            this.splitContainer1.Panel1.Controls.Add(this.profileImg);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Size = new System.Drawing.Size(1473, 893);
            this.splitContainer1.SplitterDistance = 491;
            this.splitContainer1.TabIndex = 1;
            // 
            // sections
            // 
            this.sections.Controls.Add(this.button1);
            this.sections.Controls.Add(this.examplebutton);
            this.sections.Controls.Add(this.section1);
            this.sections.Location = new System.Drawing.Point(31, 232);
            this.sections.Name = "sections";
            this.sections.Size = new System.Drawing.Size(324, 541);
            this.sections.TabIndex = 1;
            // 
            // profileImg
            // 
            this.profileImg.Image = ((System.Drawing.Image)(resources.GetObject("profileImg.Image")));
            this.profileImg.Location = new System.Drawing.Point(7, 4);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(137, 137);
            this.profileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImg.TabIndex = 0;
            this.profileImg.TabStop = false;
            // 
            // section1
            // 
            this.section1.Controls.Add(this.sectionName1);
            this.section1.Controls.Add(this.sectionIcon1);
            this.section1.Location = new System.Drawing.Point(9, 9);
            this.section1.Name = "section1";
            this.section1.Size = new System.Drawing.Size(283, 85);
            this.section1.TabIndex = 0;
            // 
            // sectionIcon1
            // 
            this.sectionIcon1.Image = ((System.Drawing.Image)(resources.GetObject("sectionIcon1.Image")));
            this.sectionIcon1.Location = new System.Drawing.Point(9, 12);
            this.sectionIcon1.Name = "sectionIcon1";
            this.sectionIcon1.Size = new System.Drawing.Size(60, 58);
            this.sectionIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sectionIcon1.TabIndex = 0;
            this.sectionIcon1.TabStop = false;
            // 
            // sectionName1
            // 
            this.sectionName1.AutoSize = true;
            this.sectionName1.Location = new System.Drawing.Point(94, 33);
            this.sectionName1.Name = "sectionName1";
            this.sectionName1.Size = new System.Drawing.Size(108, 16);
            this.sectionName1.TabIndex = 1;
            this.sectionName1.Text = "Example Section";
            // 
            // examplebutton
            // 
            this.examplebutton.Location = new System.Drawing.Point(37, 151);
            this.examplebutton.Name = "examplebutton";
            this.examplebutton.Size = new System.Drawing.Size(75, 23);
            this.examplebutton.TabIndex = 1;
            this.examplebutton.Text = "button1";
            this.examplebutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 893);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            this.Text = "mainMenu";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.sections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            this.section1.ResumeLayout(false);
            this.section1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionIcon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox profileImg;
        private System.Windows.Forms.Panel sections;
        private System.Windows.Forms.Panel section1;
        private System.Windows.Forms.Label sectionName1;
        private System.Windows.Forms.PictureBox sectionIcon1;
        private System.Windows.Forms.Button examplebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}