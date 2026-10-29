using System;

class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
    public double Add(double a, double b) => a + b;
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        Console.WriteLine(c.Add(2, 3));
        Console.WriteLine(c.Add(2, 3, 4));
        Console.WriteLine(c.Add(2.5, 3.2));
    }
}
