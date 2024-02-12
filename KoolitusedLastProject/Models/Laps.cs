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
        public string LapseEesnimi { get; set; }
        public string LapsePerenimi { get; set; }
        public int Sunniaasta { get; set; }
        public string User { get; set; }
        [ForeignKey("Kursus")]
        public int KursusId { get; set; }
        public virtual Kursus Kursus { get; set; }
        public int KursusHind { get; set; }
        [ForeignKey("Koolitus")]
        public int KoolitusId { get; set; }
        public virtual Koolitus Koolitus { get; set; }
        public int KoolitusHind { get; set; }
        [ForeignKey("Sundmus")]
        public int SundmusId { get; set; }
        public virtual Sundmus Sundmus { get; set; }
    }
}