using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void PerformActivity()
    {
        StartMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\nConsider the following prompt:\n{prompt}");

        Console.WriteLine("\nYou may begin listing items...");
        Animate(5); // Countdown before listing begins

        int remainingTime = GetDuration();
        int count = 0;
        while (remainingTime > 0)
        {
            Console.Write("> ");
            Console.ReadLine(); // Wait for user input
            count++;
            remainingTime -= 5; // Assume each item takes ~5 seconds
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndMessage();
    }
}