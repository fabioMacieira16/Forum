using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuporteSS2015._1.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        [Required]
        public string Categoria { get; set; }
        public virtual ICollection<Postagem> Postagem { get; set; }
    }
}