using Lecture24RolesInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Lecture24RolesInMVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(usert  model)
        {

            using (var context =new rolesEntities())
            {
                context.userts.Add(model);
                context.SaveChanges();
            }


            return RedirectToAction("Login");
        }





        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Members members)
        {
            using (var context = new rolesEntities())
            {
                bool isvalid = context.userts.Any(x => x.userName == members.userName && x.Pass == members.Pass);

                if (isvalid )
                {
                    FormsAuthentication.SetAuthCookie( members.userName, false);
                        return RedirectToAction("Index","students");

                }

                ModelState.AddModelError("", "invalid username or password");
                return View();


            }
        }



        public ActionResult Dashboard()
        {
            return View();
        }






        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }





    }
}