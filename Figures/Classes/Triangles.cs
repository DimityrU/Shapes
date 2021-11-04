using System;
using System.Drawing;

namespace Course_project
{
    [Serializable]
    public class Triangles : Figure
    {
        public Triangles(int A, int B, int C) : base(A, B, C, C)
        { }
        public override void Draw(Graphics draw)
        {
            Point[] point = { new Point(C, A), new Point(A, B), new Point( B, C) };
            using (Pen pen = new Pen(Color.Blue, 2))
                draw.DrawPolygon(pen, point);

            using (var brush = new SolidBrush(
               Color.FromArgb(
                       Math.Min(byte.MaxValue, Color.R + 100),
                       Math.Min(byte.MaxValue, Color.G + 100),
                       Math.Min(byte.MaxValue, Color.B + 255))))
                draw.FillPolygon(brush, point);
        }
    }
}