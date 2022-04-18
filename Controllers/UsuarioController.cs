using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{

    public class UsuarioController : Controller
    {
        public IActionResult ListarUsuario()
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.verificaSeUsuarioeAdmin(this);//XXXXXXXXXXXXXXXXXXXXXXX

            return View(new UsuarioService().Listar());
        }

        public IActionResult EditarUsuario(int id)
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.verificaSeUsuarioeAdmin(this);//XXXXXXXXXXXXXXXXXXXXXXX

            Usuario u = new UsuarioService().ListarUser(id);

            return View(u);
        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuario userEditado)
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.verificaSeUsuarioeAdmin(this);//XXXXXXXXXXXXXXXXXXXXXXX

            UsuarioService us = new UsuarioService();
            us.EditarUser(userEditado);

            return RedirectToAction("ListarUsuario");
        }

        public IActionResult RegistrarUsuario()
        {
            // Autenticacao.CheckLogin(this);
            // string Login = HttpContext.Session.GetString("login");

            // if (Login == "admin")
            // {

            // }
            // else
            // {
            //     return RedirectToAction("NeedAdmin");
            // }
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarUsuario(Usuario novoUser)
        {
            // Autenticacao.CheckLogin(this);

            novoUser.senha = Criptografo.TextoCriptografado(novoUser.senha);

            UsuarioService us = new UsuarioService();
            us.IncluirUser(novoUser);

            return RedirectToAction("CadastroRealizado");
        }

        public IActionResult ExcluirUsuario(int id)
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.verificaSeUsuarioeAdmin(this);//XXXXXXXXXXXXXXXXXXXXXXX

            return View(new UsuarioService().ListarUser(id));
        }

        [HttpPost]
        public IActionResult ExcluirUsuario(string decisao, int id)
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.verificaSeUsuarioeAdmin(this);//XXXXXXXXXXXXXXXXXXXXXXX

            if (decisao == "EXCLUIR")
            {
                ViewData["Mensagem"] = "Exclusão do usuario"  +  new UsuarioService().ListarUser(id).Nome  +  "realizada com sucesso!";
                new UsuarioService().ExcluirUser(id);
                return View("ListarUsuario", new UsuarioService().Listar());
            }
            else
            {
                ViewData["Mensagem"] = "Exclusão cancelada";
                return View("ListarUsuario", new UsuarioService().Listar());
            }

        }

        public IActionResult CadastroRealizado()
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            //Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            //Autenticacao.verificaSeUsuarioeAdmin(this);XXXXXXXXXXXXXXXXXXXXXXXX
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

            return View();
        }

        public IActionResult NeedAdmin()
        {
           // Autenticacao.CheckLogin(this);

            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}