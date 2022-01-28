using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;

namespace bakkalamca.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Login
        public ActionResult Login()
        {

            BakkalDbEntities ent = new BakkalDbEntities();
            List<kullanici> model = new List<kullanici>();
            try
            {
                //kullanici tablosunun getirilmesi
                model = ent.Database.SqlQuery<kullanici>("KullaniciGetir").ToList();
            }
            catch (Exception) { throw; }
            return View(model);
        }
        
        public ActionResult KullaniciEkle(int? id=0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<kullanici> model = new List<kullanici>();

            try
            {
                if (id > 0)
                {
                    //seçilen satirin bilgilerinin getirilmesi
                    model = ent.Database.SqlQuery<kullanici>(@"exec KullaniciGetirSecili @id", new SqlParameter("@id", id)).ToList();

                }
            }
            catch (Exception) { throw; }
            return View(model);
        }

        [HttpPost]
        public ActionResult KullaniciEkle(kullanici model)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                if (model.kullanici_id > 0)
                {   //seçilen satirdaki bilgilerin güncellenmesi


                    ent.Database.ExecuteSqlCommand(@"exec KullaniciGuncelle @k_id,@k_adi,@parola,@ad,@soyad,@eposta,@telefon,@durum,@rolid",
                          new SqlParameter("@k_id", model.kullanici_id),
                          new SqlParameter("@k_adi", model.k_kullaniciadi),
                          new SqlParameter("@parola", model.k_parola),
                          new SqlParameter("@ad", model.k_adi),
                          new SqlParameter("@soyad", model.k_soyadi),
                          new SqlParameter("@eposta", model.k_eposta),
                          new SqlParameter("@telefon", model.k_telefon),
                          new SqlParameter("@durum", model.k_durum),
                          new SqlParameter("@rolid", model.rol_id));

                }
                else
                {   //kullanici tablosuna yeni kayit eklenmesi

                    ent.Database.ExecuteSqlCommand(@"exec KullaniciEkle @k_adi,@parola,@ad,@soyad,@eposta,@telefon,@durum,@rolid",
                          new SqlParameter("@k_adi", model.k_kullaniciadi),
                          new SqlParameter("@parola", model.k_parola),
                          new SqlParameter("@ad", model.k_adi),
                          new SqlParameter("@soyad", model.k_soyadi),
                          new SqlParameter("@eposta", model.k_eposta),
                          new SqlParameter("@telefon", model.k_telefon),
                          new SqlParameter("@durum", model.k_durum),
                          new SqlParameter("@rolid", model.rol_id));
                }
            }
            catch (Exception) { throw; }

            return RedirectToAction("Login");
        }
        
        public ActionResult KullaniciSil(int? id=0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {

                //seçilen kullanicinin silinmesi
                ent.Database.ExecuteSqlCommand(@"exec KullaniciSil @id", new SqlParameter("@id",id));
            }
            catch (Exception) { throw; }

            return RedirectToAction("Login");
        }
    }
}