using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        if (!int.TryParse(Console.ReadLine(), out int rows) || rows < 1 || rows > 30)
        {
            Console.WriteLine("Enter a whole number from 1 to 30.");
            return;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int space = 0; space < rows - i; space++) Console.Write(" ");
            long value = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(value + " ");
                value = value * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}
