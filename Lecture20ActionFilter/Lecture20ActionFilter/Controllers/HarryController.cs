using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture20ActionFilter.Controllers
{  
    public class HarryController : Controller
    {


        // GET: Harry

        [OutputCache(Duration = 10)]
        public string Index()
        {
            return DateTime.Now.ToString();
        }
    }
}