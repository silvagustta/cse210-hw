
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string[] prompts =
        {
            "What was the best part of your day?",
            "Who was the most interesting person you interacted with today?",
            "What did you learn today?",
            "What made you happy today?",
            "What is something you would like to improve tomorrow?"
        };

        Random random = new Random();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(journal, prompts, random);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();

                    journal.SaveToFile(saveFile);

                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();

                    if (File.Exists(loadFile))
                    {
                        journal.LoadFromFile(loadFile);
                        Console.WriteLine("Journal loaded successfully!");
                    }
                    else
                    {
                        Console.WriteLine("File not found!");
                    }

                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");
    }

    static void WriteEntry(Journal journal, string[] prompts, Random random)
    {
        int index = random.Next(prompts.Length);

        string prompt = prompts[index];

        Console.WriteLine(prompt);
        Console.Write("> ");

        string answer = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry();

        newEntry._date = date;
        newEntry._promptText = prompt;
        newEntry._entryText = answer;

        journal.AddEntry(newEntry);

        Console.WriteLine("Entry added successfully!");
    }
}
