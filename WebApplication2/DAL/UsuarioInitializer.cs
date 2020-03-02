using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class UsuarioInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UsuarioContext>
    {
        protected override void Seed(UsuarioContext context)
        {
            var usuarios = new List<UsuarioModel>
        {
        new UsuarioModel{id = 1,
            nome = "aaaaaaa",
            sobrenome = "bbbbbbb",
            endereco = "ccccccc, 100",
            email = "ddddd@yahoo.com",
            nascimento = Convert.ToDateTime("20/11/1994") },
        new UsuarioModel{id = 2,
            nome = "111111",
            sobrenome = "22222",
            endereco = "333333, 50",
            email = "44444@bol.com.br",
            nascimento = Convert.ToDateTime("06/07/1974") }
        };

            usuarios.ForEach(s => context.Usuarios.Add(s));
            context.SaveChanges();
               
        }
    }
}