using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Kimathi Waweru", address1);
        Customer customer2 = new Customer("Muturi Thumbi", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP123", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "MS456", 29.99m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KB789", 79.99m, 3));
        order2.AddProduct(new Product("Monitor", "MN012", 199.99m, 1));

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}