using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class Sundmus
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kirjuta sündmus nimetus")]
        public string Sundmusenimetus { get; set; }
        public string Sundmusekirjeldus { get; set; }
        [ForeignKey("Opetaja")]
        public int? OpetajaId { get; set; }
        public virtual Opetaja Opetaja { get; set; }
        [Required(ErrorMessage = "Vali päev")]
        [DataType(DataType.Date)]
        public string Uritusepaev { get; set; }
    }
}