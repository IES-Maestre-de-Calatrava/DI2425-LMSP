using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysqlx.Crud;

namespace plantillaCRUD
{
    internal class Clase

    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public string combo { get; set; }
        public int numero { get; set; }
        private ClaseManage claseManage = new ClaseManage();

        public Clase(string nombre, DateTime fecha, string combo, int numero)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.combo = combo;
            this.numero = numero;
            id = claseManage.getLastId() + 1;
        }
        public Clase() { }
        public Clase(int id, string nombre, DateTime fecha, string combo, int numero)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha = fecha;
            this.combo = combo;
            this.numero = numero;
        }
        public void insert()
        {
            claseManage.insert(this);
        }
        public void modify()
        {
            claseManage.modify(this);
        }
        public void delete()
        {
            claseManage.delete(this);
        }
    }
}
