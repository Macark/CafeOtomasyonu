using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Cafe_Otomasyonu.Models.Entity;


namespace Cafe_Otomasyonu.Controllers
{
    public class MasaController : Controller
    {
        // GET: Masa
        Cafe_OtomasyonuEntities2 db = new Cafe_OtomasyonuEntities2();
        public ActionResult Index()
        {
            var degerler = db.Masalar_TBL.ToList();
            return View(degerler);
        }
    }
}