using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuporteSS2015._1.Models
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Topico { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataPostagem { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categorias Categoria { get; set; }
        public virtual ICollection<Resposta> Resposta { get; set; }
    }
}
