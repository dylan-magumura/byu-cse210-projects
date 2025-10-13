public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _completed = false;
    }

    public override int RecordEvent()
    {
        _completed = true;
        return _points;
    }

    public override bool IsComplete() => _completed;

    public override string GetStatus()
    {
        return (_completed ? "[X]" : "[ ]") + $" {_name} ({_description})";
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_completed}";
    }
}
