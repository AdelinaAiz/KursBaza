namespace KursPab
{
    partial class Form11
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cursRabDataSet = new KursPab.CursRabDataSet();
            this.eDITIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDITIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.EDITIONTableAdapter();
            this.sUBBERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_BERSTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_BERSTableAdapter();
            this.sUBTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_TIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_TIONTableAdapter();
            this.sUBBERS2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_BERS2TableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_BERS2TableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERS2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.cOUNTMDataGridViewTextBoxColumn,
            this.cOUNTNDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sUBBERS2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 144);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(570, 387);
            this.dataGridView2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(565, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Введите год:";
            // 
            // cursRabDataSet
            // 
            this.cursRabDataSet.DataSetName = "CursRabDataSet";
            this.cursRabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eDITIONBindingSource
            // 
            this.eDITIONBindingSource.DataMember = "EDITION";
            this.eDITIONBindingSource.DataSource = this.cursRabDataSet;
            // 
            // eDITIONTableAdapter
            // 
            this.eDITIONTableAdapter.ClearBeforeFill = true;
            // 
            // sUBBERSBindingSource
            // 
            this.sUBBERSBindingSource.DataMember = "SUB_BERS";
            this.sUBBERSBindingSource.DataSource = this.cursRabDataSet;
            // 
            // sUB_BERSTableAdapter
            // 
            this.sUB_BERSTableAdapter.ClearBeforeFill = true;
            // 
            // sUBTIONBindingSource
            // 
            this.sUBTIONBindingSource.DataMember = "SUB_TION";
            this.sUBTIONBindingSource.DataSource = this.cursRabDataSet;
            // 
            // sUB_TIONTableAdapter
            // 
            this.sUB_TIONTableAdapter.ClearBeforeFill = true;
            // 
            // sUBBERS2BindingSource
            // 
            this.sUBBERS2BindingSource.DataMember = "SUB_BERS2";
            this.sUBBERS2BindingSource.DataSource = this.cursRabDataSet;
            // 
            // sUB_BERS2TableAdapter
            // 
            this.sUB_BERS2TableAdapter.ClearBeforeFill = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 200;
            // 
            // cOUNTMDataGridViewTextBoxColumn
            // 
            this.cOUNTMDataGridViewTextBoxColumn.DataPropertyName = "COUNT_M";
            this.cOUNTMDataGridViewTextBoxColumn.HeaderText = "Количество журналов";
            this.cOUNTMDataGridViewTextBoxColumn.Name = "cOUNTMDataGridViewTextBoxColumn";
            this.cOUNTMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOUNTNDataGridViewTextBoxColumn
            // 
            this.cOUNTNDataGridViewTextBoxColumn.DataPropertyName = "COUNT_N";
            this.cOUNTNDataGridViewTextBoxColumn.HeaderText = "Количество газет";
            this.cOUNTNDataGridViewTextBoxColumn.Name = "cOUNTNDataGridViewTextBoxColumn";
            this.cOUNTNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERS2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private CursRabDataSet cursRabDataSet;
        private System.Windows.Forms.BindingSource eDITIONBindingSource;
        private CursRabDataSetTableAdapters.EDITIONTableAdapter eDITIONTableAdapter;
        private System.Windows.Forms.BindingSource sUBBERSBindingSource;
        private CursRabDataSetTableAdapters.SUB_BERSTableAdapter sUB_BERSTableAdapter;
        private System.Windows.Forms.BindingSource sUBTIONBindingSource;
        private CursRabDataSetTableAdapters.SUB_TIONTableAdapter sUB_TIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sUBBERS2BindingSource;
        private CursRabDataSetTableAdapters.SUB_BERS2TableAdapter sUB_BERS2TableAdapter;
    }
}