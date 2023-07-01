using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuporteSS2015._1.Startup))]
namespace SuporteSS2015._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
