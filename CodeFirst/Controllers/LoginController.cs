using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CodeFirst.Models.Class;
namespace CodeFirst.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        // GET: Login
        public ActionResult Giris()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Giris(AdminDinamik t)
        {
            var bilgiler = c.AdminDinamiks.FirstOrDefault(x => x.username == t.username && x.password == t.password);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.username,false);
                return RedirectToAction("Anasayfa", "Musteri");
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Kullanıcı adı veya şifre !!";
                return View();
            }
            
        }
        public ActionResult CikisYap()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Giris");
        }

    }
}