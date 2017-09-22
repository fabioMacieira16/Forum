using SuporteSS2015._1.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SuporteSS2015._1.Areas.Administrativo.Controllers
{
    public class PainelControleController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

   }
}