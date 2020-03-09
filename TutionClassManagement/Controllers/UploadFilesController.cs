using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace TutionClassManagement.Controllers
{
    public class UploadFilesController : Controller
    {
        // GET: UploadFiles
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    String fileneme = Path.GetFileName(file.FileName);
                    string filepath = Path.Combine(Server.MapPath("../Files_Upload"), fileneme);
                    file.SaveAs(filepath);
                }
                ViewBag.Message = "Uploade file Saved successfully";
                return View();
            }
            catch (Exception)
            {
                ViewBag.Message = "Uploade file Not Saved successfully";
                return View();

            }

        }
    }
}