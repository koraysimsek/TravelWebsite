using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        // GET: Services
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.Services.Find(id);
            db.Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateServices(Services services)
        {
            db.Services.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = db.Services.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateServices(Services model)
        {
            var values = db.Services.Find(model.ServicesID);
            values.Title = model.Title;
            values.Description = model.Description;
            values.ImageURL = model.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}