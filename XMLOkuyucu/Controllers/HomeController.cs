using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMLOkuyucu.Models;

namespace XMLOkuyucu.Controllers
{
    public class HomeController : Controller
    {
        XmlOkuyucuContex XmlCtx = new XmlOkuyucuContex();

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Giris(string TxtAdi, string TxtParola)
        {
            ViewBag.Durum = "";
            ViewBag.Ad = "";
            GirisKontrol(TxtAdi, TxtParola);
            if (ViewBag.Durum == "" && ViewBag.Ad == "")
            {
                try
                {
                    KullaniciSorgu(TxtAdi, TxtParola);
                    if (ViewBag.Durum==TxtAdi)
                    {
                        return RedirectToAction("Index", "Xml");
                    }
                    else
                    {
                        return View("Index");
                    }
                    
                }
                catch (Exception ex)
                {
                    return View("Index",ex);
                }
            }
            else
            {
                return View("Index");
            }
        }



        public ActionResult Kaydol()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydol(Kullanici A)
        {
            if (ModelState.IsValid)
            {
                XmlCtx.Kullanicilar.Add(A);
                XmlCtx.SaveChanges();
            }
            return View();
        }


        private void KullaniciSorgu(string TxtAdi, string TxtParola)
        {
            foreach (Kullanici K in XmlCtx.Kullanicilar)
            {
                if (K.KullaniciAdi == TxtAdi && K.KullaniciParola == TxtParola)
                {
                    ViewBag.Durum = TxtAdi;
                    Session["Kullanici"] = "1";
                    break;

                }
                else
                {
                    ViewBag.Durum = "Giris Başarısız, parola veya şifre hatalı.";

                }

            }
        }

        private void GirisKontrol(string TxtAdi, string TxtParola)
        {
            if (TxtAdi == "" || TxtAdi.Length < 3)
            {
                ViewBag.Ad = "Boş veya yetersiz uzunlukta! (en az 3 karakter)";
            }
            if (TxtParola == "" || TxtParola.Length < 6)
            {
                ViewBag.Durum = "Boş veya yeterrsiz uzunlukta! (en az 6 karakter)";
            }
        }

        private void isLoginSuccess(){
            txtUserId = getRequestString("UserId");
            txtSQL = "SELECT * FROM Users WHERE UserId = " + txtUserId;
        }
    }
}