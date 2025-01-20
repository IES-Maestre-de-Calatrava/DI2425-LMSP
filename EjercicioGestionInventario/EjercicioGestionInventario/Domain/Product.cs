using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGestionInventario.Domain
{
    internal class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }

        public Product(string name, int stock, double price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }



    }
}
