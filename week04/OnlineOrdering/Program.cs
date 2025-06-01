using System;

class Program
{
    static void Main(string[] args)
    {
        // === ORDER 1 ===
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Product notebook = new Product("Notebook", 1001, 2.50, 3);
        Product pen = new Product("Pen", 1002, 1.00, 5);
        Product backpack = new Product("Backpack", 1003, 25.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(notebook);
        order1.AddProduct(pen);
        order1.AddProduct(backpack);

        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotal():C}");
        Console.WriteLine();

        // === ORDER 2 ===
        Address address2 = new Address("456 Elm Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);

        Product monitor = new Product("Monitor", 2001, 150.00, 1);
        Product mouse = new Product("Mouse", 2002, 20.00, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(monitor);
        order2.AddProduct(mouse);

        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotal():C}");
    }
}