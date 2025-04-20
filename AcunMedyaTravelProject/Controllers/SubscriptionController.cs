using AcunMedyaTravelProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class SubscriptionController : Controller
    {
        // GET: Subscription
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Subscriptions.ToList();
            return View(values);
        }
    }
}