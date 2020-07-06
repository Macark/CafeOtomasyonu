using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cafe_Otomasyonu.Models.Entity;

namespace Cafe_Otomasyonu.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        Cafe_OtomasyonuEntities2 db = new Cafe_OtomasyonuEntities2();

        public ActionResult Index()
        {
            var degerler = db.Urunler_TBL.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniÜrün()
        {
            ViewBag.Kategori_ID = new SelectList(db.Kategoriler_TBL, "Kategori_ID", "Kategori_Ad");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult YeniÜrün(Urunler_TBL model, HttpPostedFileBase File)
        {
            string path = Path.Combine("~/Content/Images/" + File.FileName);
            File.SaveAs(Server.MapPath(path));

            model.Urun_Resim = File.FileName.ToString();
            db.Urunler_TBL.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult Sil(int id)
        {
            var ürün = db.Urunler_TBL.Find(id);
            db.Urunler_TBL.Remove(ürün);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = db.Urunler_TBL.Find(id);
            return View("UrunGetir", urun);
        }
       
        public ActionResult Guncelle(Urunler_TBL p)
        {
            var urun = db.Urunler_TBL.Find(p.Urun_ID);
            urun.Urun_Adi = p.Urun_Adi;
            urun.Urun_Ayrinti = p.Urun_Ayrinti;
            urun.Urun_Kategori = p.Urun_Kategori;
            urun.Urun_Ucret = p.Urun_Ucret;
            urun.Urun_Stok = p.Urun_Stok;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}