using System;

class Program
{
    // A delegate can refer to any method with this signature.
    delegate double Operation(double a, double b);

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;

    static double Divide(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }

    static void Main()
    {
        double a = 20, b = 5;
        Operation op = Add;
        Console.WriteLine($"Addition: {op(a, b)}");
        op = Subtract;
        Console.WriteLine($"Subtraction: {op(a, b)}");
        op = Multiply;
        Console.WriteLine($"Multiplication: {op(a, b)}");
        op = Divide;
        Console.WriteLine($"Division: {op(a, b)}");
    }
}
