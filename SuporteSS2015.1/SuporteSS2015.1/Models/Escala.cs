using System;
using System.ComponentModel.DataAnnotations;

namespace SuporteSS2015._1.Models
{
    public class Escala
    {
        public int Id { get; set; }
        [Display(Name = "Plantão")]
        [DataType(DataType.Date)]
        public DateTime DataDoPlantao { get; set; }
        public int AnalistasId { get; set; }
        public virtual Analistas Analistas { get; set; }
        public int TipoEscalaId { get; set; }
        public virtual TipoEscala TipoEscala { get; set; }
    
    }
}