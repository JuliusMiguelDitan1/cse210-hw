

public class ChecklistGoal : Goal {

     private bool _iscomplete;
    private string _ShortName;
    private string _description;
    private int _points;
    private int _bonus;
    private int _target;

    private int p = 0;

    public ChecklistGoal(string name, string desc, int point, bool val, int tar, int bonus) : base(name, desc, point){
        _ShortName = name;
        _description = desc;
        _points = point;
        _iscomplete = val;
        _target = tar;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _iscomplete = true;
        Console.WriteLine($"Congratulations! you have earned {_points} points.");
        p++;
        if (isComplete()) {
        Console.WriteLine($"Congratulations! you have earned {_bonus} of bonus points.");
        }
    }
    public override bool isComplete()
    {
            return p==_target;
        
    }
    public override int Bonus() {
        if (isComplete()) {
        return _bonus;
        } else {
            return 0;
        }
    }

    public override string GetDetailsString() {
        string a = isComplete() ? $"[/] {_ShortName} ({_description}) -- Amount Completed {p}/{_target}": $"[ ] {_ShortName} ({_description}) -- Amount Completed {p}/{_target}";
        return a;
    }


    public override string GetStringRepresentation()
    {
        string a = $"ChecklistGoal:{_ShortName}:{_description}:{_points}:{_iscomplete}:{_target}:{_bonus}:{p}";
        return a;
    }
}