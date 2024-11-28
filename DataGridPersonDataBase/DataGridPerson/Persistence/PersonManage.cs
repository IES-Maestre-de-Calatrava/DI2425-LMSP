using DataGridPerson.Domain;
using DataGridPerson.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataGridPerson.Persistance
{
    class PersonManage
    {
        public List<Person> listPerson {  get; set; }
        int lastId;

        public PersonManage()
        {
            listPerson = new List<Person>();
        }
        public int getLastId(Person inputPerson)
        {
            List<Object> listAux;
            listAux = DBBroker.ObtenerAgente().Leer("SELECT MAX(idpeople) FROM people;");

            foreach (List<Object> auxProject in listAux)
            {
                lastId = Convert.ToInt32(auxProject[0]) + 1;
            }

            return lastId;
        }
        public void ReadPerson()
        {
            Person p = null;
            List<Object> lperson;
            lperson = DBBroker.ObtenerAgente().Leer("select * from people order by idpeople");
            foreach (List<Object> aux in lperson)
            {
                p = new Person(Int32.Parse(aux[0].ToString()), aux[1].ToString(), aux[2].ToString(), Int32.Parse(aux[3].ToString()));//
                this.listPerson.Add(p); 
            }
        }
    }
}
