using System.Xml;

public class Order
{
    private Customer _customer;
    private List<Product> _productList = new List<Product>();


    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double cost = 0;
        foreach (Product product in _productList)
        {
            cost += product.ProductCost();
        }
        cost += _customer.GetAddress().ForeignCountry();
        
        return Math.Round(cost, 2);
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetAddressString());
        Console.WriteLine();
    }
    
    public void ProductLabel()
    {
        foreach (Product product in _productList)
        {
            Console.WriteLine(product.ProductInfo());
        }    
        Console.WriteLine();
        Console.WriteLine("Total Cost: $" + CalculateTotalCost());
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }
}