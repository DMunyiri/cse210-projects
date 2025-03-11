using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    private string _name;
    private List<Job> _jobs = new List<Job>();

    // Constructor
    public Resume(string name)
    {
        _name = name;
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}