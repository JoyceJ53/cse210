using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
        
        // Create two orders.
        Order order1 = new Order(new Customer("Samantha", "123 Main St.", "Boise", "ID", "USA"));
        Order order2 = new Order(new Customer("Jocelyn", "17 Rue du Faubourg Saint-Honoré", "Paris", "Île-de-France", "France"));

        // Make products
        Product apple = new Product("Apple", 1, 0.99);
        Product banana = new Product("Banana", 2, 0.89);
        Product orange = new Product("Orange", 3, 0.79);
        Product grape = new Product("Grape", 4, 1.99);
        Product lemon = new Product("Lemon", 5, 0.69);

        // Set quantities
        apple.Quantity = 2;
        banana.Quantity = 3;
        orange.Quantity = 4;
        grape.Quantity = 5;
        lemon.Quantity = 6;

        // Add products to each order.
        order1.AddProduct(apple);
        order1.AddProduct(banana);
        order1.AddProduct(orange);
        order2.AddProduct(grape);
        order2.AddProduct(lemon);

        // Print the packing label and shipping label for order 1
        Console.WriteLine();
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        foreach(string label in order1.PrintPackingLabel()){
            Console.WriteLine(label);
        }
        Console.WriteLine(order1.PrintShippingLabel());
        Console.WriteLine($"Order Total:\n    {order1.ProductTotal()}");
        Console.WriteLine();

        // Print the packing label and shipping label for order 2
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        foreach(string label in order2.PrintPackingLabel()){
            Console.WriteLine(label);
        }
        Console.WriteLine(order2.PrintShippingLabel());
        Console.WriteLine($"Order Total:\n    {order2.ProductTotal()}");
        Console.WriteLine();
    }
}