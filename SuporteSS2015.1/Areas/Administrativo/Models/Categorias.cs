using SuporteSS2015._1.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuporteSS2015._1.Areas.Administrativo.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        [Required]
        public string Categoria { get; set; }
        public virtual ICollection<Postagem> Postagem { get; set; }
    }
}