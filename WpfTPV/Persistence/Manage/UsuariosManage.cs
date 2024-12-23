using ExampleMVCnoDatabase.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPV.modelo;

namespace TPV.persistencia
{
    internal class UsuariosManage
    {

        
        public UsuariosManage()
        {
            
        }

        public static Usuario encontrarUsuario(String nombre)
        {

            Usuario usuario = DBBroker.obtenerAgente().leerUsuario($"Select * from mydb.usuario WHERE NOMBREUSUARIO='{nombre}';"); ;

            return usuario;
        }

    }
}
