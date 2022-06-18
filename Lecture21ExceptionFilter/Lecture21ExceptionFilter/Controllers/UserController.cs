using Lecture21ExceptionFilter.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture21ExceptionFilter.Controllers
{


    public class UserController : Controller
    {
        // GET: User

            [ExFilter]
        public ActionResult Index()
        {

            int[] abc = new int[10];
            abc[100] = 50;



            return View(abc[100]);
        }
    }
}