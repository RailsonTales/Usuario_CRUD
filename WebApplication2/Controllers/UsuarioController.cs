using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UsuarioController : Controller
    {
        private static Usuario _usuarios = new Usuario();
        private UsuarioContext db = new UsuarioContext();

        public ActionResult Index()
        {
            //return View(_usuarios.listaUsuarios);
            return View(db.Usuarios.ToList());
        }

        public ActionResult AdicionaUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(UsuarioModel _usuarioModel)
        {
            db.Usuarios.Add(_usuarioModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ViewResult DeletaUsuario(int id)
        {
            return View(_usuarios.GetUsuario(id));
        }

        [HttpPost]
        public RedirectToRouteResult DeletaUsuario(int id, UsuarioModel _usuarioModel)
        {
            //_usuarios.DeletarUsuario(id);
            db.Usuarios.Remove(db.Usuarios.Single(x => x.id == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditaUsuario(int id)
        {
            //return View(_usuarios.GetUsuario(id));            
            return View(db.Usuarios.Where(x => x.id == id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult EditaUsuario(UsuarioModel _usuarioModel)
        {
            //_usuarios.AtualizaUsuario(_usuarioModel);
            var usuario = db.Usuarios.SingleOrDefault(a => a.id == _usuarioModel.id);
            usuario.nome = _usuarioModel.nome;
            usuario.sobrenome = _usuarioModel.sobrenome;
            usuario.endereco = _usuarioModel.endereco;
            usuario.email = _usuarioModel.email;
            usuario.nascimento = _usuarioModel.nascimento;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}