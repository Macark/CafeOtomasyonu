using Cafe_Otomasyonu.Models.Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cafe_Otomasyonu.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source=DESKTOP-BTHDCST; database=Cafe Otomasyonu; integrated security=SSPI;";
        }
        [HttpPost]
        public ActionResult Verify(LoginState acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Login_TBL where Name='" + acc.Name + "' and Password='" + acc.Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                con.Close();
                return RedirectToAction("Index");
            }


        }
    }

}
