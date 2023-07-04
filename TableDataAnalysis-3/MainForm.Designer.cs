
namespace TableDataAnalysis
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpenTable = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpenSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveTable = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveTableAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileCloseTable = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditInsertColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditInsertRow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditDeleteColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAnalisys = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFrequancyData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDependency = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNumericalCharacteristics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBySelectedArea = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Table = new System.Windows.Forms.DataGridView();
            this.PanelInsertingRow = new System.Windows.Forms.Panel();
            this.ButtonCancelInsertingRow = new System.Windows.Forms.Button();
            this.ButtonInsertRow = new System.Windows.Forms.Button();
            this.NumericUpDownRowPosition = new System.Windows.Forms.NumericUpDown();
            this.LabelRowPosition = new System.Windows.Forms.Label();
            this.LabelRowInserting = new System.Windows.Forms.Label();
            this.PanelInsertingColumn = new System.Windows.Forms.Panel();
            this.LabelColumnName = new System.Windows.Forms.Label();
            this.TextBoxColumnName = new System.Windows.Forms.TextBox();
            this.ButtonCancelInsertingColumn = new System.Windows.Forms.Button();
            this.NumericUpDownColumnPosition = new System.Windows.Forms.NumericUpDown();
            this.LabelColumnPosition = new System.Windows.Forms.Label();
            this.ButtonInsertColumn = new System.Windows.Forms.Button();
            this.LabelColumnInserting = new System.Windows.Forms.Label();
            this.PanelDeletingColumn = new System.Windows.Forms.Panel();
            this.ComboBoxColumnName = new System.Windows.Forms.ComboBox();
            this.RadioButtonDeleteByName = new System.Windows.Forms.RadioButton();
            this.RadioButtonDeleteByIndex = new System.Windows.Forms.RadioButton();
            this.LabelDeletingColumnName = new System.Windows.Forms.Label();
            this.ButtonCancelDeletingColumn = new System.Windows.Forms.Button();
            this.NumericUpDownDeleteColumnPosition = new System.Windows.Forms.NumericUpDown();
            this.LabelDeletingColumnPosition = new System.Windows.Forms.Label();
            this.ButtonDeleteColumn = new System.Windows.Forms.Button();
            this.LabelDeletingColumn = new System.Windows.Forms.Label();
            this.PanelDeletingRow = new System.Windows.Forms.Panel();
            this.ButtonCancelDeletingRow = new System.Windows.Forms.Button();
            this.NumericUpDownDeletingRowPosition = new System.Windows.Forms.NumericUpDown();
            this.LabelDeletingRowPosition = new System.Windows.Forms.Label();
            this.ButtonDeleteRow = new System.Windows.Forms.Button();
            this.LabelDeletingRow = new System.Windows.Forms.Label();
            this.PanelFrequancyData = new System.Windows.Forms.Panel();
            this.LabelFrequancyData = new System.Windows.Forms.Label();
            this.ComboBoxFrequancyDataColumnName = new System.Windows.Forms.ComboBox();
            this.ButtonFrequancyDataCancel = new System.Windows.Forms.Button();
            this.ButtonFrequancyDataDraw = new System.Windows.Forms.Button();
            this.LabelFrequancyDataColumnName = new System.Windows.Forms.Label();
            this.LabelFrequancyDataDraw = new System.Windows.Forms.Label();
            this.PanelBySelectedArea = new System.Windows.Forms.Panel();
            this.LabelBySelectedAreaInfo = new System.Windows.Forms.Label();
            this.ButtonBySelectedAreaCancel = new System.Windows.Forms.Button();
            this.ButtonBySelectedAreaDraw = new System.Windows.Forms.Button();
            this.LabelBuildDiagram = new System.Windows.Forms.Label();
            this.PanelNumericalCharacteristics = new System.Windows.Forms.Panel();
            this.ButtonNumericalCharacteristicsCancel = new System.Windows.Forms.Button();
            this.ButtonNumericalCharacteristicsCalculate = new System.Windows.Forms.Button();
            this.LabelNumericalCharacteristicsResult = new System.Windows.Forms.Label();
            this.LabelNumericalCharacteristicsColumnNames = new System.Windows.Forms.Label();
            this.ComboBoxNumericalCharacteristicsColumnNames = new System.Windows.Forms.ComboBox();
            this.LabelNumericalCharacteristics = new System.Windows.Forms.Label();
            this.PanelDependency = new System.Windows.Forms.Panel();
            this.ButtonDependencyCancel = new System.Windows.Forms.Button();
            this.ButtonlDependencyDraw = new System.Windows.Forms.Button();
            this.LabelDependencyColumnX = new System.Windows.Forms.Label();
            this.ComboBoxDependencyColumnX = new System.Windows.Forms.ComboBox();
            this.LabelDependencyColumnY = new System.Windows.Forms.Label();
            this.ComboBoxDependencyColumnY = new System.Windows.Forms.ComboBox();
            this.LabelDependency = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.PanelInsertingRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRowPosition)).BeginInit();
            this.PanelInsertingColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownColumnPosition)).BeginInit();
            this.PanelDeletingColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDeleteColumnPosition)).BeginInit();
            this.PanelDeletingRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDeletingRowPosition)).BeginInit();
            this.PanelFrequancyData.SuspendLayout();
            this.PanelBySelectedArea.SuspendLayout();
            this.PanelNumericalCharacteristics.SuspendLayout();
            this.PanelDependency.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEdit,
            this.MenuItemAnalisys,
            this.MenuItemAbout});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(760, 25);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileOpenTable,
            this.MenuItemFileOpenSchedule,
            this.MenuItemFileSaveTable,
            this.MenuItemFileSaveTableAs,
            this.MenuItemFileCloseTable,
            this.MenuItemFileExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 19);
            this.MenuItemFile.Text = "Файл";
            // 
            // MenuItemFileOpenTable
            // 
            this.MenuItemFileOpenTable.Name = "MenuItemFileOpenTable";
            this.MenuItemFileOpenTable.Size = new System.Drawing.Size(214, 22);
            this.MenuItemFileOpenTable.Text = "Открыть таблицу";
            this.MenuItemFileOpenTable.Click += new System.EventHandler(this.MenuItemFileOpenTable_Click);
            // 
            // MenuItemFileOpenSchedule
            // 
            this.MenuItemFileOpenSchedule.Name = "MenuItemFileOpenSchedule";
            this.MenuItemFileOpenSchedule.Size = new System.Drawing.Size(214, 22);
            this.MenuItemFileOpenSchedule.Text = "Открыть график";
            this.MenuItemFileOpenSchedule.Click += new System.EventHandler(this.MenuItemFileOpenSchedule_Click);
            // 
            // MenuItemFileSaveTable
            // 
            this.MenuItemFileSaveTable.Name = "MenuItemFileSaveTable";
            this.MenuItemFileSaveTable.Size = new System.Drawing.Size(214, 22);
            this.MenuItemFileSaveTable.Text = "Сохранить таблицу";
            this.MenuItemFileSaveTable.Click += new System.EventHandler(this.MenuItemFileSaveTable_Click);
            // 
            // MenuItemFileSaveTableAs
            // 
            this.MenuItemFileSaveTableAs.Name = "MenuItemFileSaveTableAs";
            this.MenuItemFileSaveTableAs.Size = new System.Drawing.Size(214, 22);
            this.MenuItemFileSaveTableAs.Text = "Сохранить таблицу как ...";
            this.MenuItemFileSaveTableAs.Click += new System.EventHandler(this.MenuItemFileSaveTableAs_Click);
            // 
            // MenuItemFileCloseTable
            // 
            this.MenuItemFileCloseTable.Name = "MenuItemFileCloseTable";
            this.MenuItemFileCloseTable.Size = new System.Drawing.Size(214, 22);
            this.MenuItemFileCloseTable.Text = "Закрыть таблицу";
            this.MenuItemFileCloseTable.Click += new System.EventHandler(this.MenuItemFileCloseTable_Click);
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.Size = new System.Drawing.Size(214, 22);
            this.MenuItemFileExit.Text = "Выход";
            this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditInsertColumn,
            this.MenuItemEditInsertRow,
            this.MenuItemEditDeleteColumn,
            this.MenuItemEditDeleteRow});
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(59, 19);
            this.MenuItemEdit.Text = "Правка";
            // 
            // MenuItemEditInsertColumn
            // 
            this.MenuItemEditInsertColumn.Name = "MenuItemEditInsertColumn";
            this.MenuItemEditInsertColumn.Size = new System.Drawing.Size(170, 22);
            this.MenuItemEditInsertColumn.Text = "Вставить столбец";
            this.MenuItemEditInsertColumn.Click += new System.EventHandler(this.MenuItemEditInsertColumn_Click);
            // 
            // MenuItemEditInsertRow
            // 
            this.MenuItemEditInsertRow.Name = "MenuItemEditInsertRow";
            this.MenuItemEditInsertRow.Size = new System.Drawing.Size(170, 22);
            this.MenuItemEditInsertRow.Text = "Вставить строку";
            this.MenuItemEditInsertRow.Click += new System.EventHandler(this.MenuItemEditInsertRow_Click);
            // 
            // MenuItemEditDeleteColumn
            // 
            this.MenuItemEditDeleteColumn.Name = "MenuItemEditDeleteColumn";
            this.MenuItemEditDeleteColumn.Size = new System.Drawing.Size(170, 22);
            this.MenuItemEditDeleteColumn.Text = "Удалить столбец";
            this.MenuItemEditDeleteColumn.Click += new System.EventHandler(this.MenuItemEditDeleteColumn_Click);
            // 
            // MenuItemEditDeleteRow
            // 
            this.MenuItemEditDeleteRow.Name = "MenuItemEditDeleteRow";
            this.MenuItemEditDeleteRow.Size = new System.Drawing.Size(170, 22);
            this.MenuItemEditDeleteRow.Text = "Удалить строку";
            this.MenuItemEditDeleteRow.Click += new System.EventHandler(this.MenuItemEditDeleteRow_Click);
            // 
            // MenuItemAnalisys
            // 
            this.MenuItemAnalisys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFrequancyData,
            this.MenuItemDependency,
            this.MenuItemNumericalCharacteristics,
            this.MenuItemBySelectedArea});
            this.MenuItemAnalisys.Name = "MenuItemAnalisys";
            this.MenuItemAnalisys.Size = new System.Drawing.Size(103, 19);
            this.MenuItemAnalisys.Text = "Анализ данных";
            // 
            // MenuItemFrequancyData
            // 
            this.MenuItemFrequancyData.Name = "MenuItemFrequancyData";
            this.MenuItemFrequancyData.Size = new System.Drawing.Size(247, 22);
            this.MenuItemFrequancyData.Text = "Частота встречаемости данных";
            this.MenuItemFrequancyData.Click += new System.EventHandler(this.MenuItemFrequancyData_Click);
            // 
            // MenuItemDependency
            // 
            this.MenuItemDependency.Name = "MenuItemDependency";
            this.MenuItemDependency.Size = new System.Drawing.Size(247, 22);
            this.MenuItemDependency.Text = "График зависимости (x -> y)";
            this.MenuItemDependency.Click += new System.EventHandler(this.MenuItemDependency_Click);
            // 
            // MenuItemNumericalCharacteristics
            // 
            this.MenuItemNumericalCharacteristics.Name = "MenuItemNumericalCharacteristics";
            this.MenuItemNumericalCharacteristics.Size = new System.Drawing.Size(247, 22);
            this.MenuItemNumericalCharacteristics.Text = "Числовые характеристики";
            this.MenuItemNumericalCharacteristics.Click += new System.EventHandler(this.MenuItemNumericalCharacteristics_Click);
            // 
            // MenuItemBySelectedArea
            // 
            this.MenuItemBySelectedArea.Name = "MenuItemBySelectedArea";
            this.MenuItemBySelectedArea.Size = new System.Drawing.Size(247, 22);
            this.MenuItemBySelectedArea.Text = "По выделенной области";
            this.MenuItemBySelectedArea.Click += new System.EventHandler(this.MenuItemBySelectedArea_Click);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(68, 19);
            this.MenuItemAbout.Text = "Помощь";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle6;
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 25);
            this.Table.Margin = new System.Windows.Forms.Padding(4);
            this.Table.Name = "Table";
            this.Table.RowHeadersVisible = false;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Table.Size = new System.Drawing.Size(760, 502);
            this.Table.TabIndex = 1;
            this.Table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellEndEdit);
            this.Table.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.Table_SortCompare);
            // 
            // PanelInsertingRow
            // 
            this.PanelInsertingRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInsertingRow.Controls.Add(this.ButtonCancelInsertingRow);
            this.PanelInsertingRow.Controls.Add(this.ButtonInsertRow);
            this.PanelInsertingRow.Controls.Add(this.NumericUpDownRowPosition);
            this.PanelInsertingRow.Controls.Add(this.LabelRowPosition);
            this.PanelInsertingRow.Controls.Add(this.LabelRowInserting);
            this.PanelInsertingRow.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelInsertingRow.Location = new System.Drawing.Point(760, 25);
            this.PanelInsertingRow.Name = "PanelInsertingRow";
            this.PanelInsertingRow.Size = new System.Drawing.Size(0, 502);
            this.PanelInsertingRow.TabIndex = 2;
            // 
            // ButtonCancelInsertingRow
            // 
            this.ButtonCancelInsertingRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonCancelInsertingRow.Location = new System.Drawing.Point(103, 71);
            this.ButtonCancelInsertingRow.Name = "ButtonCancelInsertingRow";
            this.ButtonCancelInsertingRow.Size = new System.Drawing.Size(63, 23);
            this.ButtonCancelInsertingRow.TabIndex = 4;
            this.ButtonCancelInsertingRow.Text = "Закрыть";
            this.ButtonCancelInsertingRow.UseVisualStyleBackColor = true;
            this.ButtonCancelInsertingRow.Click += new System.EventHandler(this.ButtonCancelInsertingRow_Click);
            // 
            // ButtonInsertRow
            // 
            this.ButtonInsertRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonInsertRow.Location = new System.Drawing.Point(172, 71);
            this.ButtonInsertRow.Name = "ButtonInsertRow";
            this.ButtonInsertRow.Size = new System.Drawing.Size(65, 23);
            this.ButtonInsertRow.TabIndex = 3;
            this.ButtonInsertRow.Text = "Вставить";
            this.ButtonInsertRow.UseVisualStyleBackColor = true;
            this.ButtonInsertRow.Click += new System.EventHandler(this.ButtonInsertRow_Click);
            // 
            // NumericUpDownRowPosition
            // 
            this.NumericUpDownRowPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.NumericUpDownRowPosition.Location = new System.Drawing.Point(121, 38);
            this.NumericUpDownRowPosition.Name = "NumericUpDownRowPosition";
            this.NumericUpDownRowPosition.Size = new System.Drawing.Size(116, 23);
            this.NumericUpDownRowPosition.TabIndex = 2;
            // 
            // LabelRowPosition
            // 
            this.LabelRowPosition.AutoSize = true;
            this.LabelRowPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelRowPosition.Location = new System.Drawing.Point(15, 40);
            this.LabelRowPosition.Name = "LabelRowPosition";
            this.LabelRowPosition.Size = new System.Drawing.Size(100, 15);
            this.LabelRowPosition.TabIndex = 1;
            this.LabelRowPosition.Text = "Позиция строки:";
            // 
            // LabelRowInserting
            // 
            this.LabelRowInserting.AutoSize = true;
            this.LabelRowInserting.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelRowInserting.Location = new System.Drawing.Point(14, 10);
            this.LabelRowInserting.Name = "LabelRowInserting";
            this.LabelRowInserting.Size = new System.Drawing.Size(107, 19);
            this.LabelRowInserting.TabIndex = 0;
            this.LabelRowInserting.Text = "Вставка строки";
            // 
            // PanelInsertingColumn
            // 
            this.PanelInsertingColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInsertingColumn.Controls.Add(this.LabelColumnName);
            this.PanelInsertingColumn.Controls.Add(this.TextBoxColumnName);
            this.PanelInsertingColumn.Controls.Add(this.ButtonCancelInsertingColumn);
            this.PanelInsertingColumn.Controls.Add(this.NumericUpDownColumnPosition);
            this.PanelInsertingColumn.Controls.Add(this.LabelColumnPosition);
            this.PanelInsertingColumn.Controls.Add(this.ButtonInsertColumn);
            this.PanelInsertingColumn.Controls.Add(this.LabelColumnInserting);
            this.PanelInsertingColumn.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelInsertingColumn.Location = new System.Drawing.Point(760, 25);
            this.PanelInsertingColumn.Name = "PanelInsertingColumn";
            this.PanelInsertingColumn.Size = new System.Drawing.Size(0, 502);
            this.PanelInsertingColumn.TabIndex = 3;
            // 
            // LabelColumnName
            // 
            this.LabelColumnName.AutoSize = true;
            this.LabelColumnName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelColumnName.Location = new System.Drawing.Point(15, 70);
            this.LabelColumnName.Name = "LabelColumnName";
            this.LabelColumnName.Size = new System.Drawing.Size(112, 15);
            this.LabelColumnName.TabIndex = 6;
            this.LabelColumnName.Text = "Название столбца:";
            // 
            // TextBoxColumnName
            // 
            this.TextBoxColumnName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TextBoxColumnName.Location = new System.Drawing.Point(133, 67);
            this.TextBoxColumnName.Name = "TextBoxColumnName";
            this.TextBoxColumnName.Size = new System.Drawing.Size(101, 23);
            this.TextBoxColumnName.TabIndex = 5;
            this.TextBoxColumnName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxColumnName_KeyDown);
            this.TextBoxColumnName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxColumnName_KeyUp);
            // 
            // ButtonCancelInsertingColumn
            // 
            this.ButtonCancelInsertingColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonCancelInsertingColumn.Location = new System.Drawing.Point(100, 100);
            this.ButtonCancelInsertingColumn.Name = "ButtonCancelInsertingColumn";
            this.ButtonCancelInsertingColumn.Size = new System.Drawing.Size(63, 23);
            this.ButtonCancelInsertingColumn.TabIndex = 4;
            this.ButtonCancelInsertingColumn.Text = "Закрыть";
            this.ButtonCancelInsertingColumn.UseVisualStyleBackColor = true;
            this.ButtonCancelInsertingColumn.Click += new System.EventHandler(this.ButtonCancelInsertingColumn_Click);
            // 
            // NumericUpDownColumnPosition
            // 
            this.NumericUpDownColumnPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.NumericUpDownColumnPosition.Location = new System.Drawing.Point(133, 38);
            this.NumericUpDownColumnPosition.Name = "NumericUpDownColumnPosition";
            this.NumericUpDownColumnPosition.Size = new System.Drawing.Size(101, 23);
            this.NumericUpDownColumnPosition.TabIndex = 2;
            // 
            // LabelColumnPosition
            // 
            this.LabelColumnPosition.AutoSize = true;
            this.LabelColumnPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelColumnPosition.Location = new System.Drawing.Point(15, 40);
            this.LabelColumnPosition.Name = "LabelColumnPosition";
            this.LabelColumnPosition.Size = new System.Drawing.Size(100, 15);
            this.LabelColumnPosition.TabIndex = 1;
            this.LabelColumnPosition.Text = "Позиция стобца:";
            // 
            // ButtonInsertColumn
            // 
            this.ButtonInsertColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonInsertColumn.Location = new System.Drawing.Point(169, 100);
            this.ButtonInsertColumn.Name = "ButtonInsertColumn";
            this.ButtonInsertColumn.Size = new System.Drawing.Size(65, 23);
            this.ButtonInsertColumn.TabIndex = 3;
            this.ButtonInsertColumn.Text = "Вставить";
            this.ButtonInsertColumn.UseVisualStyleBackColor = true;
            this.ButtonInsertColumn.Click += new System.EventHandler(this.ButtonInsertColumn_Click);
            // 
            // LabelColumnInserting
            // 
            this.LabelColumnInserting.AutoSize = true;
            this.LabelColumnInserting.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelColumnInserting.Location = new System.Drawing.Point(14, 10);
            this.LabelColumnInserting.Name = "LabelColumnInserting";
            this.LabelColumnInserting.Size = new System.Drawing.Size(116, 19);
            this.LabelColumnInserting.TabIndex = 0;
            this.LabelColumnInserting.Text = "Вставка столбца";
            // 
            // PanelDeletingColumn
            // 
            this.PanelDeletingColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDeletingColumn.Controls.Add(this.ComboBoxColumnName);
            this.PanelDeletingColumn.Controls.Add(this.RadioButtonDeleteByName);
            this.PanelDeletingColumn.Controls.Add(this.RadioButtonDeleteByIndex);
            this.PanelDeletingColumn.Controls.Add(this.LabelDeletingColumnName);
            this.PanelDeletingColumn.Controls.Add(this.ButtonCancelDeletingColumn);
            this.PanelDeletingColumn.Controls.Add(this.NumericUpDownDeleteColumnPosition);
            this.PanelDeletingColumn.Controls.Add(this.LabelDeletingColumnPosition);
            this.PanelDeletingColumn.Controls.Add(this.ButtonDeleteColumn);
            this.PanelDeletingColumn.Controls.Add(this.LabelDeletingColumn);
            this.PanelDeletingColumn.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDeletingColumn.Location = new System.Drawing.Point(760, 25);
            this.PanelDeletingColumn.Name = "PanelDeletingColumn";
            this.PanelDeletingColumn.Size = new System.Drawing.Size(0, 502);
            this.PanelDeletingColumn.TabIndex = 4;
            // 
            // ComboBoxColumnName
            // 
            this.ComboBoxColumnName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxColumnName.FormattingEnabled = true;
            this.ComboBoxColumnName.Location = new System.Drawing.Point(133, 73);
            this.ComboBoxColumnName.Name = "ComboBoxColumnName";
            this.ComboBoxColumnName.Size = new System.Drawing.Size(101, 23);
            this.ComboBoxColumnName.TabIndex = 9;
            // 
            // RadioButtonDeleteByName
            // 
            this.RadioButtonDeleteByName.AutoSize = true;
            this.RadioButtonDeleteByName.Checked = true;
            this.RadioButtonDeleteByName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButtonDeleteByName.Location = new System.Drawing.Point(18, 42);
            this.RadioButtonDeleteByName.Name = "RadioButtonDeleteByName";
            this.RadioButtonDeleteByName.Size = new System.Drawing.Size(100, 19);
            this.RadioButtonDeleteByName.TabIndex = 8;
            this.RadioButtonDeleteByName.TabStop = true;
            this.RadioButtonDeleteByName.Text = "По названию";
            this.RadioButtonDeleteByName.UseVisualStyleBackColor = true;
            this.RadioButtonDeleteByName.CheckedChanged += new System.EventHandler(this.RadioByttonsDeleteBy_Checked);
            // 
            // RadioButtonDeleteByIndex
            // 
            this.RadioButtonDeleteByIndex.AutoSize = true;
            this.RadioButtonDeleteByIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButtonDeleteByIndex.Location = new System.Drawing.Point(133, 42);
            this.RadioButtonDeleteByIndex.Name = "RadioButtonDeleteByIndex";
            this.RadioButtonDeleteByIndex.Size = new System.Drawing.Size(89, 19);
            this.RadioButtonDeleteByIndex.TabIndex = 7;
            this.RadioButtonDeleteByIndex.Text = "По индексу";
            this.RadioButtonDeleteByIndex.UseVisualStyleBackColor = true;
            // 
            // LabelDeletingColumnName
            // 
            this.LabelDeletingColumnName.AutoSize = true;
            this.LabelDeletingColumnName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelDeletingColumnName.Location = new System.Drawing.Point(15, 76);
            this.LabelDeletingColumnName.Name = "LabelDeletingColumnName";
            this.LabelDeletingColumnName.Size = new System.Drawing.Size(112, 15);
            this.LabelDeletingColumnName.TabIndex = 6;
            this.LabelDeletingColumnName.Text = "Название столбца:";
            // 
            // ButtonCancelDeletingColumn
            // 
            this.ButtonCancelDeletingColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonCancelDeletingColumn.Location = new System.Drawing.Point(100, 139);
            this.ButtonCancelDeletingColumn.Name = "ButtonCancelDeletingColumn";
            this.ButtonCancelDeletingColumn.Size = new System.Drawing.Size(63, 23);
            this.ButtonCancelDeletingColumn.TabIndex = 4;
            this.ButtonCancelDeletingColumn.Text = "Закрыть";
            this.ButtonCancelDeletingColumn.UseVisualStyleBackColor = true;
            this.ButtonCancelDeletingColumn.Click += new System.EventHandler(this.ButtonCancelDeletingColumn_Click);
            // 
            // NumericUpDownDeleteColumnPosition
            // 
            this.NumericUpDownDeleteColumnPosition.Enabled = false;
            this.NumericUpDownDeleteColumnPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.NumericUpDownDeleteColumnPosition.Location = new System.Drawing.Point(133, 102);
            this.NumericUpDownDeleteColumnPosition.Name = "NumericUpDownDeleteColumnPosition";
            this.NumericUpDownDeleteColumnPosition.Size = new System.Drawing.Size(101, 23);
            this.NumericUpDownDeleteColumnPosition.TabIndex = 2;
            // 
            // LabelDeletingColumnPosition
            // 
            this.LabelDeletingColumnPosition.AutoSize = true;
            this.LabelDeletingColumnPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelDeletingColumnPosition.Location = new System.Drawing.Point(15, 104);
            this.LabelDeletingColumnPosition.Name = "LabelDeletingColumnPosition";
            this.LabelDeletingColumnPosition.Size = new System.Drawing.Size(100, 15);
            this.LabelDeletingColumnPosition.TabIndex = 1;
            this.LabelDeletingColumnPosition.Text = "Позиция стобца:";
            // 
            // ButtonDeleteColumn
            // 
            this.ButtonDeleteColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteColumn.Location = new System.Drawing.Point(169, 139);
            this.ButtonDeleteColumn.Name = "ButtonDeleteColumn";
            this.ButtonDeleteColumn.Size = new System.Drawing.Size(65, 23);
            this.ButtonDeleteColumn.TabIndex = 3;
            this.ButtonDeleteColumn.Text = "Удалить";
            this.ButtonDeleteColumn.UseVisualStyleBackColor = true;
            this.ButtonDeleteColumn.Click += new System.EventHandler(this.ButtonDeleteColumn_Click);
            // 
            // LabelDeletingColumn
            // 
            this.LabelDeletingColumn.AutoSize = true;
            this.LabelDeletingColumn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelDeletingColumn.Location = new System.Drawing.Point(14, 10);
            this.LabelDeletingColumn.Name = "LabelDeletingColumn";
            this.LabelDeletingColumn.Size = new System.Drawing.Size(125, 19);
            this.LabelDeletingColumn.TabIndex = 0;
            this.LabelDeletingColumn.Text = "Удаление столбца";
            // 
            // PanelDeletingRow
            // 
            this.PanelDeletingRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDeletingRow.Controls.Add(this.ButtonCancelDeletingRow);
            this.PanelDeletingRow.Controls.Add(this.NumericUpDownDeletingRowPosition);
            this.PanelDeletingRow.Controls.Add(this.LabelDeletingRowPosition);
            this.PanelDeletingRow.Controls.Add(this.ButtonDeleteRow);
            this.PanelDeletingRow.Controls.Add(this.LabelDeletingRow);
            this.PanelDeletingRow.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDeletingRow.Location = new System.Drawing.Point(760, 25);
            this.PanelDeletingRow.Name = "PanelDeletingRow";
            this.PanelDeletingRow.Size = new System.Drawing.Size(0, 502);
            this.PanelDeletingRow.TabIndex = 5;
            // 
            // ButtonCancelDeletingRow
            // 
            this.ButtonCancelDeletingRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonCancelDeletingRow.Location = new System.Drawing.Point(100, 78);
            this.ButtonCancelDeletingRow.Name = "ButtonCancelDeletingRow";
            this.ButtonCancelDeletingRow.Size = new System.Drawing.Size(63, 23);
            this.ButtonCancelDeletingRow.TabIndex = 4;
            this.ButtonCancelDeletingRow.Text = "Закрыть";
            this.ButtonCancelDeletingRow.UseVisualStyleBackColor = true;
            this.ButtonCancelDeletingRow.Click += new System.EventHandler(this.ButtonCancelDeletingRow_Click);
            // 
            // NumericUpDownDeletingRowPosition
            // 
            this.NumericUpDownDeletingRowPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.NumericUpDownDeletingRowPosition.Location = new System.Drawing.Point(133, 42);
            this.NumericUpDownDeletingRowPosition.Name = "NumericUpDownDeletingRowPosition";
            this.NumericUpDownDeletingRowPosition.Size = new System.Drawing.Size(101, 23);
            this.NumericUpDownDeletingRowPosition.TabIndex = 2;
            // 
            // LabelDeletingRowPosition
            // 
            this.LabelDeletingRowPosition.AutoSize = true;
            this.LabelDeletingRowPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelDeletingRowPosition.Location = new System.Drawing.Point(15, 44);
            this.LabelDeletingRowPosition.Name = "LabelDeletingRowPosition";
            this.LabelDeletingRowPosition.Size = new System.Drawing.Size(100, 15);
            this.LabelDeletingRowPosition.TabIndex = 1;
            this.LabelDeletingRowPosition.Text = "Позиция строки:";
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteRow.Location = new System.Drawing.Point(169, 78);
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.Size = new System.Drawing.Size(65, 23);
            this.ButtonDeleteRow.TabIndex = 3;
            this.ButtonDeleteRow.Text = "Удалить";
            this.ButtonDeleteRow.UseVisualStyleBackColor = true;
            this.ButtonDeleteRow.Click += new System.EventHandler(this.ButtonDeleteRow_Click);
            // 
            // LabelDeletingRow
            // 
            this.LabelDeletingRow.AutoSize = true;
            this.LabelDeletingRow.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelDeletingRow.Location = new System.Drawing.Point(14, 10);
            this.LabelDeletingRow.Name = "LabelDeletingRow";
            this.LabelDeletingRow.Size = new System.Drawing.Size(116, 19);
            this.LabelDeletingRow.TabIndex = 0;
            this.LabelDeletingRow.Text = "Удаление строки";
            // 
            // PanelFrequancyData
            // 
            this.PanelFrequancyData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFrequancyData.Controls.Add(this.LabelFrequancyData);
            this.PanelFrequancyData.Controls.Add(this.ComboBoxFrequancyDataColumnName);
            this.PanelFrequancyData.Controls.Add(this.ButtonFrequancyDataCancel);
            this.PanelFrequancyData.Controls.Add(this.ButtonFrequancyDataDraw);
            this.PanelFrequancyData.Controls.Add(this.LabelFrequancyDataColumnName);
            this.PanelFrequancyData.Controls.Add(this.LabelFrequancyDataDraw);
            this.PanelFrequancyData.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelFrequancyData.Location = new System.Drawing.Point(760, 25);
            this.PanelFrequancyData.Name = "PanelFrequancyData";
            this.PanelFrequancyData.Size = new System.Drawing.Size(0, 502);
            this.PanelFrequancyData.TabIndex = 6;
            // 
            // LabelFrequancyData
            // 
            this.LabelFrequancyData.AutoSize = true;
            this.LabelFrequancyData.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFrequancyData.Location = new System.Drawing.Point(14, 36);
            this.LabelFrequancyData.Name = "LabelFrequancyData";
            this.LabelFrequancyData.Size = new System.Drawing.Size(214, 19);
            this.LabelFrequancyData.TabIndex = 6;
            this.LabelFrequancyData.Text = "Частота встречаемости данных";
            // 
            // ComboBoxFrequancyDataColumnName
            // 
            this.ComboBoxFrequancyDataColumnName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxFrequancyDataColumnName.FormattingEnabled = true;
            this.ComboBoxFrequancyDataColumnName.Location = new System.Drawing.Point(133, 67);
            this.ComboBoxFrequancyDataColumnName.Name = "ComboBoxFrequancyDataColumnName";
            this.ComboBoxFrequancyDataColumnName.Size = new System.Drawing.Size(104, 23);
            this.ComboBoxFrequancyDataColumnName.TabIndex = 5;
            // 
            // ButtonFrequancyDataCancel
            // 
            this.ButtonFrequancyDataCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonFrequancyDataCancel.Location = new System.Drawing.Point(93, 102);
            this.ButtonFrequancyDataCancel.Name = "ButtonFrequancyDataCancel";
            this.ButtonFrequancyDataCancel.Size = new System.Drawing.Size(63, 23);
            this.ButtonFrequancyDataCancel.TabIndex = 4;
            this.ButtonFrequancyDataCancel.Text = "Отмена";
            this.ButtonFrequancyDataCancel.UseVisualStyleBackColor = true;
            this.ButtonFrequancyDataCancel.Click += new System.EventHandler(this.ButtonFrequancyDataCancel_Click);
            // 
            // ButtonFrequancyDataDraw
            // 
            this.ButtonFrequancyDataDraw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonFrequancyDataDraw.Location = new System.Drawing.Point(162, 102);
            this.ButtonFrequancyDataDraw.Name = "ButtonFrequancyDataDraw";
            this.ButtonFrequancyDataDraw.Size = new System.Drawing.Size(75, 23);
            this.ButtonFrequancyDataDraw.TabIndex = 3;
            this.ButtonFrequancyDataDraw.Text = "Построить";
            this.ButtonFrequancyDataDraw.UseVisualStyleBackColor = true;
            this.ButtonFrequancyDataDraw.Click += new System.EventHandler(this.ButtonFrequancyDataDraw_Click);
            // 
            // LabelFrequancyDataColumnName
            // 
            this.LabelFrequancyDataColumnName.AutoSize = true;
            this.LabelFrequancyDataColumnName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelFrequancyDataColumnName.Location = new System.Drawing.Point(15, 70);
            this.LabelFrequancyDataColumnName.Name = "LabelFrequancyDataColumnName";
            this.LabelFrequancyDataColumnName.Size = new System.Drawing.Size(112, 15);
            this.LabelFrequancyDataColumnName.TabIndex = 1;
            this.LabelFrequancyDataColumnName.Text = "Название столбца:";
            // 
            // LabelFrequancyDataDraw
            // 
            this.LabelFrequancyDataDraw.AutoSize = true;
            this.LabelFrequancyDataDraw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFrequancyDataDraw.Location = new System.Drawing.Point(14, 10);
            this.LabelFrequancyDataDraw.Name = "LabelFrequancyDataDraw";
            this.LabelFrequancyDataDraw.Size = new System.Drawing.Size(146, 19);
            this.LabelFrequancyDataDraw.TabIndex = 0;
            this.LabelFrequancyDataDraw.Text = "Построение графика:\r\n";
            // 
            // PanelBySelectedArea
            // 
            this.PanelBySelectedArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBySelectedArea.Controls.Add(this.LabelBySelectedAreaInfo);
            this.PanelBySelectedArea.Controls.Add(this.ButtonBySelectedAreaCancel);
            this.PanelBySelectedArea.Controls.Add(this.ButtonBySelectedAreaDraw);
            this.PanelBySelectedArea.Controls.Add(this.LabelBuildDiagram);
            this.PanelBySelectedArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelBySelectedArea.Location = new System.Drawing.Point(760, 25);
            this.PanelBySelectedArea.Name = "PanelBySelectedArea";
            this.PanelBySelectedArea.Size = new System.Drawing.Size(0, 502);
            this.PanelBySelectedArea.TabIndex = 7;
            // 
            // LabelBySelectedAreaInfo
            // 
            this.LabelBySelectedAreaInfo.AutoSize = true;
            this.LabelBySelectedAreaInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelBySelectedAreaInfo.Location = new System.Drawing.Point(14, 47);
            this.LabelBySelectedAreaInfo.Name = "LabelBySelectedAreaInfo";
            this.LabelBySelectedAreaInfo.Size = new System.Drawing.Size(212, 38);
            this.LabelBySelectedAreaInfo.TabIndex = 5;
            this.LabelBySelectedAreaInfo.Text = "Выделите область в таблице и \r\nнажмите построить.";
            // 
            // ButtonBySelectedAreaCancel
            // 
            this.ButtonBySelectedAreaCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonBySelectedAreaCancel.Location = new System.Drawing.Point(90, 99);
            this.ButtonBySelectedAreaCancel.Name = "ButtonBySelectedAreaCancel";
            this.ButtonBySelectedAreaCancel.Size = new System.Drawing.Size(63, 23);
            this.ButtonBySelectedAreaCancel.TabIndex = 4;
            this.ButtonBySelectedAreaCancel.Text = "Отмена";
            this.ButtonBySelectedAreaCancel.UseVisualStyleBackColor = true;
            this.ButtonBySelectedAreaCancel.Click += new System.EventHandler(this.ButtonBySelectedAreaCancel_Click);
            // 
            // ButtonBySelectedAreaDraw
            // 
            this.ButtonBySelectedAreaDraw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonBySelectedAreaDraw.Location = new System.Drawing.Point(159, 99);
            this.ButtonBySelectedAreaDraw.Name = "ButtonBySelectedAreaDraw";
            this.ButtonBySelectedAreaDraw.Size = new System.Drawing.Size(78, 23);
            this.ButtonBySelectedAreaDraw.TabIndex = 3;
            this.ButtonBySelectedAreaDraw.Text = "Построить";
            this.ButtonBySelectedAreaDraw.UseVisualStyleBackColor = true;
            this.ButtonBySelectedAreaDraw.Click += new System.EventHandler(this.ButtonBySelectedAreaDraw_Click);
            // 
            // LabelBuildDiagram
            // 
            this.LabelBuildDiagram.AutoSize = true;
            this.LabelBuildDiagram.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelBuildDiagram.Location = new System.Drawing.Point(14, 10);
            this.LabelBuildDiagram.Name = "LabelBuildDiagram";
            this.LabelBuildDiagram.Size = new System.Drawing.Size(166, 19);
            this.LabelBuildDiagram.TabIndex = 0;
            this.LabelBuildDiagram.Text = "Построиение диграммы";
            // 
            // PanelNumericalCharacteristics
            // 
            this.PanelNumericalCharacteristics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelNumericalCharacteristics.Controls.Add(this.ButtonNumericalCharacteristicsCancel);
            this.PanelNumericalCharacteristics.Controls.Add(this.ButtonNumericalCharacteristicsCalculate);
            this.PanelNumericalCharacteristics.Controls.Add(this.LabelNumericalCharacteristicsResult);
            this.PanelNumericalCharacteristics.Controls.Add(this.LabelNumericalCharacteristicsColumnNames);
            this.PanelNumericalCharacteristics.Controls.Add(this.ComboBoxNumericalCharacteristicsColumnNames);
            this.PanelNumericalCharacteristics.Controls.Add(this.LabelNumericalCharacteristics);
            this.PanelNumericalCharacteristics.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelNumericalCharacteristics.Location = new System.Drawing.Point(760, 25);
            this.PanelNumericalCharacteristics.Name = "PanelNumericalCharacteristics";
            this.PanelNumericalCharacteristics.Size = new System.Drawing.Size(0, 502);
            this.PanelNumericalCharacteristics.TabIndex = 8;
            // 
            // ButtonNumericalCharacteristicsCancel
            // 
            this.ButtonNumericalCharacteristicsCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonNumericalCharacteristicsCancel.Location = new System.Drawing.Point(87, 80);
            this.ButtonNumericalCharacteristicsCancel.Name = "ButtonNumericalCharacteristicsCancel";
            this.ButtonNumericalCharacteristicsCancel.Size = new System.Drawing.Size(63, 23);
            this.ButtonNumericalCharacteristicsCancel.TabIndex = 6;
            this.ButtonNumericalCharacteristicsCancel.Text = "Закрыть";
            this.ButtonNumericalCharacteristicsCancel.UseVisualStyleBackColor = true;
            this.ButtonNumericalCharacteristicsCancel.Click += new System.EventHandler(this.ButtonNumericalCharacteristicsCancel_Click);
            // 
            // ButtonNumericalCharacteristicsCalculate
            // 
            this.ButtonNumericalCharacteristicsCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonNumericalCharacteristicsCalculate.Location = new System.Drawing.Point(156, 80);
            this.ButtonNumericalCharacteristicsCalculate.Name = "ButtonNumericalCharacteristicsCalculate";
            this.ButtonNumericalCharacteristicsCalculate.Size = new System.Drawing.Size(78, 23);
            this.ButtonNumericalCharacteristicsCalculate.TabIndex = 5;
            this.ButtonNumericalCharacteristicsCalculate.Text = "Рассчитать";
            this.ButtonNumericalCharacteristicsCalculate.UseVisualStyleBackColor = true;
            this.ButtonNumericalCharacteristicsCalculate.Click += new System.EventHandler(this.ButtonNumericalCharacteristicsCalculate_Click);
            // 
            // LabelNumericalCharacteristicsResult
            // 
            this.LabelNumericalCharacteristicsResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNumericalCharacteristicsResult.Location = new System.Drawing.Point(14, 112);
            this.LabelNumericalCharacteristicsResult.Name = "LabelNumericalCharacteristicsResult";
            this.LabelNumericalCharacteristicsResult.Size = new System.Drawing.Size(220, 177);
            this.LabelNumericalCharacteristicsResult.TabIndex = 3;
            // 
            // LabelNumericalCharacteristicsColumnNames
            // 
            this.LabelNumericalCharacteristicsColumnNames.AutoSize = true;
            this.LabelNumericalCharacteristicsColumnNames.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNumericalCharacteristicsColumnNames.Location = new System.Drawing.Point(15, 50);
            this.LabelNumericalCharacteristicsColumnNames.Name = "LabelNumericalCharacteristicsColumnNames";
            this.LabelNumericalCharacteristicsColumnNames.Size = new System.Drawing.Size(112, 15);
            this.LabelNumericalCharacteristicsColumnNames.TabIndex = 2;
            this.LabelNumericalCharacteristicsColumnNames.Text = "Название столбца:";
            // 
            // ComboBoxNumericalCharacteristicsColumnNames
            // 
            this.ComboBoxNumericalCharacteristicsColumnNames.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxNumericalCharacteristicsColumnNames.FormattingEnabled = true;
            this.ComboBoxNumericalCharacteristicsColumnNames.Location = new System.Drawing.Point(133, 46);
            this.ComboBoxNumericalCharacteristicsColumnNames.Name = "ComboBoxNumericalCharacteristicsColumnNames";
            this.ComboBoxNumericalCharacteristicsColumnNames.Size = new System.Drawing.Size(101, 23);
            this.ComboBoxNumericalCharacteristicsColumnNames.TabIndex = 1;
            // 
            // LabelNumericalCharacteristics
            // 
            this.LabelNumericalCharacteristics.AutoSize = true;
            this.LabelNumericalCharacteristics.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelNumericalCharacteristics.Location = new System.Drawing.Point(14, 10);
            this.LabelNumericalCharacteristics.Name = "LabelNumericalCharacteristics";
            this.LabelNumericalCharacteristics.Size = new System.Drawing.Size(181, 19);
            this.LabelNumericalCharacteristics.TabIndex = 0;
            this.LabelNumericalCharacteristics.Text = "Числовые характеристики";
            // 
            // PanelDependency
            // 
            this.PanelDependency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDependency.Controls.Add(this.ButtonDependencyCancel);
            this.PanelDependency.Controls.Add(this.ButtonlDependencyDraw);
            this.PanelDependency.Controls.Add(this.LabelDependencyColumnX);
            this.PanelDependency.Controls.Add(this.ComboBoxDependencyColumnX);
            this.PanelDependency.Controls.Add(this.LabelDependencyColumnY);
            this.PanelDependency.Controls.Add(this.ComboBoxDependencyColumnY);
            this.PanelDependency.Controls.Add(this.LabelDependency);
            this.PanelDependency.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDependency.Location = new System.Drawing.Point(760, 25);
            this.PanelDependency.Name = "PanelDependency";
            this.PanelDependency.Size = new System.Drawing.Size(0, 502);
            this.PanelDependency.TabIndex = 9;
            // 
            // ButtonDependencyCancel
            // 
            this.ButtonDependencyCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonDependencyCancel.Location = new System.Drawing.Point(87, 108);
            this.ButtonDependencyCancel.Name = "ButtonDependencyCancel";
            this.ButtonDependencyCancel.Size = new System.Drawing.Size(63, 23);
            this.ButtonDependencyCancel.TabIndex = 6;
            this.ButtonDependencyCancel.Text = "Отмена";
            this.ButtonDependencyCancel.UseVisualStyleBackColor = true;
            this.ButtonDependencyCancel.Click += new System.EventHandler(this.ButtonDependencyCancel_Click);
            // 
            // ButtonlDependencyDraw
            // 
            this.ButtonlDependencyDraw.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonlDependencyDraw.Location = new System.Drawing.Point(156, 108);
            this.ButtonlDependencyDraw.Name = "ButtonlDependencyDraw";
            this.ButtonlDependencyDraw.Size = new System.Drawing.Size(78, 23);
            this.ButtonlDependencyDraw.TabIndex = 5;
            this.ButtonlDependencyDraw.Text = "Построить";
            this.ButtonlDependencyDraw.UseVisualStyleBackColor = true;
            this.ButtonlDependencyDraw.Click += new System.EventHandler(this.ButtonlDependencyDraw_Click);
            // 
            // LabelDependencyColumnX
            // 
            this.LabelDependencyColumnX.AutoSize = true;
            this.LabelDependencyColumnX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelDependencyColumnX.Location = new System.Drawing.Point(15, 78);
            this.LabelDependencyColumnX.Name = "LabelDependencyColumnX";
            this.LabelDependencyColumnX.Size = new System.Drawing.Size(113, 15);
            this.LabelDependencyColumnX.TabIndex = 4;
            this.LabelDependencyColumnX.Text = "Столбец для очи X:";
            // 
            // ComboBoxDependencyColumnX
            // 
            this.ComboBoxDependencyColumnX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxDependencyColumnX.FormattingEnabled = true;
            this.ComboBoxDependencyColumnX.Location = new System.Drawing.Point(133, 74);
            this.ComboBoxDependencyColumnX.Name = "ComboBoxDependencyColumnX";
            this.ComboBoxDependencyColumnX.Size = new System.Drawing.Size(101, 23);
            this.ComboBoxDependencyColumnX.TabIndex = 3;
            // 
            // LabelDependencyColumnY
            // 
            this.LabelDependencyColumnY.AutoSize = true;
            this.LabelDependencyColumnY.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LabelDependencyColumnY.Location = new System.Drawing.Point(15, 49);
            this.LabelDependencyColumnY.Name = "LabelDependencyColumnY";
            this.LabelDependencyColumnY.Size = new System.Drawing.Size(113, 15);
            this.LabelDependencyColumnY.TabIndex = 2;
            this.LabelDependencyColumnY.Text = "Столбец для очи Y:";
            // 
            // ComboBoxDependencyColumnY
            // 
            this.ComboBoxDependencyColumnY.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxDependencyColumnY.FormattingEnabled = true;
            this.ComboBoxDependencyColumnY.Location = new System.Drawing.Point(133, 45);
            this.ComboBoxDependencyColumnY.Name = "ComboBoxDependencyColumnY";
            this.ComboBoxDependencyColumnY.Size = new System.Drawing.Size(101, 23);
            this.ComboBoxDependencyColumnY.TabIndex = 1;
            // 
            // LabelDependency
            // 
            this.LabelDependency.AutoSize = true;
            this.LabelDependency.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LabelDependency.Location = new System.Drawing.Point(14, 10);
            this.LabelDependency.Name = "LabelDependency";
            this.LabelDependency.Size = new System.Drawing.Size(142, 19);
            this.LabelDependency.TabIndex = 0;
            this.LabelDependency.Text = "График зависимости";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 527);
            this.Controls.Add(this.PanelDependency);
            this.Controls.Add(this.PanelNumericalCharacteristics);
            this.Controls.Add(this.PanelBySelectedArea);
            this.Controls.Add(this.PanelFrequancyData);
            this.Controls.Add(this.PanelDeletingRow);
            this.Controls.Add(this.PanelDeletingColumn);
            this.Controls.Add(this.PanelInsertingColumn);
            this.Controls.Add(this.PanelInsertingRow);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ табличных данных";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.PanelInsertingRow.ResumeLayout(false);
            this.PanelInsertingRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRowPosition)).EndInit();
            this.PanelInsertingColumn.ResumeLayout(false);
            this.PanelInsertingColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownColumnPosition)).EndInit();
            this.PanelDeletingColumn.ResumeLayout(false);
            this.PanelDeletingColumn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDeleteColumnPosition)).EndInit();
            this.PanelDeletingRow.ResumeLayout(false);
            this.PanelDeletingRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDeletingRowPosition)).EndInit();
            this.PanelFrequancyData.ResumeLayout(false);
            this.PanelFrequancyData.PerformLayout();
            this.PanelBySelectedArea.ResumeLayout(false);
            this.PanelBySelectedArea.PerformLayout();
            this.PanelNumericalCharacteristics.ResumeLayout(false);
            this.PanelNumericalCharacteristics.PerformLayout();
            this.PanelDependency.ResumeLayout(false);
            this.PanelDependency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpenTable;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpenSchedule;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveTable;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveTableAs;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileCloseTable;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditInsertRow;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditInsertColumn;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditDeleteColumn;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAnalisys;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFrequancyData;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNumericalCharacteristics;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDependency;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBySelectedArea;
        private System.Windows.Forms.Panel PanelInsertingRow;
        private System.Windows.Forms.Label LabelRowInserting;
        private System.Windows.Forms.NumericUpDown NumericUpDownRowPosition;
        private System.Windows.Forms.Label LabelRowPosition;
        private System.Windows.Forms.Button ButtonInsertRow;
        private System.Windows.Forms.Button ButtonCancelInsertingRow;
        private System.Windows.Forms.Panel PanelInsertingColumn;
        private System.Windows.Forms.Label LabelColumnName;
        private System.Windows.Forms.TextBox TextBoxColumnName;
        private System.Windows.Forms.Button ButtonCancelInsertingColumn;
        private System.Windows.Forms.NumericUpDown NumericUpDownColumnPosition;
        private System.Windows.Forms.Label LabelColumnPosition;
        private System.Windows.Forms.Button ButtonInsertColumn;
        private System.Windows.Forms.Label LabelColumnInserting;
        private System.Windows.Forms.Panel PanelDeletingColumn;
        private System.Windows.Forms.Label LabelDeletingColumnName;
        private System.Windows.Forms.Button ButtonCancelDeletingColumn;
        private System.Windows.Forms.NumericUpDown NumericUpDownDeleteColumnPosition;
        private System.Windows.Forms.Label LabelDeletingColumnPosition;
        private System.Windows.Forms.Button ButtonDeleteColumn;
        private System.Windows.Forms.Label LabelDeletingColumn;
        private System.Windows.Forms.ComboBox ComboBoxColumnName;
        private System.Windows.Forms.RadioButton RadioButtonDeleteByName;
        private System.Windows.Forms.RadioButton RadioButtonDeleteByIndex;
        private System.Windows.Forms.Panel PanelDeletingRow;
        private System.Windows.Forms.Button ButtonCancelDeletingRow;
        private System.Windows.Forms.NumericUpDown NumericUpDownDeletingRowPosition;
        private System.Windows.Forms.Label LabelDeletingRowPosition;
        private System.Windows.Forms.Button ButtonDeleteRow;
        private System.Windows.Forms.Label LabelDeletingRow;
        private System.Windows.Forms.Panel PanelFrequancyData;
        private System.Windows.Forms.Button ButtonFrequancyDataCancel;
        private System.Windows.Forms.Button ButtonFrequancyDataDraw;
        private System.Windows.Forms.Label LabelFrequancyDataColumnName;
        private System.Windows.Forms.Label LabelFrequancyDataDraw;
        private System.Windows.Forms.Label LabelFrequancyData;
        private System.Windows.Forms.ComboBox ComboBoxFrequancyDataColumnName;
        private System.Windows.Forms.Panel PanelBySelectedArea;
        private System.Windows.Forms.Label LabelBuildDiagram;
        private System.Windows.Forms.Label LabelBySelectedAreaInfo;
        private System.Windows.Forms.Panel PanelNumericalCharacteristics;
        private System.Windows.Forms.Label LabelNumericalCharacteristics;
        private System.Windows.Forms.ComboBox ComboBoxNumericalCharacteristicsColumnNames;
        private System.Windows.Forms.Label LabelNumericalCharacteristicsColumnNames;
        private System.Windows.Forms.Label LabelNumericalCharacteristicsResult;
        private System.Windows.Forms.Panel PanelDependency;
        private System.Windows.Forms.Label LabelDependencyColumnX;
        private System.Windows.Forms.ComboBox ComboBoxDependencyColumnX;
        private System.Windows.Forms.Label LabelDependencyColumnY;
        private System.Windows.Forms.ComboBox ComboBoxDependencyColumnY;
        private System.Windows.Forms.Label LabelDependency;
        private System.Windows.Forms.Button ButtonDependencyCancel;
        private System.Windows.Forms.Button ButtonlDependencyDraw;
        private System.Windows.Forms.Button ButtonBySelectedAreaCancel;
        private System.Windows.Forms.Button ButtonBySelectedAreaDraw;
        private System.Windows.Forms.Button ButtonNumericalCharacteristicsCancel;
        private System.Windows.Forms.Button ButtonNumericalCharacteristicsCalculate;
    }
}

