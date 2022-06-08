using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture17HttpVerbs.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
      
            public ActionResult Index() // handles GET requests by default
            {
                return View();
            }

            [HttpPost]
            public ActionResult PostAction() // handles POST requests by default
            {
                return View("Index");
            }


            [HttpPut]
            public ActionResult PutAction() // handles PUT requests by default
            {
                return View("Index");
            }

            [HttpDelete]
            public ActionResult DeleteAction() // handles DELETE requests by default
            {
                return View("Index");
            }

            [HttpHead]
            public ActionResult HeadAction() // handles HEAD requests by default
            {
                return View("Index");
            }

            [HttpOptions]
            public ActionResult OptionsAction() // handles OPTION requests by default
            {
                return View("Index");
            }

            [HttpPatch]
            public ActionResult PatchAction() // handles PATCH requests by default
            {
                return View("Index");
            }
         

            [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get | HttpVerbs.Delete)]
            public ActionResult GetAndPostAction()
              {
            return RedirectToAction("Index");
              }







    }
    }
