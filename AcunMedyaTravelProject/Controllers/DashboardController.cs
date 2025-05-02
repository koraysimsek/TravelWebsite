using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize]
        // GET: Dashboard
        public ActionResult Index()
        {
            //son eklenen 3 tur programı
            //toplam admin
            //toplam hizmet
            //son eklenen referans ad soyad
            //ilk eklenen 3 tur programı
            //toplam referans
            return View();
        }
    }
}