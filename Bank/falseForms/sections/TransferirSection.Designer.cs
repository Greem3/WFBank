namespace Bank
{
    partial class TransferirSection
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
            this.startTrans = new System.Windows.Forms.Button();
            this.resetTexts = new System.Windows.Forms.Button();
            this.actionButtons = new System.Windows.Forms.Panel();
            this.cantityInfo = new Bank.BorderlessGroupBox();
            this.cantityValue = new System.Windows.Forms.NumericUpDown();
            this.infoMethod = new Bank.BorderlessGroupBox();
            this.userMethod = new System.Windows.Forms.ComboBox();
            this.receiverInfo = new Bank.BorderlessGroupBox();
            this.receiverValue = new System.Windows.Forms.TextBox();
            this.actionButtons.SuspendLayout();
            this.cantityInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantityValue)).BeginInit();
            this.infoMethod.SuspendLayout();
            this.receiverInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // startTrans
            // 
            this.startTrans.Location = new System.Drawing.Point(24, 135);
            this.startTrans.Name = "startTrans";
            this.startTrans.Size = new System.Drawing.Size(148, 57);
            this.startTrans.TabIndex = 6;
            this.startTrans.Text = "Realizar transferencia";
            this.startTrans.UseVisualStyleBackColor = true;
            this.startTrans.Click += new System.EventHandler(this.startTrans_Click);
            // 
            // resetTexts
            // 
            this.resetTexts.Location = new System.Drawing.Point(24, 30);
            this.resetTexts.Name = "resetTexts";
            this.resetTexts.Size = new System.Drawing.Size(148, 57);
            this.resetTexts.TabIndex = 7;
            this.resetTexts.Text = "Vaciar";
            this.resetTexts.UseVisualStyleBackColor = true;
            this.resetTexts.Click += new System.EventHandler(this.resetTexts_Click);
            // 
            // actionButtons
            // 
            this.actionButtons.Controls.Add(this.resetTexts);
            this.actionButtons.Controls.Add(this.startTrans);
            this.actionButtons.Location = new System.Drawing.Point(108, 237);
            this.actionButtons.Name = "actionButtons";
            this.actionButtons.Size = new System.Drawing.Size(190, 225);
            this.actionButtons.TabIndex = 8;
            // 
            // cantityInfo
            // 
            this.cantityInfo.Controls.Add(this.cantityValue);
            this.cantityInfo.Location = new System.Drawing.Point(107, 168);
            this.cantityInfo.Name = "cantityInfo";
            this.cantityInfo.Size = new System.Drawing.Size(196, 42);
            this.cantityInfo.TabIndex = 5;
            this.cantityInfo.TabStop = false;
            this.cantityInfo.Text = "Cantidad a transferir";
            this.cantityInfo.Visible = false;
            // 
            // cantityValue
            // 
            this.cantityValue.DecimalPlaces = 2;
            this.cantityValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cantityValue.Location = new System.Drawing.Point(2, 18);
            this.cantityValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantityValue.Name = "cantityValue";
            this.cantityValue.Size = new System.Drawing.Size(189, 22);
            this.cantityValue.TabIndex = 4;
            this.cantityValue.ValueChanged += new System.EventHandler(this.cantityValue_ValueChanged);
            // 
            // infoMethod
            // 
            this.infoMethod.Controls.Add(this.userMethod);
            this.infoMethod.Location = new System.Drawing.Point(109, 66);
            this.infoMethod.Name = "infoMethod";
            this.infoMethod.Size = new System.Drawing.Size(174, 49);
            this.infoMethod.TabIndex = 3;
            this.infoMethod.TabStop = false;
            this.infoMethod.Text = "Método de transferencia";
            // 
            // userMethod
            // 
            this.userMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userMethod.FormattingEnabled = true;
            this.userMethod.Items.AddRange(new object[] {
            "Correo electrónico",
            "Número de tarjeta",
            "Token"});
            this.userMethod.Location = new System.Drawing.Point(0, 21);
            this.userMethod.Name = "userMethod";
            this.userMethod.Size = new System.Drawing.Size(170, 24);
            this.userMethod.TabIndex = 0;
            this.userMethod.SelectedIndexChanged += new System.EventHandler(this.userMethod_SelectedIndexChanged);
            this.userMethod.TextUpdate += new System.EventHandler(this.userMethod_TextUpdate);
            // 
            // receiverInfo
            // 
            this.receiverInfo.Controls.Add(this.receiverValue);
            this.receiverInfo.Location = new System.Drawing.Point(328, 66);
            this.receiverInfo.Name = "receiverInfo";
            this.receiverInfo.Size = new System.Drawing.Size(267, 47);
            this.receiverInfo.TabIndex = 0;
            this.receiverInfo.TabStop = false;
            this.receiverInfo.Text = "Número de tarjeta del receptor";
            // 
            // receiverValue
            // 
            this.receiverValue.Location = new System.Drawing.Point(0, 21);
            this.receiverValue.Name = "receiverValue";
            this.receiverValue.Size = new System.Drawing.Size(264, 22);
            this.receiverValue.TabIndex = 1;
            this.receiverValue.TextChanged += new System.EventHandler(this.methodValue_TextChanged);
            // 
            // TransferirSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 546);
            this.Controls.Add(this.actionButtons);
            this.Controls.Add(this.cantityInfo);
            this.Controls.Add(this.infoMethod);
            this.Controls.Add(this.receiverInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferirSection";
            this.Text = "TransferirSection";
            this.Load += new System.EventHandler(this.TransferirSection_Load);
            this.actionButtons.ResumeLayout(false);
            this.cantityInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cantityValue)).EndInit();
            this.infoMethod.ResumeLayout(false);
            this.receiverInfo.ResumeLayout(false);
            this.receiverInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderlessGroupBox receiverInfo;
        private System.Windows.Forms.TextBox receiverValue;
        private System.Windows.Forms.ComboBox userMethod;
        private BorderlessGroupBox infoMethod;
        private System.Windows.Forms.NumericUpDown cantityValue;
        private BorderlessGroupBox cantityInfo;
        private System.Windows.Forms.Button startTrans;
        private System.Windows.Forms.Button resetTexts;
        private System.Windows.Forms.Panel actionButtons;
    }
}