public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Implement RecordEvent
    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded '{GetName()}' and earned {GetPoints()} points.");
    }

    // Implement IsComplete
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    // Implement GetDetailsString
    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
}