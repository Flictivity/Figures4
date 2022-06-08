//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
using System.Drawing;

class Rectangle : FilledFigure
{
    public int Height;
    public int Width;

    public Rectangle(MyPoint point, int height, int width) : base(point)
    {
        Height = height;
        Width = width;
    }
    public override void Draw(Graphics g)
    {
        g.DrawRectangle(new Pen(Stroke.Color, Stroke.Width), basePoint.X, basePoint.Y, Width, Height);
    }

    public override string ToString()
    {
        return $"Rectangle;{Stroke.Color.ToArgb()};{Stroke.Width};{basePoint};" +
            $"{Height};{Width}";
    }
}
