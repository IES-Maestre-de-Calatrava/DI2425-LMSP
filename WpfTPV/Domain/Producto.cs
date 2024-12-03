using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTPV.Domain
{
    class Producto
    {
        #region Constants
        public const int TOAST = 1;
        public const int COFFEE = 2;
        #endregion

        private int idproducto;
        private String nombre;
        private double precio;
        private int unidades;
        public Producto(int idproducto, String nombre, double precio, int unidades)
        {
            this.idproducto = idproducto;
            this.nombre = nombre;
            this.precio = precio;
            this.unidades = unidades;
        }
        public int Idproducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }
    }
}
