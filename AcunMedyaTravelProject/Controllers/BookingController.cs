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
    public class BookingController : Controller
    {
        // GET: Booking
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Bookings.ToList();
            return View(values);
        }
        public ActionResult DeleteBooking(int id)
        {
            var values = db.Bookings.Find(id);
            db.Bookings.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateBooking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBooking(Booking booking)
        {
            db.Bookings.Add(booking);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBooking(int id)
        {
            var values = db.Bookings.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateBooking(Booking model)
        {
            var values = db.Bookings.Find(model.BookingID);
            values.Title = model.Title;
            values.Description = model.Description;
            values.ImageURL = model.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}