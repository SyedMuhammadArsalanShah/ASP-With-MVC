using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lecture08DatabaseFirst.Models
{
    public class WatchesContext :DbContext
    {



        public DbSet<Watches>  watches {get; set;}


    }
}