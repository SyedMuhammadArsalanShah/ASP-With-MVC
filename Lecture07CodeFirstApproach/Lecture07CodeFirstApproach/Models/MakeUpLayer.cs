using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture07CodeFirstApproach.Models
{
    public class MakeUpLayer
    {

        public List<MakeUp> getallrecords()
        {


            MakeupContext obj = new MakeupContext();
            List<MakeUp> list = obj.misbah.ToList();
            return list;


        }

 

    }
}