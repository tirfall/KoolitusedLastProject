using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KoolitusedLastProject.Models
{
    public class KoolitusDbInitializer : CreateDatabaseIfNotExists<KoolitusContext>
    {
        protected override void Seed(KoolitusContext db)
        {
            base.Seed(db);
        }
    }
}