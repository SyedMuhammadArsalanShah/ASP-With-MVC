using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture19AuthorizationFilter.Controllers
{
    public class UrightsController : Controller
    {
        // GET: Urights

        [AuthorizeAttribute]  
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Users ="misbah@gmail.com")]
        public ActionResult About()
        {
            return View();
        }




    }
}