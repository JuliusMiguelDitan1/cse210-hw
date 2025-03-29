using System;

public class Address
{
    private string _city{get; set;}
    private string _state{get; set;}
    private string _country{get; set;}

    public Address(string City, string State, string Country) 
    {
        _city = City;
        _state = State;
        _country = Country;
    }

    public bool USAbased() {
        if (_country=="USA"||_country=="usa"){
        return true;
        } else {
            return false;
        }
    }
    public void Display()
    {
        Console.WriteLine($"{_city}, {_state}, {_country}");
    }
}