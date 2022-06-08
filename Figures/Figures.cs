//Saifullin Bulat 220P GeometricFigures Task4 04.06.22
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

class Figures
{
    List<Figure> figures;
    string path;

    public Figures(string path)
    {
        this.path = path;
        figures = new List<Figure>();
        Load(this.path);
    }

    public Figures()
    {
        figures = new List<Figure>();
    }

    public void Add(Figure figure)
    {
        figures.Add(figure);
    }

    public void Load(string path)
    {
        figures.Clear();
        using(StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var figuresRead = line.Split(";");
                string figureName = figuresRead[0];

                var basePoint = new MyPoint(int.Parse(figuresRead[3]),
                                          int.Parse(figuresRead[4]));

                var color = Color.FromArgb(int.Parse(figuresRead[1]));
                var width = int.Parse(figuresRead[2]);

                FilledFigure figure;
                switch (figureName)
                {
                    case "Line":
                        var p2 = new MyPoint(int.Parse(figuresRead[5]),
                                           int.Parse(figuresRead[6]));

                        figure = new Line(basePoint, p2);
                        figure.Stroke.Color = color;
                        figure.Stroke.Width = width;
                        figures.Add(figure);
                        break;

                    case "Circle":
                        int radius = int.Parse(figuresRead[5]);

                        figure = new Circle(basePoint, radius);
                        figure.Stroke.Color = color;
                        figure.Stroke.Width = width;
                        figures.Add(figure);
                        break;

                    case "Triangle":
                        p2 = new MyPoint(int.Parse(figuresRead[5]),
                                       int.Parse(figuresRead[6]));
                        var p3 = new MyPoint(int.Parse(figuresRead[7]),
                                           int.Parse(figuresRead[8]));

                        figure = new Triangle(basePoint, p2, p3);
                        figure.Stroke.Color = color;
                        figure.Stroke.Width = width;
                        figures.Add(figure);
                        break;

                    case "Rectangle":
                        int height = int.Parse(figuresRead[5]);
                        int weight = int.Parse(figuresRead[6]);

                        figure = new Rectangle(basePoint, height, weight);
                        figure.Stroke.Color = color;
                        figure.Stroke.Width = width;
                        figures.Add(figure);
                        break;

                    default:
                        throw new Exception("Non correct format data!");
                }
            }
        }
    }

    public void Save(string path)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach(var figure in figures)
            {
                writer.WriteLine(figure);
            }
        }
    }

    internal void Draw(Graphics g)
    {
        foreach(var figure in figures)
        {
            figure.Draw(g);
        }
    }
    internal void Clear()
    {
        figures.Clear();
    }
}