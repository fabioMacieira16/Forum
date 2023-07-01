using System;
using System.ComponentModel.DataAnnotations;

namespace SuporteSS2015._1.Areas.Administrativo.Models
{
    // [Table("Analistas")]
    public class Analistas
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Analista")]
        public String NomeAnalista { get; set; }
        [Display(Name = "Contato")]
        [DataType(DataType.PhoneNumber)]
        //[Ma("999999999")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public String FoneAnalista { get; set; }
    }
}