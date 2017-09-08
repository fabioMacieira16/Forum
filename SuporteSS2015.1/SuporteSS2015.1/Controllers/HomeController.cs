using SuporteSS2015._1.Models;
using System.Linq;
using System.Web.Mvc;

namespace SuporteSS2015._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController()
        {
            db = new ApplicationDbContext();
        }

        ~HomeController()
        {
            db.Dispose();
        }

        [HttpGet]
        public ActionResult Pesquisar()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Pesquisar(string texto)
        {
            //poder ser ordenado par categoria tambem obser isso!
            return View(db.Postagem.Where(x => x.Mensagem.Contains(texto)).OrderBy(x => x.Categoria));
        }

        public ActionResult Index()
        {
            return View();
        }
        //[Authorize]
        public ActionResult Download()
        {
            ViewBag.Message = "Baixe programas e drives de impressoras.";
            return View();
        }
        //[Authorize]
        public ActionResult Versoes()
        {
            return View();
        }
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