using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SuporteSS2015._1.Models
{
    public class Usuario : IdentityUser
    {
        public string id_usuario { get; set; }
        public string NomeDoUsuario { get; set; }
        //public virtual ICollection<Postagem> postagem { get; set; }
    }
}