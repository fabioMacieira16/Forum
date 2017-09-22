using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuporteSS2015._1.Models
{
    public class Contato
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string  Email  { get; set; }
        public string Fone { get; set; }
        public string Empresa { get; set; }
        public string Assunto { get; set; }
        public string Comentario { get; set; }

    }
}