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

        private int GetNewId()
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
                product.PrintProductInfo();
            }
        }

        public void EditProduct()
        {
            Console.WriteLine("Enter product Name:");
            string productName = Console.ReadLine();
            int index = products.FindIndex(product => product.Name == productName);
            if (index != -1)
            {
                Console.WriteLine("Enter new product Name:");
                string newProductName = Console.ReadLine();
                Console.WriteLine("Enter new product Price:");
                decimal newProductPrice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter new product Quantity:");
                int newProductQuantity = int.Parse(Console.ReadLine());
                products[index] = new Product(products[index].Id, newProductName, newProductPrice, newProductQuantity);
            }
            else { Console.WriteLine("The product is not found in the inventory"); }
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter product Name:");
            string productName = Console.ReadLine();
            int index = products.FindIndex(product => product.Name == productName);
            if (index != -1)
            {
                products.RemoveAt(index);
                Console.WriteLine("The product is deleted");
            }
            else { Console.WriteLine("The product is not found in the inventory"); }
        }
    }
}
