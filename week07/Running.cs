public class Running : Activity
{
    private double _distance; // Distance in miles

    // Constructor
    public Running(string date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    // Implement GetDistance
    public override double GetDistance()
    {
        return _distance;
    }

    // Implement GetSpeed
    public override double GetSpeed()
    {
        return (_distance / GetLengthInMinutes()) * 60;
    }

    // Implement GetPace
    public override double GetPace()
    {
        return GetLengthInMinutes() / _distance;
    }
}