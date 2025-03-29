using System;

class Program
{
    static void Main(string[] args)
    {
        Product pro1 = new Product("Sharpener", "12D", 12);
        Product pro2 = new Product("Eraser", "45A", 100);
        Product pro3 = new Product("Bondpaper", "99P", 500);
        Order or = new Order(new Customer("JM", "Ditan", new Address("TMC", "Cavite", "Phil")));
        or._product.Add(pro1);
        or._product.Add(pro2);
        or._product.Add(pro3);
        or.Packing();
        or.Shipping();
        or.Totalprice();

        Order or1 = new Order(new Customer("Jared", "Cold",new Address("Tempe","Arizona","USA")));
        Product pro4 = new Product("MRE", "100L", 100);
        Product pro5 = new Product("Hiking gear", "13A", 10);
        Product pro6 = new Product("Tool Kit", "70P", 500);
        or1._product.Add(pro4);
        or1._product.Add(pro5);
        or1._product.Add(pro6);
        or1.Packing();
        or1.Shipping();
        or1.Totalprice();
    }
}