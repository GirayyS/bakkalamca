using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;
using System.Data.SqlClient;

namespace bakkalamca.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(kullanici model)
        {

            // veritabanı için nesne oluşturma
            BakkalDbEntities ent = new BakkalDbEntities();
            List<kullanici> kontrol = new List<kullanici>();
            try
            {
                //veritabanındaki prosedürün kullanılması
                kontrol = ent.Database.SqlQuery<kullanici>(@"exec Giris @k_adi,@parola",
               new SqlParameter("@k_adi",model.k_kullaniciadi),
               new SqlParameter("@parola",model.k_parola)).ToList();
                if (kontrol.Count>0)
                {
                    return RedirectToAction("Urunler", "Urunler");
                }
                else
                {
                     return View("Index");
                }
                
            }
            catch (Exception) {throw;  }
        }
    }
}