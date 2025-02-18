
using GestPro2.Dominio;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestPro2.persistence.manages
{
    internal class EmployManage
    {

        public List<Employ> listEmploy { get; set; }

        public EmployManage()
        {
            listEmploy = new List<Employ>();
        }

      
        
        public void insertEmploy(Employ e)
        {
            
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("Insert into empleado (NOMBREEMP,APELLIDOSEMP,IDROL,CSR) values ('" + e.Name + "','" + e.SurName + "',"+e.Role+","+ e.CSR+");");
            
        }
        public void deleteEmploy(Employ e)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("Delete from empleado where NOMBREEMP='"+ e.Name +"'" );
        }
        public void modifyEmploy(Employ e)
        {
            String nameOld = e.Name;
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("Update empleado set NOMBREEMP = '" + e.Name + "', APELLIDOSEMP = '"+ e.SurName+"', IDROL = "+e.Role+", CSR = "+e.CSR+"  where IDUSUARIO = '"+readUserId(e)+"';");
        }
        private int readUserId(Employ e)
        {
            int idUser = -1;
            List<Object> lista = new List<Object>();
            DBBroker dBBroker = DBBroker.obtenerAgente();
            lista = dBBroker.leer("SELECT IDUSUARIO from usuario where NOMBREUSUARIO = '" + e.Username + "';");
            idUser = Int32.Parse(lista[0].ToString());
  
            return idUser;
        }

    }
}
