using System;

public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract bool IsValid();
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override double CalculateArea()
    {
        return IsValid() ? Length * Width : 0;
    }

    public override bool IsValid()
    {
        return Length > 0 && Width > 0;
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return IsValid() ? Side * Side : 0;
    }

    public override bool IsValid()
    {
        return Side > 0;
    }
}

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public override double CalculateArea()
    {
        if (!IsValid()) return 0;

        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override bool IsValid()
    {
        return SideA > 0 && SideB > 0 && SideC > 0 &&
               SideA + SideB > SideC &&
               SideA + SideC > SideB &&
               SideB + SideC > SideA;
    }
}

class Program
{
    static void Main()
    {
        var rect = new Rectangle { Length = 3, Width = 4 };
        Console.WriteLine($"长方形面积: {rect.CalculateArea()}, 是否合法: {rect.IsValid()}");

        var square = new Square { Side = 5 };
        Console.WriteLine($"正方形面积: {square.CalculateArea()}, 是否合法: {square.IsValid()}");

        var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
        Console.WriteLine($"三角形面积: {triangle.CalculateArea():F2}, 是否合法: {triangle.IsValid()}");

        var invalidRect = new Rectangle { Length = -2, Width = 5 };
        Console.WriteLine($"非法长方形面积: {invalidRect.CalculateArea()}, 是否合法: {invalidRect.IsValid()}");
    }
}
