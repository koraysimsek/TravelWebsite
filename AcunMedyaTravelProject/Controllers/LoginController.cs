using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AcunMedyaTravelProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        AcunMedyaDbContext db = new AcunMedyaDbContext();
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }

        [HttpPost]
        public ActionResult Index (Admin model)
        {
            var values = db.Admins.FirstOrDefault(x=>x.UserName == model.UserName && x.Password == model.Password);

            if (values == null)
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı!");
                return View(model);
            }
            FormsAuthentication.SetAuthCookie(model.UserName, false);

            Session["currentUser"] = model.UserName;

            return RedirectToAction("Index", "Dashboard");
        }
        public ActionResult LogOut()
        {
            return View();
        }
    }
}