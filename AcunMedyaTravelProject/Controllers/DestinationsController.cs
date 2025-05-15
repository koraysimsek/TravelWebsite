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
    public class DestinationsController : Controller
    {
        // GET: Destinations
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Destinations.ToList();
            return View(values);
        }
        public ActionResult DeleteDestinations(int id)
        {
            var values = db.Destinations.Find(id);
            db.Destinations.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateDestinations()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDestinations(Destinations destinations)
        {
            db.Destinations.Add(destinations);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateDestinations(int id)
        {
            var values = db.Destinations.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateDestinations(Destinations model)
        {
            var values = db.Destinations.Find(model.DestinationsID);
            values.CategoryID = model.CategoryID;
            values.Title = model.Title;
            values.ImageURL = model.ImageURL;
            values.Description = model.Description;
            values.Description2 = model.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SearchDestinations(string searchText)
        {
            var result = string.IsNullOrEmpty(searchText) ? new List<Destinations>() : db.Destinations.Where(x => x.Title.Contains(searchText) || x.Description.Contains(searchText)).ToList();

            return View(result);
        }
    }
}