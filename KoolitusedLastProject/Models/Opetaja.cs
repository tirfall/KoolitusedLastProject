using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class Opetaja
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kirjuta õpetaja nimi")]
        public string OpetajaEesnimi { get; set; }
        [Required(ErrorMessage = "Kirjuta õpetaja perenimi")]
        public string OpetajaPerenimi { get; set; }
        [Required(ErrorMessage = "Kirjuta õpetaja telefon")]
        [RegularExpression(@"\+372\d{8}", ErrorMessage = "Vale number")]
        public string Telefon { get; set; }
    }
}