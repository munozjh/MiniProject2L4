using MiniProject2L4;
bool exit = false;
//List<Product> products = new List<Product>();
ProductManager ProductManager = new ProductManager();
decimal price =0;
string category =string.Empty;
string name;

while (!exit)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("  PRODUCT MANAGEMENT SYSTEM  ");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. View Products");
    Console.WriteLine("3. Search Product");
    Console.WriteLine("4. Total Price from products");
    Console.WriteLine("5. Exit");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Select option: ");
    string choice = Console.ReadLine().Trim();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            bool quit = false;
            
            while (!quit)
            {
              
                while (true)
                {
                    Console.Write("Enter product category or 'q' to go back to main menu: ");
                    string input = Console.ReadLine().Trim();
                    if (input.ToLower() == "q")
                    {
                        quit = true;
                        break;
                    }
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Category cannot be empty. Please enter a valid category.");
                        Console.ResetColor();
                        continue;
                    }

                    if(input.Any(char.IsDigit))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Category cannot contain numbers. Please enter a valid category.");
                        Console.ResetColor();
                        continue;
                    }
                    if(input.Length > 15 || input.Length < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Category must be between 3 and 15 characters. Please enter a valid category.");
                        Console.ResetColor();
                        continue;
                    }
                    category = input;
                    break;

                }
                if (quit)
                {
                    break;
                }

                while (true)
                {
                    Console.Write("Enter product name: ");
                    string input = Console.ReadLine().Trim();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
                        Console.ResetColor();
                        continue;
                    }

                    if (input.Any(char.IsDigit))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Name cannot contain numbers. Please enter a valid name.");
                        Console.ResetColor();
                        continue;
                    }
                    if (input.Length > 15 || input.Length < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Name must be between 3 and 15 characters. Please enter a valid name.");
                        Console.ResetColor();
                        continue;
                    }
                    name = input;
                    break;

                }  
                    
                while (true)
                {
                    try
                   {
                       Console.Write("Enter product price: ");
                       price = decimal.Parse(Console.ReadLine().Trim());
                        if (price <0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Price cannot be negative. Please enter a valid price.");
                            Console.ResetColor();
                            continue;
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid price format. Please enter a valid decimal number.");
                        Console.ResetColor();
                        continue;
                    }
                    
                }

                ProductManager.AddProduct(category, name, price);

            }
            
            break;
        case "2":
            ProductManager.ViewProducts();
            break;

        case "3":

            while (true)
            {
                Console.Write("Search Product: ");
                string searchTerm = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Search term cannot be empty. Please enter a valid search term.");
                    Console.ResetColor();
                    continue;
                }
                if (searchTerm.Any(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Search term cannot contain numbers. Please enter a valid search term.");
                    Console.ResetColor();
                    continue;
                }
                ProductManager.SearchProducts(searchTerm);
                break;
            }
            break;

        case "4":
            ProductManager.GetTotalPrice();
            break;

        case "5":
            Console.WriteLine("Exiting the program. Goodbye!");
            exit = true;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid option. Please try again.");
            Console.ResetColor();
            break;
    }
}