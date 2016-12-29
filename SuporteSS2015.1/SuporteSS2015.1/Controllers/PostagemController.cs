using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SuporteSS2015._1.Models;

namespace SuporteSS2015._1.Controllers
{
    public class PostagemController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Postagem
        public ActionResult Index()
        {
            //var nomeTopico = db.Categorias.Find(Id);
            var postagem = db.Postagem.Include(p => p.Categoria);

            //ViewBag.nomeTopico = nomeTopico.Categoria;
            return View(postagem.ToList());
        }

        // GET: Postagem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Postagem postagem = db.Postagem.Find(id);
            if (postagem == null)
            {
                return HttpNotFound();
            }
            return View(postagem);
        }

        // GET: Postagem/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Categoria");
            return View();
        }

        // POST: Postagem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,Topico,Mensagem,DataPostagem,CategoriaId")] Postagem postagem)
        {
            postagem.DataPostagem = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Postagem.Add(postagem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Categoria", postagem.CategoriaId);
            return View(postagem);
        }

        // GET: Postagem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Postagem postagem = db.Postagem.Find(id);
            if (postagem == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Categoria", postagem.CategoriaId);
            return View(postagem);
        }

        // POST: Postagem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Topico,Mensagem,DataPostagem,CategoriaId")] Postagem postagem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postagem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.Categorias, "Id", "Categoria", postagem.CategoriaId);
            return View(postagem);
        }

        // GET: Postagem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Postagem postagem = db.Postagem.Find(id);
            if (postagem == null)
            {
                return HttpNotFound();
            }
            return View(postagem);
        }

        // POST: Postagem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Postagem postagem = db.Postagem.Find(id);
            db.Postagem.Remove(postagem);
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
