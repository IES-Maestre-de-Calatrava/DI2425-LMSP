using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGestionInventario.Domain
{
    internal class Inventory
    {
        public List<Product> Products { get; set; }
        
        public Inventory() {
            Products = new List<Product>();
        }
    }
}
