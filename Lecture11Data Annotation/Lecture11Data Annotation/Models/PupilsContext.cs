using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lecture11Data_Annotation.Models
{
    public class PupilsContext :DbContext
    {

        public DbSet<Pupils> pupils
        {
            get; set;
        }


    }
}