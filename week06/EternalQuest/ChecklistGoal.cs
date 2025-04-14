public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    // Public properties to access private fields
    public int TargetCount => _targetCount;
    public int CurrentCount => _currentCount;
    public int BonusPoints => _bonusPoints;

    // Implement RecordEvent
    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"You recorded '{GetName()}' and earned {GetPoints()} points.");

        if (_currentCount >= _targetCount)
        {
            Console.WriteLine($"Congratulations! You've completed the checklist and earned an additional {_bonusPoints} bonus points.");
        }
    }

    // Implement IsComplete
    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    // Implement GetDetailsString
    public override string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {GetName()} ({GetDescription()}) - Completed {_currentCount}/{_targetCount}";
    }
}