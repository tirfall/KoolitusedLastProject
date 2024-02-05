using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class KoolitusContext : DbContext
    {
        public DbSet<Koolitus> Koolitus { get; set; }
        public DbSet<Laps> Laps { get; set; }
        public DbSet<Opetaja> Opetaja { get; set; }

    }
}