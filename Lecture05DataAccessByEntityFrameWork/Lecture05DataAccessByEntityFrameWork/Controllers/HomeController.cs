using Lecture05DataAccessByEntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture05DataAccessByEntityFrameWork.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id )
        {
            CompanyContext obj = new CompanyContext();
            Company st = obj.companies.Single(x =>x.id==id);
            return View(st);
        }
    }
}