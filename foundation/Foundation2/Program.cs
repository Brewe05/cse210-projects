using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Jackson", "CA", "USA");
        Address address2 = new Address("456 Maple Ave", "Springfield", "IL", "Canada");

        Customer customer1 = new Customer("Jack Mayer", address1);
        Customer customer2 = new Customer("Jannet Johnson", address2);

        Product product1 = new Product("Laptop", "A101", 999.99, 1);
        Product product2 = new Product("Phone", "B202", 499.99, 2);
        Product product3 = new Product("Headphones", "C303", 89.99, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
