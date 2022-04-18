using System;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Cadastro()
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.verificaSeUsuarioeAdmin(this);//XXXXXXXXXXXXXXXXXXXXXXX

            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Livro l)
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.verificaSeUsuarioeAdmin(this);//XXXXXXXXXXXXXXXXXXXXXXX

            LivroService livroService = new LivroService();

            if (l.Id == 0)
            {
                livroService.Inserir(l);
            }
            else
            {
                livroService.Atualizar(l);
            }

            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro, string itensPorPagina, int NumDaPagina, int PaginaAtual)
        {
            Autenticacao.CheckLogin(this);
            FiltrosLivros objFiltro = null;

            if (!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosLivros();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            ViewData["livrosPorPagina"] = (string.IsNullOrEmpty(itensPorPagina) ? 10 : Int32.Parse(itensPorPagina));
            ViewData["PaginaAtual"] = (PaginaAtual != 0 ? PaginaAtual : 1);

            LivroService livroService = new LivroService();
            return View(livroService.ListarTodos(objFiltro));
        }

        public IActionResult Edicao(int id)
        {
            //XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.CheckLogin(this);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Autenticacao.verificaSeUsuarioeAdmin(this);//XXXXXXXXXXXXXXXXXXXXXXX

            LivroService ls = new LivroService();
            Livro l = ls.ObterPorId(id);
            return View(l);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}