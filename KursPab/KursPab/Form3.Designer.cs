namespace KursPab
{
    partial class Form3
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
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursRabDataSet = new KursPab.CursRabDataSet();
            this.dataTable1TableAdapter = new KursPab.CursRabDataSetTableAdapters.DataTable1TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFill1 = new System.Windows.Forms.Button();
            this.textYEAR = new System.Windows.Forms.TextBox();
            this.eDITIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDITIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.EDITIONTableAdapter();
            this.sUBBERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_BERSTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_BERSTableAdapter();
            this.sUBTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_TIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_TIONTableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATESUBTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.zIPCODEDataGridViewTextBoxColumn,
            this.aDRESSDataGridViewTextBoxColumn,
            this.nAMEEDDataGridViewTextBoxColumn,
            this.dATESUBTIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.cursRabDataSet;
            // 
            // cursRabDataSet
            // 
            this.cursRabDataSet.DataSetName = "CursRabDataSet";
            this.cursRabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = " Найти и вывести сведения о подписке на журналы в заданном году (параметр):";
            // 
            // btnFill1
            // 
            this.btnFill1.Location = new System.Drawing.Point(15, 82);
            this.btnFill1.Name = "btnFill1";
            this.btnFill1.Size = new System.Drawing.Size(116, 30);
            this.btnFill1.TabIndex = 9;
            this.btnFill1.Text = "Выполнить";
            this.btnFill1.UseVisualStyleBackColor = true;
            this.btnFill1.Click += new System.EventHandler(this.btnFill1_Click);
            // 
            // textYEAR
            // 
            this.textYEAR.Location = new System.Drawing.Point(15, 44);
            this.textYEAR.Name = "textYEAR";
            this.textYEAR.Size = new System.Drawing.Size(536, 22);
            this.textYEAR.TabIndex = 8;
            this.textYEAR.TextChanged += new System.EventHandler(this.textYEAR_TextChanged);
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
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // zIPCODEDataGridViewTextBoxColumn
            // 
            this.zIPCODEDataGridViewTextBoxColumn.DataPropertyName = "ZIP_CODE";
            this.zIPCODEDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.zIPCODEDataGridViewTextBoxColumn.Name = "zIPCODEDataGridViewTextBoxColumn";
            // 
            // aDRESSDataGridViewTextBoxColumn
            // 
            this.aDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn.HeaderText = "Адресс";
            this.aDRESSDataGridViewTextBoxColumn.Name = "aDRESSDataGridViewTextBoxColumn";
            // 
            // nAMEEDDataGridViewTextBoxColumn
            // 
            this.nAMEEDDataGridViewTextBoxColumn.DataPropertyName = "NAME_ED";
            this.nAMEEDDataGridViewTextBoxColumn.HeaderText = "Название издания";
            this.nAMEEDDataGridViewTextBoxColumn.Name = "nAMEEDDataGridViewTextBoxColumn";
            // 
            // dATESUBTIONDataGridViewTextBoxColumn
            // 
            this.dATESUBTIONDataGridViewTextBoxColumn.DataPropertyName = "DATE_SUBTION";
            this.dATESUBTIONDataGridViewTextBoxColumn.HeaderText = "Дата подписки";
            this.dATESUBTIONDataGridViewTextBoxColumn.Name = "dATESUBTIONDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFill1);
            this.Controls.Add(this.textYEAR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private CursRabDataSet cursRabDataSet;
        private CursRabDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFill1;
        private System.Windows.Forms.TextBox textYEAR;
        private System.Windows.Forms.BindingSource eDITIONBindingSource;
        private CursRabDataSetTableAdapters.EDITIONTableAdapter eDITIONTableAdapter;
        private System.Windows.Forms.BindingSource sUBBERSBindingSource;
        private CursRabDataSetTableAdapters.SUB_BERSTableAdapter sUB_BERSTableAdapter;
        private System.Windows.Forms.BindingSource sUBTIONBindingSource;
        private CursRabDataSetTableAdapters.SUB_TIONTableAdapter sUB_TIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATESUBTIONDataGridViewTextBoxColumn;
    }
}