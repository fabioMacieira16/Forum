using SuporteSS2015._1.Models;
using System.Linq;
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
        [Authorize]

        public ActionResult Forum()
        {
            return Redirect("/Postagem/Index");
        }

        public ActionResult Agenda()
        {
            return Redirect("/Escalas/Details");
        }
        
    }
}