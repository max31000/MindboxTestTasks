namespace FigureAreaCalculator;

public class Circle : IShape
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}