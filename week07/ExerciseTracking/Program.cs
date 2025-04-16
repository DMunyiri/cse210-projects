using System;
using System.Collections.Generic;

// Define the Activity class and its derived classes
abstract class Activity
{
    public string Date { get; set; }
    public int Duration { get; set; } // in minutes

    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public abstract string GetSummary();
}

class Running : Activity
{
    public double Distance { get; set; } // in miles

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override string GetSummary()
    {
        return $"{Date} - Running: {Duration} min, {Distance} miles";
    }
}

class Cycling : Activity
{
    public double Speed { get; set; } // in mph

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    public override string GetSummary()
    {
        return $"{Date} - Cycling: {Duration} min, {Speed} mph";
    }
}

class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override string GetSummary()
    {
        return $"{Date} - Swimming: {Duration} min, {Laps} laps";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("04 Nov 2022", 45, 12.0),
            new Swimming("05 Nov 2022", 60, 20)
        };

        // Display summaries
        Console.WriteLine("Exercise Tracking Program\n");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}