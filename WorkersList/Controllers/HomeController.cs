using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkersList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.WorkersContext workersContext = new Models.WorkersContext();
            workersContext.Companies.Add(new Models.Company { Name = "Рога и копыта" });
            workersContext.SaveChanges();
            return View();
        }
    }
}