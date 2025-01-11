using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTPV.Domain
{
    public class Usuario
    {
        private string user;
        private string pass;

        public Usuario()
        {
        }

        public Usuario(string user, string pass)
        {
            this.User = user;
            this.Pass = pass;
        }

        public string Pass { get => pass; set => pass = value; }
        public string User { get => user; set => user = value; }



    }
}
