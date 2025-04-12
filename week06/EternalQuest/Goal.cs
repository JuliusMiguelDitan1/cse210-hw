using System;

public abstract class Goal {
    private string _ShortName;
    private string _description;
    private int _points;
    int p = 0;

    public Goal(string name, string desc, int point) {
        _ShortName = name;
        _description = desc;
        _points = point;
    }

    public int Score(){
        return _points;
    }

    public virtual int Bonus(){
        return p;
    }

    public abstract void RecordEvent();

    public abstract bool isComplete();

    public virtual string GetDetailsString() {
        string a = isComplete() ? $"[/] {_ShortName} ({_description})": $"[ ] {_ShortName} ({_description})";
        return a;
    }

    public abstract string GetStringRepresentation();

}