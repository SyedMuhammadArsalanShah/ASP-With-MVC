using Lecture04Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture04Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Student obj = new Student()
            {
                id = 1,
                name = "Laiba",
                age = "20",
                contact = "03031234567"
            };




            return View(obj);
        }
    }
}