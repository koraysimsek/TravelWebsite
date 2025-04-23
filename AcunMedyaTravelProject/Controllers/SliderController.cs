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
    public class SliderController : Controller
    {
        // GET: Slider
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Slider.ToList();
            return View(values);
        }
        public ActionResult DeleteSlider(int id)
        {
            var values = db.Slider.Find(id);
            db.Slider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSlider(Slider slider)
        {
            db.Slider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var values = db.Slider.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSlider(Slider model)
        {
            var values = db.Slider.Find(model.SliderID);
            values.Title = model.Title;
            values.Description = model.Description;
            values.Description2 = model.Description2;
            values.ImageURL = model.ImageURL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}