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
    public class SubscriptionController : Controller
    {
        // GET: Subscription
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Subscriptions.ToList();
            return View(values);
        }
        public ActionResult DeleteSubscription(int id)
        {
            var values = db.Subscriptions.Find(id);
            db.Subscriptions.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateSubscription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSubscription(Subscription subscriptions)
        {
            db.Subscriptions.Add(subscriptions);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSubscription(int id)
        {
            var values = db.Subscriptions.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSubscription(Subscription model)
        {
            var values = db.Subscriptions.Find(model.SubscriptionID);
            values.Email = model.Email;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}