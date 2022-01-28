using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;
using System.Data.SqlClient;

namespace bakkalamca.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kategori()
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<kategori> model = new List<kategori>();
            try
            {

                //prosedür ile kategorinin getirilmesi
                model = ent.Database.SqlQuery<kategori>("KategoriGetir").ToList();
            }
            catch (Exception) { throw; }
            return View(model);
        }

        public ActionResult KategoriEkle(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<kategori> model = new List<kategori>();

            try
            {
                if (id > 0)
                {
                    //güncellemek için seçilen satırın id sine göre getirilmesi
                    model = ent.Database.SqlQuery<kategori>(@"exec KategoriGetirSecili @id", new SqlParameter("@id", id)).ToList();

                }
            }
            catch (Exception) { throw; }
            return View(model);
        }
        [HttpPost]
        public ActionResult KategoriEkle(kategori model)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                if (model.kategori_id > 0)
                {   

                    //kategorinin güncellenmesi
                    ent.Database.ExecuteSqlCommand(@"exec KategoriGuncelle @id,@adi",
                          new SqlParameter("@id", model.kategori_id),
                          new SqlParameter("@adi", model.k_adi));

                }
                else
                {   
                    //prosedür ile kategori ekleme işlemi

                    ent.Database.ExecuteSqlCommand(@"exec KategoriEkle @adi",
                          new SqlParameter("@adi", model.k_adi));
                }
            }
            catch (Exception) { throw; }
            //kategori sayfasına geri dönme işlemi
            return RedirectToAction("Kategori");
        }
        public ActionResult KategoriSil(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {

                //seçilen kategorinin silme işlemi
                ent.Database.ExecuteSqlCommand(@"exec KategoriSil @id", new SqlParameter("@id", id));
            }
            catch (Exception) { throw; }

            return RedirectToAction("Kategori");
        }
    }
}