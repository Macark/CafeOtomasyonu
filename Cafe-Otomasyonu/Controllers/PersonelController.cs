using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cafe_Otomasyonu.Models.Entity;

namespace Cafe_Otomasyonu.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        Cafe_OtomasyonuEntities2 db = new Cafe_OtomasyonuEntities2();
        public ActionResult Index()
        {
            var degerler = db.Personel_TBL.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniPersonel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniPersonel(Personel_TBL p1)
        {
            db.Personel_TBL.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Sil(int id)
        {
            var personel = db.Personel_TBL.Find(id);
            db.Personel_TBL.Remove(personel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Güncelle(int id)
        {
            var per= db.Personel_TBL.Find(id);
            return View("Güncelle", per);

        }
        public ActionResult Guncelle(Personel_TBL p1)
        {
            var gncll = db.Personel_TBL.Find(p1.Per_ID);
            gncll.Per_Ad = p1.Per_Ad;
            gncll.Per_Soyad = p1.Per_Soyad;
            gncll.Per_Telefon = p1.Per_Telefon;
            gncll.Per_Bölüm = p1.Per_Bölüm;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}