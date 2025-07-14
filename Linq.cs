using System;
using System.Collections.Generic;
using System.Linq;

class LinqOperations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of integers :");

        string input = Console.ReadLine();
        List<int> numbers = new List<int>();

        try
        {
            numbers = input
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            
            var greaterThan50 = numbers.Where(n => n > 50);

            
            var sortedNumbers = numbers.OrderBy(n => n);

            
            var squaredNumbers = numbers.Select(n => n * n);

            Console.WriteLine("\n🔹 Numbers greater than 50:");
            Console.WriteLine(string.Join(", ", greaterThan50));

            Console.WriteLine("\n🔹 Sorted numbers (ascending):");
            Console.WriteLine(string.Join(", ", sortedNumbers));

            Console.WriteLine("\n🔹 Squares of all numbers:");
            Console.WriteLine(string.Join(", ", squaredNumbers));
        }
        catch (FormatException)
        {
            Console.WriteLine("❌ Invalid input. Please enter only integers separated by spaces.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ An unexpected error occurred: {ex.Message}");
        }
    }
}
