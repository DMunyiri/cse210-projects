using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nSelect the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            totalScore += goals[index].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("\nList of Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    static void ShowScore()
    {
        Console.WriteLine($"\nYour total score: {totalScore}");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalScore);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.GetName());
                writer.WriteLine(goal.GetDescription());
                writer.WriteLine(goal.GetPoints());
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.IsComplete());
                    writer.WriteLine(((ChecklistGoal)goal).CurrentCount);
                    writer.WriteLine(((ChecklistGoal)goal).TargetCount);
                    writer.WriteLine(((ChecklistGoal)goal).BonusPoints);
                }
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        goals.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            totalScore = int.Parse(reader.ReadLine());
            while (!reader.EndOfStream)
            {
                string type = reader.ReadLine();
                string name = reader.ReadLine();
                string description = reader.ReadLine();
                int points = int.Parse(reader.ReadLine());

                if (type == "SimpleGoal")
                {
                    goals.Add(new SimpleGoal(name, description, points));
                }
                else if (type == "EternalGoal")
                {
                    goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    bool isComplete = bool.Parse(reader.ReadLine());
                    int currentCount = int.Parse(reader.ReadLine());
                    int targetCount = int.Parse(reader.ReadLine());
                    int bonusPoints = int.Parse(reader.ReadLine());

                    var checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);

                    goals.Add(checklistGoal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}