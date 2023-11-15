namespace FigureAreaCalculator;

public class Triangle : IShape
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public double CalculateArea()
    {
        // формула Герона
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightAngled()
    {
        // Теорема пифагора
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < Epsilon;
    }

    private static double Epsilon { get; set; } = 0.0001;
}