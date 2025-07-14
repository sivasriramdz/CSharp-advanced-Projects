using System;
using System.Diagnostics;
using System.IO;

class FileWriterSingle
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        for (int i = 1; i <= 100; i++)
        {
            string fileName = $"File_{i}.dat";
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[51200]; // 50KB block
                for (int j = 0; j < 205; j++)     // 205 * 50KB = ~10MB
                {
                    fs.Write(buffer, 0, buffer.Length);
                }
            }
            Console.WriteLine($"{fileName} Writing Completed");
        }

        stopwatch.Stop();
        Console.WriteLine($"\n Time taken (Single Thread): {stopwatch.Elapsed.TotalSeconds:F2} seconds");
    }
}
