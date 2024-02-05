using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class Opetaja
    {
        public int Id { get; set; }
        public string OpetajaEesnimi { get; set; }
        public string OpetajaPerenimi { get; set; }
        public string Telefon { get; set; }
    }
}