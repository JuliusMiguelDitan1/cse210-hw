using System;

public class Customer 
{
    private string _fname;
    private string _lname;

    public Address add;


    public Customer(string first, string last, Address ad) 
    {
        _fname = first;
        _lname = last;
        add = ad;
    }

    public void Display() 
    {
        Console.WriteLine($"{_fname} {_lname}");
    }

    public void address() {
        add.Display();
    }

    public bool USAbased() {
        return add.USAbased();
    }

}