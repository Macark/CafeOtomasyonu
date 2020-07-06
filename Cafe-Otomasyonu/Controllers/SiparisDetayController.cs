using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cafe_Otomasyonu.Models.Entity;

namespace Cafe_Otomasyonu.Controllers
{
    public class SiparisDetayController : Controller
    {
        // GET: SiparisDetay
        Cafe_OtomasyonuEntities2 db = new Cafe_OtomasyonuEntities2();
        public ActionResult Index()
        {
            var degerler = db.Siparisler_TBL.ToList();
            return View(degerler);
        }
        public ActionResult Sil(int id)
        {
            var siparis = db.Siparisler_TBL.Find(id);
            db.Siparisler_TBL.Remove(siparis);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SiparisGetir(int id)
        {
            var urun = db.Siparisler_TBL.Find(id);
            return View("SiparisGetir", urun);
        }
        public ActionResult Guncelle(Siparisler_TBL p)
        {
            var urun = db.Siparisler_TBL.Find(p.Siparis_ID);
            urun.Siparis_Urun = p.Siparis_Urun;
            urun.Siparis_Adet = p.Siparis_Adet;
            urun.Siparis_Zaman = p.Siparis_Zaman;
            urun.Siparis_Masa = p.Siparis_Masa;
            urun.Siparis_Durum = p.Siparis_Durum;
            urun.Siparis_Fiyat= p.Siparis_Fiyat;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}