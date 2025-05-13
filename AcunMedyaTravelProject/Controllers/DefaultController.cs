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
            return PartialView();
        }

        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }

        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }

        public PartialViewResult PartialService()
        {
            return PartialView();
        }

        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }

        public PartialViewResult PartialSponsor()
        {
            return PartialView();
        }

        [HttpGet]
        public JsonResult PartialSubscription(Subscription model)
        {
            if (ModelState.IsValid)
            {
                db.Subscriptions.Add(model);
                db.SaveChanges();
                return Json(new { succes = true, message = "Tebrikler Abone Oldunuz" });
            }
            else
            {
                return Json(new { succes = false, message = "Hata Abone Olamadınız" });
            }
        }
    }
}