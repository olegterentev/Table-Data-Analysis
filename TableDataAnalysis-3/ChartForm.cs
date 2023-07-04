using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TableDataAnalysis
{
    public partial class ChartForm : Form
    {
        private Color[] colors = new Color[]  // Цвета столбцов
        {
           ColorTranslator.FromHtml("#4F81BD"),
           ColorTranslator.FromHtml("#C0504D"),
           ColorTranslator.FromHtml("#9BBB59"),
           ColorTranslator.FromHtml("#F98D00"),
           ColorTranslator.FromHtml("#B300E8"),
           ColorTranslator.FromHtml("#EAD200")
        };

        public List<List<Column>> Columns { set; get; }  // Столбцы
        public List<string> Rows { set; get; }  // Строки (для выделенной области)
        public List<PointF> Points { set; get; }  // Точки (для графика зависимостей)
        public ChartDrawType Type { set; get; }  // Тип графика
        public string NameX { set; get; }  // Имя оси абсцисс
        public string NameY { set; get; }  // Имя оси ординат

        // Конструктор из объекта Chart (график)
        public ChartForm(Chart chart)
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
              | BindingFlags.Instance | BindingFlags.NonPublic, null,
              Canvas, new object[] { true });
            Canvas.MouseWheel += Canvas_MouseWheel;  // Обработка колесика мыши
            Type = chart.Type;  // Тип графика
            switch (chart.Type)
            {
                case ChartDrawType.Columns:
                    Columns = chart.Columns;  // Столбцы 
                    break;
                case ChartDrawType.Dependence:
                    Points = chart.Points;  // Точки
                    break;
            }
            Rows = chart.Rows;  // Строки
            NumericUpDownColumnWidth.Value = (decimal)chart.ScaleX;  // Ширина столбцов
        }
        
        // Конструктор из списка значений (для отображения частоты)
        public ChartForm(List<string> values)
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null,
                Canvas, new object[] { true });
            Columns = new List<List<Column>>();  // Стобцы
            Type = ChartDrawType.Columns;  // Тип
            Canvas.MouseWheel += Canvas_MouseWheel;  // Обработка колесика мыши
            var colorNumber = (new Random()).Next(colors.Length);   // Цвет столбцов
            for (int i = 0; i < values.Count; i++)
            {
                var column = Columns.Where(x => // Поиск столбца по имени
                {
                    if (x.Count > 0) 
                        return x[0].Name == values[i]; 
                    return false; 
                }).FirstOrDefault();
                if (column == null)  // Если столбец еще не добавлен
                {
                    Columns.Add(new List<Column>() 
                    {
                        new Column()  // Создание столбца
                        {
                            Name = values[i],
                            Value = 1,
                            Color = colors[colorNumber]
                        }
                    });
                }
                else  // Если столбец добавлен
                    column[0].Value++;  // Увеличение састоты
            }
            Rows = new List<string>() { "Частота" };
            NumericUpDownColumnWidth.Value = 20;
        }

        // Конструктор для выделенной области
        public ChartForm(List<string> columns, List<string> rows, List<List<float>> values)
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null,
                Canvas, new object[] { true });
            Canvas.MouseWheel += Canvas_MouseWheel;  // Обработка колесика мыши
            Columns = new List<List<Column>>();  // Столбцы
            Type = ChartDrawType.Columns;  // Тип
            for (int i = 0; i < columns.Count; i++)  // Проход по столбцам
            {
                var list = new List<Column>();
                for (int j = 0; j < values[i].Count; j++)
                {
                    list.Add(new Column()  // Добавление столбца
                    {
                        Name = columns[i],
                        Value = values[i][j],
                        Color = colors[j % colors.Length]
                    });
                }
                Columns.Add(list);
            }
            Rows = rows;  // Строки (подписи сверху)
            NumericUpDownColumnWidth.Value = 20;
        }

        // Конструктор для графика зависимости
        public ChartForm(string columnX, string columnY, List<PointF> points)
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
               | BindingFlags.Instance | BindingFlags.NonPublic, null,
               Canvas, new object[] { true });
            NameX = columnX;  // Имя оси абсцисс
            NameY = columnY;  // Имя оси ординат      
            Canvas.MouseWheel += Canvas_MouseWheel;  // Обработка колесика мыши
            Points = points;  // Точки
            Points = Points.OrderBy(x => x.X).ToList();  // Расположение по порядку (по оси X)
            Type = ChartDrawType.Dependence;  // Тип
            NumericUpDownColumnWidth.Value = 100;
        }
        
        private float RoundUp(float number)
        {
            string value = number.ToString();
            char[] chars = value.ToCharArray();
            if (chars.Length > 1 && chars[1] > '5' || chars.Length == 1)
            {
                chars[0]++;
                if (chars[0] > '9')
                    value = "1" + new string('0', chars.Length);
                else
                    value = chars[0] + new string('0', chars.Length - 1);
            }
            else
                value = chars[0] + "5" + new string('0', chars.Length - 2);
            return float.Parse(value);
        }

        // Найти максимальное значение столбца
        private float GetMaxColumnValue()
        {
            return Columns.OrderByDescending(x => x.OrderByDescending(y => y.Value)
                    .FirstOrDefault().Value).FirstOrDefault()
                    .OrderByDescending(z => z.Value).FirstOrDefault().Value;
        }

        // Найти максимальное значение по X
        private float GetMaxX()
        {
            return Points.OrderByDescending(x => x.X).FirstOrDefault().X;
        }

        // Найти максимальное значение по Y
        private float GetMaxY()
        {
            return Points.OrderByDescending(x => x.Y).FirstOrDefault().Y;
        }

        // Найти минимальное значение по X
        private float GetMinX()
        {
            return Points.OrderBy(x => x.X).FirstOrDefault().X;
        }

        // Обработка колесика мыши
        private void Canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            var value = (float)NumericUpDownColumnWidth.Value;
            value *= e.Delta > 0 ? 1.05f : 0.9f;
            if (value > (float)NumericUpDownColumnWidth.Maximum)
                NumericUpDownColumnWidth.Value = NumericUpDownColumnWidth.Maximum;
            else if (value < (float)NumericUpDownColumnWidth.Minimum)
                NumericUpDownColumnWidth.Value = NumericUpDownColumnWidth.Minimum;
            else
                NumericUpDownColumnWidth.Value = (decimal)value;
        }

        // Среднее количество точек на еденицу графика
        private int AveragePointsForUnit()
        {
            var min = GetMinX();
            var max = GetMaxX();
            var avg = 0.0f;
            var count = 0;
            for (var i = min; i <= max; i++)
            {
                var temp = Points.Where(x => (int)x.X == (int)i).Count();
                if (temp > 0)
                {
                    avg += temp;
                    count++;
                }
            }
            avg /= count;
            return (int)avg;
        }

        // Отрисовка графика
        private void DrawChart(Graphics graphics, bool scrollable = true)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switch (Type)
            {
                case ChartDrawType.Columns:  // Тип - стобцы
                    {
                        var maxColumnValue = RoundUp(GetMaxColumnValue());
                        var drawRegionY = 70.0f;
                        var drawRegionX = 50.0f;
                        var drawRegionHeight = Canvas.ClientSize.Height - drawRegionY - 50.0f;
                        var pixelsPercent = drawRegionHeight / maxColumnValue;
                        var space = 10.0f;
                        var offset = 20.0f;
                        var columnWidth = (float)NumericUpDownColumnWidth.Value - 10;
                        var font = new Font("SegoeUI", 9.0f);
                        var columnMinWidth = 0.0f;
                        for (int i = 0; i < Columns.Count; i++)
                        {
                            var currentSize = graphics.MeasureString(Columns[i][0].Name, font, 100);
                            if (currentSize.Width > columnMinWidth)
                                columnMinWidth = currentSize.Width;
                        }
                        columnMinWidth = Math.Max(30, columnMinWidth);
                        var chartWidth = drawRegionX + Columns.Count * (columnMinWidth + columnWidth + space) + offset + 10.0f;
                        var regionWidth = Canvas.ClientSize.Width;
                        ScrollBar.Maximum = (int)chartWidth;
                        ScrollBar.Minimum = 0;
                        ScrollBar.SmallChange = regionWidth;
                        ScrollBar.LargeChange = regionWidth;
                        if (scrollable)
                            if (ScrollBar.Value != 0)
                                drawRegionX = 50 - ScrollBar.Value;
                        graphics.Clear(Color.White);
                        graphics.DrawLine(Pens.Black,
                                new PointF(drawRegionX, drawRegionY - 5.0f),
                                new PointF(drawRegionX, drawRegionY + drawRegionHeight + 5.0f));
                        int countLines = 10;
                        for (int i = 10; i > 4; i--)
                        {
                            bool comp = true;
                            for (int j = 0; j < i; j++)
                            {
                                if (maxColumnValue / (i - 1) * j % 1 != 0)
                                {
                                    comp = false;
                                    break;
                                }
                            }
                            if (comp)
                            {
                                countLines = i;
                                break;
                            }
                        }
                        for (int i = 0; i < countLines; i++)
                        {
                            graphics.DrawLine(Pens.Black,
                                new PointF(drawRegionX - 5.0f, drawRegionY + drawRegionHeight - (i * drawRegionHeight / (countLines - 1))),
                                new PointF(chartWidth, drawRegionY + drawRegionHeight - (i * drawRegionHeight / (countLines - 1))));
                            var stringFormat = new StringFormat
                            {
                                Alignment = StringAlignment.Far,
                                LineAlignment = StringAlignment.Center
                            };
                            graphics.DrawString((maxColumnValue / (countLines - 1) * i).ToString("0.#"), font, Brushes.Black,
                                new RectangleF(drawRegionX - 50.0f, drawRegionY + drawRegionHeight - (i * drawRegionHeight / (countLines - 1)) - 24.0f,
                                    48.0f, 24.0f), stringFormat);
                        }
                        for (var i = 0; i < Columns.Count; i++)
                        {
                            for (int j = 0; j < Columns[i].Count; j++)
                            {
                                var size = new SizeF(columnMinWidth + columnWidth, Columns[i][j].Value * pixelsPercent);
                                var currentColumnWidth = size.Width / Columns[i].Count;
                                var position = new PointF(drawRegionX + offset + i * (size.Width + space),
                                    drawRegionY + drawRegionHeight - size.Height);
                                var rectangleF = new RectangleF(position.X + j * (currentColumnWidth),
                                    position.Y, currentColumnWidth, size.Height);
                                var stringFormat = new StringFormat
                                {
                                    Alignment = StringAlignment.Center,
                                    LineAlignment = StringAlignment.Near
                                };
                                var rectangleFString = new RectangleF(position.X, drawRegionY + drawRegionHeight + 5, columnMinWidth + columnWidth, 100);
                                graphics.FillRectangle(new SolidBrush(Columns[i][j].Color), rectangleF);
                                graphics.DrawRectangle(Pens.Black, rectangleF);
                                graphics.DrawString(Columns[i][j].Name, font, Brushes.Black, rectangleFString, stringFormat);
                            }
                        }

                        PointF rowsPosition = new PointF(50.0f, 10.0f);
                        for (int i = 0; i < Rows.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(Rows[i]))
                            {
                                var stringFormat = new StringFormat
                                {
                                    Alignment = StringAlignment.Near,
                                    LineAlignment = StringAlignment.Center
                                };
                                var rectangle = new RectangleF(rowsPosition.X, rowsPosition.Y, 14.0f, 14.0f);
                                graphics.FillRectangle(new SolidBrush(Columns[0][i].Color), rectangle);
                                graphics.DrawRectangle(Pens.Black, rectangle);
                                var rectangleFString = new RectangleF(rowsPosition.X + 18.0f, rowsPosition.Y, 200, 14.0f);
                                graphics.DrawString(Rows[i], font, Brushes.Black, rectangleFString, stringFormat);
                                var widthRow = graphics.MeasureString(Rows[i], font, 200);
                                rowsPosition = new PointF(rowsPosition.X + 18.0f + widthRow.Width + 10.0f, rowsPosition.Y);
                            }
                        }
                    }
                    break;

                case ChartDrawType.Dependence:  // Тип - зависимость
                    {
                        var maxX = GetMaxX() + 1;
                        var maxY = GetMaxY() + 1;
                        var drawRegionY = 70.0f;
                        var drawRegionX = 50.0f;
                        var drawRegionHeight = Canvas.ClientSize.Height - drawRegionY - 50.0f;
                        var pixelsPercentY = drawRegionHeight / maxY;
                        var pixelsPercentX = pixelsPercentY * ((float)NumericUpDownColumnWidth.Value / 100.0f);
                        var color = colors[Points.Count % colors.Length];
                        var brush = new SolidBrush(color);
                        var pen = new Pen(color, 3);
                        var regionWidth = Canvas.ClientSize.Width;
                        var chartWidth = maxX * pixelsPercentX + 50;
                        ScrollBar.Maximum = (int)chartWidth;
                        ScrollBar.Minimum = 0;
                        ScrollBar.SmallChange = regionWidth;
                        ScrollBar.LargeChange = regionWidth;
                        if (scrollable)
                            if (ScrollBar.Value != 0)
                                drawRegionX = 50 - ScrollBar.Value;
                        var font = new Font("SegoeUI", 9.0f);

                        var chartXStart = drawRegionX;
                        var chartXEnd = chartXStart + maxX * pixelsPercentX;
                        var chartYStart = drawRegionY + drawRegionHeight;
                        var chartYEnd = drawRegionY + drawRegionHeight - maxY * pixelsPercentY;
                        var chartValueYStep = (float)Math.Ceiling(maxY / (drawRegionHeight / 22.0f));
                        var chartValueXStep = (float)Math.Ceiling(chartValueYStep / AveragePointsForUnit());
                        var chartXStep = pixelsPercentX * chartValueXStep;
                        var chartYStep = pixelsPercentY * chartValueYStep;

                        graphics.Clear(Color.White);
                        for (float i = chartYStart, value = 0 ; i >= chartYEnd; i -= chartYStep, value += chartValueYStep)
                        {
                            var stringFormat = new StringFormat
                            {
                                Alignment = StringAlignment.Far,
                                LineAlignment = StringAlignment.Far
                            };
                            graphics.DrawLine(value == 0 ? new Pen(Color.Black, 2) : Pens.Black,
                                chartXStart - 5.0f, i, chartXEnd + 5.0f, i);
                            if (value < maxY && value > -1)
                                graphics.DrawString(value.ToString("0.#"), font, Brushes.Black,
                                    new RectangleF(drawRegionX - 101.0f, i - 31.0f, 100.0f, 30.0f), stringFormat);
                        }

                        for (float i = chartXStart, value = 0; i <= chartXEnd; i += chartXStep, value += chartValueXStep)
                        {
                            var stringFormat = new StringFormat
                            {
                                Alignment = StringAlignment.Near,
                                LineAlignment = StringAlignment.Near
                            };
                            graphics.DrawLine(value == 0 ? new Pen(Color.Black, 2) : Pens.Black,
                                i, chartYStart + 5.0f, i, chartYEnd - 5.0f);
                            if (value < maxX && value > -1)
                                graphics.DrawString(value.ToString("0.#"), font, Brushes.Black,
                                    new RectangleF(i + 1.0f, drawRegionY + drawRegionHeight + 1.0f, 30.0f, 30.0f), stringFormat);
                        }

                        for (int i = 0; i < Points.Count - 1; i++)
                            graphics.DrawLine(pen, drawRegionX + Points[i].X * pixelsPercentX, drawRegionY + drawRegionHeight - Points[i].Y * pixelsPercentY,
                                drawRegionX + Points[i + 1].X * pixelsPercentX, drawRegionY + drawRegionHeight - Points[i + 1].Y * pixelsPercentY);
                        for (int i = 0; i < Points.Count; i++)
                        {
                            var rectangle = new RectangleF(drawRegionX + Points[i].X * pixelsPercentX - 4.0f,
                                drawRegionY + drawRegionHeight - Points[i].Y * pixelsPercentY - 4.0f, 8.0f, 8.0f);
                            graphics.FillEllipse(brush, rectangle);
                        }

                        var boldFont = new Font("SegoeUI", 9.0f, FontStyle.Bold);
                        graphics.DrawString($"X: {NameX}", boldFont, Brushes.Black, new PointF(50.0f, 10.0f));
                        graphics.DrawString($"Y: {NameY}", boldFont, Brushes.Black, 
                            new PointF(graphics.MeasureString($"X: {NameX}", boldFont, 200).Width + 70.0f, 10.0f));
                    }
                    break;
            }
        }

        // Получить размер графика в пикселях
        private SizeF GetChartSize(Graphics graphics)
        {
            switch (Type)
            {
                case ChartDrawType.Dependence:  // График зависимости
                    {
                        var maxX = GetMaxX() + 1;
                        var maxY = GetMaxY() + 1;
                        var drawRegionY = 70.0f;
                        var drawRegionHeight = Canvas.ClientSize.Height - drawRegionY - 50.0f;
                        var pixelsPercentY = drawRegionHeight / maxY;
                        var pixelsPercentX = pixelsPercentY * ((float)NumericUpDownColumnWidth.Value / 100.0f);
                        var chartWidth = maxX * pixelsPercentX + 50;
                        return new SizeF(chartWidth, Canvas.ClientSize.Height);
                    }
                case ChartDrawType.Columns:  // Столбцы
                    {
                        var space = 10.0f;
                        var offset = 20.0f;
                        var drawRegionX = 50.0f;
                        var columnWidth = (float)NumericUpDownColumnWidth.Value - 10;
                        var font = new Font("SegoeUI", 9.0f);
                        var columnMinWidth = 0.0f;
                        for (int i = 0; i < Columns.Count; i++)
                        {
                            var currentSize = graphics.MeasureString(Columns[i][0].Name, font, 100);
                            if (currentSize.Width > columnMinWidth)
                                columnMinWidth = currentSize.Width;
                        }
                        columnMinWidth = Math.Max(30, columnMinWidth);
                        var chartWidth = drawRegionX + Columns.Count * (columnMinWidth + columnWidth + space) + offset + 10.0f;
                        return new SizeF(chartWidth, Canvas.ClientSize.Height);
                    }
            }
            return new SizeF(0, 0);
        }

        // При перерисовке панели
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawChart(e.Graphics);
        }

        // При изменение размера панели
        private void Canvas_Resize(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }

        // При изменении значения ширины столбца
        private void NumericUpDownColumnWidth_ValueChanged(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }

        // При прокрутке
        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Canvas.Invalidate();
        }

        // При отжатии мыши от панели
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (Type == ChartDrawType.Columns)
            {
                var bitMapForGraphics = new Bitmap(1, 1);
                var graphics = Graphics.FromImage(bitMapForGraphics);
                var maxColumnValue = RoundUp(GetMaxColumnValue());
                var drawRegionY = 70.0f;
                var drawRegionX = 50.0f;
                var drawRegionHeight = Canvas.ClientSize.Height - drawRegionY - 50.0f;
                var pixelsPercent = drawRegionHeight / maxColumnValue;
                var space = 10.0f;
                var offset = 20.0f;
                var columnWidth = (float)NumericUpDownColumnWidth.Value - 10;
                var font = new Font("SegoeUI", 9.0f);
                var columnMinWidth = 0.0f;
                for (int i = 0; i < Columns.Count; i++)
                {
                    var currentSize = graphics.MeasureString(Columns[i][0].Name, font, 100);
                    if (currentSize.Width > columnMinWidth)
                        columnMinWidth = currentSize.Width;
                }
                columnMinWidth = Math.Max(30, columnMinWidth);
                var chartWidth = drawRegionX + Columns.Count * (columnMinWidth + columnWidth + space) + offset + 10.0f;
                var regionWidth = Canvas.ClientSize.Width;
                ScrollBar.Maximum = (int)chartWidth;
                ScrollBar.Minimum = 0;
                ScrollBar.SmallChange = regionWidth;
                ScrollBar.LargeChange = regionWidth;
                if (ScrollBar.Value != 0)
                    drawRegionX = 10 - ScrollBar.Value;
                for (var i = 0; i < Columns.Count; i++)
                {
                    for (int j = 0; j < Columns[i].Count; j++)
                    {
                        var size = new SizeF(columnMinWidth + columnWidth, Columns[i][j].Value * pixelsPercent);
                        var currentColumnWidth = size.Width / Columns[i].Count;
                        var position = new PointF(drawRegionX + offset + i * (size.Width + space),
                            drawRegionY + drawRegionHeight - size.Height);
                        var rectangleF = new RectangleF(position.X + j * (currentColumnWidth),
                            position.Y, currentColumnWidth, size.Height);
                        if (e.Location.X > rectangleF.X && e.Location.Y > rectangleF.Y &&
                            e.Location.X < rectangleF.X + rectangleF.Width &&
                            e.Location.Y < rectangleF.Y + rectangleF.Height)
                        {
                            using (var form = new ColorDialog())
                            {
                                if (form.ShowDialog() == DialogResult.OK)
                                {
                                    for (int z = 0; z < Columns.Count; z++)
                                        Columns[z][j].Color = form.Color;
                                    Canvas.Invalidate();
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }

        // При нажатии пункта меню "Открыть график"
        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            using (var form = new OpenFileDialog() { Filter = "JSON График (*.json)|*.json" })
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var json = File.ReadAllText(form.FileName);
                    var chart = JsonConvert.DeserializeObject<Chart>(json);
                    Type = chart.Type;
                    switch (chart.Type)
                    {
                        case ChartDrawType.Columns:
                            Columns = chart.Columns;
                            break;
                        case ChartDrawType.Dependence:
                            Points = chart.Points;
                            break;
                    }
                    Rows = chart.Rows;
                    NumericUpDownColumnWidth.Value = (decimal)chart.ScaleX;
                    Canvas.Invalidate();
                }
            }
        }

        // При нажатии пункта меню "Сохранить график"
        private void MenuItemFileSave_Click(object sender, EventArgs e)
        {
            using (var form = new SaveFileDialog() { Filter = "JSON График (*.json)|*.json" })
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var json = JsonConvert.SerializeObject(new Chart 
                    {
                        Type = Type, 
                        Points = Points, 
                        Columns = Columns,
                        ScaleX = (float)NumericUpDownColumnWidth.Value,
                        Rows = Rows
                    }, Formatting.Indented);
                    File.WriteAllText(form.FileName, json);
                }
            }
        }

        // При нажатии пункта меню "Экспорт графика"
        private void MenuItemExport_Click(object sender, EventArgs e)
        {
            using (var form = new SaveFileDialog() { Filter = "Изображение JPEG (*.jpg)|*.jpg|Изображение PNG (*.png)|*.png" })
            {
                if (form.ShowDialog() == DialogResult.OK)
                {               
                    Bitmap bitmap = new Bitmap(1, 1);
                    var graphics = Graphics.FromImage(bitmap);
                    var size = GetChartSize(graphics);
                    bitmap = new Bitmap((int)size.Width, (int)size.Height);
                    graphics = Graphics.FromImage(bitmap);
                    DrawChart(graphics, false);
                    bitmap.Save(form.FileName);
                }
            }
        }
    }
}
