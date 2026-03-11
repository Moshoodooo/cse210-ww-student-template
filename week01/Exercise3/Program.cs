using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Generate magic number
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // 1–100

        bool guessedCorrectly = false;

        Console.WriteLine("Welcome to Guess My Number!");
        Console.WriteLine("I have picked a number between 1 and 100.");

        // Step 2: Loop until correct guess
        while (!guessedCorrectly)
        {
            Console.Write("Guess my number: ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!");
                guessedCorrectly = true;
            }
        }
    }
}