using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class Sundmus
    {
        public int Id { get; set; }
        public string Sundmusenimetus { get; set; }
        public string Sundmusekirjeldus { get; set; }
        public int OpetajaId { get; set; }
        [DataType(DataType.Date)]
        public string Uritusepaev { get; set; }
    }
}