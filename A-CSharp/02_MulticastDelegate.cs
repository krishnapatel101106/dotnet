using System;

class Program
{
    delegate void Notify();

    static void First() => Console.WriteLine("First method called.");
    static void Second() => Console.WriteLine("Second method called.");
    static void Third() => Console.WriteLine("Third method called.");

    static void Main()
    {
        Notify all = First;
        all += Second;
        all += Third;
        all(); // Calls all three methods in order.
    }
}
