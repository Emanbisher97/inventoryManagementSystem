using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryManagementSystem
{
    public class Inventory
    {
        List<Product> products = new List<Product>();

        public void AddProduct()
        {
            Console.WriteLine("Please Enter the Details for the product");
            Console.WriteLine("Product Name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Price:");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Quantity:");
            int productQuantity = int.Parse(Console.ReadLine());
            Product product = new Product(productName, productPrice, productQuantity);
            products.Add(product);
            Console.WriteLine("The Product added successfully");
        }
    }
}
