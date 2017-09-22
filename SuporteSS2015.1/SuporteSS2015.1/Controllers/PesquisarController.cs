using SuporteSS2015._1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SuporteSS2015._1.Controllers
{
    public class PesquisarController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        public ActionResult Index(string SeachTerm)
        {
            List<Postagem> postagem;
            if (string.IsNullOrEmpty(SeachTerm))
            {
                postagem = db.Postagem.Take(0).ToList();
                //ViewBag.Mensagem("Assunto não encontrado");
            }
            else
            {
                postagem = db.Postagem.Where(x => x.Topico.Contains(SeachTerm)).Take(20).ToList();
            }
            return View(postagem);
        }

        [Authorize]
        public PartialViewResult Pesquisa(string SeachTerm)
        {
            List<Postagem> postagem;
            if (string.IsNullOrEmpty(SeachTerm))
            {
                postagem = db.Postagem.Take(0).ToList();
            }
            else
            {
                postagem = db.Postagem.Where(x => x.Topico.Contains(SeachTerm)).Take(20).ToList();
            }
            return PartialView("_Buscar", postagem);
        }

        //public PartialViewResult top3()
        //{
        //    List<Postagem> model = db.Postagem.OrderByDescending(x => x.Topico).Take(3).ToList();

        //    return PartialView("_postagem", model);
        //}

        //public PartialViewResult Botton()
        //{
        //    List<Postagem> model = db.Postagem.OrderBy(x => x.Topico).Take(3).ToList();

        //    return PartialView("_postagem", model);
        //}

    }
}


