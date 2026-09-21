class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address(
            "123 Main Street",
            "Provo",
            "UT",
            "USA");
        Customer usaCustomer = new Customer("Alex Johnson", usaAddress);

        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(new Product("Notebook", "N100", 4.50m, 2));
        usaOrder.AddProduct(new Product("Ballpoint Pens", "P200", 2.25m, 3));

        Address internationalAddress = new Address(
            "45 Maple Avenue",
            "Toronto",
            "Ontario",
            "Canada");
        Customer internationalCustomer = new Customer("Morgan Lee", internationalAddress);

        Order internationalOrder = new Order(internationalCustomer);
        internationalOrder.AddProduct(new Product("Desk Lamp", "L300", 18.75m, 1));
        internationalOrder.AddProduct(new Product("USB Cable", "U400", 6.50m, 2));
        internationalOrder.AddProduct(new Product("Mouse Pad", "M500", 9.99m, 1));

        DisplayOrder(usaOrder);
        DisplayOrder(internationalOrder);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: {order.GetTotalPrice():C}");
        Console.WriteLine();
    }
}