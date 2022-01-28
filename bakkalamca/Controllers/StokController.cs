using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;
using System.Data.SqlClient;

namespace bakkalamca.Controllers
{
    public class StokController : Controller
    {
        // GET: Stok
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Stok()
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<stok> model = new List<stok>();
            try
            {

                //stok tablosunun prosedür ile çağrılması
                model = ent.Database.SqlQuery<stok>("StokGetir").ToList();
            }
            catch (Exception) { throw; }
            return View(model);
        }

        public ActionResult StokEkle(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<stok> model = new List<stok>();

            try
            {
                if (id > 0)
                {
                    //seçilen satirin bilgilerinin getirilmesi
                    model = ent.Database.SqlQuery<stok>(@"exec StokGetirSecili @id",new SqlParameter("@id",id)).ToList();
                    //model = ent.Database.ExecuteSqlCommand(@"exec StokGetirSecili @id",new SqlParameter("@id",id));

                }
            }
            catch (Exception) { throw; }
            return View(model);
        }
        [HttpPost]
        public ActionResult StokEkle(stok model)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                if (model.stok_id > 0)
                {   //güncelleme işlemi


                    ent.Database.ExecuteSqlCommand(@"exec StokGuncelle @id,@adet,@giris,@bitis",
                          new SqlParameter("@id", model.stok_id),
                          new SqlParameter("@adet", model.s_adedi),
                          new SqlParameter("@giris", model.s_giris_tarihi),
                          new SqlParameter("@bitis", model.s_bitis_tarihi));

                }
                else
                {   //ekleme işlemi

                    ent.Database.ExecuteSqlCommand(@"exec StokEkle @id,@adet,@giris,@bitis",
                          new SqlParameter("@id", model.stok_id),
                          new SqlParameter("@adet", model.s_adedi),
                          new SqlParameter("@giris", model.s_giris_tarihi),
                          new SqlParameter("@bitis", model.s_bitis_tarihi));
                }
            }
            catch (Exception) { throw; }

            return RedirectToAction("Stok");
        }
        public ActionResult StokSil(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {

                //silme işlemi
                ent.Database.ExecuteSqlCommand(@"exec StokSil @id", new SqlParameter("@id", id));
            }
            catch (Exception) { throw; }

            return RedirectToAction("Stok");
        }
    }
}