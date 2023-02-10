namespace KursPab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.sUBBERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursRabDataSet = new KursPab.CursRabDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sUBBERSGridView = new System.Windows.Forms.DataGridView();
            this.sUBERSCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBTIONGridView = new System.Windows.Forms.DataGridView();
            this.sUBTIONCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBERSCODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUB_BERS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pUBLICCODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITION = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eDITIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATESUBTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMMONTHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIGNPERKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUB_BERSTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_BERSTableAdapter();
            this.eDITIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.EDITIONTableAdapter();
            this.sUB_TIONTableAdapter = new KursPab.CursRabDataSetTableAdapters.SUB_TIONTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefres = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.eDITIONGridView = new System.Windows.Forms.DataGridView();
            this.pUBLICCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMONPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREFPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIRCULATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMBERSUBERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDITORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.основнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тройнойЦиклToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.подзапросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.подзапросыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.sUBBERSBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 28);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1441, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // sUBBERSBindingSource
            // 
            this.sUBBERSBindingSource.DataMember = "SUB_BERS";
            this.sUBBERSBindingSource.DataSource = this.cursRabDataSet;
            // 
            // cursRabDataSet
            // 
            this.cursRabDataSet.DataSetName = "CursRabDataSet";
            this.cursRabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sUBBERSGridView
            // 
            this.sUBBERSGridView.AutoGenerateColumns = false;
            this.sUBBERSGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUBBERSGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUBERSCODEDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.aDRESSDataGridViewTextBoxColumn,
            this.tELEPHONEDataGridViewTextBoxColumn,
            this.zIPCODEDataGridViewTextBoxColumn});
            this.sUBBERSGridView.DataSource = this.sUBBERSBindingSource;
            this.sUBBERSGridView.Location = new System.Drawing.Point(23, 76);
            this.sUBBERSGridView.Name = "sUBBERSGridView";
            this.sUBBERSGridView.RowTemplate.Height = 24;
            this.sUBBERSGridView.Size = new System.Drawing.Size(686, 288);
            this.sUBBERSGridView.TabIndex = 1;
            this.sUBBERSGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUBBERSGridView_CellContentClick);
            // 
            // sUBERSCODEDataGridViewTextBoxColumn
            // 
            this.sUBERSCODEDataGridViewTextBoxColumn.DataPropertyName = "SUBERS_CODE";
            this.sUBERSCODEDataGridViewTextBoxColumn.HeaderText = "Код Подписчика";
            this.sUBERSCODEDataGridViewTextBoxColumn.Name = "sUBERSCODEDataGridViewTextBoxColumn";
            this.sUBERSCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 200;
            // 
            // aDRESSDataGridViewTextBoxColumn
            // 
            this.aDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.aDRESSDataGridViewTextBoxColumn.Name = "aDRESSDataGridViewTextBoxColumn";
            this.aDRESSDataGridViewTextBoxColumn.Width = 200;
            // 
            // tELEPHONEDataGridViewTextBoxColumn
            // 
            this.tELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE";
            this.tELEPHONEDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.tELEPHONEDataGridViewTextBoxColumn.Name = "tELEPHONEDataGridViewTextBoxColumn";
            // 
            // zIPCODEDataGridViewTextBoxColumn
            // 
            this.zIPCODEDataGridViewTextBoxColumn.DataPropertyName = "ZIP_CODE";
            this.zIPCODEDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.zIPCODEDataGridViewTextBoxColumn.Name = "zIPCODEDataGridViewTextBoxColumn";
            // 
            // sUBTIONGridView
            // 
            this.sUBTIONGridView.AutoGenerateColumns = false;
            this.sUBTIONGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUBTIONGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUBTIONCODEDataGridViewTextBoxColumn,
            this.sUBERSCODEDataGridViewTextBoxColumn1,
            this.SUB_BERS,
            this.pUBLICCODEDataGridViewTextBoxColumn1,
            this.EDITION,
            this.dATESUBTIONDataGridViewTextBoxColumn,
            this.nUMMONTHSDataGridViewTextBoxColumn,
            this.sIGNPERKSDataGridViewTextBoxColumn});
            this.sUBTIONGridView.DataSource = this.sUBTIONBindingSource;
            this.sUBTIONGridView.Location = new System.Drawing.Point(23, 370);
            this.sUBTIONGridView.Name = "sUBTIONGridView";
            this.sUBTIONGridView.RowTemplate.Height = 24;
            this.sUBTIONGridView.Size = new System.Drawing.Size(686, 284);
            this.sUBTIONGridView.TabIndex = 2;
            this.sUBTIONGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sUBTIONGridView_CellContentClick);
            // 
            // sUBTIONCODEDataGridViewTextBoxColumn
            // 
            this.sUBTIONCODEDataGridViewTextBoxColumn.DataPropertyName = "SUBTION_CODE";
            this.sUBTIONCODEDataGridViewTextBoxColumn.HeaderText = "Код подписки";
            this.sUBTIONCODEDataGridViewTextBoxColumn.Name = "sUBTIONCODEDataGridViewTextBoxColumn";
            this.sUBTIONCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUBERSCODEDataGridViewTextBoxColumn1
            // 
            this.sUBERSCODEDataGridViewTextBoxColumn1.DataPropertyName = "SUBERS_CODE";
            this.sUBERSCODEDataGridViewTextBoxColumn1.HeaderText = "Код Подписчика";
            this.sUBERSCODEDataGridViewTextBoxColumn1.Name = "sUBERSCODEDataGridViewTextBoxColumn1";
            // 
            // SUB_BERS
            // 
            this.SUB_BERS.DataPropertyName = "SUBERS_CODE";
            this.SUB_BERS.DataSource = this.sUBBERSBindingSource;
            this.SUB_BERS.DisplayMember = "FIO";
            this.SUB_BERS.HeaderText = "Подписчики";
            this.SUB_BERS.Name = "SUB_BERS";
            this.SUB_BERS.ValueMember = "SUBERS_CODE";
            this.SUB_BERS.Width = 200;
            // 
            // pUBLICCODEDataGridViewTextBoxColumn1
            // 
            this.pUBLICCODEDataGridViewTextBoxColumn1.DataPropertyName = "PUBLIC_CODE";
            this.pUBLICCODEDataGridViewTextBoxColumn1.HeaderText = "Код Издания";
            this.pUBLICCODEDataGridViewTextBoxColumn1.Name = "pUBLICCODEDataGridViewTextBoxColumn1";
            // 
            // EDITION
            // 
            this.EDITION.DataPropertyName = "PUBLIC_CODE";
            this.EDITION.DataSource = this.eDITIONBindingSource;
            this.EDITION.DisplayMember = "NAME_ED";
            this.EDITION.HeaderText = "Издания";
            this.EDITION.Name = "EDITION";
            this.EDITION.ValueMember = "PUBLIC_CODE";
            this.EDITION.Width = 200;
            // 
            // eDITIONBindingSource
            // 
            this.eDITIONBindingSource.DataMember = "EDITION";
            this.eDITIONBindingSource.DataSource = this.cursRabDataSet;
            // 
            // dATESUBTIONDataGridViewTextBoxColumn
            // 
            this.dATESUBTIONDataGridViewTextBoxColumn.DataPropertyName = "DATE_SUBTION";
            this.dATESUBTIONDataGridViewTextBoxColumn.HeaderText = "Дата подписки";
            this.dATESUBTIONDataGridViewTextBoxColumn.Name = "dATESUBTIONDataGridViewTextBoxColumn";
            // 
            // nUMMONTHSDataGridViewTextBoxColumn
            // 
            this.nUMMONTHSDataGridViewTextBoxColumn.DataPropertyName = "NUM_MONTHS";
            this.nUMMONTHSDataGridViewTextBoxColumn.HeaderText = "Кол-во месяцев";
            this.nUMMONTHSDataGridViewTextBoxColumn.Name = "nUMMONTHSDataGridViewTextBoxColumn";
            // 
            // sIGNPERKSDataGridViewTextBoxColumn
            // 
            this.sIGNPERKSDataGridViewTextBoxColumn.DataPropertyName = "SIGN_PERKS";
            this.sIGNPERKSDataGridViewTextBoxColumn.HeaderText = "Признак льготы";
            this.sIGNPERKSDataGridViewTextBoxColumn.Name = "sIGNPERKSDataGridViewTextBoxColumn";
            // 
            // sUBTIONBindingSource
            // 
            this.sUBTIONBindingSource.DataMember = "SUB_TION";
            this.sUBTIONBindingSource.DataSource = this.cursRabDataSet;
            // 
            // sUB_BERSTableAdapter
            // 
            this.sUB_BERSTableAdapter.ClearBeforeFill = true;
            // 
            // eDITIONTableAdapter
            // 
            this.eDITIONTableAdapter.ClearBeforeFill = true;
            // 
            // sUB_TIONTableAdapter
            // 
            this.sUB_TIONTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(947, 591);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 33);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(947, 522);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 33);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefres
            // 
            this.btnRefres.Location = new System.Drawing.Point(947, 458);
            this.btnRefres.Name = "btnRefres";
            this.btnRefres.Size = new System.Drawing.Size(112, 33);
            this.btnRefres.TabIndex = 20;
            this.btnRefres.Text = "Обновить";
            this.btnRefres.UseVisualStyleBackColor = true;
            this.btnRefres.Click += new System.EventHandler(this.btnRefres_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(947, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 33);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(796, 458);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(112, 33);
            this.btnLast.TabIndex = 18;
            this.btnLast.Text = "Последняя";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(796, 394);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(112, 33);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "Первая";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(796, 591);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 33);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(796, 522);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(112, 33);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTable.Location = new System.Drawing.Point(474, 28);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(100, 19);
            this.lblTable.TabIndex = 23;
            this.lblTable.Text = "\"Подписчики\"";
            // 
            // eDITIONGridView
            // 
            this.eDITIONGridView.AutoGenerateColumns = false;
            this.eDITIONGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eDITIONGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pUBLICCODEDataGridViewTextBoxColumn,
            this.nAMEEDDataGridViewTextBoxColumn,
            this.cOMMONPRICEDataGridViewTextBoxColumn,
            this.pREFPRICEDataGridViewTextBoxColumn,
            this.cIRCULATIONDataGridViewTextBoxColumn,
            this.nUMBERSUBERSDataGridViewTextBoxColumn,
            this.tYPEEDDataGridViewTextBoxColumn,
            this.eDITORDataGridViewTextBoxColumn});
            this.eDITIONGridView.DataSource = this.eDITIONBindingSource;
            this.eDITIONGridView.Location = new System.Drawing.Point(731, 76);
            this.eDITIONGridView.Name = "eDITIONGridView";
            this.eDITIONGridView.RowTemplate.Height = 24;
            this.eDITIONGridView.Size = new System.Drawing.Size(686, 288);
            this.eDITIONGridView.TabIndex = 24;
            this.eDITIONGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eDITIONGridView_CellContentClick);
            // 
            // pUBLICCODEDataGridViewTextBoxColumn
            // 
            this.pUBLICCODEDataGridViewTextBoxColumn.DataPropertyName = "PUBLIC_CODE";
            this.pUBLICCODEDataGridViewTextBoxColumn.HeaderText = "Код Издания";
            this.pUBLICCODEDataGridViewTextBoxColumn.Name = "pUBLICCODEDataGridViewTextBoxColumn";
            this.pUBLICCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEEDDataGridViewTextBoxColumn
            // 
            this.nAMEEDDataGridViewTextBoxColumn.DataPropertyName = "NAME_ED";
            this.nAMEEDDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nAMEEDDataGridViewTextBoxColumn.Name = "nAMEEDDataGridViewTextBoxColumn";
            this.nAMEEDDataGridViewTextBoxColumn.Width = 200;
            // 
            // cOMMONPRICEDataGridViewTextBoxColumn
            // 
            this.cOMMONPRICEDataGridViewTextBoxColumn.DataPropertyName = "COMMON_PRICE";
            this.cOMMONPRICEDataGridViewTextBoxColumn.HeaderText = "Обычная цена за месяц (руб.)";
            this.cOMMONPRICEDataGridViewTextBoxColumn.Name = "cOMMONPRICEDataGridViewTextBoxColumn";
            // 
            // pREFPRICEDataGridViewTextBoxColumn
            // 
            this.pREFPRICEDataGridViewTextBoxColumn.DataPropertyName = "PREF_PRICE";
            this.pREFPRICEDataGridViewTextBoxColumn.HeaderText = "Льготная цена за месяц (руб.)";
            this.pREFPRICEDataGridViewTextBoxColumn.Name = "pREFPRICEDataGridViewTextBoxColumn";
            // 
            // cIRCULATIONDataGridViewTextBoxColumn
            // 
            this.cIRCULATIONDataGridViewTextBoxColumn.DataPropertyName = "CIRCULATION";
            this.cIRCULATIONDataGridViewTextBoxColumn.HeaderText = "Тираж";
            this.cIRCULATIONDataGridViewTextBoxColumn.Name = "cIRCULATIONDataGridViewTextBoxColumn";
            // 
            // nUMBERSUBERSDataGridViewTextBoxColumn
            // 
            this.nUMBERSUBERSDataGridViewTextBoxColumn.DataPropertyName = "NUMBER_SUBERS";
            this.nUMBERSUBERSDataGridViewTextBoxColumn.HeaderText = "Число подписчиков";
            this.nUMBERSUBERSDataGridViewTextBoxColumn.Name = "nUMBERSUBERSDataGridViewTextBoxColumn";
            // 
            // tYPEEDDataGridViewTextBoxColumn
            // 
            this.tYPEEDDataGridViewTextBoxColumn.DataPropertyName = "TYPE_ED";
            this.tYPEEDDataGridViewTextBoxColumn.HeaderText = "Тип издания";
            this.tYPEEDDataGridViewTextBoxColumn.Name = "tYPEEDDataGridViewTextBoxColumn";
            // 
            // eDITORDataGridViewTextBoxColumn
            // 
            this.eDITORDataGridViewTextBoxColumn.DataPropertyName = "EDITOR";
            this.eDITORDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.eDITORDataGridViewTextBoxColumn.Name = "eDITORDataGridViewTextBoxColumn";
            this.eDITORDataGridViewTextBoxColumn.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаяToolStripMenuItem,
            this.запросToolStripMenuItem,
            this.запросToolStripMenuItem1,
            this.запросToolStripMenuItem2,
            this.запросToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1441, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // основнаяToolStripMenuItem
            // 
            this.основнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.альтернативнаяToolStripMenuItem,
            this.альтернативнаяToolStripMenuItem1});
            this.основнаяToolStripMenuItem.Name = "основнаяToolStripMenuItem";
            this.основнаяToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.основнаяToolStripMenuItem.Text = "Формы";
            // 
            // альтернативнаяToolStripMenuItem
            // 
            this.альтернативнаяToolStripMenuItem.Name = "альтернативнаяToolStripMenuItem";
            this.альтернативнаяToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.альтернативнаяToolStripMenuItem.Text = "Основная";
            // 
            // альтернативнаяToolStripMenuItem1
            // 
            this.альтернативнаяToolStripMenuItem1.Name = "альтернативнаяToolStripMenuItem1";
            this.альтернативнаяToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.альтернативнаяToolStripMenuItem1.Text = "Альтернативная";
            this.альтернативнаяToolStripMenuItem1.Click += new System.EventHandler(this.альтернативнаяToolStripMenuItem1_Click);
            // 
            // запросToolStripMenuItem
            // 
            this.запросToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableAdapterToolStripMenuItem,
            this.двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem,
            this.работаСБДToolStripMenuItem});
            this.запросToolStripMenuItem.Name = "запросToolStripMenuItem";
            this.запросToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.запросToolStripMenuItem.Text = "1 запрос";
            // 
            // tableAdapterToolStripMenuItem
            // 
            this.tableAdapterToolStripMenuItem.Name = "tableAdapterToolStripMenuItem";
            this.tableAdapterToolStripMenuItem.Size = new System.Drawing.Size(404, 26);
            this.tableAdapterToolStripMenuItem.Text = "TableAdapter";
            this.tableAdapterToolStripMenuItem.Click += new System.EventHandler(this.tableAdapterToolStripMenuItem_Click);
            // 
            // двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem
            // 
            this.двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem.Name = "двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem";
            this.двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem.Size = new System.Drawing.Size(404, 26);
            this.двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem.Text = "Двойной цикл, первичный ключ, DataRelation";
            this.двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem.Click += new System.EventHandler(this.двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem_Click);
            // 
            // работаСБДToolStripMenuItem
            // 
            this.работаСБДToolStripMenuItem.Name = "работаСБДToolStripMenuItem";
            this.работаСБДToolStripMenuItem.Size = new System.Drawing.Size(404, 26);
            this.работаСБДToolStripMenuItem.Text = "Работа с БД";
            this.работаСБДToolStripMenuItem.Click += new System.EventHandler(this.работаСБДToolStripMenuItem_Click);
            // 
            // запросToolStripMenuItem1
            // 
            this.запросToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableAdapterToolStripMenuItem1,
            this.тройнойЦиклToolStripMenuItem});
            this.запросToolStripMenuItem1.Name = "запросToolStripMenuItem1";
            this.запросToolStripMenuItem1.Size = new System.Drawing.Size(93, 24);
            this.запросToolStripMenuItem1.Text = "2.1 запрос";
            // 
            // tableAdapterToolStripMenuItem1
            // 
            this.tableAdapterToolStripMenuItem1.Name = "tableAdapterToolStripMenuItem1";
            this.tableAdapterToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.tableAdapterToolStripMenuItem1.Text = "TableAdapter";
            this.tableAdapterToolStripMenuItem1.Click += new System.EventHandler(this.tableAdapterToolStripMenuItem1_Click);
            // 
            // тройнойЦиклToolStripMenuItem
            // 
            this.тройнойЦиклToolStripMenuItem.Name = "тройнойЦиклToolStripMenuItem";
            this.тройнойЦиклToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.тройнойЦиклToolStripMenuItem.Text = "Тройной цикл";
            this.тройнойЦиклToolStripMenuItem.Click += new System.EventHandler(this.тройнойЦиклToolStripMenuItem_Click);
            // 
            // запросToolStripMenuItem2
            // 
            this.запросToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableAdapterToolStripMenuItem2,
            this.подзапросыToolStripMenuItem});
            this.запросToolStripMenuItem2.Name = "запросToolStripMenuItem2";
            this.запросToolStripMenuItem2.Size = new System.Drawing.Size(93, 24);
            this.запросToolStripMenuItem2.Text = "2.2 запрос";
            // 
            // tableAdapterToolStripMenuItem2
            // 
            this.tableAdapterToolStripMenuItem2.Name = "tableAdapterToolStripMenuItem2";
            this.tableAdapterToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.tableAdapterToolStripMenuItem2.Text = "TableAdapter";
            this.tableAdapterToolStripMenuItem2.Click += new System.EventHandler(this.tableAdapterToolStripMenuItem2_Click);
            // 
            // подзапросыToolStripMenuItem
            // 
            this.подзапросыToolStripMenuItem.Name = "подзапросыToolStripMenuItem";
            this.подзапросыToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.подзапросыToolStripMenuItem.Text = "Подзапросы";
            this.подзапросыToolStripMenuItem.Click += new System.EventHandler(this.подзапросыToolStripMenuItem_Click);
            // 
            // запросToolStripMenuItem3
            // 
            this.запросToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableAdapterToolStripMenuItem3,
            this.подзапросыToolStripMenuItem1});
            this.запросToolStripMenuItem3.Name = "запросToolStripMenuItem3";
            this.запросToolStripMenuItem3.Size = new System.Drawing.Size(82, 24);
            this.запросToolStripMenuItem3.Text = "3 запрос";
            // 
            // tableAdapterToolStripMenuItem3
            // 
            this.tableAdapterToolStripMenuItem3.Name = "tableAdapterToolStripMenuItem3";
            this.tableAdapterToolStripMenuItem3.Size = new System.Drawing.Size(216, 26);
            this.tableAdapterToolStripMenuItem3.Text = "TableAdapter";
            this.tableAdapterToolStripMenuItem3.Click += new System.EventHandler(this.tableAdapterToolStripMenuItem3_Click);
            // 
            // подзапросыToolStripMenuItem1
            // 
            this.подзапросыToolStripMenuItem1.Name = "подзапросыToolStripMenuItem1";
            this.подзапросыToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.подзапросыToolStripMenuItem1.Text = "Подзапросы";
            this.подзапросыToolStripMenuItem1.Click += new System.EventHandler(this.подзапросыToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 677);
            this.Controls.Add(this.eDITIONGridView);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefres);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.sUBTIONGridView);
            this.Controls.Add(this.sUBBERSGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursRabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBBERSGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDITIONGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView sUBBERSGridView;
        private System.Windows.Forms.DataGridView sUBTIONGridView;
        private CursRabDataSet cursRabDataSet;
        private System.Windows.Forms.BindingSource sUBBERSBindingSource;
        private CursRabDataSetTableAdapters.SUB_BERSTableAdapter sUB_BERSTableAdapter;
        private System.Windows.Forms.BindingSource eDITIONBindingSource;
        private CursRabDataSetTableAdapters.EDITIONTableAdapter eDITIONTableAdapter;
        private System.Windows.Forms.BindingSource sUBTIONBindingSource;
        private CursRabDataSetTableAdapters.SUB_TIONTableAdapter sUB_TIONTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefres;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridView eDITIONGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBERSCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBTIONCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBERSCODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn SUB_BERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLICCODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn EDITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATESUBTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMMONTHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIGNPERKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLICCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMMONPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREFPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIRCULATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBERSUBERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDITORDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem основнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативнаяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem запросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableAdapterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двойнойЦиклПервичныйКлючDataRelationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tableAdapterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem тройнойЦиклToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tableAdapterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem подзапросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tableAdapterToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem подзапросыToolStripMenuItem1;
    }
}

