using Lecture06TraditionalBusinesslayerWithoutEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture06TraditionalBusinesslayerWithoutEF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            TraditonalLayer obj = new TraditonalLayer();
            List<Teachers> list = obj.Teachers.ToList();
            return View(list);
        }
    }
}