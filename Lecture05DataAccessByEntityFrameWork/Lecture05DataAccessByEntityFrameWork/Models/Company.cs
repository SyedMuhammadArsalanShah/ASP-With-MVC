using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lecture05DataAccessByEntityFrameWork.Models
{  [Table("info")]
    public class Company
    {
        public int id{get; set;}
        public string name{get; set;}
        public string des{get; set;}
        public int salary {get; set;}

    }
}