using System;

public class Swimming : Activity {
    private int _length;
    private string _date;

    private int _laps;

    double a;



    public Swimming(int val, string date, int laps) : base(val,date) {
        _length = val;
        _date = date;
        _laps = laps;
    }

    public override double Distance(){
        a = _laps * 50;
        double b = a/1000;
        return b;
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
        Console.WriteLine($"-{_date}, Swimming ({_length} min): Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace()} min per km.");
    }

}