public abstract class Goal
{
    // Shared attributes
    private string _name;
    private string _description;
    private int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Getters
    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    // Abstract methods to be implemented by derived classes
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
}