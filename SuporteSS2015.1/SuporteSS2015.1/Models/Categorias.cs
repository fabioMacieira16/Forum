using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuporteSS2015._1.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public virtual ICollection<Postagem> Postagem { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}