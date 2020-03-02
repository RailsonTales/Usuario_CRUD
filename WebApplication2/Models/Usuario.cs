using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Usuario
    {
        public List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        public Usuario()
        {
            listaUsuarios.Add(new UsuarioModel
            {
                id = 1,
                nome = "Railson",
                sobrenome = "Oliveira",
                endereco = "Rua Gisele, 100",
                email = "railson@yahoo.com",
                nascimento = Convert.ToDateTime("20/11/1994")
            });
            listaUsuarios.Add(new UsuarioModel
            {
                id = 2,
                nome = "Rosangela",
                sobrenome = "Barbosa",
                endereco = "Rua Martins, 50",
                email = "rosangela@bol.com.br",
                nascimento = Convert.ToDateTime("06/07/1974")
            });
            listaUsuarios.Add(new UsuarioModel
            {
                id = 3,
                nome = "Raul",
                sobrenome = "Fernando",
                endereco = "Rua Albano, 10",
                email = "raul@hotmail.com",
                nascimento = Convert.ToDateTime("22/06/1993")
            });
        }
        public void CriaUsuario(UsuarioModel usuarioModelo)
        {
            listaUsuarios.Add(usuarioModelo);
        }

        public void AtualizaUsuario(UsuarioModel usuarioModelo)
        {
            foreach (UsuarioModel usuario in listaUsuarios)
            {
                if (usuario.id == usuarioModelo.id)
                {
                    listaUsuarios.Remove(usuario);
                    listaUsuarios.Add(usuarioModelo);
                    break;
                }
            }
        }
        public UsuarioModel GetUsuario(int Id)
        {
            UsuarioModel _usuarioModel = null;

            foreach (UsuarioModel _usuario in listaUsuarios)
                if (_usuario.id == Id)
                    _usuarioModel = _usuario;

            return _usuarioModel;
        }

        public void DeletarUsuario(int Id)
        {
            foreach (UsuarioModel _usuario in listaUsuarios)
            {
                if (_usuario.id == Id)
                {
                    listaUsuarios.Remove(_usuario);

                    break;
                }
            }
        }
    }
}