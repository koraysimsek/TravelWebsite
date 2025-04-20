using AcunMedyaTravelProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Slider.ToList();
            return View(values);
        }
    }
}