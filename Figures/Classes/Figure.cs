using System;
using System.Drawing;

namespace Course_project
{
    [Serializable]
    public abstract class Figure
    {
        public Color Color { get;protected set; }
        public int A { get;protected set; }
        public int B { get;protected set; }
        public int C { get;protected set; }
        public int D { get;protected set; }
        protected Figure(int A, int B, int C, int D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public abstract void Draw(Graphics draw);
    }
}