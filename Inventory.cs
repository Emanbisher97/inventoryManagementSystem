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

        public int GetNewId()
        {
            int id;
            if (products.Count == 0)
                id = 1;
            else
            {
                id = products.Last().Id + 1;
            }
            return id;
        }
        public void AddProduct()
        {
            Console.WriteLine("Please Enter the Details for the product");
            Console.WriteLine("Product Name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Price:");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Quantity:");
            int productQuantity = int.Parse(Console.ReadLine());
            Product product = new Product(GetNewId(), productName, productPrice, productQuantity);
            products.Add(product);
            Console.WriteLine("The Product added successfully");
        }

        public void ViewAllProducts()
        {
            Console.WriteLine("All products in inventory:");
            foreach (Product product in products)
            {
                PrintProductInfo(product);
            }
        }

        public string PrintProductInfo(Product product) => $"Prodcut Name is {product.Name}, Product Price is {product.Price}, product quntity is {product.Quantity}";
        
    }
}
