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
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Testimonials.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Testimonials.Find(id);
            db.Testimonials.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            db.Testimonials.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Testimonials.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial model)
        {
            var values = db.Testimonials.Find(model.TestimonialID);
            values.TestimonialName = model.TestimonialName;
            values.Description = model.Description;
            values.ImageURL = model.ImageURL;
            values.Title = model.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult SearchTestimonial(string searchText)
        {
            var result = string.IsNullOrEmpty(searchText) ? new List<Testimonial>() : db.Testimonials.Where(x => x.TestimonialName.Contains(searchText) || x.Description.Contains(searchText)).ToList();

            return View(result);
        }
    }
}