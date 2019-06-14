using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkersList.Controllers
{
    public class HomeController : Controller
    {
        Models.WorkersContext workersContext = new Models.WorkersContext();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Companies = workersContext.Companies.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.Company company)
        {
            workersContext.Companies.Add(company);
            workersContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Models.Company company = workersContext.Companies.Find(id);
            if (company !=null)
            {
                workersContext.Companies.Remove(company);
                workersContext.SaveChanges();
            }
            return Redirect("Index");
        }
        public ActionResult Edit(int id, string name)
        {
            var temp = workersContext.Companies.Find(id);
            temp.Name = name;
            workersContext.SaveChanges();
            return Redirect("Index");
        }
    }
}