using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Invalid number."); return; }
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine() ?? "";
        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Invalid number."); return; }

        switch (op)
        {
            case "+": Console.WriteLine($"Result: {a + b}"); break;
            case "-": Console.WriteLine($"Result: {a - b}"); break;
            case "*": Console.WriteLine($"Result: {a * b}"); break;
            case "/":
                if (b == 0) Console.WriteLine("Cannot divide by zero.");
                else Console.WriteLine($"Result: {a / b}");
                break;
            default: Console.WriteLine("Unknown operator."); break;
        }
    }
}
