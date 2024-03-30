using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Customer & Address: ");
        Order order = new(new Customer("Joe", new Address("123 Min St.", "Metropolis", "IR", "UK")));
        
        order.AddProduct(new Product("Toothbrush", 2.99, "001", 2));
        order.AddProduct(new Product("Floss", 4.99, "002", 5));
        
        order.ShippingLabel();
        order.ProductLabel();

        Console.WriteLine();
        Console.WriteLine("**************************************");
        Console.WriteLine();

        Console.WriteLine("Address: ");
        Order order1 = new(new Customer("Bob", new Address("456 Max St.", "Gotham", "NY", "US")));
        
        order1.AddProduct(new Product("Fork", 3.99, "003", 4));
        order1.AddProduct(new Product("Spoon", 3.99, "004", 4));
        order1.AddProduct(new Product("Knife", 4.99, "005", 4));

        order1.ShippingLabel();
        order1.ProductLabel();
        Console.WriteLine();
    }
}