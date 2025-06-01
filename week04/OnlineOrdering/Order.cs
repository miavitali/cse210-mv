using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.TotalCost();
        }

        if (_customer.LivesInUsa())
        {
            total += 5;  // envío dentro de USA
        }
        else
        {
            total += 35; // envío internacional
        }

        return total;
    }

    public string CreatePackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        sb.AppendLine("----------------------------");

        foreach (Product p in _products)
        {
            sb.AppendLine(p.DisplayLabel()); // asumimos que DisplayLabel() devuelve un string
        }

        sb.AppendLine("----------------------------");
        return sb.ToString();
    }

    public string CreateShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
