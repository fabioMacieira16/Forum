using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuporteSS2015._1.Models;

namespace SuporteSS2015._1.Controllers
{
    public class VitrineController : Controller
    {
        //Criando a paginação
        //private Postagem _postagem;
        public int PostagemPoPagina = 8;
        //
        // GET: /Vitrine/

        public ViewResult ListaPostagem(string categoria, int pagina = 1)
        {
        //    _postagem = new Postagem();
        //    Postagem model = new Postagem
        //    {
        //        Postagems = _postagem.Categoria
        //            .Where(pagina => categoria = null || p.Categoria == categoria)
        //    };
      
            return View();
        }

        //public ViewResult ListaPostagem(string categoria, int pagina = 1)
        //{
            //_postagem = new Postagem();
            //Postagem model = new Postagem
            //{
            //    Postagens = _postagem.Categoria
            //    .Where(pagina => categoria = null || p.Categoria == categoria)
            //    .OrderBy(p => p.Descricao)
            //    .Skip((pagina - 1 ) * PostagemPoPagina)
            //    .Take(PostagemPoPagina),

            //    Paginacao = new Paginacao
            //    {
            //        PaginaAtual = pagina,
            //        itensTotal = categoria null ? _re
            //    }
            //}
        
            //return View(model);
        //}

    }
}