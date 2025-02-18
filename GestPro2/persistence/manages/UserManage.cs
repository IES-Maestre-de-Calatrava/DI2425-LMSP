
using DataGridPersonas.persistence;
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
    internal class UserManage
    {

        public List<User> listUsers { get; set; }

        public UserManage()
        {
            listUsers = new List<User>();
        }

        
        public void insertUser(User u)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("Insert into usuario (NOMBREUSUARIO,PASSUSUARIO) values ('" + u.Username + "','" + u.Password + "')");
            
        }
        public void deleteUser(User u)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("Delete from usuario where NOMBREUSUARIO='"+ u.Username +"'" );
        }
        public void updatePass(User u)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("Update usuario set PASSUSUARIO = '" + u.Password + "' where NOMBREUSUARIO = '"+u.Username+"';");
        }

    }
}
