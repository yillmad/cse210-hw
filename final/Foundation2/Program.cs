class Program
{
    static void Main(string[] args)
    {
        // Create address
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var address2 = new Address("456 Elm St", "Othertown", "NY", "Canada");

        // Create customers
        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);

        // Create products
        var product1 = new Product("Widget", "W123", 10.50m, 2);
        var product2 = new Product("Gadget", "G456", 20.25m, 1);
        var product3 = new Product("Thingamabob", "T789", 15.75m, 3);

        // Create orders
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}