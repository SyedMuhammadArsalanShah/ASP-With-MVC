using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture20ActionFilter.Controllers
{ 
    public class MisbahController : Controller
    {
        // GET: Misbah
        [HandleError]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }




    }
}