using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestpro.Dominio
{
    class User
    {
        private String username;
        private String password;
        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
        }
        public User(String username)
        {
            this.username = username;
            this.password = string.Empty;
        }
        public User()
        {
            this.username = String.Empty;
            this.password = String.Empty;
        }
        public String Username { get => this.username; }
        public String Password { get => this.password; set => this.password = value; }
      
    }
}
