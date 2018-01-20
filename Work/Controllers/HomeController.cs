using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Work.Models;

namespace Work.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Worker()
        {
            WorkerModel workerModel = new WorkerModel();
            return View(workerModel);
        }
        [HttpPost]
        public ActionResult Worker(WorkerModel work)
        {

            return RedirectToAction("JobDescription", "Home", work);
        }

        public ActionResult JobDescription()
        {
            return View();
        }
        [HttpPost]
        public ActionResult JobDescription(WorkerModel work)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Workers.Add(work);
            db.SaveChanges();
            return RedirectToAction("StartTender");
        }
        public ActionResult StartTender()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var x=db.Workers.ToList();

            return View();
        }

    }
}