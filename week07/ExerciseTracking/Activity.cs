using System;

public abstract class Activity {
    private int _length;
    private string _date;



    public Activity(int val, string date) {
        _length = val;
        _date = date;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public abstract void GetSummary();

}