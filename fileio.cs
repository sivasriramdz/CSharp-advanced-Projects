using System;
using System.Collections.Generic;
using System.IO;

class FileIOExample
{
    static void Main(string[] args)
    {
        string fileName = "output.txt";
        List<string> lines = new List<string>();
        string input;

        Console.WriteLine("Enter multiple lines of text. Type 'STOP' to finish:");

        try
        {
            
            while (true)
            {
                input = Console.ReadLine();

                if (input.ToUpper() == "STOP")
                {
                    break;
                }

                lines.Add(input);
            }

            
            File.WriteAllLines(fileName, lines.ToArray());
            Console.WriteLine("\n✅ Text saved to 'output.txt' successfully.\n");

            
            Console.WriteLine("📄 Contents of 'output.txt':\n");
            string[] fileContent = File.ReadAllLines(fileName);

            foreach (string line in fileContent)
            {
                Console.WriteLine(line);
            }
        }
        catch (IOException ioEx)
        {
            Console.WriteLine($"❌ File access error: {ioEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ An unexpected error occurred: {ex.Message}");
        }
    }
}
