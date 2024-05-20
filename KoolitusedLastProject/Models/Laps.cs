using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class Laps
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kirjuta lapse nimi")]
        public string LapseEesnimi { get; set; }
        [Required(ErrorMessage = "Kirjuta lapse perenimi")]
        public string LapsePerenimi { get; set; }
        [Required(ErrorMessage = "Kirjuta lapse sünniaasta")]
        public int Sunniaasta { get; set; }
        public string User { get; set; }
        [ForeignKey("Kursus")]
        public int? KursusId { get; set; }
        public virtual Kursus Kursus { get; set; }
        public int KursusHind { get; set; }
        [ForeignKey("Koolitus")]
        public int? KoolitusId { get; set; }
        public virtual Koolitus Koolitus { get; set; }
        public int KoolitusHind { get; set; }
        [ForeignKey("Seminar")]
        public int? SeminarId { get; set; }
        public virtual Seminar Seminar { get; set; }
    }
}