using KoolitusedLastProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace KoolitusedLastProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        readonly KoolitusContext db = new KoolitusContext();

        #region Koolitus
        public ActionResult Koolitused() 
        {
            IEnumerable<Koolitus> koolitus = db.Koolitus.Include(k => k.Opetaja).ToList();
            return View(koolitus);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult k_Create()
        {
            ViewBag.OpetajaList = new SelectList(db.Opetaja.ToList(), "Id", "OpetajaPerenimi");
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult k_Create(Koolitus koolitus)
        {
            db.Koolitus.Add(koolitus);
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public ActionResult k_Edit(int? id)
        {
            Koolitus g = db.Koolitus.Find(id);
            if (g == null)
                return HttpNotFound();
            ViewBag.OpetajaList = new SelectList(db.Opetaja.ToList(), "Id", "OpetajaPerenimi");
            return View(g);
        }
        [HttpPost,ActionName("k_Edit")]
        [Authorize(Roles = "Admin")]
        public ActionResult k_EditConfirmed(Koolitus koolitus)
        {
            db.Entry(koolitus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }
        #endregion

        #region Laps
        [Authorize]
        public ActionResult Lapsed()
        {
            IEnumerable<Laps> laps = db.Laps.Include(k => k.Kursus).Include(k => k.Koolitus).Include(k => k.Seminar).ToList();
            return View(laps);
        }
        [Authorize]
        public ActionResult l_Create()
        {
            ViewBag.KursusList = new SelectList(db.Kursus.ToList(), "Id", "Kursusenimetus");
            ViewBag.KoolitusList = new SelectList(db.Koolitus.ToList(), "Id", "Koolitusenimetus");
            ViewBag.SeminarList = new SelectList(db.Seminar.ToList(), "Id", "Seminarinimetus");
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult l_Create(Laps laps)
        {
            db.Laps.Add(laps);
            db.SaveChanges();
            return RedirectToAction("Lapsed");
        }
        [HttpGet]
        [Authorize]
        public ActionResult l_Delete(int id)
        {
            Laps g = db.Laps.Find(id);
            if (g==null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("l_Delete")]
        [Authorize]
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
        [Authorize]
        public ActionResult l_Edit(int? id)
        {
            Laps g = db.Laps.Find(id);
            if (g == null)
                return HttpNotFound();
            ViewBag.KursusList = new SelectList(db.Kursus.ToList(), "Id", "Kursusenimetus");
            ViewBag.KoolitusList = new SelectList(db.Koolitus.ToList(), "Id", "Koolitusenimetus");
            ViewBag.SeminarList = new SelectList(db.Seminar.ToList(), "Id", "Seminarinimetus");
            return View(g);
        }
        [HttpPost, ActionName("l_Edit")]
        [Authorize]
        public ActionResult l_EditConfirmed(Laps laps)
        {
            db.Entry(laps).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Lapsed");
        }
        #endregion

        #region Opetaja
        [Authorize(Roles = "Admin")]
        public ActionResult Opetajad()
        {
            IEnumerable<Opetaja> opetaja = db.Opetaja;
            return View(opetaja);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult o_Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult o_Create(Opetaja opetaja)
        {
            db.Opetaja.Add(opetaja);
            db.SaveChanges();
            return RedirectToAction("Opetajad");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult o_Delete(int id)
        {
            Opetaja g = db.Opetaja.Find(id);
            if (g==null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("o_Delete")]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public ActionResult o_Edit(int? id)
        {
            Opetaja g = db.Opetaja.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("o_Edit")]
        [Authorize(Roles = "Admin")]
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
            IEnumerable<Kursus> kursus = db.Kursus.Include(k => k.Opetaja).ToList();
            return View(kursus);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult ku_Create()
        {
            ViewBag.OpetajaList = new SelectList(db.Opetaja.ToList(), "Id", "OpetajaPerenimi");
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult ku_Create(Kursus kursus)
        {
            db.Kursus.Add(kursus);
            db.SaveChanges();
            return RedirectToAction("Kursused");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult ku_Delete(int id)
        {
            Kursus g = db.Kursus.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("ku_Delete")]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public ActionResult ku_Edit(int? id)
        {
            Kursus g = db.Kursus.Find(id);
            if (g == null)
                return HttpNotFound();
            ViewBag.OpetajaList = new SelectList(db.Opetaja.ToList(), "Id", "OpetajaPerenimi");
            return View(g);
        }
        [HttpPost, ActionName("ku_Edit")]
        [Authorize(Roles = "Admin")]
        public ActionResult ku_EditConfirmed(Kursus kursus)
        {
            db.Entry(kursus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Kursused");
        }
        #endregion

        #region Seminar
        public ActionResult Seminarid()
        {
            IEnumerable<Seminar> Seminar = db.Seminar.Include(k => k.Opetaja).ToList();
            return View(Seminar);
        }
        [HttpGet]
        [Authorize]
        public ActionResult su_Create()
        {
            ViewBag.OpetajaList = new SelectList(db.Opetaja.ToList(), "Id", "OpetajaPerenimi");
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult su_Create(Seminar Seminar)
        {
            db.Seminar.Add(Seminar);
            db.SaveChanges();
            return RedirectToAction("Seminarid");
        }
        [HttpGet]
        [Authorize]
        public ActionResult su_Delete(int id)
        {
            Seminar g = db.Seminar.Find(id);
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("su_Delete")]
        [Authorize]
        public ActionResult su_DeleteConfirmed(int id)
        {
            Seminar g = db.Seminar.Find(id);
            if (g == null)
                return HttpNotFound();
            db.Seminar.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Seminarid");
        }
        [HttpGet]
        [Authorize]
        public ActionResult su_Edit(int? id)
        {
            Seminar g = db.Seminar.Find(id);
            ViewBag.OpetajaList = new SelectList(db.Opetaja.ToList(), "Id", "OpetajaPerenimi");
            if (g == null)
                return HttpNotFound();
            return View(g);
        }
        [HttpPost, ActionName("su_Edit")]
        [Authorize]
        public ActionResult su_EditConfirmed(Seminar Seminar)
        {
            db.Entry(Seminar).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Seminarid");
        }
        #endregion
    }
}