namespace Bank
{
    partial class InicioSection
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
            this.cardInfoCantity = new System.Windows.Forms.Panel();
            this.cardMoney = new System.Windows.Forms.Label();
            this.cardMoneyTitle = new System.Windows.Forms.Label();
            this.cardInfo = new System.Windows.Forms.Panel();
            this.cardNumber = new System.Windows.Forms.Label();
            this.cardNumberTitle = new System.Windows.Forms.Label();
            this.noCardLabel = new System.Windows.Forms.Label();
            this.transCantityInfo = new System.Windows.Forms.Panel();
            this.transCantity = new System.Windows.Forms.Label();
            this.transCantityTitle = new System.Windows.Forms.Label();
            this.transDateInfo = new System.Windows.Forms.Panel();
            this.transDate = new System.Windows.Forms.Label();
            this.transDateTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardInfoCantity.SuspendLayout();
            this.cardInfo.SuspendLayout();
            this.transCantityInfo.SuspendLayout();
            this.transDateInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardInfoCantity
            // 
            this.cardInfoCantity.Controls.Add(this.cardMoney);
            this.cardInfoCantity.Controls.Add(this.cardMoneyTitle);
            this.cardInfoCantity.Location = new System.Drawing.Point(702, 34);
            this.cardInfoCantity.Name = "cardInfoCantity";
            this.cardInfoCantity.Size = new System.Drawing.Size(357, 164);
            this.cardInfoCantity.TabIndex = 0;
            this.cardInfoCantity.Visible = false;
            // 
            // cardMoney
            // 
            this.cardMoney.AutoSize = true;
            this.cardMoney.Location = new System.Drawing.Point(55, 25);
            this.cardMoney.Name = "cardMoney";
            this.cardMoney.Size = new System.Drawing.Size(66, 16);
            this.cardMoney.TabIndex = 1;
            this.cardMoney.Text = "Sin tarjeta";
            // 
            // cardMoneyTitle
            // 
            this.cardMoneyTitle.AutoSize = true;
            this.cardMoneyTitle.Location = new System.Drawing.Point(26, 121);
            this.cardMoneyTitle.Name = "cardMoneyTitle";
            this.cardMoneyTitle.Size = new System.Drawing.Size(10, 16);
            this.cardMoneyTitle.TabIndex = 0;
            this.cardMoneyTitle.Text = " ";
            // 
            // cardInfo
            // 
            this.cardInfo.Controls.Add(this.cardNumber);
            this.cardInfo.Controls.Add(this.cardNumberTitle);
            this.cardInfo.Location = new System.Drawing.Point(56, 34);
            this.cardInfo.Name = "cardInfo";
            this.cardInfo.Size = new System.Drawing.Size(357, 164);
            this.cardInfo.TabIndex = 1;
            this.cardInfo.Visible = false;
            // 
            // cardNumber
            // 
            this.cardNumber.AutoSize = true;
            this.cardNumber.Location = new System.Drawing.Point(59, 25);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(66, 16);
            this.cardNumber.TabIndex = 0;
            this.cardNumber.Text = "Sin tarjeta";
            // 
            // cardNumberTitle
            // 
            this.cardNumberTitle.AutoSize = true;
            this.cardNumberTitle.Location = new System.Drawing.Point(59, 119);
            this.cardNumberTitle.Name = "cardNumberTitle";
            this.cardNumberTitle.Size = new System.Drawing.Size(10, 16);
            this.cardNumberTitle.TabIndex = 1;
            this.cardNumberTitle.Text = " ";
            // 
            // noCardLabel
            // 
            this.noCardLabel.AutoSize = true;
            this.noCardLabel.Location = new System.Drawing.Point(351, 256);
            this.noCardLabel.Name = "noCardLabel";
            this.noCardLabel.Size = new System.Drawing.Size(199, 16);
            this.noCardLabel.TabIndex = 2;
            this.noCardLabel.Text = "No tienes una tarjeta conectada.";
            // 
            // transCantityInfo
            // 
            this.transCantityInfo.Controls.Add(this.transCantity);
            this.transCantityInfo.Controls.Add(this.transCantityTitle);
            this.transCantityInfo.Location = new System.Drawing.Point(56, 320);
            this.transCantityInfo.Name = "transCantityInfo";
            this.transCantityInfo.Size = new System.Drawing.Size(357, 164);
            this.transCantityInfo.TabIndex = 2;
            this.transCantityInfo.Visible = false;
            // 
            // transCantity
            // 
            this.transCantity.AutoSize = true;
            this.transCantity.Location = new System.Drawing.Point(59, 25);
            this.transCantity.Name = "transCantity";
            this.transCantity.Size = new System.Drawing.Size(14, 16);
            this.transCantity.TabIndex = 0;
            this.transCantity.Text = "0";
            // 
            // transCantityTitle
            // 
            this.transCantityTitle.AutoSize = true;
            this.transCantityTitle.Location = new System.Drawing.Point(59, 119);
            this.transCantityTitle.Name = "transCantityTitle";
            this.transCantityTitle.Size = new System.Drawing.Size(10, 16);
            this.transCantityTitle.TabIndex = 1;
            this.transCantityTitle.Text = " ";
            // 
            // transDateInfo
            // 
            this.transDateInfo.Controls.Add(this.transDate);
            this.transDateInfo.Controls.Add(this.transDateTitle);
            this.transDateInfo.Location = new System.Drawing.Point(702, 320);
            this.transDateInfo.Name = "transDateInfo";
            this.transDateInfo.Size = new System.Drawing.Size(357, 164);
            this.transDateInfo.TabIndex = 3;
            this.transDateInfo.Visible = false;
            // 
            // transDate
            // 
            this.transDate.AutoSize = true;
            this.transDate.Location = new System.Drawing.Point(59, 25);
            this.transDate.Name = "transDate";
            this.transDate.Size = new System.Drawing.Size(30, 16);
            this.transDate.TabIndex = 0;
            this.transDate.Text = "N/A";
            // 
            // transDateTitle
            // 
            this.transDateTitle.AutoSize = true;
            this.transDateTitle.Location = new System.Drawing.Point(59, 119);
            this.transDateTitle.Name = "transDateTitle";
            this.transDateTitle.Size = new System.Drawing.Size(10, 16);
            this.transDateTitle.TabIndex = 1;
            this.transDateTitle.Text = " ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.transDateInfo);
            this.panel1.Controls.Add(this.transCantityInfo);
            this.panel1.Controls.Add(this.noCardLabel);
            this.panel1.Controls.Add(this.cardInfo);
            this.panel1.Controls.Add(this.cardInfoCantity);
            this.panel1.Location = new System.Drawing.Point(13, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 529);
            this.panel1.TabIndex = 4;
            // 
            // InicioSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 559);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSection";
            this.Text = "1";
            this.Load += new System.EventHandler(this.InicioSection_Load);
            this.cardInfoCantity.ResumeLayout(false);
            this.cardInfoCantity.PerformLayout();
            this.cardInfo.ResumeLayout(false);
            this.cardInfo.PerformLayout();
            this.transCantityInfo.ResumeLayout(false);
            this.transCantityInfo.PerformLayout();
            this.transDateInfo.ResumeLayout(false);
            this.transDateInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cardInfoCantity;
        private System.Windows.Forms.Label cardMoneyTitle;
        private System.Windows.Forms.Label cardMoney;
        private System.Windows.Forms.Panel cardInfo;
        private System.Windows.Forms.Label cardNumber;
        private System.Windows.Forms.Label cardNumberTitle;
        private System.Windows.Forms.Label noCardLabel;
        private System.Windows.Forms.Panel transCantityInfo;
        private System.Windows.Forms.Label transCantity;
        private System.Windows.Forms.Label transCantityTitle;
        private System.Windows.Forms.Panel transDateInfo;
        private System.Windows.Forms.Label transDate;
        private System.Windows.Forms.Label transDateTitle;
        private System.Windows.Forms.Panel panel1;
    }
}