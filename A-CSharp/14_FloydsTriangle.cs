using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        if (!int.TryParse(Console.ReadLine(), out int rows) || rows < 1 || rows > 100)
        {
            Console.WriteLine("Enter a whole number from 1 to 100.");
            return;
        }

        int number = 1;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++) Console.Write(number++ + " ");
            Console.WriteLine();
        }
    }
}
