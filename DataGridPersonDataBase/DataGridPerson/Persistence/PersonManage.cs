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
        private List<Person> listPerson {  get; set; }

        public PersonManage()
        {
            listPerson = new List<Person>();
        }
        public void ReadPerson()
        {
            Person p = null;
            List<Object> lperson;
            lperson = DBBroker.ObtenerAgente().Leer("select * from people order by idpeople");
            foreach (List<Object> aux in lperson)
            {
                p = new Person(Int32.Parse(aux[0].ToString()));
                p.Name = aux[1].ToString();
                p.SurName = aux[2].ToString();
                p.Age = Int32.Parse(aux[3].ToString());
                
                this.listPerson.Add(p); 
            }
        }
    }
}
