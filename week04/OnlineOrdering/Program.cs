using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create Addresses
        Address addr1 = new Address("123 Main St", "Denver", "CO", "USA");
        Address addr2 = new Address("456 Queen St", "Toronto", "ON", "Canada");

        // Create Customers
        Customer cust1 = new Customer("John Doe", addr1);
        Customer cust2 = new Customer("Forget Sibanda", addr2);

        // Create Products
        Product prod1 = new Product("Coffee Mug", "CM123", 12.99, 2);
        Product prod2 = new Product("T-shirt", "TS456", 19.99, 1);
        Product prod3 = new Product("Notebook", "NB789", 5.99, 3);

        // Create Orders
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod3);

        Order order2 = new Order(cust2);
        order2.AddProduct(prod2);

        // Display order details
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
