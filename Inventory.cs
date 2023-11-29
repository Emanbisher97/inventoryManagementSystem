using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventoryManagementSystem
{
    public class Inventory
    {
        public static List<Product> products;

        public Inventory() {
            products = new List<Product>();
        }
        private int GetNewId()
        {
            int id;
            if (!products.Any())
                id = 1;
            else
            {
                id = products.Last().Id + 1;
            }
            return id;
        }
        public void AddProduct(Product product)
        {
            product.Id = GetNewId();
            products.Add(product);
            Console.WriteLine("The Product added successfully");
        }

        public void ViewAllProducts()
        {
            Console.WriteLine("All products in inventory:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PrintProductInfo());
            }
        }

        public void EditProduct(string productName, Product p)
        {
            int index = products.FindIndex(product => product.Name == productName);
            if (index != -1)
            {
                products[index] = p;
            }
            else { Console.WriteLine("The product is not found in the inventory"); }
        }

        public void DeleteProduct(string productName)
        {
            int index = products.FindIndex(product => product.Name == productName);
            if (index != -1)
            {
                products.RemoveAt(index);
                Console.WriteLine("The product is deleted");
            }
            else { Console.WriteLine("The product is not found in the inventory"); }
        }

        public void SearchForProduct(string productName)
        {
            int index = products.FindIndex(product => product.Name == productName);
            if (index != -1)
            {
                Console.WriteLine(products.ElementAt(index).PrintProductInfo());
            }
            else { Console.WriteLine("The product is not found in the inventory"); }
        }
    }
}
