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

        public PartialViewResult PartialSubscription()
        {
            return PartialView();
        }
    }
}