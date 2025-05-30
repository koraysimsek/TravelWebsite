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
            ViewBag.Last3Destinations = db.Destinations.OrderByDescending(x => x.DestinationsID).Select(x => x.Title).Take(3).ToList();
            //toplam admin
            ViewBag.AdminsCount = db.Admins.Count();
            //toplam hizmet
            ViewBag.ServicesCount = db.Services.Count();
            //son eklenen referans ad soyad
            ViewBag.LastTestimonialName = db.Testimonials.OrderByDescending(p => p.TestimonialID).FirstOrDefault()?.TestimonialName;
            //son eklenen 3 abonelik programı
            ViewBag.Last3Subscriptions = db.Subscriptions.OrderByDescending(x => x.SubscriptionID).Select(x => x.Email).Take(3).ToList();
            //toplam referans
            ViewBag.TestimonialCount = db.Testimonials.Count();
            //toplam seyahat
            ViewBag.DestinationsCount = db.Destinations.Count();
            //son eklenen seyahat
            ViewBag.LastDestinationName = db.Destinations.OrderByDescending(p => p.DestinationsID).FirstOrDefault()?.Title;
            //toplam aboneler
            ViewBag.SubscriptionCount = db.Subscriptions.Count();
            //son eklenen abonelik
            ViewBag.LastSubscriptionEmail = db.Subscriptions.OrderByDescending(p => p.SubscriptionID).FirstOrDefault()?.Email;
            //toplam kateogriler
            ViewBag.CategoryCount = db.Categories.Count();
            //son eklenen kategori
            ViewBag.LastCategoryName = db.Categories.OrderByDescending(p => p.CategoryID).FirstOrDefault()?.CategoryName;
            return View();
        }
    }
}