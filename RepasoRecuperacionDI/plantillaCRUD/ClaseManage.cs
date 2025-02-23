using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plantillaCRUD
{
    internal class ClaseManage
    {
        public List<Clase> selectAll()
        {
            Clase clase = null;
            List<Object> aux = DBBroker.obtenerAgente().leer("Select * from schema33.CLASE;");
            List<Clase> clases = new List<Clase>();
            foreach (List<Object> c in aux)
            {

                clase = new Clase(Convert.ToInt32(c[0]), c[1].ToString(), Convert.ToDateTime(c[2]), c[3].ToString(), Convert.ToInt32(c[4]));
                clases.Add(clase);
            }
            return clases;
        }
        public int getLastId()
        {
            int id = 0;
            List<Object> aux = DBBroker.obtenerAgente().leer("SELECT MAX(ID) FROM schema33.CLASE;");


            if (aux.Count > 0 && aux[0] is List<object> fila && fila.Count > 0 && fila[0] != DBNull.Value && Int32.TryParse(fila[0].ToString(), out id)) { }
            

            return id;
        }

        public void insert(Clase c)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            string date = c.fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "INSERT INTO schema33.CLASE (Nombre, Fecha, Combo, Numero) VALUES ('" + c.nombre + "', '" + date + "', '" + c.combo + "' ," + c.numero + ");";

            dBBroker.modificar(query);
        }
        public void modify(Clase c)
        {
            DBBroker db = DBBroker.obtenerAgente();
            string date = c.fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "UPDATE schema33.CLASE SET Nombre = '" + c.nombre + "', Fecha = '" + date + "', Combo = '" + c.combo + "', Numero=" + c.numero + " WHERE ID = " + c.id + ";";
            db.modificar(query);

        }
        public void delete(Clase c)
        {
            DBBroker db = DBBroker.obtenerAgente();
            db.modificar("DELETE FROM schema33.CLASE where ID=" + c.id + ";");
        }
    }
}
