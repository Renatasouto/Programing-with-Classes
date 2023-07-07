using System;
using System;

namespace ProgramingWithClasses
{
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Program 2: Encapsulation with Online Ordering");
        Console.WriteLine();

        Address address1 = new Address("183 Main Street", "Fairfield", "IA", "USA");
        Customer customer1 = new Customer("Ana Karenina", address1);
        Product product1 = new Product("Widget", "W488", 10, 2);
        Product product2 = new Product("Gizmo", "G744", 5, 3);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address("320 E Burlington Ave", "Rio de Janeiro", "RJ", "Brazil");
        Customer customer2 = new Customer("Maria Santos", address2);
        Product product3 = new Product("Thingamabob", "T954", 8, 4);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine("Order #1:");
        Console.WriteLine("Packing:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder #2:");
        Console.WriteLine("Packing:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}
}