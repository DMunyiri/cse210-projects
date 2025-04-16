public abstract class Activity
{
    // Shared attributes
    private string _date;
    private int _lengthInMinutes;

    // Constructor
    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Getters
    public string GetDate() => _date;
    public int GetLengthInMinutes() => _lengthInMinutes;

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance(); // In miles or kilometers
    public abstract double GetSpeed();    // In mph or kph
    public abstract double GetPace();     // In minutes per mile or km

    // Summary method (common to all activities)
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthInMinutes} min) - " +
               $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}