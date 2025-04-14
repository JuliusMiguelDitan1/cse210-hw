using System;

public class Running : Activity {
    private int _length;
    private string _date;

    private double _distance;

    double a;



    public Running(int val, string date, double laps) : base(val,date) {
        _length = val;
        _date = date;
        _distance = laps;
    }

    public override double Distance(){
        a = _distance;
        return a;
    }

    public override double Speed(){
        a = Distance() / _length * 60;
        return a;
    }

    public override double Pace(){
        a =  _length / Distance();
        return a;
    }

    public override void GetSummary() {
        Console.WriteLine($"-{_date}, Running ({_length} min): Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace()} min per km.");
    }

}