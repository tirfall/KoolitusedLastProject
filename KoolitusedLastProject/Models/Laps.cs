using System;
using System.Collections.Generic;
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
    }
}