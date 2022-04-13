using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture06TraditionalBusinesslayerWithoutEF.Models
{
    public class Teachers
      {
        public int Id { get; set;}
        public string name { get; set;}
      
        public string contact { get; set; }
        public int salary
        {
            get; set;
        }

    }
}