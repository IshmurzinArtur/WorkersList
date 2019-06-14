using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkersList.Controllers
{
    public class WorkerController : Controller
    {
        Models.WorkersContext workersContext = new Models.WorkersContext();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.CompanyList = workersContext.Companies.ToList();
            return View();
        }
        [HttpPost]

        public ActionResult Index(Models.Worker worker)
        {
            worker.DateAdded = DateTime.Now;
            workersContext.Workers.Add(worker);
            workersContext.SaveChanges();
            return Redirect("Index");
        }
    }
}