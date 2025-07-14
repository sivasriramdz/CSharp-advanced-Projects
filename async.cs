using System;
using System.Threading.Tasks;

class OrderSystem
{
    static async Task Main(string[] args)
    {
        Console.Write("Enter the item you want to order: ");
        string item = Console.ReadLine();

        await ProcessOrderAsync(item);
    }

    static async Task ProcessOrderAsync(string item)
    {
        Console.WriteLine("\nProcessing order...");
        await Task.Delay(3000); 
        Console.WriteLine($"✅ Order for '{item}' is ready!");
    }
}
