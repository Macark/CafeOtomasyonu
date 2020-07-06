using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cafe_Otomasyonu.Models.Entity;

namespace Cafe_Otomasyonu.Controllers
{
    public class SiparişlerController : Controller
    {
        // GET: Siperişler
        Cafe_OtomasyonuEntities2 db = new Cafe_OtomasyonuEntities2();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
          //  ViewBag.Urun_ID = new SelectList(db.Urunler_TBL, "Urun_ID", "Urun_Adi");
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(Siparisler_TBL p)
        {
            db.Siparisler_TBL.Add(p);
            db.SaveChanges();
            return View("Index");
            
        }
      
    }
}