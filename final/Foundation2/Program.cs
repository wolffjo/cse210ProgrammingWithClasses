using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Product p1 = new Product("Cabbage", "16416", 2, 50);
        Product p2 = new Product("Banana", "73528", 3, 15);
        Product p3 = new Product("Soap Bar", "43256", 6, 37);

        Address a1 = new Address("1234", "New York", "New York");
        Customer c1 = new Customer("John Henry", a1);
        Order o1 = new Order(c1);

        o1.AddProduct(p1);
        o1.AddProduct(p2);

        string label = o1.CreateLabel();
        
        Console.WriteLine(label);
        Console.WriteLine($"${o1.TotalCost()}");


        Console.WriteLine("\n\n\n");



        Address a2 = new Address("5678", "Merida", "Yucatan", "Mexico");
        Customer c2 = new Customer("Spencer Weels", a2);
        Order o2 = new Order(c2);


        o2.AddProduct(p1);
        o2.AddProduct(p2);
        o2.AddProduct(p3);

        label = o2.CreateLabel();

        Console.WriteLine(o2.CreateLabel());
        Console.WriteLine($"${o2.TotalCost()}");
    }
}