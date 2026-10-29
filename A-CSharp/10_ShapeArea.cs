using System;

interface IShape { double CalculateArea(); }

class Circle : IShape
{
    public double Radius { get; }
    public Circle(double radius) => Radius = radius;
    public double CalculateArea() => Math.PI * Radius * Radius;
}

class Rectangle : IShape
{
    public double Length { get; }
    public double Width { get; }
    public Rectangle(double length, double width) { Length = length; Width = width; }
    public double CalculateArea() => Length * Width;
}

class Program
{
    static void Main()
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Circle area: {circle.CalculateArea():F2}");
        Console.WriteLine($"Rectangle area: {rectangle.CalculateArea():F2}");
    }
}
