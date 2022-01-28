using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;
using System.Data.SqlClient;
using bakkalamca.ViewModels;

namespace bakkalamca.Controllers
{
    public class SatısController : Controller
    {
        // GET: Satıs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Satis()
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<satis> model = new List<satis>();
            try
            {

                //satis tablosunun getirilmesi
                model = ent.Database.SqlQuery<satis>("SatisGetir").ToList();
            }
            catch (Exception) { throw; }
            return View(model);
        }

        public ActionResult SatisEkle(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<satis> model = new List<satis>();

            try
            {
                if (id > 0)
                {
                    //seçilen satirin bilgilerinin getirilmesi
                    model = ent.Database.SqlQuery<satis>(@"exec SatisGetirSecili @id", new SqlParameter("@id", id)).ToList();

                }
            }
            catch (Exception) { throw; }
            return View(model);
        }
        [HttpPost]
        public ActionResult SatisEkle(satis model)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                if (model.satis_id > 0)
                {   //satis için güncelleme


                    ent.Database.ExecuteSqlCommand(@"exec SatisGuncelle @id,@tarih,@durum,@k_id",
                          new SqlParameter("@id", model.satis_id),
                          new SqlParameter("@tarih", model.s_tarih),
                          new SqlParameter("@durum", model.s_durum),
                          new SqlParameter("@k_id", model.kullanici_id));

                }
                else
                {   //tabloya yeni kayit ekleme

                    ent.Database.ExecuteSqlCommand(@"exec SatisEkle @tarih,@durum,@k_id",
                          new SqlParameter("@tarih", model.s_tarih),
                          new SqlParameter("@durum", model.s_durum),
                          new SqlParameter("@k_id", model.kullanici_id));
                }
            }
            catch (Exception) { throw; }

            return RedirectToAction("Fatura",new {id=model.satis_id });
        }
        public ActionResult SatisSil(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                //satis tablosundan satir silme
                ent.Database.ExecuteSqlCommand(@"exec SatisSil @id", new SqlParameter("@id", id));
            }
            catch (Exception) { throw; }

            return RedirectToAction("Satis");
        }

        public ActionResult Fatura(int id)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            FaturaClass model = new FaturaClass();
            try
            {
                
                //ent.Database.ExecuteSqlCommand(@"exec Fatura @id", new SqlParameter("@id","a"));
                // model = ent.Database.SqlQuery<FaturaClass>(@"exec Fatura @id",new SqlParameter("@id",id)).ToList();
                model.sat = ent.satis.FirstOrDefault(i=>i.satis_id==id);
                model.smadde = ent.satis_maddeleri.FirstOrDefault(i=>i.satis_id==id);
                //fatura için verilerin çekilmesi
            }
            catch (Exception) { throw; }

            return View(model);
        }
    }
}