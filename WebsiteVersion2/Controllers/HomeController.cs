using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteVersion2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult CompletedProjects()
        {
            return View();
        }

        public ActionResult Hire()
        {
            return View();
        }

        public FilePathResult DownloadCV(string fileName)
        {
            return new FilePathResult(string.Format(@"~\Files\{0}", fileName + ".pdf"), "application/pdf");
        }
    }
}