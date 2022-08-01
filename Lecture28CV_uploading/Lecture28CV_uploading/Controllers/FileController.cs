using Lecture28CV_uploading.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture28CV_uploading.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }
        // doc , pdf exce, ppt etc l

        [HttpPost]
        public ActionResult Index(cvmsh MI, HttpPostedFileBase file )
        {
            if(file ==  null )
            {
                ModelState.AddModelError("customerror","please select  file ");
                return View();

            }
            if (!(file.ContentType == "application/msword"|| file.ContentType == "application/pdf")) {

                ModelState.AddModelError("customerror", "please select doc / pdf file only ");
                return View();
            }


            if (ModelState.IsValid==true) {


                try
                {
                    string filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    file.SaveAs(Path.Combine(Server.MapPath("~/cv_uploading"), filename));

                    using (cvuploadingEntities  db =new cvuploadingEntities())
                    {
                        MI.CV = filename;
                        db.cvmshes.Add(MI);
                        db.SaveChanges();


                        ModelState.Clear();
                        MI = null;
                        ViewBag.Message = "Submited";

                    }

                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Not Submited";
                    return View();
                }
            }
            return View();
        }
    }
}