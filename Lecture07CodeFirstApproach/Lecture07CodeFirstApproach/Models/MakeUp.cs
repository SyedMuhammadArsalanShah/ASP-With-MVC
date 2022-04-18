using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lecture07CodeFirstApproach.Models
{

 
    public class MakeUp
    {
        
        public int  id  { get; set; }
        public string  product   { get; set; }
        public int  price { get; set; }



    }
}