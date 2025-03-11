using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two Job instances
        Job job1 = new Job();
        job1.Company = "Tile and Carpet";
        job1.JobTitle = "Sales Representative";
        job1.StartYear = 2021;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.Company = "Jaquar";
        job2.JobTitle = "Sales Executive";
        job2.StartYear = 2022;
        job2.EndYear = 2023;

        // Create a Resume instance
        Resume myResume = new Resume("Dominic Munyiri Wanjau");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.Display();
    }
}                                                                                                                                                   