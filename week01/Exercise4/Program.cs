using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter numbers one by one. Enter 0 to stop.");

        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        // Make sure the user entered at least one number
        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];
            int min = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;
                if (num > max) max = num;
                if (num < min) min = num;
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"\nYou entered {numbers.Count} numbers.");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}