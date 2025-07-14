using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

class FileWriterAsync
{
    static async Task Main(string[] args)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        List<Task> tasks = new List<Task>();

        for (int i = 1; i <= 100; i++)
        {
            int fileIndex = i;
            tasks.Add(Task.Run(async () =>
            {
                string fileName = $"File_{fileIndex}.dat";
                byte[] buffer = new byte[51200]; // 50KB

                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, buffer.Length, useAsync: true))
                {
                    for (int j = 0; j < 205; j++)
                    {
                        await fs.WriteAsync(buffer, 0, buffer.Length);
                    }
                }

                Console.WriteLine($"{fileName} Writing Completed");
            }));
        }

        await Task.WhenAll(tasks); // Wait for all tasks to finish

        stopwatch.Stop();
        Console.WriteLine($"\nTime taken (Multi-threaded): {stopwatch.Elapsed.TotalSeconds:F2} seconds");
    }
}
