using SuporteSS2015._1.Areas.Administrativo.Models;
using SuporteSS2015._1.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SuporteSS2015._1.Areas.Administrativo.Controllers
{
    public class TipoEscalaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoEscala
        public ActionResult Index()
        {
            return View(db.TipoEscala.ToList());
        }

        // GET: TipoEscala/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEscala/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TipoEscalas")] TipoEscala tipoEscala)
        {
            if (ModelState.IsValid)
            {
                db.TipoEscala.Add(tipoEscala);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoEscala);
        }

        // GET: TipoEscala/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEscala tipoEscala = db.TipoEscala.Find(id);
            if (tipoEscala == null)
            {
                return HttpNotFound();
            }
            return View(tipoEscala);
        }

        // POST: TipoEscala/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TipoEscalas")] TipoEscala tipoEscala)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoEscala).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoEscala);
        }

        // GET: TipoEscala/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoEscala tipoEscala = db.TipoEscala.Find(id);
            if (tipoEscala == null)
            {
                return HttpNotFound();
            }
            return View(tipoEscala);
        }

        // POST: TipoEscala/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoEscala tipoEscala = db.TipoEscala.Find(id);
            db.TipoEscala.Remove(tipoEscala);
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
