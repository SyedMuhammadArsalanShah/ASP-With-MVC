using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture02IntroductionAndFolderStructure.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home



        public string index()
        {
            return "Laiba";
        }


        public string indexeven(int id)
        {
            if (id % 2==0)
            {
                return "even";

            }
            else
            {
                return "odd";

            }


        }
        public string indexleap(int id)
        {
            if (id % 4 == 0)
            {
                return "leap";

            }
            else
            {
                return "is not leap year";

            }


        }


    }
}