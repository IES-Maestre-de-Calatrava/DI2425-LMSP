using DataGridPersonas.persistence;
using WpfTPV.Domain;
using System.Linq;

namespace WpfTPV.Persistence.Manage
{
    internal class UsuariosManage
    {

        
        public UsuariosManage()
        {
            
        }

        public static Usuario encontrarUsuario(String nombre)
        {


            Usuario usuario = DBBroker.ObtenerAgente().LeerUsuario($"Select * from mydb.usuario WHERE NOMBREUSUARIO='{nombre}';");
            return usuario;
        }

    }
}
