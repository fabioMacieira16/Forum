using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuporteSS2015._1.Models
{
    public class Resposta
    {
        public int Id { get; set; }
        public string Respostas { get; set; }
        public DateTime DataResposta { get; set; }
        public int PostagemId { get; set; }
        public virtual Postagem Postagem { get; set; }
        public string UsuarioLogado { get; set; }
    }
}