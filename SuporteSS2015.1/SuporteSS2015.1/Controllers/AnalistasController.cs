using SuporteSS2015._1.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SuporteSS2015._1.Controllers
{
    public class AnalistasController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Analistas
        public ActionResult Index()
        {
            return View(db.Analistas.ToList());
        }

        // GET: Analistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Analistas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, NomeAnalista, FoneAnalista")] Analistas analistas)
        {
            if (ModelState.IsValid)
            {
                db.Analistas.Add(analistas);
                db.SaveChanges();
                return Redirect("Index");
            }
            return View(analistas);
        }

        // GET: Analistas/Edit/5
        public ActionResult Edit(int? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Analistas analista = db.Analistas.Find(id);
            if (analista == null)
            {
                return HttpNotFound();
            }
            return View(analista);
        }

        // POST: Analistas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeAnalista, FoneAnalista")] Analistas analistas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(analistas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(analistas);
        }

        // GET: Analistas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Analistas analista = db.Analistas.Find(id);
            if (analista == null)
            {
                return HttpNotFound();
            }
            return View(analista);
        }

        // POST: Analistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Analistas analista = db.Analistas.Find(id);
            db.Analistas.Remove(analista);
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
