public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int index)
    {
        int points = _goals[index].RecordEvent();
        _score += points;
        Console.WriteLine($"You earned {points} points! Total Score: {_score}");
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\n*** Total Score: {_score} ***\n");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
                writer.WriteLine(g.GetSaveString());
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]))
                    {
                        // optional: load completion status if needed
                    });
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;

                case "ChecklistGoal":
                    var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                 int.Parse(parts[5]), int.Parse(parts[4]));
                    // Use reflection or overload to set current count
                    typeof(ChecklistGoal).GetField("_currentCount", 
                        System.Reflection.BindingFlags.NonPublic | 
                        System.Reflection.BindingFlags.Instance)
                        ?.SetValue(goal, int.Parse(parts[6]));
                    _goals.Add(goal);
                    break;
            }
        }
    }

    public int GoalCount() => _goals.Count;
}
