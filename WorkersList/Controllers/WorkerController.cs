using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            ViewBag.WorkersList = workersContext.Workers.ToList();
            return View(new Models.Worker());
        }
        [HttpPost]

        public ActionResult Index(Models.Worker worker, int Company_Id)
        {
            worker.DateAdded = DateTime.Now;
            worker.Company = workersContext.Companies.Find(Company_Id);
            workersContext.Workers.Add(worker);
            workersContext.SaveChanges();
            return Redirect("Index");
        }
        public ActionResult Delete(int id)
        {
            Models.Worker company = workersContext.Workers.Find(id);
            if (company != null)
            {
                workersContext.Workers.Remove(company);
                workersContext.SaveChanges();
            }
            return Redirect("Index");
        }
        public ActionResult Edit(Models.Worker worker, int Company_Id)
        {
            /*Небольшой велосипед лучше использовать EntityState.Modified*/
            var edit = workersContext.Workers.Find(worker.Id);
            edit.Age = worker.Age;
            edit.Company = workersContext.Companies.Find(Company_Id);
            edit.Name = worker.Name;
            edit.Description = worker.Description;
            workersContext.SaveChanges();
            return Redirect("Index");
        }
    }
}