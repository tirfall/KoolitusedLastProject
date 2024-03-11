using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class Kursus
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kirjuta kusruse nimetus")]
        public string Kursusenimetus { get; set; }
        public string Kursusekirjeldus { get; set; }
        [ForeignKey("Opetaja")]
        public int? OpetajaId{ get; set; }
        public virtual Opetaja Opetaja { get; set; }
        [Required(ErrorMessage = "Kirjuta, mitu tundi kursus kestab")]
        public int Kursusemaht { get; set; }
    }
}