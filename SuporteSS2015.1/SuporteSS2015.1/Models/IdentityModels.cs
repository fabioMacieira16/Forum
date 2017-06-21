using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SuporteSS2015._1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("SuporteSS", throwIfV1Schema: false)
        {
          Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }
        public virtual DbSet<Analistas> Analistas { get; set; }
        public virtual DbSet<TipoEscala> TipoEscala { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Postagem> Postagem { get; set; }
        public virtual DbSet<Resposta> Resposta { get; set; }
        public virtual DbSet<Escala> Escalas { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}