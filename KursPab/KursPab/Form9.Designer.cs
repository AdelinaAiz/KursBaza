namespace KursPab
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.cursRabDataSet = new KursPab.CursRabDataSet();
            this.eDITIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDITIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.EDITIONTableAdapter();
            this.sUBBERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_BERSTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_BERSTableAdapter();
            this.sUBTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_TIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_TIONTableAdapter();
            this.eDITION1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDITION1TableAdapter = new KursPab.CursRabDataSetTableAdapters.EDITION1TableAdapter();
            this.nAMEEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITION1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEEDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eDITION1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 488);
            this.dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Газеты, которые в 2015 году подписали все подписчики из Казани";
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
            // eDITION1BindingSource
            // 
            this.eDITION1BindingSource.DataMember = "EDITION1";
            this.eDITION1BindingSource.DataSource = this.cursRabDataSet;
            // 
            // eDITION1TableAdapter
            // 
            this.eDITION1TableAdapter.ClearBeforeFill = true;
            // 
            // nAMEEDDataGridViewTextBoxColumn
            // 
            this.nAMEEDDataGridViewTextBoxColumn.DataPropertyName = "NAME_ED";
            this.nAMEEDDataGridViewTextBoxColumn.HeaderText = "Название издания";
            this.nAMEEDDataGridViewTextBoxColumn.Name = "nAMEEDDataGridViewTextBoxColumn";
            this.nAMEEDDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 565);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITION1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private CursRabDataSet cursRabDataSet;
        private System.Windows.Forms.BindingSource eDITIONBindingSource;
        private CursRabDataSetTableAdapters.EDITIONTableAdapter eDITIONTableAdapter;
        private System.Windows.Forms.BindingSource sUBBERSBindingSource;
        private CursRabDataSetTableAdapters.SUB_BERSTableAdapter sUB_BERSTableAdapter;
        private System.Windows.Forms.BindingSource sUBTIONBindingSource;
        private CursRabDataSetTableAdapters.SUB_TIONTableAdapter sUB_TIONTableAdapter;
        private System.Windows.Forms.BindingSource eDITION1BindingSource;
        private CursRabDataSetTableAdapters.EDITION1TableAdapter eDITION1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEEDDataGridViewTextBoxColumn;
    }
}