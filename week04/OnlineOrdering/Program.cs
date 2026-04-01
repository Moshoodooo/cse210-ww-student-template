using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 20, 2));

        Address address2 = new Address("45 King Road", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P300", 150, 2));
        order2.AddProduct(new Product("Keyboard", "P400", 50, 1));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
        Console.WriteLine();
    }
}