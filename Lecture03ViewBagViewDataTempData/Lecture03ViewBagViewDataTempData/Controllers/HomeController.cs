using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture03ViewBagViewDataTempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            ViewBag.Name = "Laiba";
            ViewBag.classs = "16th ";
            ViewBag.subject = "C# MSCS";

            ViewBag.obj = new List<string>() {

                "Laiba",
                "Affan",
                "Misbah",
                "Harry",
                "Maryam",
                "Adnan"


            };

            return View();
        }


        public ActionResult IndexViewData()
        {

            ViewData["Name"] = "Laiba";
            ViewData["Class"] = "16th ";
            ViewData["Subject"] = "C# MSCS";

            ViewData["Obj"] = new List<string>() {

                "Laiba",
                "Affan",
                "Misbah",
                "Harry",
                "Maryam",
                "Adnan"


            };

            return View();
        }

        public ActionResult IndexTempData()
        {

            TempData["Name"] = "Laiba";
            TempData["Class"] = "16th ";
            TempData["Subject"] = "C# MSCS";

            TempData["Obj"] = new List<string>() {

                "Laiba",
                "Affan",
                "Misbah",
                "Harry",
                "Maryam",
                "Adnan"


            };

            return RedirectToAction("About");
        }


        public ActionResult About()
        {
            TempData["Name"] = "Laiba";


            return View();
        }




    }
}