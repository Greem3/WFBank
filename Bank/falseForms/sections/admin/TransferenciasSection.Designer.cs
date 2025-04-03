namespace Bank
{
    partial class TransferenciasSection
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
            this.transferencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transferencesTableAdapter = new Bank.FiDBDataSetTableAdapters.transferencesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferencesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.actorIdDataGridViewTextBoxColumn,
            this.toUserDataGridViewTextBoxColumn,
            this.cantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transferencesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 524);
            this.dataGridView1.TabIndex = 2;
            // 
            // fiDBDataSet
            // 
            this.fiDBDataSet.DataSetName = "FiDBDataSet";
            this.fiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transferencesBindingSource
            // 
            this.transferencesBindingSource.DataMember = "transferences";
            this.transferencesBindingSource.DataSource = this.fiDBDataSet;
            // 
            // transferencesTableAdapter
            // 
            this.transferencesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // actorIdDataGridViewTextBoxColumn
            // 
            this.actorIdDataGridViewTextBoxColumn.DataPropertyName = "actorId";
            this.actorIdDataGridViewTextBoxColumn.HeaderText = "actorId";
            this.actorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actorIdDataGridViewTextBoxColumn.Name = "actorIdDataGridViewTextBoxColumn";
            this.actorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // toUserDataGridViewTextBoxColumn
            // 
            this.toUserDataGridViewTextBoxColumn.DataPropertyName = "toUser";
            this.toUserDataGridViewTextBoxColumn.HeaderText = "toUser";
            this.toUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toUserDataGridViewTextBoxColumn.Name = "toUserDataGridViewTextBoxColumn";
            this.toUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantityDataGridViewTextBoxColumn
            // 
            this.cantityDataGridViewTextBoxColumn.DataPropertyName = "cantity";
            this.cantityDataGridViewTextBoxColumn.HeaderText = "cantity";
            this.cantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantityDataGridViewTextBoxColumn.Name = "cantityDataGridViewTextBoxColumn";
            this.cantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // TransferenciasSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 752);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferenciasSection";
            this.Text = "TransferenciasSection";
            this.Load += new System.EventHandler(this.TransferenciasSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferencesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FiDBDataSet fiDBDataSet;
        private System.Windows.Forms.BindingSource transferencesBindingSource;
        private FiDBDataSetTableAdapters.transferencesTableAdapter transferencesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantityDataGridViewTextBoxColumn;
    }
}