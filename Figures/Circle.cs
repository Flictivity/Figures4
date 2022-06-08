//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
using System.Drawing;

class Circle : FilledFigure
{
    public int Radius;

    public Circle(MyPoint point, int radius) : base(point)
    {
        Radius = radius;
    }

    public override void Draw(Graphics g)
    {
        g.DrawEllipse(new Pen(Stroke.Color, Stroke.Width), basePoint.X, basePoint.Y, Radius * 2, Radius * 2);
        //Radius * 2 = Height and Width;
    }
    public override string ToString()
    {
        return $"Circle;{Stroke.Color.ToArgb()};{Stroke.Width};{basePoint};{Radius}";
    }
}
