using System;
using System.Drawing;

namespace Course_project
{
    [Serializable]
    public class Circles : Figure
    {
        public Circles(int A, int B, int C) : base(A, B, C, C)
        { }
        public override void Draw(Graphics draw)
        {
            using (Pen Pen = new Pen(Color.Blue, 2))
            {
                draw.DrawEllipse(Pen, A - C, B - C, C + C, C + C);
            }

            using (var brush = new SolidBrush(
               Color.FromArgb(
                       Math.Min(byte.MaxValue, Color.R + 100),
                       Math.Min(byte.MaxValue, Color.G + 100),
                       Math.Min(byte.MaxValue, Color.B + 255))))           
                draw.FillEllipse(brush, A - C, B - C, C + C, C + C);
        }
    }
}