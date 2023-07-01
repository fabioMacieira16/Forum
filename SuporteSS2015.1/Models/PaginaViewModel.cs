using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuporteSS2015._1.Models
{
    public class PaginaViewModel
    {
        public IEnumerable<Postagem> Postagens { get; set; }
        public Paginacao Paginacao { get; set; }
        public string CategoriaAtual { get; set; }
    }
}