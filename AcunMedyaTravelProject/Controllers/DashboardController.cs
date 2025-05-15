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
    public class DashboardController : Controller
    {
        // GET: Dashboard
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            //son eklenen 3 tur programı
            ViewBag.Last3DestinationsName = db.Destinations.OrderByDescending(t => t.DestinationsID).Take(3).ToList();
            //toplam admin
            ViewBag.AdminsCount = db.Admins.Count();
            //toplam hizmet
            ViewBag.ServicesCount = db.Services.Count();
            //son eklenen referans ad soyad
            ViewBag.LastTestimonialName = db.Testimonials.OrderByDescending(p => p.TestimonialID).FirstOrDefault()?.TestimonialName;
            //ilk eklenen 3 tur programı
            //
            //toplam referans
            ViewBag.TestimonialCount = db.Testimonials.Count();
            return View();
        }
    }
}