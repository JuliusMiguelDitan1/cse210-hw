using System;


public abstract class Shape {
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string Getcolor(){
        return _color;
    }

    public void SetColor(string n) {
        _color = n;
    }

    public abstract double GetArea();
}