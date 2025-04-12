

public class SimpleGoal : Goal {
    private bool _iscomplete;
    private string _ShortName;
    private string _description;
    private int _points;

    public SimpleGoal(string name, string desc, int point, bool val) : base(name, desc, point){
        _ShortName = name;
        _description = desc;
        _points = point;
        _iscomplete = val;
    }

    public override void RecordEvent()
    {
        _iscomplete = true;
        Console.WriteLine($"Congratulations! you have earned {_points} points.");
    }
    public override bool isComplete()
    {
        return _iscomplete;
    }
    public override string GetStringRepresentation()
    {
        string a = $"SimpleGoal:{_ShortName}:{_description}:{_points}:{_iscomplete}";
        return a;
    }
}