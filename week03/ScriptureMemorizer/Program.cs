using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ------------------------------------------------------------
        // EXCEEDING REQUIREMENTS:
        // This program uses a library of multiple scriptures instead of one.
        // A scripture is randomly selected each time the program runs.
        // When hiding words, only words that are not already hidden are chosen.
        // ------------------------------------------------------------

        List<Scripture> library = new List<Scripture>();

        // Scripture 1
        Reference ref1 = new Reference("John", 3, 16);
        Scripture s1 = new Scripture(ref1,
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life");

        // Scripture 2 (multiple verses example)
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Scripture s2 = new Scripture(ref2,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths");

        // Scripture 3
        Reference ref3 = new Reference("Mosiah", 2, 17);
        Scripture s3 = new Scripture(ref3,
            "When ye are in the service of your fellow beings ye are only in the service of your God");

        library.Add(s1);
        library.Add(s2);
        library.Add(s3);

        // Pick random scripture
        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Stop if fully hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide 3 random words each round
            scripture.HideRandomWords(3);
        }
    }
}