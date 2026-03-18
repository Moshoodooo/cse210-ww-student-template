using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // I added a mood tracking feature that allows users to record how they feel for each entry.
        // This mood is saved, loaded, and displayed with each journal entry.
        // I also added a feature to display the total number of journal entries.

        Journal journal = new Journal();

        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see God's hand in my life today?",
            "What was the strongest emotion I felt today?",
            "What would I do differently today?"
        };

        Random random = new Random();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts[random.Next(prompts.Count)];
                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
                Console.WriteLine($"Total Entries: {journal._entries.Count}");
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("Journal saved successfully!");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                Console.WriteLine("Journal loaded successfully!");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}