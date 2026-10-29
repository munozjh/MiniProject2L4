using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;


namespace MiniProject2L4
{
    internal class ProductManager
    {
        public List<Product> products;
        public ProductManager()
        {
            products = new List<Product>();
        }

        public ProductManager(List<Product> products)
        {
            this.products = products;
        }

        public void AddProduct(string category, string name, decimal price)
        {
            
            Product product = new Product(category, name, price);
            products.Add(product);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Product added successfully.");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine(product.Category + " " + product.Name + " " + product.Price + " has been added to the list.");
        }
        public void ViewProducts()
        {
            List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("===================== Product List ====================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{"Category",-15} | {"Name",-15} | {"Price",10}");
            Console.ResetColor();
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"{product.Category,-15} | {product.Name,-15} | {product.Price,10:C}");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
        public void SearchProducts(string searchTerm)
        {
            List<Product> searchResults = products.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                               p.Category.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                                               .ToList();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("FOUND PRODUCTS:             ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"{"Category",-15} | {"Name",-15} | {"Price",10}");
            foreach (var product in searchResults)
            {
                Console.WriteLine($"{product.Category,-15} | {product.Name,-15} | {product.Price,10:C}");
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }
        public void GetTotalPrice()
        {
           
          decimal totalPrice = products.Sum(p => p.Price);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Total price of all products: {totalPrice:C}");
            Console.WriteLine("-------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();


        }
    }
}
