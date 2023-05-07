using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture29WebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public int age { get; set; }
    }
}