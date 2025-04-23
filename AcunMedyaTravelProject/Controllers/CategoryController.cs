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
    public class CategoryController : Controller
    {
        // GET: Category
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            var values = db.Categories.ToList();
            return View(values);
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.Categories.Find(id);
            db.Categories.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.Categories.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category model)
        {
            var values = db.Categories.Find(model.CategoryID);
            values.CategoryName = model.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}