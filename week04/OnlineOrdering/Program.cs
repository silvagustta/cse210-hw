using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer - USA
        Address address1 = new Address(
            "123 Main Street",
            "Orlando",
            "Florida",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // First order
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "L001", 800, 1));
        order1.AddProduct(new Product("Mouse", "M002", 25, 2));

        // Second customer - Outside USA
        Address address2 = new Address(
            "Rua das Flores, 100",
            "Manaus",
            "Amazonas",
            "Brazil"
        );

        Customer customer2 = new Customer("Gustavo Silva", address2);

        // Second order
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "K003", 50, 1));
        order2.AddProduct(new Product("Monitor", "M004", 200, 2));

        // Display first order
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine($"Products:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Subtotal: ${order1.GetTotalCost():F2}");
        Console.WriteLine($"Shipping: ${order1.GetShippingCost():F2}");
        Console.WriteLine($"Total: ${order1.GetTotalOrderCost():F2}");

        Console.WriteLine("\nPACKING LABEL:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order1.GetShippingLabel());

        // Display second order
        Console.WriteLine("\n========== ORDER 2 ==========");
        Console.WriteLine($"Products:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Subtotal: ${order2.GetTotalCost():F2}");
        Console.WriteLine($"Shipping: ${order2.GetShippingCost():F2}");
        Console.WriteLine($"Total: ${order2.GetTotalOrderCost():F2}");

        Console.WriteLine("\nPACKING LABEL:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order2.GetShippingLabel());
    }
}