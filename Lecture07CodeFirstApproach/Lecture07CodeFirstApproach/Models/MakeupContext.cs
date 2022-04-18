using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lecture07CodeFirstApproach.Models
{
    public class MakeupContext: DbContext
    {
        public DbSet<MakeUp> misbah
        {
            get; set;
        }


    }
}