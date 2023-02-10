namespace KursPab
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sUBBERS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursRabDataSet = new KursPab.CursRabDataSet();
            this.sUBTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textYEAR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eDITIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDITIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.EDITIONTableAdapter();
            this.sUBBERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_BERSTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_BERSTableAdapter();
            this.sUB_TIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_TIONTableAdapter();
            this.sUB_BERS1TableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_BERS1TableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sUBBERS1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 283);
            this.dataGridView1.TabIndex = 10;
            // 
            // sUBBERS1BindingSource
            // 
            this.sUBBERS1BindingSource.DataMember = "SUB_BERS1";
            this.sUBBERS1BindingSource.DataSource = this.cursRabDataSet;
            // 
            // cursRabDataSet
            // 
            this.cursRabDataSet.DataSetName = "CursRabDataSet";
            this.cursRabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUBTIONBindingSource
            // 
            this.sUBTIONBindingSource.DataMember = "SUB_TION";
            this.sUBTIONBindingSource.DataSource = this.cursRabDataSet;
            // 
            // textYEAR
            // 
            this.textYEAR.Location = new System.Drawing.Point(13, 88);
            this.textYEAR.Name = "textYEAR";
            this.textYEAR.Size = new System.Drawing.Size(565, 22);
            this.textYEAR.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите год:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "в заданном году (параметр) они подписались не на все газеты из каталога изданий.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Найти и вывести список ФИО подписчиков согласно условию: ";
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
            // sUB_TIONTableAdapter
            // 
            this.sUB_TIONTableAdapter.ClearBeforeFill = true;
            // 
            // sUB_BERS1TableAdapter
            // 
            this.sUB_BERS1TableAdapter.ClearBeforeFill = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 200;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textYEAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textYEAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CursRabDataSet cursRabDataSet;
        private System.Windows.Forms.BindingSource eDITIONBindingSource;
        private CursRabDataSetTableAdapters.EDITIONTableAdapter eDITIONTableAdapter;
        private System.Windows.Forms.BindingSource sUBBERSBindingSource;
        private CursRabDataSetTableAdapters.SUB_BERSTableAdapter sUB_BERSTableAdapter;
        private System.Windows.Forms.BindingSource sUBTIONBindingSource;
        private CursRabDataSetTableAdapters.SUB_TIONTableAdapter sUB_TIONTableAdapter;
        private System.Windows.Forms.BindingSource sUBBERS1BindingSource;
        private CursRabDataSetTableAdapters.SUB_BERS1TableAdapter sUB_BERS1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
    }
}