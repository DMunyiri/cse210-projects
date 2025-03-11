using System;

public class Job
{
    // Member variables
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    // Method to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    // Properties (optional for easier access if needed)
    public string Company { get => _company; set => _company = value; }
    public string JobTitle { get => _jobTitle; set => _jobTitle = value; }
    public int StartYear { get => _startYear; set => _startYear = value; }
    public int EndYear { get => _endYear; set => _endYear = value; }
}