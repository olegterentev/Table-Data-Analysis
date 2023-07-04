using System.Collections.Generic;
using System.Drawing;

namespace TableDataAnalysis
{
    public class Column  // Столбец графика
    {
        public string Name { set; get; }  // Имя
        public float Value { set; get; }  // Значение
        public Color Color { set; get; }  // Цвет
    }

    public enum ChartDrawType  // Тип графика
    {
        Columns,  // Столбцы
        Dependence  // Зависимость (точки)
    }

    public class Chart  // График
    {
        public ChartDrawType Type { get; set; }  // Тип графика
        public List<PointF> Points { get; set; }  // Точки графика
        public List<List<Column>> Columns { get; set; }  // Стобцы графика
        public List<string> Rows { get; set; }  // Строки графика
        public float ScaleX { get; set; }  // Ширина графика
    }
}
