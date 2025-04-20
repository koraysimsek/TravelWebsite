using AcunMedyaTravelProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class SponsorController : Controller
    {
        // GET: Sponsor
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Sponsors.ToList();
            return View(values);
        }
    }
}