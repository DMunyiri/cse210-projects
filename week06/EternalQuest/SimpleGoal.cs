public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Implement RecordEvent
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You completed '{GetName()}' and earned {GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    // Implement IsComplete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Implement GetDetailsString
    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {GetName()} ({GetDescription()})";
    }
}