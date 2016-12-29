using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuporteSS2015._1.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int CategoriasID { get; set; }

        public virtual Categorias Categorias { get; set; }

    }
}