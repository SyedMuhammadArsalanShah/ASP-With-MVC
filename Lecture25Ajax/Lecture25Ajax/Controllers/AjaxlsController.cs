using Lecture25Ajax.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture25Ajax.Controllers
{
    public class AjaxlsController : Controller
    {
        // GET: Ajaxls
        public ActionResult Index()
        {
            return View();
        }
        private readonly LateStudents[] lateStudents =
            {
            new LateStudents{firstName="LaibaRazi" , lastName="Khan" , birthday = new DateTime(2002,11,6),role =Role.bohtachybachy},
            new LateStudents{firstName="Misbah" , lastName="Iqbal" , birthday = new DateTime(2001,3,10),role =Role.bohtachybachy},
            new LateStudents{firstName="Affan" , lastName="Zeeshan" , birthday = new DateTime(2002,11,28),role =Role.Senior},
            new LateStudents{firstName="Ahsan" , lastName="nasir" , birthday = new DateTime(2002,11,28),role =Role.farigh},
        };


        public ActionResult GetUserData(string selectedrole = "All")
        {

            IEnumerable data = lateStudents;
            if (selectedrole != "All")
            {
                var selected = (Role)Enum.Parse(typeof(Role), selectedrole);

                data = lateStudents.Where(p => p.role == selected);
            }


            return View(data);
        }



        public ActionResult GetUser(string selectedrole = "All")
        {
            return View((object)selectedrole);


        }



    }
}