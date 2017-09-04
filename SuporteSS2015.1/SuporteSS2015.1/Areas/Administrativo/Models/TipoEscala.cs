using System.ComponentModel.DataAnnotations;

namespace SuporteSS2015._1.Areas.Administrativo.Models
{
    public class TipoEscala
    {
        public int Id { get; set; }
        [Display(Name="Tipo de Escala")]
        public string TipoEscalas { get; set; }
    }
}