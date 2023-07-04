using System.Drawing;

namespace TableDataAnalysis
{
    public static class GraphicsExtensions
    {
        public static void DrawRectangle(this Graphics g, Pen pen, RectangleF rect)
        {
            g.DrawRectangles(pen, new[] { rect });
        }
    }
}
