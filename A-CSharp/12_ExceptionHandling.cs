using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class Program
{
    static void CheckAge(int age)
    {
        if (age < 0) throw new InvalidAgeException("Age cannot be negative.");
        Console.WriteLine($"Age accepted: {age}");
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter denominator: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b == 0) throw new DivideByZeroException("Denominator cannot be zero.");
            Console.WriteLine($"Result: {a / b}");
            CheckAge(20);
        }
        catch (DivideByZeroException ex) { Console.WriteLine($"Math error: {ex.Message}"); }
        catch (FormatException ex) { Console.WriteLine($"Input error: {ex.Message}"); }
        catch (InvalidAgeException ex) { Console.WriteLine($"Custom error: {ex.Message}"); }
        catch (Exception ex) { Console.WriteLine($"Unexpected error: {ex.Message}"); }
        finally { Console.WriteLine("Finally block always executes."); }
    }
}
