using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuporteSS2015._1.Models;

namespace SuporteSS2015._1.Controllers
{
    public class PostagemController : Controller
    {
        private BD_FORUMEntities db = new BD_FORUMEntities();
        // GET: /Postagem/

        public ActionResult Index(int? id_topico_forum)
        {
            ////var nomeTopico = db.topico_forum.Find(id_topico_forum);
            ////var postagem = db.postagem.Where(p => p.topico_forum.id_topico_forum == id_topico_forum).Include(p => p.topico_forum).Include(p => p.usuario);
            ////ViewBag.nomeTopico = nomeTopico.nome;
            ////return View(postagem.ToList());
            return View();
        }
        //GET: Postagem/Create
        public ActionResult Create()
        {
            ViewBag.id_topico_forum = new SelectList(db.topico_forum, "id_topico_forum", "nome");
            ViewBag.id_usario = new SelectList(db.usuario, "id_usuario", "nome");
            return View();
        }

        //Post: Postagem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "id_postage, id_topico_forum_id_usuario,id_resposta, mensagem, data_publicacao")] postagem postagem)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // usarioLogado = AutenticarUsuario.retornaUsuarioDaSessao();

        //        postagem.id_usuario = usarioLogado.id_usuario;
        //        postagem.data_publicacao = DateTime.Now;

        //        db.postagem.Add(postagem);
        //        db.SaveChanges();

        //        return RedirectToAction("Index", new { id_topico_forum = postagem.id_topico_forum });
        //    }

        //    ViewBag.id_topico_forum = new SelectList(db.topico_forum, "id_topico_forum", "nome", postagem.id_topico_forum);
        //    ViewBag.id_usuario = new SelectList(db.usuario, "id_usuario", "nome", postagem.id_usuario);
        //    return View(postagem);
        //}
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}