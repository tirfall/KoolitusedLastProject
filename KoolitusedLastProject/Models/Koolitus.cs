using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class Koolitus
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kirjuta koolituse nimetus")]
        public string Koolitusenimetus { get; set; }
        public string Koolitusekirjeldus { get; set; }
        [ForeignKey("Opetaja")]
        public int? OpetajaId { get; set; }
        public virtual Opetaja Opetaja { get; set; }
        [Required(ErrorMessage = "Kirjuta, mitu tundi koolitus kestab")]
        public int Koolitusemaht { get; set; }
    }
}