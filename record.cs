using System;
using System.Collections.Generic;

class StudentRecords
{
    static void Main(string[] args)
    {
        Dictionary<int, string> students = new Dictionary<int, string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nStudent Record System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Student ID: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        if (students.ContainsKey(id))
                        {
                            Console.WriteLine("❌ Student ID already exists.");
                        }
                        else
                        {
                            Console.Write("Enter Student Name: ");
                            string name = Console.ReadLine();
                            students[id] = name;
                            Console.WriteLine("✅ Student added successfully.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid ID. Please enter a number.");
                    }
                    break;

                case "2":
                    Console.Write("Enter Student ID to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int removeId))
                    {
                        if (students.Remove(removeId))
                        {
                            Console.WriteLine("✅ Student removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("❌ Student ID not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid ID.");
                    }
                    break;

                case "3":
                    Console.WriteLine("\n📋 Student Records:");
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No students found.");
                    }
                    else
                    {
                        foreach (var entry in students)
                        {
                            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
                        }
                    }
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("❌ Invalid option. Please choose 1 to 4.");
                    break;
            }
        }
    }
}
