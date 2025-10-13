public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
            return _points + _bonus;
        else
            return _points;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus()
    {
        string mark = IsComplete() ? "[X]" : "[ ]";
        return $"{mark} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
    }
}
