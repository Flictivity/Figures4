//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
using System.Drawing;
abstract class Figure
{
    public MyPoint basePoint;

    public Figure(MyPoint point)
    {
        basePoint = point;
    }

    public Figure(int x = 0, int y = 0)
    {
        basePoint = new MyPoint(x, y);
    }

    public virtual void Draw(Graphics g) { }
}