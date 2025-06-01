public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string DisplayLabel()
    {
        return $"{_name} (ID: {_id})";
    }
    public void Display()
    {
        Console.WriteLine($"Product: {_name}");
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Price: {_price:C}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Total Cost: {TotalCost():C}");
    }
}
