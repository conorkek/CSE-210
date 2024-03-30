using System.Data.Common;

public class Product
{
    private string _name;
    private double _pricePerUnit;
    private string _id;
    private int _quantity;


    public Product(string name, double pricePerUnit, string id, int quantity)
    {
        _name = name;
        _pricePerUnit = pricePerUnit;
        _id = id;
        _quantity = quantity;
    }


    public string ProductInfo()
    {
        return $"Product Name: {_name} | Product ID: {_id} | Price per Unit: ${_pricePerUnit} | Quantity: {_quantity} | Product Cost: ${Math.Round(ProductCost(), 2)}";
    }


    public double ProductCost()
    {
        return _pricePerUnit * _quantity;
    }
}