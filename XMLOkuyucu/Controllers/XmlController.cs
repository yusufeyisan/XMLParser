using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using XMLOkuyucu.Denetleme;
using XMLOkuyucu.Models;



namespace XMLOkuyucu.Controllers
{
    public class XmlController : BaseController
    {
        // GET: Xml

        public ActionResult Index()
        {
            DirectoryInfo DrcYuklenen = new DirectoryInfo(Server.MapPath("~/YuklenenDosyalar/"));

            var LstYuklenen = new List<XmlYuklenenler>();

            foreach (var Y in DrcYuklenen.GetFiles("*.xml"))
            {
                LstYuklenen.Add(new XmlYuklenenler { XmlYuklenen = Y.Name });
            }
            ViewBag.XmlEskiDosya = LstYuklenen;

            return View();

        }

        [HttpPost]
        public ActionResult XmlYaz(HttpPostedFileBase XmlGelen)
        {
            TempData["HataliXml"] = "";
            TempData["HataliUzanti"] = "";
            TempData["HataliSecim"] = "";
            try
            {
            
                if (XmlGelen.FileName != "")
                {
                    string XmlUzanti = System.IO.Path.GetExtension(XmlGelen.FileName);
                    string XmlYolu = System.IO.Path.GetFileName(XmlGelen.FileName);
                    if (XmlUzanti.ToLower() == ".xml")
                    {


                        var XmlYuklenmeYeri = System.IO.Path.Combine(Server.MapPath("~/YuklenenDosyalar/"), XmlYolu);
                        XmlGelen.SaveAs(XmlYuklenmeYeri);
                    }
                    else
                    {
                        TempData["HataliUzanti"] = "Lütfen sadece Xml dosyası seçiniz!";
                        return RedirectToAction("Index");
                    }
                    try
                    {
                        XmlSerializer XmlSerialize = new XmlSerializer(typeof(CxXMLResults));
                        using (StreamReader StrReader = new StreamReader(Server.MapPath("~/YuklenenDosyalar/") + XmlGelen.FileName))
                        {
                            CxXMLResults XmlVeriler = (CxXMLResults)XmlSerialize.Deserialize(StrReader);

                            return View(XmlVeriler);

                        }
                    }
                    catch (Exception)
                    {
                        TempData["HataliXml"] = "Bu Xml dosyası uygun yapıda değil!";
                        System.IO.File.Delete(Server.MapPath("~/YuklenenDosyalar/" + XmlGelen.FileName));
                        return RedirectToAction("Index");

                    }

                }
                else
                {
                    return RedirectToAction("Index");
                }



            }
            catch (NullReferenceException)
            {
                TempData["HataliSecim"] = "Lütfen bir dosya seçiniz!";
                return RedirectToAction("Index");

            }

        }

        public ActionResult XmlEskiYaz(int Id)
        {
            Id = Id - 1;
            List<XmlYuklenenler> LstYuklenen = KayitListele();

            XmlSerializer XmlSerialize = new XmlSerializer(typeof(CxXMLResults));

            StreamReader StrReader = new StreamReader(Server.MapPath("~/YuklenenDosyalar/") + LstYuklenen[Id].XmlYuklenen);

            CxXMLResults XmlVeriler = (CxXMLResults)XmlSerialize.Deserialize(StrReader);
            StrReader.Close();

            return View(XmlVeriler);

        }

        private List<XmlYuklenenler> KayitListele()
        {
            DirectoryInfo DrcYuklenen = new DirectoryInfo(Server.MapPath("~/YuklenenDosyalar/"));

            var LstYuklenen = new List<XmlYuklenenler>();

            foreach (var Y in DrcYuklenen.GetFiles("*.xml"))
            {
                LstYuklenen.Add(new XmlYuklenenler { XmlYuklenen = Y.Name });
            }

            return LstYuklenen;
        }
       
        public ActionResult XmlSil(int Id)
        {
            TempData["XmlSilme"] = "";
            TempData["LabelRenk"] = "success";
            List<XmlYuklenenler> LstYuklenen = KayitListele();
            try
            {
                System.IO.File.Delete(Server.MapPath("~/YuklenenDosyalar/" + LstYuklenen[Id-1].XmlYuklenen));
                TempData["XmlSilme"] = String.Format("{0} adlı dosya başarı ile silinmiştir.", LstYuklenen[Id - 1].XmlYuklenen);

            }
            catch (Exception)
            {
                TempData["XmlSilme"] = String.Format("{0} adlı dosya silinirken bir hata oluştu!", LstYuklenen[Id - 1].XmlYuklenen);
                TempData["LabelRenk"] = "danger";
            }


            return RedirectToAction("Index");
        }
    }
}
