using System;

public class Order 
{
    public List<Product> _product = new List<Product>();
    public Customer _customer; 
    List<int> a = new List<int>{};

    public Order(Customer cus) 
    {
        _customer = cus;
    }
    
    public void Totalprice()
    {
        Console.WriteLine("----------------");
        foreach (Product p in _product){
        a.Add(p.compute());
        }
        if (_customer.USAbased()) {
        Console.WriteLine("USA Discount");
        Console.WriteLine("Total:");
        Console.WriteLine($"${a.Sum()}");
        Console.WriteLine();

        }else {
        Console.WriteLine("Total:");
        Console.WriteLine($"${a.Sum()+15}");
        Console.WriteLine();
        }
    }

    public void Packing() {
        Console.WriteLine("----------------");
        Console.WriteLine("Packing:");
        foreach (Product p in _product){
             p.Display();
        }
        Console.WriteLine();
    }

    public void Shipping() {
        Console.WriteLine("----------------");
        Console.WriteLine("Shipping To:");
        _customer.address();
         Console.WriteLine();

    }
}