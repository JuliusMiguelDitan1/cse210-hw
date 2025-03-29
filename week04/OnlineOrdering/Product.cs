using System;

public class Product 
{
    private string _pname;
    private string _pID;
    private int _quantity;

    public Product(string productname, string ID, int amount) 
    {
        _pname = productname;
        _pID = ID;
        _quantity = amount;
    }

    public int compute() 
    {
        int a =  _quantity*50;
       return a;
    }

    public void Display()
    {
        Console.WriteLine($"{_pname}, {_pID}, {_quantity}");
    }

}