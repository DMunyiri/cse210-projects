using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Common starting message
    protected void StartMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Preparing for {_name}...");
        Animate(3); // Show animation before starting
    }

    // Common ending message
    protected void EndMessage()
    {
        Console.WriteLine($"\nGreat job! You have completed the {_name} Activity.");
        Console.WriteLine($"Duration: {_duration} seconds");
        Animate(3); // Show animation before finishing
    }

    // Animation method
    protected void Animate(int seconds)
    {
        int totalDots = seconds * 3; // 3 dots per second
        for (int i = 0; i < totalDots; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000 / 3); // Sleep for 1/3 second
        }
        Console.WriteLine();
    }

    // Abstract method for activity-specific logic
    public abstract void PerformActivity();

    // Getter for duration
    protected int GetDuration()
    {
        return _duration;
    }
}