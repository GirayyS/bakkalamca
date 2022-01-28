using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;
using System.Data.SqlClient;

namespace bakkalamca.Controllers
{
    public class SMController : Controller
    {
        // GET: SM
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SM()
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<satis_maddeleri> model = new List<satis_maddeleri>();
            try
            {
                //satis maddeleri tablosunun getirilmesi
                model = ent.Database.SqlQuery<satis_maddeleri>("SMGetir").ToList();
            }
            catch (Exception) { throw; }
            return View(model);
        }

        public ActionResult SMEkle(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<satis_maddeleri> model = new List<satis_maddeleri>();

            try
            {
                if (id > 0)
                {
                    //seçilen satirin bilgilerinin yeni sayfada getirilmesi için prosedür kullanımı
                    model = ent.Database.SqlQuery<satis_maddeleri>(@"exec SMGetirSecili @id", new SqlParameter("@id", id)).ToList();

                }
            }
            catch (Exception) { throw; }
            return View(model);
        }
        [HttpPost]
        public ActionResult SMEkle(satis_maddeleri model)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                if (model.sm_id > 0)
                {   //güncelleme işlemi


                    ent.Database.ExecuteSqlCommand(@"exec SMGuncelle @id,@miktar,@fiyat,@iskonto,@satis_id,@urun_id",
                          new SqlParameter("@id", model.sm_id),
                          new SqlParameter("@miktar", model.si_miktar),
                          new SqlParameter("@fiyat", model.si_fiyat),
                          new SqlParameter("@iskonto", model.si_iskonto),
                          new SqlParameter("@satis_id", model.satis_id),
                          new SqlParameter("@urun_id", model.urun_id));

                }
                else
                {   //ekleme işlemi

                    ent.Database.ExecuteSqlCommand(@"exec SMEkle @miktar,@fiyat,@iskonto,@satis_id,@urun_id",
                          new SqlParameter("@miktar", model.si_miktar),
                          new SqlParameter("@fiyat", model.si_fiyat),
                          new SqlParameter("@iskonto", model.si_iskonto),
                          new SqlParameter("@satis_id", model.satis_id),
                          new SqlParameter("@urun_id", model.urun_id));
                }
            }
            catch (Exception) { throw; }

            return RedirectToAction("SM");
        }
        public ActionResult SMSil(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {

                //silme işlemi
                ent.Database.ExecuteSqlCommand(@"exec SMSil @id", new SqlParameter("@id", id));
            }
            catch (Exception) { throw; }

            return RedirectToAction("SM");
        }
    }
}