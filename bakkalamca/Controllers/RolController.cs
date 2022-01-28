using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bakkalamca.Models;
using System.Data.SqlClient;

namespace bakkalamca.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rol()
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<rol> model = new List<rol>();
            try
            {
                //rol tablosunun getirilmesi
                model = ent.Database.SqlQuery<rol>("RolGetir").ToList();
            }
            catch (Exception) { throw; }
            return View(model);
        }

        public ActionResult RolEkle(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            List<rol> model = new List<rol>();

            try
            {
                if (id > 0)
                {
                    //seçilen rol bilgilerinin güncellenmek üzere yeni sayfada açılması
                    model = ent.Database.SqlQuery<rol>(@"exec RolGetirSecili @id", new SqlParameter("@id", id)).ToList();

                }
            }
            catch (Exception) { throw; }
            return View(model);
        }
        [HttpPost]
        public ActionResult RolEkle(rol model)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                if (model.rol_id > 0)
                {   //seçilen rol bilgilerinin güncellenmesi


                    ent.Database.ExecuteSqlCommand(@"exec RolGuncelle @id,@adi",
                          new SqlParameter("@id", model.rol_id),
                          new SqlParameter("@adi", model.r_adi));

                }
                else
                {   //yeni rol eklenmesi

                    ent.Database.ExecuteSqlCommand(@"exec RolEkle @adi",
                          new SqlParameter("@adi", model.r_adi));
                }
            }
            catch (Exception) { throw; }

            return RedirectToAction("Rol");
        }
        public ActionResult RolSil(int? id = 0)
        {
            BakkalDbEntities ent = new BakkalDbEntities();
            try
            {
                //seçilen satırın silinmesi
                ent.Database.ExecuteSqlCommand(@"exec RolSil @id", new SqlParameter("@id", id));
            }
            catch (Exception) { throw; }

            return RedirectToAction("Rol");
        }
    }
}