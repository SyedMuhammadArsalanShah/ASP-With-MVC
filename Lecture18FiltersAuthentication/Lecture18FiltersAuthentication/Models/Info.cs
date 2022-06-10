using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lecture18FiltersAuthentication.Models
{
    public class Info
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
    }
}