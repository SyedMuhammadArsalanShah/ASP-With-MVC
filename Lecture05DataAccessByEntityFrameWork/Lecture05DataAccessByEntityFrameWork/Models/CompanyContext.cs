using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lecture05DataAccessByEntityFrameWork.Models
{
    public class CompanyContext : DbContext
    {
        public DbSet<Company> companies { get; set; }
    }
}