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
            this.cardInfoCantity.SuspendLayout();
            this.cardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardInfoCantity
            // 
            this.cardInfoCantity.Controls.Add(this.cardMoney);
            this.cardInfoCantity.Controls.Add(this.cardMoneyTitle);
            this.cardInfoCantity.Location = new System.Drawing.Point(736, 41);
            this.cardInfoCantity.Name = "cardInfoCantity";
            this.cardInfoCantity.Size = new System.Drawing.Size(291, 164);
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
            this.cardInfo.Location = new System.Drawing.Point(69, 41);
            this.cardInfo.Name = "cardInfo";
            this.cardInfo.Size = new System.Drawing.Size(292, 164);
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
            this.noCardLabel.Location = new System.Drawing.Point(364, 263);
            this.noCardLabel.Name = "noCardLabel";
            this.noCardLabel.Size = new System.Drawing.Size(199, 16);
            this.noCardLabel.TabIndex = 2;
            this.noCardLabel.Text = "No tienes una tarjeta conectada.";
            // 
            // InicioSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 559);
            this.Controls.Add(this.noCardLabel);
            this.Controls.Add(this.cardInfo);
            this.Controls.Add(this.cardInfoCantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSection";
            this.Text = "1";
            this.Load += new System.EventHandler(this.InicioSection_Load);
            this.cardInfoCantity.ResumeLayout(false);
            this.cardInfoCantity.PerformLayout();
            this.cardInfo.ResumeLayout(false);
            this.cardInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cardInfoCantity;
        private System.Windows.Forms.Label cardMoneyTitle;
        private System.Windows.Forms.Label cardMoney;
        private System.Windows.Forms.Panel cardInfo;
        private System.Windows.Forms.Label cardNumber;
        private System.Windows.Forms.Label cardNumberTitle;
        private System.Windows.Forms.Label noCardLabel;
    }
}