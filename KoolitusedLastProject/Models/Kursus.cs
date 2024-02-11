using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class Kursus
    {
        public int Id { get; set; }
        public string Kursusenimetus { get; set; }
        public string Kursusekirjeldus { get; set; }
        public int OpetajaId { get; set; }
        public int Kursusehind { get; set; }
        public int Kursusemaht { get; set; }
    }
}