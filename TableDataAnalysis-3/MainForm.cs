using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableDataAnalysis
{
    public partial class MainForm : Form
    {
        private bool save;  // Сохранен ли график
        private string path;  // Путь к файлу
        private readonly Dictionary<Panel, Task> panelsTasks;  // Панели управления и задачи
        private Task switchTask;  // Здача переключения панелей

        public MainForm()
        {
            InitializeComponent();
            switchTask = null;
            save = true;
            path = string.Empty;
            panelsTasks = new Dictionary<Panel, Task>  // Панели управления
            {
                { PanelInsertingRow, null },
                { PanelInsertingColumn, null },
                { PanelDeletingColumn, null },
                { PanelDeletingRow, null },
                { PanelFrequancyData, null },
                { PanelBySelectedArea, null },
                { PanelDependency, null },
                { PanelNumericalCharacteristics, null}
            };
        }

        // При нажатии пункта меню "Выход"
        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            if (!save)
            {
                var ansver = MessageBox.Show("Желаете сохранить таблицу перед закрытием?", "Таблица не сохранена!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (ansver)
                {
                    case DialogResult.Yes:
                        MenuItemFileSaveTable_Click(this, EventArgs.Empty);
                        Close();
                        break;
                    case DialogResult.No:
                        Close();
                        break;
                }
            }
        }

        // Загрузка таблицы
        private void LoadTable()
        {
            using (var textFieldParser = new TextFieldParser(path))
            {
                textFieldParser.SetDelimiters(",");
                if (!textFieldParser.EndOfData)
                {
                    string[] fields = textFieldParser.ReadFields();
                    for (int i = 0; i < fields.Count(); i++)
                    {
                        var column = Table.Columns[Table.Columns.Add(fields[i], fields[i])];
                        column.AutoSizeMode = (Table.ColumnCount - 1 > i ?
                            DataGridViewAutoSizeColumnMode.AllCells :
                            DataGridViewAutoSizeColumnMode.Fill);
                    }
                }
                while (!textFieldParser.EndOfData)
                    Table.Rows.Add(textFieldParser.ReadFields());
            }
        }

        // // При нажатии пункта меню "Открыть таблицу"
        private void MenuItemFileOpenTable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panelsTasks.Count; i++)
                panelsTasks.ElementAt(i).Key.Width = 0;
            if (!string.IsNullOrEmpty(path))
            {
                if (!save)
                {
                    var ansver = MessageBox.Show("Желаете сохранить таблицу перед открытием другой?", "Таблица не сохранена!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    switch (ansver)
                    {
                        case DialogResult.Yes:
                            MenuItemFileSaveTable_Click(this, EventArgs.Empty);
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
            }
            using (var form = new OpenFileDialog() { Filter = "Таблицы (*.csv)|*.csv|Все файлы (*.*)|*.*" })
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CloseTable();
                    path = form.FileName;
                    save = true;
                    LoadTable();
                }
            }
        }

        // При нажатии пункта меню "Открыть график"
        private void MenuItemFileOpenSchedule_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog() { Filter = "JSON График (*.json)|*.json" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var json = File.ReadAllText(dialog.FileName);
                    var chart = JsonConvert.DeserializeObject<Chart>(json);
                    var form = new ChartForm(chart);
                    form.Show();
                }
            }
        }

        // При нажатии пункта меню "Сохранить таблицу как"
        private void MenuItemFileSaveTableAs_Click(object sender, EventArgs e)
        {
            using (var form = new SaveFileDialog() { Filter = "Таблицы (*.csv)|*.csv" })
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    path = form.FileName;
                    SaveTable();
                }
            }
        }

        // Сохранение таблицы
        private void SaveTable()
        {
            using (var streamWriter = new StreamWriter(path))
            {
                for (int i = 0; i < Table.ColumnCount; i++)
                {
                    streamWriter.Write($"\"{ Table.Columns[i].HeaderText }\"");
                    if (i < Table.ColumnCount - 1)
                        streamWriter.Write(", ");
                }
                if (Table.RowCount > 0)
                {
                    streamWriter.Write("\r\n");
                    for (int i = 0; i < Table.RowCount; i++)
                    {
                        for (int j = 0; j < Table.Rows[i].Cells.Count; j++)
                        {
                            streamWriter.Write($"\"{Table.Rows[i].Cells[j].Value}\"");
                            if (j < Table.Rows[i].Cells.Count - 1)
                                streamWriter.Write(", ");
                        }
                        if (i < Table.RowCount - 1)
                            streamWriter.Write("\r\n");
                    }
                }
            }
            save = true;
        }

        // Закрытие таблицы
        private void CloseTable()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            path = "";
            save = true;
        }

        // При нажатии пункта меню "Закрыть"
        private void MenuItemFileCloseTable_Click(object sender, EventArgs e)
        {
            if (!save)
            {
                var ansver = MessageBox.Show("Желаете сохранить таблицу перед закрытием?", "Таблица не сохранена!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (ansver)
                {
                    case DialogResult.Yes:
                        MenuItemFileSaveTable_Click(this, EventArgs.Empty);
                        CloseTable();
                        break;
                    case DialogResult.No:
                        CloseTable();
                        break;
                }
            }
            else
                CloseTable();
        }

        // При нажатии пункта меню "Сохранить как"
        private void MenuItemFileSaveTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
                MenuItemFileSaveTableAs_Click(this, EventArgs.Empty);
            if (!string.IsNullOrEmpty(path))
                SaveTable();
        }

        // Сортировка таблицы
        private void Table_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.HeaderCell.SortGlyphDirection == SortOrder.None)
            {
                if (double.TryParse(e.CellValue1.ToString(), out double first) &&
                  double.TryParse(e.CellValue2.ToString(), out double second))
                    e.SortResult = second.CompareTo(first);
                else
                    e.SortResult = string.Compare(e.CellValue2.ToString(), e.CellValue1.ToString());
                e.Handled = true;
            }
            else if (e.Column.HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                if (double.TryParse(e.CellValue1.ToString(), out double first) &&
                  double.TryParse(e.CellValue2.ToString(), out double second))
                    e.SortResult = first.CompareTo(second);
                else
                    e.SortResult = string.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
                e.Handled = true;
            }
        }

        // При редактировании таблицы
        private void Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            save = false;
        }

        // Выбор панели
        private void SelectPanel(Panel panel)
        {
            if (switchTask == null)
            {
                switchTask = Task.Run(() =>
                {
                    lock (panelsTasks)
                    {
                        for (int i = 0; i < panelsTasks.Count; i++)
                            if (panelsTasks.ElementAt(i).Key != panel)
                                DisablePanel(panelsTasks.ElementAt(i).Key, false);
                    }
                    EnablePanel(panel);
                    switchTask = null;
                });
            }
        }

        // Выключение панели
        private void DisablePanel(Panel panel, bool async = true)
        {
            var task = Task.Run(() =>
            {
                if (panelsTasks[panel] != null)
                    panelsTasks[panel].Wait();
                panelsTasks[panel] = Task.Run(() =>
                {
                    while (true)
                    {
                        int width = 0;
                        try
                        {
                            Invoke(new Action(() => width = panel.Width));
                            if (Math.Abs(width) > 4)
                                Invoke(new Action(() => panel.Width += (0 - panel.Width) / 4));
                            else
                            {
                                Invoke(new Action(() => panel.Width = 0));
                                break;
                            }
                        }
                        catch
                        {
                            break;
                        }
                        Thread.Sleep(1);
                    }
                });
                if (!async)
                    panelsTasks[panel].Wait();
            });
            if (!async)
                task.Wait();
        }

        // Включение панели
        private void EnablePanel(Panel panel)
        {
            Task.Run(() =>
            {
                if (panelsTasks[panel] != null)
                    panelsTasks[panel].Wait();
                panelsTasks[panel] = Task.Run(() =>
                {
                    while (true)
                    {
                        int width = 0;
                        try
                        {
                            Invoke(new Action(() => width = panel.Width));
                            if (Math.Abs(width - 250) > 5)
                                Invoke(new Action(() => panel.Width += (250 - panel.Width) / 5));
                            else
                            {
                                Invoke(new Action(() => panel.Width = 250));
                                break;
                            }
                        }
                        catch
                        {
                            break;
                        }
                        Thread.Sleep(1);
                    }
                });
            });
        }

        // При нажатии пункта меню "Вставка строки"
        private void MenuItemEditInsertRow_Click(object sender, EventArgs e)
        {
            NumericUpDownRowPosition.Maximum = Table.RowCount;
            NumericUpDownRowPosition.Value = NumericUpDownRowPosition.Maximum;
            SelectPanel(PanelInsertingRow);
        }

        // При нажатии кнопки "Закрыть" (Вставка строки)
        private void ButtonCancelInsertingRow_Click(object sender, EventArgs e)
        {
            DisablePanel(PanelInsertingRow);
        }

        // При нажатии кнопки "Вставить" (Вставка строки)
        private void ButtonInsertRow_Click(object sender, EventArgs e)
        {
            if (Table.ColumnCount > 0)
            {
                Table.Rows.Insert((int)NumericUpDownRowPosition.Value);
                NumericUpDownRowPosition.Maximum++;
                NumericUpDownRowPosition.Value++;
            }
            else
                MessageBox.Show("Сначала добавьте хотя бы один столбец!", "Таблица не содержит столбцов!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // При нажатии пункта менб "Вставка столбца"
        private void MenuItemEditInsertColumn_Click(object sender, EventArgs e)
        {
            NumericUpDownColumnPosition.Maximum = Table.ColumnCount;
            NumericUpDownColumnPosition.Value = NumericUpDownColumnPosition.Maximum;
            SelectPanel(PanelInsertingColumn);
        }

        // При нажатии кнопки "Закрыть" (Вставка столбца)
        private void ButtonCancelInsertingColumn_Click(object sender, EventArgs e)
        {
            DisablePanel(PanelInsertingColumn);
        }

        // При нажатии кнопки "Вставить" (Вставка столбца)
        private void ButtonInsertColumn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxColumnName.Text))
            {
                Table.Columns.Insert((int)NumericUpDownColumnPosition.Value, new DataGridViewTextBoxColumn()
                {
                    Name = TextBoxColumnName.Text,
                    HeaderText = TextBoxColumnName.Text
                });
                Table.Columns[(int)NumericUpDownColumnPosition.Value].AutoSizeMode =
                    (int)NumericUpDownColumnPosition.Value == Table.Columns.Count - 1 ?
                    DataGridViewAutoSizeColumnMode.Fill :
                    DataGridViewAutoSizeColumnMode.AllCells;
                NumericUpDownColumnPosition.Maximum++;
                NumericUpDownColumnPosition.Value++;
                TextBoxColumnName.Text = "";
            }
            else
                MessageBox.Show("Введите название столбца!", "Название столбца не введено!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // При переключении типа удаления (Удаление столбца)
        private void RadioByttonsDeleteBy_Checked(object sender, EventArgs e)
        {
            if (RadioButtonDeleteByName.Checked)
            {
                ComboBoxColumnName.Enabled = true;
                NumericUpDownDeleteColumnPosition.Enabled = false;
            }
            else if (RadioButtonDeleteByIndex.Checked)
            {
                ComboBoxColumnName.Enabled = false;
                NumericUpDownDeleteColumnPosition.Enabled = true;
            }
        }

        // При нажатии пункта меню "Удалить столбец"
        private void MenuItemEditDeleteColumn_Click(object sender, EventArgs e)
        {
            NumericUpDownDeleteColumnPosition.Maximum = Table.ColumnCount;
            NumericUpDownDeleteColumnPosition.Value = NumericUpDownDeleteColumnPosition.Maximum;
            ComboBoxColumnName.Items.Clear();
            ComboBoxColumnName.Items.AddRange(Table.Columns
                .Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToArray());
            SelectPanel(PanelDeletingColumn);
        }

        // При нажатии кнопки "Закрыть" (Удаление столбца)
        private void ButtonCancelDeletingColumn_Click(object sender, EventArgs e)
        {
            DisablePanel(PanelDeletingColumn);
        }

        // При нажатии кнопки "Удалить" (Удаление столбца)
        private void ButtonDeleteColumn_Click(object sender, EventArgs e)
        {
            if (RadioButtonDeleteByName.Checked)
            {
                if (ComboBoxColumnName.SelectedIndex != -1)
                {
                    Table.Columns.RemoveAt(ComboBoxColumnName.SelectedIndex);
                    ComboBoxColumnName.Items.Clear();
                    ComboBoxColumnName.Items.AddRange(Table.Columns
                        .Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToArray());
                    ComboBoxColumnName.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("Введите название столбца либо выберите в выпадающем списке!", "Название столбца не введено!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RadioButtonDeleteByIndex.Checked)
            {
                if (Table.Columns.Count > 0)
                    Table.Columns.RemoveAt((int)NumericUpDownDeleteColumnPosition.Value);
            }
        }

        // При нажатии пункта меню "Удаление строки"
        private void MenuItemEditDeleteRow_Click(object sender, EventArgs e)
        {
            NumericUpDownDeletingRowPosition.Maximum = Table.RowCount - 1;
            NumericUpDownDeletingRowPosition.Value = NumericUpDownDeletingRowPosition.Maximum;
            SelectPanel(PanelDeletingRow);
        }

        // При нажатии кнопки "Закрыть" (Удаление строки)
        private void ButtonCancelDeletingRow_Click(object sender, EventArgs e)
        {
            DisablePanel(PanelDeletingRow);
        }

        // При нажатии кнопки "Удалить" (Удаление строки)
        private void ButtonDeleteRow_Click(object sender, EventArgs e)
        {
            if (Table.Rows.Count > 0 && (int)NumericUpDownDeletingRowPosition.Value < Table.Rows.Count)
            {
                Table.Rows.RemoveAt((int)NumericUpDownDeletingRowPosition.Value);
                NumericUpDownDeletingRowPosition.Value -= NumericUpDownDeletingRowPosition.Value > 0 ? 1 : 0;
                NumericUpDownDeletingRowPosition.Maximum -= NumericUpDownDeletingRowPosition.Maximum > 0 ? 1 : 0;
            }
        }

        // При нажатии пункта меню "Частота встречаемости данных"
        private void MenuItemFrequancyData_Click(object sender, EventArgs e)
        {
            ComboBoxFrequancyDataColumnName.Items.Clear();
            ComboBoxFrequancyDataColumnName.Items.AddRange(Table.Columns
              .Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToArray());
            SelectPanel(PanelFrequancyData);
        }

        // При нажатии кнопки "Отмена" (Частота встречаемости данных)
        private void ButtonFrequancyDataCancel_Click(object sender, EventArgs e)
        {
            DisablePanel(PanelFrequancyData);
        }

        // При нажатии кнопки "Построить" (Частота встречаемости данных)
        private void ButtonFrequancyDataDraw_Click(object sender, EventArgs e)
        {
            if (ComboBoxFrequancyDataColumnName.SelectedIndex != -1)
            {
                List<string> data = new List<string>();
                for (int i = 0; i < Table.RowCount; i++)
                    data.Add(Table.Rows[i].Cells[ComboBoxFrequancyDataColumnName.SelectedIndex].Value.ToString());
                var form = new ChartForm(data);
                form.Show();

                ComboBoxFrequancyDataColumnName.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Введите название столбца либо выберите в выпадающем списке!", "Название столбца не введено!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuItemBySelectedArea_Click(object sender, EventArgs e)
        {
            SelectPanel(PanelBySelectedArea);
        }

        private void ButtonBySelectedAreaCancel_Click(object sender, EventArgs e)
        {
            DisablePanel(PanelBySelectedArea);
        }

        private void ButtonBySelectedAreaDraw_Click(object sender, EventArgs e)
        {
            if (Table.SelectedCells.Count == 0)
                MessageBox.Show("Выделить облать для построение диграммы!", "Область не выделена!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var rows = new List<string>();
                var columns = new List<string>();
                var rowsIndeces = new List<int>();
                var columnsIndeces = new List<int>();
                var values = new List<List<float>>();

                var cells = Table.SelectedCells.Cast<DataGridViewCell>().ToArray();
                var maxColumn = cells.OrderByDescending(x => x.ColumnIndex).FirstOrDefault().ColumnIndex;
                var minColumn = cells.OrderBy(x => x.ColumnIndex).FirstOrDefault().ColumnIndex;
                var maxRow = cells.OrderByDescending(x => x.RowIndex).FirstOrDefault().RowIndex;
                var minRow = cells.OrderBy(x => x.RowIndex).FirstOrDefault().RowIndex;

                for (int i = minColumn + 1; i <= maxColumn; i++)
                {
                    if (cells.Where(x => x.ColumnIndex == i).FirstOrDefault() != null)
                    {
                        columns.Add(Table.Columns[i].HeaderText);
                        columnsIndeces.Add(i);
                    }
                }

                for (int i = minRow; i <= maxRow; i++)
                {
                    if (cells.Where(x => x.RowIndex == i).FirstOrDefault() != null)
                    {
                        rows.Add(Table.Rows[i].Cells[minColumn].Value.ToString());
                        rowsIndeces.Add(i);                
                    }
                }             
                       
                for (int i = 0; i < columnsIndeces.Count; i++)
                {
                    for (int j = 0; j < rowsIndeces.Count; j++)
                    {
                        values.Add(new List<float>());
                        var cell = cells.Where(x => x.ColumnIndex == columnsIndeces[i] && x.RowIndex == rowsIndeces[j]).FirstOrDefault();
                        if (!double.TryParse(cell.Value.ToString(), out double _))
                        {
                            MessageBox.Show("Выделенная облать должна содержать только числовые значение!", "Некорректная область!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        values[i].Add(float.Parse(cell.Value.ToString()));
                    }
                }

                if (values.Count == 0)
                {
                    MessageBox.Show("Выделенная должна содержать больше одного столбца!", "Некорректная область!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            
                var form = new ChartForm(columns, rows, values);
                form.Show();
            }
        }

        private void MenuItemDependency_Click(object sender, EventArgs e)
        {
            ComboBoxDependencyColumnX.Items.Clear();
            ComboBoxDependencyColumnX.Items.AddRange(Table.Columns
                .Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToArray());
            ComboBoxDependencyColumnY.Items.Clear();
            ComboBoxDependencyColumnY.Items.AddRange(Table.Columns
                .Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToArray());
            SelectPanel(PanelDependency);
        }

        private void MenuItemNumericalCharacteristics_Click(object sender, EventArgs e)
        {
            ComboBoxNumericalCharacteristicsColumnNames.Items.Clear();
            ComboBoxNumericalCharacteristicsColumnNames.Items.AddRange(Table.Columns
                .Cast<DataGridViewColumn>().Select(x => x.HeaderText).ToArray());
            SelectPanel(PanelNumericalCharacteristics);
        }

        private void ButtonDependencyCancel_Click(object sender, EventArgs e)
        {
            DisablePanel(PanelDependency);
        }

        private void ButtonNumericalCharacteristicsCancel_Click(object sender, EventArgs e)
        {
            DisablePanel(PanelNumericalCharacteristics);
        }

        private void ButtonNumericalCharacteristicsCalculate_Click(object sender, EventArgs e)
        {
            float[] values = new float[Table.RowCount];
            if (ComboBoxNumericalCharacteristicsColumnNames.SelectedIndex != -1)
            {
                for (int i = 0; i < Table.RowCount; i++)
                {
                    if (!float.TryParse(Table.Rows[i].Cells[ComboBoxNumericalCharacteristicsColumnNames.SelectedIndex].Value.ToString(), out values[i]))
                    {
                        LabelNumericalCharacteristicsResult.Text = "Столбец должен содержать только числовые значения!";
                        return;
                    }
                }

                float avg = 0.0f;
                for (int i = 0; i < values.Length; i++)
                    avg += values[i];
                avg /= values.Length;

                float med = values.OrderBy(x => x).ToArray()[values.Length / 2];
                float des = 0.0f;
                for (int i = 0; i < values.Length; i++)
                    des += (float)Math.Pow(values[i] - avg, 2);
                des /= values.Length;

                float sro = (float)Math.Sqrt(des);

                LabelNumericalCharacteristicsResult.Text = 
                    $"Среднее: {avg}{Environment.NewLine}" +
                    $"Медиана: {med}{Environment.NewLine}" +
                    $"Дисперсия  : {des}{Environment.NewLine}" +
                    $"Среднеквадратичное : {sro}";
            }
            else
                LabelNumericalCharacteristicsResult.Text = "Выберите столбец для начала!";
        }

        private void ButtonlDependencyDraw_Click(object sender, EventArgs e)
        {
            if (ComboBoxDependencyColumnX.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите столбец для оси X!", "Не выбран столбец для оси X!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ComboBoxDependencyColumnY.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите столбец для оси Y!", "Не выбран столбец для оси Y!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ComboBoxDependencyColumnY.SelectedIndex == ComboBoxDependencyColumnX.SelectedIndex)
            {
                MessageBox.Show("Выберите разные столбцы для осей X и Y", "Столбцы оси X и Y совпадают!" ,
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var columnX = Table.Columns[ComboBoxDependencyColumnX.SelectedIndex].HeaderText;
                var columnY = Table.Columns[ComboBoxDependencyColumnY.SelectedIndex].HeaderText;
                var points = new List<PointF>();
                for (int i = 0; i < Table.RowCount; i++)
                {
                    float x, y;
                    float multX = 1.0f, multY = 1.0f;
                    if (Table.Rows[i].Cells[ComboBoxDependencyColumnX.SelectedIndex].Value
                        .ToString().Contains("k"))
                        multX = 1000.0f;
                    if (Table.Rows[i].Cells[ComboBoxDependencyColumnY.SelectedIndex].Value
                       .ToString().Contains("k"))
                        multY = 1000.0f;
                    if (!float.TryParse(Table.Rows[i].Cells[ComboBoxDependencyColumnX.SelectedIndex].Value
                        .ToString().Replace(".", ",").Replace("k", ""), out x))
                    {
                        MessageBox.Show("Столбец для оси X должен содержать только числовые значения!",
                            "Столбец для оси X содержит нечисловые значения!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (!float.TryParse(Table.Rows[i].Cells[ComboBoxDependencyColumnY.SelectedIndex].Value
                        .ToString().Replace(".", ",").Replace("k", "000"), out y))
                    {
                        MessageBox.Show("Столбец для оси Y должен содержать только числовые значения!",
                            "Столбец для оси Y содержит нечисловые значения!",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                        points.Add(new PointF(x * multX, y * multY));
                }
                var form = new ChartForm(columnX, columnY, points);
                form.Show();

                ComboBoxDependencyColumnX.SelectedIndex = -1;
                ComboBoxDependencyColumnY.SelectedIndex = -1;
            }
        }

        private void TextBoxColumnName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonInsertColumn_Click(this, EventArgs.Empty);
        }

        private void TextBoxColumnName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для редактирования ячейки таблицы вам необходимо выбрать " +
                "ее посредствод мыши или клавиатуры, для добавления и " +
                "удаления столбцов и строк необходимо воспользоваться " +
                "пунтом меню правка, для анализа табличных данных так же " +
                "существет отдельный пунт меню.",
                           "Помощь",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
