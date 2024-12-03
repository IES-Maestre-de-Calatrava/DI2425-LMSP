
using DataGridPersonas.persistence;
using Gestpro.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gestpro.persistence.manages
{
    internal class ProjectManage
    {

        public List<Proyectos> listProject { get; set; }

        public ProjectManage()
        {
            listProject = new List<Proyectos>();
        }

        public void readProyect()
        {

            Proyectos p = null;
            List<Object> lproyect;
            lproyect = DBBroker.obtenerAgente().leer("select * from proyecto order by IDPROYECTO");
            foreach (List<Object> aux in lproyect)
            {
                p = new Proyectos(Int32.Parse(aux[0].ToString()));
                p.CodProy = aux[1].ToString();
                p.Nombre = aux[2].ToString();
                p.FechaInicio = DateTime.Now.ToString();
                p.FechaFin = DateTime.Now.ToString();
                this.listProject.Add(p);
            }
        }
        
        public void insertProject(Proyectos p)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("Insert into proyecto (CODIGOPROY,NOMBREPROY) values ('" + p.CodProy + "','" + p.Nombre + "')");
            
        }
        public void modifyProject(Proyectos p, string aux)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            string sql = "Update proyecto set CODIGOPROY='" + p.CodProy + "',NOMBREPROY='" + p.Nombre + "' where CODIGOPROY='" + aux+"'";
            dBBroker.modificar(sql);
        }
        
        public void deleteProject(Proyectos p)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("Delete from proyecto where CODIGOPROY='"+ p.CodProy +"'" );
        }

    }
}
