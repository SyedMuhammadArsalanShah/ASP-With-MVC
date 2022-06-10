using Lecture18FiltersAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture18FiltersAuthentication.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Info model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                if (model.name == "admin" && model.pass == "admin")
                {
                    Session["UserName"] = model.name.ToString();
                    return RedirectToAction("Dashboard", "User");


                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username or pass");
                    return View(model);
                }



            }





        }
    }
}