public class Cycling : Activity
{
    private double _speed; // Speed in mph

    // Constructor
    public Cycling(string date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    // Implement GetDistance
    public override double GetDistance()
    {
        return (_speed * GetLengthInMinutes()) / 60;
    }

    // Implement GetSpeed
    public override double GetSpeed()
    {
        return _speed;
    }

    // Implement GetPace
    public override double GetPace()
    {
        return 60 / _speed;
    }
}