using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestpro.Dominio
{
    internal class Proyectos
    {
        private int id;
        private String codProy;
        private String nombre;
        private String fechaInicio;
        private String fechaFin;

        public Proyectos(String codProy, string nombre, string fechaInicio, string fechaFin)
        {  
            this.codProy = codProy;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        public Proyectos(int id,String codProy, string nombre, string fechaInicio, string fechaFin)
        {
            this.id = id;
            this.codProy = codProy;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        public Proyectos(int id)
        {
            this.id = id;
        }
        public int Id { get => this.id; set => this.id = value; }
        public String CodProy { get => this.codProy; set => this.codProy = value; }
        public String Nombre { get => this.nombre; set => this.nombre = value; }
        public String FechaInicio {  get => this.fechaInicio; set => this.fechaInicio = value;}
        public String FechaFin { get => this.fechaFin; set => this.fechaFin = value; }
    }
}
