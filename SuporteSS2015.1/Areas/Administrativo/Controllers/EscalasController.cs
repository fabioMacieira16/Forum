using SuporteSS2015._1.Areas.Administrativo.Models;
using SuporteSS2015._1.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SuporteSS2015._1.Areas.Administrativo.Controllers
{
    public class EscalasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Escalas
        public ActionResult Index()
        {
            var escalas = db.Escalas.Include(e => e.Analistas).Include(e => e.TipoEscala);
            return View(escalas.ToList());
        }

        // GET: Escalas/Details/5
        public ActionResult Details()
        {
            var escalas = db.Escalas.Include(e => e.Analistas).Include(e => e.TipoEscala);
            return View(escalas.ToList());
        }

        // GET: Escalas/Create
        public ActionResult Create()
        {
            ViewBag.AnalistasId = new SelectList(db.Analistas, "Id", "NomeAnalista");
            ViewBag.TipoEscalaId = new SelectList(db.TipoEscala, "Id", "TipoEscalas");
            return View();
        }

        // POST: Escalas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DataDoPlantao,AnalistasId,TipoEscalaId")] Escala escala)
        {
            if (ModelState.IsValid)
            {
                db.Escalas.Add(escala);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AnalistasId = new SelectList(db.Analistas, "Id", "NomeAnalista", escala.AnalistasId);
            ViewBag.TipoEscalaId = new SelectList(db.TipoEscala, "Id", "TipoEscalas", escala.TipoEscalaId);
            return View(escala);
        }

        // GET: Escalas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escala escala = db.Escalas.Find(id);
            if (escala == null)
            {
                return HttpNotFound();
            }
            ViewBag.AnalistasId = new SelectList(db.Analistas, "Id", "NomeAnalista", escala.AnalistasId);
            ViewBag.TipoEscalaId = new SelectList(db.TipoEscala, "Id", "TipoEscalas", escala.TipoEscalaId);
            return View(escala);
        }

        // POST: Escalas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DataDoPlantao,AnalistasId,TipoEscalaId")] Escala escala)
        {
            if (ModelState.IsValid)
            {
                db.Entry(escala).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AnalistasId = new SelectList(db.Analistas, "Id", "NomeAnalista", escala.AnalistasId);
            ViewBag.TipoEscalaId = new SelectList(db.TipoEscala, "Id", "TipoEscalas", escala.TipoEscalaId);
            return View(escala);
        }

        // GET: Escalas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escala escala = db.Escalas.Find(id);
            if (escala == null)
            {
                return HttpNotFound();
            }
            return View(escala);
        }

        // POST: Escalas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Escala escala = db.Escalas.Find(id);
            db.Escalas.Remove(escala);
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
