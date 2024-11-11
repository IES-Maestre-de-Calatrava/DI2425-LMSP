using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestpro.Dominio
{
    internal class Proyectos
    {
        private int codProy;
        private String nombre;
        private String fechaInicio;
        private String fechaFin;

        public Proyectos(int codProy, string nombre, string fechaInicio, string fechaFin)
        {
            this.codProy = codProy;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        public int CodProy { get => this.codProy; set => this.codProy = value; }
        public String Nombre { get => this.nombre; set => this.nombre = value; }
        public String FechaInicio {  get => this.fechaInicio; set => this.fechaInicio = value;}
        public String FechaFin { get => this.fechaFin; set => this.fechaFin = value; }
    }
}
