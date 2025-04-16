public class Swimming : Activity
{
    private int _laps; // Number of laps

    // Constructor
    public Swimming(string date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    // Implement GetDistance
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62; // Convert meters to miles
    }

    // Implement GetSpeed
    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthInMinutes()) * 60;
    }

    // Implement GetPace
    public override double GetPace()
    {
        return GetLengthInMinutes() / GetDistance();
    }
}