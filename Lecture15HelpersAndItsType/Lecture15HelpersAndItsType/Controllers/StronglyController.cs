using Lecture15HelpersAndItsType.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture15HelpersAndItsType.Controllers
{
    public class StronglyController : Controller
    {
        // GET: Strongly
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Info info)
        {
            return View();
        }
    }
}