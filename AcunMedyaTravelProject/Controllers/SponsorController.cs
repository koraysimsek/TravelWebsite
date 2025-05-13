using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class SponsorController : Controller
    {
        // GET: Sponsor
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Sponsors.ToList();
            return View(values);
        }
        public ActionResult DeleteSponsor(int id)
        {
            var values = db.Sponsors.Find(id);
            db.Sponsors.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSponsor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSponsor(Sponsor sponsor)
        {
            db.Sponsors.Add(sponsor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSponsor(int id)
        {
            var values = db.Sponsors.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSponsor(Sponsor model)
        {
            var values = db.Sponsors.Find(model.SponsorID);
            values.ImageURL = model.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SearchSponsor(string searchText)
        {
            var result = string.IsNullOrEmpty(searchText) ? new List<Services>() : db.Services.Where(x => x.Title.Contains(searchText) || x.Description.Contains(searchText)).ToList();

            return View(result);
        }
    }
}