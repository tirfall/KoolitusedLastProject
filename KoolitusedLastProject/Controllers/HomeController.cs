using KoolitusedLastProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KoolitusedLastProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        KoolitusContext db = new KoolitusContext();

        #region Koolitus
        public ActionResult Koolitused() 
        {
            IEnumerable<Koolitus> koolitus = db.Koolitus;
            return View(koolitus);
        }
        [HttpGet]
        public ActionResult k_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult k_Create(Koolitus koolitus)
        {
            db.Koolitus.Add(koolitus);
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }
        [HttpGet]
        public ActionResult k_Delete(int id)
        {
            Koolitus g = db.Koolitus.Find(id);
            if (g==null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost,ActionName("k_Delete")]
        public ActionResult k_DeleteConfirmed(int id)
        {
            Koolitus g = db.Koolitus.Find(id);
            if (g == null)
                return HttpNotFound();
            db.Koolitus.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }
        [HttpGet]
        public ActionResult k_Edit(int? id)
        {
            Koolitus g = db.Koolitus.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost,ActionName("k_Edit")]
        public ActionResult k_EditConfirmed(Koolitus koolitus)
        {
            db.Entry(koolitus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }
        #endregion

        #region Laps
        public ActionResult Lapsed()
        {
            IEnumerable<Laps> laps = db.Laps;
            return View(laps);
        }
        [HttpGet]
        public ActionResult l_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult l_Create(Laps laps)
        {
            db.Laps.Add(laps);
            db.SaveChanges();
            return RedirectToAction("Lapsed");
        }
        [HttpGet]
        public ActionResult l_Delete(int id)
        {
            Laps g = db.Laps.Find(id);
            if (g==null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("l_Delete")]
        public ActionResult l_DeleteConfirmed(int id)
        {
            Laps g = db.Laps.Find(id);
            if (g == null)
                return HttpNotFound();
            db.Laps.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Lapsed");
        }
        [HttpGet]
        public ActionResult l_Edit(int? id)
        {
            Laps g = db.Laps.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("l_Edit")]
        public ActionResult l_EditConfirmed(Laps laps)
        {
            db.Entry(laps).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Lapsed");
        }
        #endregion

        #region Opetaja
        public ActionResult Opetajad()
        {
            IEnumerable<Opetaja> opetaja = db.Opetaja;
            return View(opetaja);
        }
        [HttpGet]
        public ActionResult o_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult o_Create(Opetaja opetaja)
        {
            db.Opetaja.Add(opetaja);
            db.SaveChanges();
            return RedirectToAction("Opetajad");
        }
        [HttpGet]
        public ActionResult o_Delete(int id)
        {
            Opetaja g = db.Opetaja.Find(id);
            if (g==null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("o_Delete")]
        public ActionResult o_DeleteConfirmed(int id)
        {
            Opetaja g = db.Opetaja.Find(id);
            if (g == null)
                return HttpNotFound();
            db.Opetaja.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Opetajad");
        }
        [HttpGet]
        public ActionResult o_Edit(int? id)
        {
            Opetaja g = db.Opetaja.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("o_Edit")]
        public ActionResult o_EditConfirmed(Opetaja opetaja)
        {
            db.Entry(opetaja).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Opetajad");
        }
        #endregion

        #region Kursus
        public ActionResult Kursused()
        {
            IEnumerable<Kursus> kursus = db.Kursus;
            return View(kursus);
        }
        [HttpGet]
        public ActionResult ku_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ku_Create(Kursus kursus)
        {
            db.Kursus.Add(kursus);
            db.SaveChanges();
            return RedirectToAction("Kursused");
        }
        [HttpGet]
        public ActionResult ku_Delete(int id)
        {
            Kursus g = db.Kursus.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("ku_Delete")]
        public ActionResult ku_DeleteConfirmed(int id)
        {
            Kursus g = db.Kursus.Find(id);
            if (g == null)
                return HttpNotFound();
            db.Kursus.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Kursused");
        }
        [HttpGet]
        public ActionResult ku_Edit(int? id)
        {
            Kursus g = db.Kursus.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("ku_Edit")]
        public ActionResult ku_EditConfirmed(Kursus kursus)
        {
            db.Entry(kursus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Kursused");
        }
        #endregion

        #region Sündmus
        public ActionResult Sundmused()
        {
            IEnumerable<Sundmus> Sundmus = db.Sundmus;
            return View(Sundmus);
        }
        [HttpGet]
        public ActionResult su_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult su_Create(Sundmus Sundmus)
        {
            db.Sundmus.Add(Sundmus);
            db.SaveChanges();
            return RedirectToAction("Sundmused");
        }
        [HttpGet]
        public ActionResult su_Delete(int id)
        {
            Sundmus g = db.Sundmus.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("su_Delete")]
        public ActionResult su_DeleteConfirmed(int id)
        {
            Sundmus g = db.Sundmus.Find(id);
            if (g == null)
                return HttpNotFound();
            db.Sundmus.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Sundmused");
        }
        [HttpGet]
        public ActionResult su_Edit(int? id)
        {
            Sundmus g = db.Sundmus.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("su_Edit")]
        public ActionResult su_EditConfirmed(Sundmus Sundmus)
        {
            db.Entry(Sundmus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Sundmused");
        }
        #endregion
    }
}