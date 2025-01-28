using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestpro.Dominio
{
    internal class Employ : User
    {
        private String name;
        private String surName;
        private int role;
        private double csr;
        private int idUser;
        public Employ(String name, String surName, int role, double csr) 
        {
            this.name = name;
            this.surName = surName;
            this.role = role;
            this.csr = csr;
        }
        public Employ() { }
        public String Name {  get { return name; } }
        public String SurName { get { return surName; } }   
        public int Role { get { return role; } }      
        public double CSR { get { return csr; } }
        public int IdUser { get => idUser; set => this.IdUser = value; }
    }
}
