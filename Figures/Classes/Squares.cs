using System;
using System.Drawing;

namespace Course_project
{
    [Serializable]
    public class Squares : Figure
    {
        public Squares(int A, int B, int C, int D) : base(A, B, C, D)
        { }
        public override void Draw(Graphics draw)
        {
            using (Pen Pen = new Pen(Color.Blue, 2))
            {
                draw.DrawRectangle(Pen, A, B, C, D);
            }

            using (var brush = new SolidBrush(
                Color.FromArgb(
                        Math.Min(byte.MaxValue, Color.R + 100),
                        Math.Min(byte.MaxValue, Color.G + 100),
                        Math.Min(byte.MaxValue, Color.B + 255))))
                draw.FillRectangle(brush, A, B, C, D);            
        }
    }
}