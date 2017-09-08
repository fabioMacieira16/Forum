using Microsoft.AspNet.Identity;
using SuporteSS2015._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SuporteSS2015._1.Areas.Administrativo.Controllers
{
    public class PainelControleController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Administrativo/PainelControle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaUsuario()
        {
            //Usuario login = db.Usuario.Where(x => x.Login == Login && x.Senha == Senha).FirstOrDefault;
            if (User.Identity.IsAuthenticated)
            {
                //var nomeUsuario = User.Identity.Name;
                //var usuario = db.No.FirstOrDefault(x => x.Logins = nomeUsuario);
                var nomeUsuario = new UserManager<ApplicationUser>(new Microsoft.AspNet.Identity.EntityFramework.UserStore<ApplicationUser>(new ApplicationDbContext()));
                var usuario = nomeUsuario.FindById(User.Identity.GetUserId());

                if (usuario != null)
                    return View(usuario);
            }
            return RedirectToAction("Index");
        }

    }
}