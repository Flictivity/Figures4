//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
using System.Drawing;

class Line : FilledFigure
{
    public MyPoint A
    {
        get { return basePoint; }
        set { basePoint = value; }
    }
    public MyPoint B;

    public Line(MyPoint a, MyPoint b) : base(a)
    {
        B = b;
    }

    public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
    {
        B = new MyPoint(x2, y2);
    }

    public override void Draw(Graphics g)
    {
        g.DrawLine(new Pen(Stroke.Color, Stroke.Width), A.X, A.Y, B.X, B.Y);
    }
    public override string ToString()
    {
        return $"Line;{Stroke.Color.ToArgb()};{Stroke.Width};{A};{B}";
    }
}
