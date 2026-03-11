using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for numeric score
        Console.Write("Enter your numeric score: ");
        string input = Console.ReadLine();

        // Convert to integer
        int score = int.Parse(input);

        // Determine letter grade
        string grade;
        if (score >= 90 && score <= 100)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        // Print the result
        Console.WriteLine($"Your letter grade is {grade}.");
    }
}