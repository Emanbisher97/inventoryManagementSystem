// See https://aka.ms/new-console-template for more information
using inventoryManagementSystem;

Inventory inventory = new Inventory();

int code;

Console.WriteLine("Inventory Managment System");
Console.WriteLine("-------------- -------------");
Console.WriteLine(" 1. Add Product");
Console.WriteLine(" 2. View All Products");
Console.WriteLine(" 3. Edit Product");
Console.WriteLine(" 4. Delete Product");
Console.WriteLine(" 5. Search for a Product");
Console.WriteLine(" 6. Exit");
Console.WriteLine("-------------- -------------");
try {
    Console.WriteLine("Select your option:");
    code = int.Parse(Console.ReadLine());
    while (code != 6)
    {
        if (code == 1)
        {
            Console.WriteLine("Please Enter the Details for the product");
            Console.WriteLine("Product Name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Price:");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Quantity:");
            int productQuantity = int.Parse(Console.ReadLine());
            Product p =new Product(productName, productPrice, productQuantity);
            inventory.AddProduct(p);
        }
        else if (code == 2)
        {
            inventory.ViewAllProducts();
        }
        else if (code == 3)
        {
            Console.WriteLine("Enter product Name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter new product Name:");
            string newProductName = Console.ReadLine();
            Console.WriteLine("Enter new product Price:");
            decimal newProductPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter new product Quantity:");
            int newProductQuantity = int.Parse(Console.ReadLine());
            Product newProduct = new Product(newProductName, newProductPrice, newProductQuantity);
            inventory.EditProduct(productName, newProduct);
        }
        else if (code == 4)
        {
            Console.WriteLine("Enter product Name:");
            string productName = Console.ReadLine();
            inventory.DeleteProduct(productName);
        }
        else if (code == 5)
        {
            Console.WriteLine("Enter product Name:");
            string productName = Console.ReadLine();
            inventory.SearchForProduct(productName);
        }
        else if (code == 6)
        {
            Environment.Exit(0);
        }
        Console.WriteLine("Select your option:");
        code = int.Parse(Console.ReadLine());
    }
}
catch
{
    Console.WriteLine("You enter the wrong character e.g abcd!@#");
    Console.WriteLine("Please re-enter a number e.g 123456");
    code = int.Parse(Console.ReadLine());
}
