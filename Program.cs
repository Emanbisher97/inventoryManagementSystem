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
            inventory.AddProduct();
        }
        else if (code == 2)
        {
            inventory.ViewAllProducts();
        }
        else if (code == 3)
        {
            inventory.EditProduct();
        }
        else if (code == 4)
        {
            inventory.DeleteProduct();
        }
        else if (code == 5)
        {
            inventory.SearchForProduct();
        }
        else if (code == 6)
        {
            inventory.ExitApplication();
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
