using Lecture26CreatebyAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture26CreatebyAjax.Controllers
{
    public class UserController : Controller
    {
        lrkEntities db = new lrkEntities();




        // GET: User
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(info  emp )
        {
            if (ModelState.IsValid==true)
            {
                db.infoes.Add(emp);
               int a =db.SaveChanges();//
                if (a>0)
                {
                    return Json("data inserted ");
                }
                else
                {

                    return Json("data is not inserted");
                }           

            }


            return View();
        }

    }
}