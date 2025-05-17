using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialDestination()
        {
            var values = db.Destinations.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBooking()
        {
            var values = db.Bookings.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = db.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSlider()
        {
            var values = db.Slider.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSponsor()
        {
            var values = db.Sponsors.ToList();
            return PartialView(values);
        }

        [HttpPost]
        public JsonResult PartialSubscription(Subscription model)
        {
            if (ModelState.IsValid)
            {
                db.Subscriptions.Add(model);
                db.SaveChanges();
                return Json(new { success = true, message = "Tebrikler Abone Oldunuz" });
            }
            else
            {
                return Json(new { success = false, message = "Hata Abone Olamadınız" });
            }
        }
    }
}