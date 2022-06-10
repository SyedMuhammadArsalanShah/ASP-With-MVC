using Lecture18FiltersAuthentication.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture18FiltersAuthentication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [UserAuthenticationFilter]
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}