using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuporteSS2015._1.Models;

namespace SuporteSS2015._1.Controllers
{

    public class TopicoController : Controller
    {
        private BD_FORUMEntities db = new BD_FORUMEntities();
        //
        // GET: /Topico/

        public ActionResult Index()
        {
            return View();
        }
        // GET: Topico/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: topico/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_topico_forum, nome, descricao, data_cadatro")] topico_forum topico_forum)
        {
            if (ModelState.IsValid)
            {
                db.topico_forum.Add(topico_forum);
                db.SaveChanges();
                return Redirect("Index");
            }
            return View(topico_forum);
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
