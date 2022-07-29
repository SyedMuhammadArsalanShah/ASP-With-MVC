using Lecture27SearchingbyAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture27SearchingbyAjax.Controllers
{
    public class SearchController : Controller
    {


        searchEntities obj = new searchEntities();
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult SearchpPeople(string keyword)
        {
            var data = obj.infoes.Where(mi => mi.Name.StartsWith(keyword)).ToList();

            return PartialView(data);
        }












    }
}