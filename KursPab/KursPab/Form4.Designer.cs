namespace KursPab
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnFill3 = new System.Windows.Forms.Button();
            this.btnFill2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursRabDataSet = new KursPab.CursRabDataSet();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFill1 = new System.Windows.Forms.Button();
            this.textYEAR = new System.Windows.Forms.TextBox();
            this.eDITIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDITIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.EDITIONTableAdapter();
            this.sUBBERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_BERSTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_BERSTableAdapter();
            this.sUBTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_TIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_TIONTableAdapter();
            this.dataTable1TableAdapter = new KursPab.CursRabDataSetTableAdapters.DataTable1TableAdapter();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIP_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_ED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_SUBTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = " Найти и вывести сведения о подписке на журналы в заданном году (параметр):";
            // 
            // btnFill3
            // 
            this.btnFill3.Location = new System.Drawing.Point(519, 90);
            this.btnFill3.Name = "btnFill3";
            this.btnFill3.Size = new System.Drawing.Size(332, 28);
            this.btnFill3.TabIndex = 15;
            this.btnFill3.Text = "Выполнить запрос через DataRelation";
            this.btnFill3.UseVisualStyleBackColor = true;
            this.btnFill3.Click += new System.EventHandler(this.btnFill3_Click);
            // 
            // btnFill2
            // 
            this.btnFill2.Location = new System.Drawing.Point(274, 90);
            this.btnFill2.Name = "btnFill2";
            this.btnFill2.Size = new System.Drawing.Size(239, 30);
            this.btnFill2.TabIndex = 14;
            this.btnFill2.Text = "Выполнить через поиск по ключу";
            this.btnFill2.UseVisualStyleBackColor = true;
            this.btnFill2.Click += new System.EventHandler(this.btnFill2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.ZIP_CODE,
            this.ADRESS,
            this.NAME_ED,
            this.DATE_SUBTION});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 356);
            this.dataGridView1.TabIndex = 13;
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
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.cursRabDataSet;
            // 
            // btnFill1
            // 
            this.btnFill1.Location = new System.Drawing.Point(29, 90);
            this.btnFill1.Name = "btnFill1";
            this.btnFill1.Size = new System.Drawing.Size(239, 30);
            this.btnFill1.TabIndex = 12;
            this.btnFill1.Text = "Выполнить двойным циклом";
            this.btnFill1.UseVisualStyleBackColor = true;
            this.btnFill1.Click += new System.EventHandler(this.btnFill1_Click);
            // 
            // textYEAR
            // 
            this.textYEAR.Location = new System.Drawing.Point(19, 56);
            this.textYEAR.Name = "textYEAR";
            this.textYEAR.Size = new System.Drawing.Size(848, 22);
            this.textYEAR.TabIndex = 11;
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
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.Width = 150;
            // 
            // ZIP_CODE
            // 
            this.ZIP_CODE.DataPropertyName = "ZIP_CODE";
            this.ZIP_CODE.HeaderText = "Индекс";
            this.ZIP_CODE.Name = "ZIP_CODE";
            // 
            // ADRESS
            // 
            this.ADRESS.DataPropertyName = "ADRESS";
            this.ADRESS.HeaderText = "Адресс";
            this.ADRESS.Name = "ADRESS";
            this.ADRESS.Width = 200;
            // 
            // NAME_ED
            // 
            this.NAME_ED.DataPropertyName = "NAME_ED";
            this.NAME_ED.HeaderText = "Название издания";
            this.NAME_ED.Name = "NAME_ED";
            this.NAME_ED.Width = 150;
            // 
            // DATE_SUBTION
            // 
            this.DATE_SUBTION.DataPropertyName = "DATE_SUBTION";
            this.DATE_SUBTION.HeaderText = "Дата подписки";
            this.DATE_SUBTION.Name = "DATE_SUBTION";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFill3);
            this.Controls.Add(this.btnFill2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFill1);
            this.Controls.Add(this.textYEAR);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFill3;
        private System.Windows.Forms.Button btnFill2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFill1;
        private System.Windows.Forms.TextBox textYEAR;
        private CursRabDataSet cursRabDataSet;
        private System.Windows.Forms.BindingSource eDITIONBindingSource;
        private CursRabDataSetTableAdapters.EDITIONTableAdapter eDITIONTableAdapter;
        private System.Windows.Forms.BindingSource sUBBERSBindingSource;
        private CursRabDataSetTableAdapters.SUB_BERSTableAdapter sUB_BERSTableAdapter;
        private System.Windows.Forms.BindingSource sUBTIONBindingSource;
        private CursRabDataSetTableAdapters.SUB_TIONTableAdapter sUB_TIONTableAdapter;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private CursRabDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZIP_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ED;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_SUBTION;
    }
}