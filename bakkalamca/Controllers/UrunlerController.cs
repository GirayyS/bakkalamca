using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;
using System.Data.SqlClient;

namespace bakkalamca.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Urunler()
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<urun> model = new List<urun>();
            try
            {

                //urun tablosunun getirilmesi
                model = ent.Database.SqlQuery<urun>("UrunGetir").ToList();
            }
            catch (Exception) { throw; }
            return View(model);
        }

        public ActionResult UrunEkle(int? id=0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<urun> model = new List<urun>();

            try
            {
                if (id > 0)
                {
                    //seçili satırın bilgilerinin getirilmesi yeni sayfada
                    model = ent.Database.SqlQuery<urun>(@"exec UrunGetirSecili @id", new SqlParameter("@id", id)).ToList();

                }
            }
            catch (Exception) { throw; }
            return View(model);
        }
        [HttpPost]
        public ActionResult UrunEkle(urun model)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                if (model.urun_id > 0)
                {   //güncelleme işlemi


                    ent.Database.ExecuteSqlCommand(@"exec UrunGuncelle @id,@adi,@barkod,@uretim,@tuketim,@fiyat,@agirlik,@renk,@marka_id,@kategori_id,@stok_id",
                          new SqlParameter("@id", model.urun_id),
                          new SqlParameter("@adi", model.u_adi),
                          new SqlParameter("@barkod", model.u_barkodu),
                          new SqlParameter("@uretim", model.u_uretim_tarihi),
                          new SqlParameter("@tuketim", model.u_tuketim_tarihi),
                          new SqlParameter("@fiyat", model.u_fiyat),
                          new SqlParameter("@agirlik", model.u_agirlik),
                          new SqlParameter("@renk", model.u_rengi),
                          new SqlParameter("@marka_id", model.marka_id),
                          new SqlParameter("@kategori_id", model.kategori_id),
                          new SqlParameter("@stok_id", model.stok_id));

                }
                else
                {   //ekleme işlemi

                    ent.Database.ExecuteSqlCommand(@"exec UrunEkle @adi,@barkod,@uretim,@tuketim,@fiyat,@agirlik,@renk,@marka_id,@kategori_id,@stok_id",
                          new SqlParameter("@adi", model.u_adi),
                          new SqlParameter("@barkod", model.u_barkodu),
                          new SqlParameter("@uretim", model.u_uretim_tarihi),
                          new SqlParameter("@tuketim", model.u_tuketim_tarihi),
                          new SqlParameter("@fiyat", model.u_fiyat),
                          new SqlParameter("@agirlik", model.u_agirlik),
                          new SqlParameter("@renk", model.u_rengi),
                          new SqlParameter("@marka_id", model.marka_id),
                          new SqlParameter("@kategori_id", model.kategori_id),
                          new SqlParameter("@stok_id", model.stok_id));
                }
            }
            catch (Exception) { throw; }

            return RedirectToAction("Urunler");
        }
        public ActionResult UrunSil(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                //silme işlemi
                ent.Database.ExecuteSqlCommand(@"exec UrunSil @id", new SqlParameter("@id", id));
            }
            catch (Exception) { throw; }

            return RedirectToAction("Urunler");
        }
    }
}