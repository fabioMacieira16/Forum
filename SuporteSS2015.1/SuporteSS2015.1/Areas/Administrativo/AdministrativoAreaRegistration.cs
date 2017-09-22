using System.Web.Mvc;

namespace SuporteSS2015._1.Areas.Administrativo
{
    public class AdministrativoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administrativo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Administrativo_default",
                "Administrativo/{controller}/{action}/{id}",
                new { Controller = "PainelControle", action = "Index", id = UrlParameter.Optional },
                new[] { "SuporteSS2015._1.Areas.Administrativo.Controllers" }
            );
        }
    }
}