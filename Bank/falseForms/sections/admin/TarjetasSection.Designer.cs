namespace Bank
{
    partial class TarjetasSection
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fiDBDataSet = new Bank.FiDBDataSet();
            this.cardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardsTableAdapter = new Bank.FiDBDataSetTableAdapters.cardsTableAdapter();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyCantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardNumberDataGridViewTextBoxColumn,
            this.keyAccountDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn,
            this.moneyCantityDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cardsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 524);
            this.dataGridView1.TabIndex = 1;
            // 
            // fiDBDataSet
            // 
            this.fiDBDataSet.DataSetName = "FiDBDataSet";
            this.fiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardsBindingSource
            // 
            this.cardsBindingSource.DataMember = "cards";
            this.cardsBindingSource.DataSource = this.fiDBDataSet;
            // 
            // cardsTableAdapter
            // 
            this.cardsTableAdapter.ClearBeforeFill = true;
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "cardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "cardNumber";
            this.cardNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            this.cardNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // keyAccountDataGridViewTextBoxColumn
            // 
            this.keyAccountDataGridViewTextBoxColumn.DataPropertyName = "keyAccount";
            this.keyAccountDataGridViewTextBoxColumn.HeaderText = "keyAccount";
            this.keyAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keyAccountDataGridViewTextBoxColumn.Name = "keyAccountDataGridViewTextBoxColumn";
            this.keyAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "typeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "typeId";
            this.typeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // moneyCantityDataGridViewTextBoxColumn
            // 
            this.moneyCantityDataGridViewTextBoxColumn.DataPropertyName = "moneyCantity";
            this.moneyCantityDataGridViewTextBoxColumn.HeaderText = "moneyCantity";
            this.moneyCantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moneyCantityDataGridViewTextBoxColumn.Name = "moneyCantityDataGridViewTextBoxColumn";
            this.moneyCantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // TarjetasSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 717);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TarjetasSection";
            this.Text = "TarjetasSection";
            this.Load += new System.EventHandler(this.TarjetasSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FiDBDataSet fiDBDataSet;
        private System.Windows.Forms.BindingSource cardsBindingSource;
        private FiDBDataSetTableAdapters.cardsTableAdapter cardsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyCantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    }
}