using System;

public class Cycling : Activity {
    private int _length;
    private string _date;

    private int _Speed;

    double a;



    public Cycling(int val, string date, int laps) : base(val,date) {
        _length = val;
        _date = date;
        _Speed = laps;
    }

    public override double Distance(){
        a = _length / Pace();
        return a;
    }

    public override double Speed(){
        a = _Speed;
        return a;
    }

    public override double Pace(){
        a =  60 / Speed();
        return a;
    }

    public override void GetSummary() {
        Console.WriteLine($"-{_date}, Cycling ({_length} min): Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace()} min per km.");
    }

}