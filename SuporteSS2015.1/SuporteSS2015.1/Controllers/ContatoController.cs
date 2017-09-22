using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuporteSS2015._1.Controllers
{
    public class ContatoController : Controller
    {
        // GET: Contato
        public ActionResult Contato()
        {
            return View();
        }

        // GET: Contato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contato/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
               return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
