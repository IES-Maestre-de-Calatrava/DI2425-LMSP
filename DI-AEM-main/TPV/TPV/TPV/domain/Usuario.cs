﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPV.persistence.manages;

namespace TPV.domain
{
    internal class Usuario
    {
        public int idUsuario { get; set; }
        public String nombre { get; set; }
        public String password { get; set; }

        public int idRol { get; set; }

        private UsuarioManage usuarioManage;
        public Usuario(int idUsuario, String nombre, String password, int idRol)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.password = password;
            this.idRol = idRol;
        }

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public Usuario(string nombre, string password, int idRol)
        {
            this.nombre = nombre;
            this.password = password;
            this.idRol = idRol;
        }

        public Usuario()
        {
        }

        public List<Usuario> LeerUsuarios()
        {
            usuarioManage = new UsuarioManage();
            return usuarioManage.LeerUsuarios();
        }

        public List<Usuario> LeerUsuariosGestion()
        {
            usuarioManage = new UsuarioManage();
            return usuarioManage.LeerUsuariosGestion();
        }

        public void InsertarUsuario(Usuario usuario)
        {
            usuarioManage = new UsuarioManage();
            usuarioManage.InsertarUsuario(usuario);

        }

        public void ModificarUsuario(Usuario usuario)
        {
            usuarioManage = new UsuarioManage();
            usuarioManage.ModificarUsuario(usuario);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            usuarioManage = new UsuarioManage();
            usuarioManage.EliminarUsuario(usuario);
        }
    }
}
