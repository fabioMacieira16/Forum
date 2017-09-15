using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SuporteSS2015._1.Models;
using Microsoft.AspNet.Identity;

namespace SuporteSS2015._1.Controllers
{
    public class RespostasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Respostas
        public ActionResult Index(int id)
        {
            var query = db.Postagem.Where(p => p.Id == id);
            var firstOrDefault = query.FirstOrDefault().Topico;
            ViewBag.PostTopico = firstOrDefault;

            var resposta = db.Resposta.Where(p => p.PostagemId == id).Include(r => r.Postagem);
            return View(resposta.ToList());
        }

        // GET: Respostas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resposta resposta = db.Resposta.Find(id);
            if (resposta == null)
            {
                return HttpNotFound();
            }
            return View(resposta);
        }

        // GET: Respostas/Create
        public ActionResult Create(int id)
        {
             var query = db.Postagem.Where(p => p.Id == id);
 
             ViewBag.PostagemId = new SelectList(query, "Id", "Topico");
 
             var firstOrDefault = query.FirstOrDefault();
 
            ViewBag.Mensagem = firstOrDefault != null ? firstOrDefault.Mensagem:"Mensagem não encontrada";
             ViewBag.Postagem = firstOrDefault;

            return View();
        }

        // POST: Respostas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,Respostas,DataResposta,PostagemId,UsuarioLogado")] Resposta resposta)
        {
            var manager = new UserManager<ApplicationUser>
                  (new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
            var currentUser = manager.FindById(User.Identity.GetUserId());

            resposta.UsuarioLogado = currentUser.NomeUsuario; //User.Identity.Name;

            resposta.DataResposta = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Resposta.Add(resposta);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = resposta.PostagemId });
            }

            ViewBag.PostagemId = new SelectList(db.Postagem, "Id", "Topico", resposta.PostagemId);
            return View(resposta);
        }

        // GET: Respostas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resposta resposta = db.Resposta.Find(id);
            if (resposta == null)
            {
                return HttpNotFound();
            }
            ViewBag.PostagemId = new SelectList(db.Postagem, "Id", "Topico", resposta.PostagemId = resposta.PostagemId);
            return View(resposta);
        }

        // POST: Respostas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Respostas,DataResposta,PostagemId")] Resposta resposta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resposta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PostagemId = new SelectList(db.Postagem, "Id", "Topico", resposta.PostagemId);
            return View(resposta);
        }

        // GET: Respostas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resposta resposta = db.Resposta.Find(id);
            if (resposta == null)
            {
                return HttpNotFound();
            }
            return View(resposta);
        }

        // POST: Respostas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Resposta resposta = db.Resposta.Find(id);
            db.Resposta.Remove(resposta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
