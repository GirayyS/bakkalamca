using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;
using System.Data.SqlClient;


namespace bakkalamca.Controllers
{
    public class MarkaController : Controller
    {
        // GET: Marka
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Marka()
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<marka> model = new List<marka>();
            try
            { //marka tablosunun getirilmesi
                model = ent.Database.SqlQuery<marka>("MarkaGetir").ToList();
            }
            catch (Exception) { throw; }
            return View(model);
        }

        public ActionResult MarkaEkle(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<marka> model = new List<marka>();

            try
            {
                if (id > 0)
                {
                    //seçilen satırın bilgilerinin getirilmesi
                    model = ent.Database.SqlQuery<marka>(@"exec MarkaGetirSecili @id", new SqlParameter("@id", id)).ToList();

                }
            }
            catch (Exception) { throw; }
            return View(model);
        }
        [HttpPost]
        public ActionResult MarkaEkle(marka model)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                if (model.marka_id > 0)
                {   //seçilen satırın bilgilerinin güncellenmesi


                    ent.Database.ExecuteSqlCommand(@"exec MarkaGuncelle @id,@adi",
                          new SqlParameter("@id", model.marka_id),
                          new SqlParameter("@adi", model.m_adi));

                }
                else
                {   //tabloya yeni marka eklenmesi

                    ent.Database.ExecuteSqlCommand(@"exec MarkaEkle @adi",
                          new SqlParameter("@adi", model.m_adi));
                }
            }
            catch (Exception) { throw; }

            return RedirectToAction("Marka");
        }
        public ActionResult MarkaSil(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {

                //seçilen markanın silinmesi
                ent.Database.ExecuteSqlCommand(@"exec MarkaSil @id", new SqlParameter("@id", id));
            }
            catch (Exception) { throw; }

            return RedirectToAction("Marka");
        }
    }
}