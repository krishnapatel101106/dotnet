using System;

class Program
{
    static void Main()
    {
        string[] cities = new string[10];
        for (int i = 0; i < cities.Length; i++)
        {
            Console.Write($"Enter city {i + 1}: ");
            cities[i] = Console.ReadLine()?.Trim() ?? "";
        }

        Array.Sort(cities, StringComparer.OrdinalIgnoreCase);
        Console.WriteLine("\nCities in sorted order:");
        foreach (string city in cities) Console.WriteLine(city);
    }
}
