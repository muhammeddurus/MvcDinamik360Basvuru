using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CodeFirst.Models.Class;

namespace CodeFirst.Controllers
{
    public class MusteriController : Controller
    {
        Context c = new Context();
        [Authorize]
        // GET: Musteri
        public ActionResult Anasayfa()
        {
            return View();
        }
        [Authorize]
        public ActionResult Index()
        {
            
            var musteriler = c.musteris.ToList();

            return View(musteriler);
        }
        [HttpGet]
        public ActionResult ekle()
        {
            return View();
        }

        [HttpPost]
       public ActionResult ekle(musteri m)
        {

            if (!ModelState.IsValid)
            {
                return View("ekle");
            }
            c.musteris.Add(m);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult sil(int id)
        {
         
                var musteri = c.musteris.Find(id);
                c.musteris.Remove(musteri);
                c.SaveChanges();
                return RedirectToAction("Index");
            
        }
      
        public ActionResult MusteriDetay(int id)
        {
            var mus = c.musteris.Find(id);
            return View("MusteriDetay", mus);
        }  
        public ActionResult guncelle(musteri p1)
        {
            if (!ModelState.IsValid)
            {
                return View("MusteriDetay");
            }
            var musteri = c.musteris.Find(p1.Id);
            musteri.Ad = p1.Ad;
            musteri.Soyad = p1.Soyad;
            musteri.Sehir = p1.Sehir;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}