using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture25Ajax.Models
{
    public class LateStudents
    {


        public int id { get; set; }
        public string firstName  { get; set; }
        public string  lastName  { get; set; } 
        public DateTime  birthday  { get; set; } 
        public Role role  { get; set; } 


    }

   public enum Role
    {
        Senior, farigh, bohtachybachy

    }





}