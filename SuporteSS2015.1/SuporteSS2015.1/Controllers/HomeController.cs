using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuporteSS2015._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Download()
        {
            ViewBag.Message = "Baixe programas e drives de impressoras.";
            return View();
        }
        [Authorize]
        public ActionResult Versoes()
        {
            return View();
        }

        public ActionResult Forum()
        {
            return Redirect("/Topico/Index");
        }
        //[Authorize]
        public ActionResult Agenda()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}