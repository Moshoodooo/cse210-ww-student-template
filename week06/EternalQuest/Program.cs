using System;
using System.Collections.Generic;

class Program
{
    static GoalManager manager = new GoalManager();

    static void Main(string[] args)
    {
        // EXCEED REQUIREMENTS:
        // I added a leveling/title system where users earn titles as their score increases.

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest Program ===");
            manager.DisplayScore();
            DisplayTitle();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    manager.DisplayGoals();
                    Pause();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    return;
            }
        }
    }

    static void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddGoal(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            manager.AddGoal(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
        }

        Console.WriteLine("Goal created!");
        Pause();
    }

    static void RecordEvent()
    {
        manager.DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        manager.RecordGoal(index);
        Console.WriteLine("Event recorded!");
        Pause();
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string file = Console.ReadLine();
        manager.Save(file);
        Console.WriteLine("Saved successfully!");
        Pause();
    }

    static void DisplayTitle()
    {
        int score = manager.GetScore();

        string title = "Beginner";
        if (score >= 1000) title = "Disciple";
        if (score >= 3000) title = "Master";
        if (score >= 6000) title = "Eternal Champion";

        Console.WriteLine($"Title: {title}");
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}