

public class EternalGoal : Goal {
    private string _ShortName;
    private string _description;
    private int _points;

    public EternalGoal(string name, string desc, int point) : base(name, desc, point) {
        _ShortName = name;
        _description = desc;
        _points = point;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! you have earned {_points} points.");
    }
    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string a = $"EternalGoal:{_ShortName},{_description},{_points}";
        return a;
    }
}