//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
class FilledFigure : Figure
{
    public FillData Fill;
    public StrokeData Stroke;

    public FilledFigure(MyPoint point) : base(point)
    {
        Fill.Color = 0xFFFFFF;
        Stroke.Color = System.Drawing.Color.Black;
    }

    public FilledFigure(int x, int y) : base(x, y)
    {
        Fill.Color = 0xFFFFFF;
        Stroke.Color = System.Drawing.Color.Black;
    }
}
