using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EjercicioGestionInventario.Domain;

namespace EjercicioGestionInventario
{
    internal class Program
    {   
        private static Inventory inventory = new Inventory();
        static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            int option = -1;
            do
            {
                ShowMenu();
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter product stock: ");
                        int stock = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter product price: ");
                        double price = Double.Parse(Console.ReadLine());
                        AddProduct(name, stock, price);
                        break;
                    case 2:
                        ShowInventory();
                        break;
                    case 3:
                        Console.WriteLine("Enter product name: ");
                        string productName = Console.ReadLine();
                        ShowProduct(productName);
                        break;
                    case 4:
                        Console.WriteLine("Enter product name: ");
                        string productName2 = Console.ReadLine();
                        Console.WriteLine("Enter new stock: ");
                        int newStock = Int32.Parse(Console.ReadLine());
                        ChangeStock(FindProduct(productName2), newStock);
                        break;
                    case 5:
                        Console.WriteLine("Enter product name: ");
                        string productName3 = Console.ReadLine();
                        DeleteProduct(FindProduct(productName3));
                        break;
                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }while(option != 0);
        }
        private static void ShowMenu()
        {
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Show inventory");
            Console.WriteLine("3. Show product");
            Console.WriteLine("4. Change stock");
            Console.WriteLine("5. Delete product");
            Console.WriteLine("0. Quit");
        }
        private static void AddProduct(string name, int stock, double price)
        {

            Product product = new Product(name, stock, price);
            inventory.Products.Add(product);
        }
        private static void ShowInventory()
        {
            int counter = 1;
            foreach(Product p in inventory.Products)
            {
                Console.WriteLine($"#{counter}--> Nombre: " + p.Name + "; Stock: " + p.Stock + "; Precio: " + p.Price+"$");
                counter++;
            }
        }
        private static Product FindProduct(string productName)
        {
            Product product = null;
            product = inventory.Products.FirstOrDefault(Product => Product.Name == productName);
            return product;
        }
        private static void ShowProduct(string productName)
        {
            Product pE = null;
            pE = FindProduct(productName);
            if (pE == null)
            {
                Console.WriteLine("Product not found");
            }
            else
            {
                Console.WriteLine($"#--> Nombre: " + pE.Name + ", Stock: " + pE.Stock + ", Precio: " + pE.Price + "$");
            }
            
        }
        private static void ChangeStock(Product product, int newStock)
        {
            product.Stock = newStock;
        }
        private static void DeleteProduct(Product product)
        {
            inventory.Products.Remove(product);
        }
    }
}
