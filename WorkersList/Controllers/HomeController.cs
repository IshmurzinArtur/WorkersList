﻿using System.Linq;
using System.Web.Mvc;

namespace WorkersList.Controllers
{
    public class CompanyController : Controller
    {
        Models.WorkersContext workersContext = new Models.WorkersContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View(workersContext.Companies.ToList());
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
                var workersForDeleted = from t in workersContext.Workers
                                    where t.Company.Id == id
                                    select t;
                workersContext.Workers.RemoveRange(workersForDeleted);
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