using System;
using System.Collections.Generic;

public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract bool IsValid();
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override double CalculateArea() => IsValid() ? Length * Width : 0;
    public override bool IsValid() => Length > 0 && Width > 0;
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea() => IsValid() ? Side * Side : 0;
    public override bool IsValid() => Side > 0;
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

    public override bool IsValid() =>
        SideA > 0 && SideB > 0 && SideC > 0 &&
        SideA + SideB > SideC &&
        SideA + SideC > SideB &&
        SideB + SideC > SideA;
}
public class ShapeFactory
{
    private static readonly Random _random = new Random();

    public Shape CreateShape(string type)
    {
        return type switch
        {
            "Rectangle" => new Rectangle
            {
                Length = _random.Next(1, 10),
                Width = _random.Next(1, 10)
            },
            "Square" => new Square
            {
                Side = _random.Next(1, 10)
            },
            "Triangle" => GenerateValidTriangle(),
            _ => throw new ArgumentException("Invalid shape type")
        };
    }

    private Triangle GenerateValidTriangle()
    {
        while (true)
        {
            double a = _random.Next(1, 10);
            double b = _random.Next(1, 10);
            double c = _random.Next(1, 10);

            var triangle = new Triangle { SideA = a, SideB = b, SideC = c };
            if (triangle.IsValid()) return triangle;
        }
    }
}

class Program
{
    static void Main()
    {
        ShapeFactory factory = new ShapeFactory();
        List<Shape> shapes = new List<Shape>();
        string[] types = { "Rectangle", "Square", "Triangle" };
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            string type = types[random.Next(types.Length)];
            shapes.Add(factory.CreateShape(type));
        }

        double totalArea = 0;
        foreach (var shape in shapes)
        {
            totalArea += shape.CalculateArea();
        }

        Console.WriteLine($"随机生成的10个形状总面积：{totalArea:F2}");
        Console.WriteLine("各形状详情：");
        foreach (var shape in shapes)
        {
            string type = shape switch
            {
                Rectangle _ => "长方形",
                Square _ => "正方形",
                Triangle _ => "三角形",
                _ => "未知"
            };
            Console.WriteLine($"{type} 面积：{shape.CalculateArea():F2}");
        }
    }
}