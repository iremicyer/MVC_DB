using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DB.Models; // model tanımlaması

namespace MVC_DB.Controllers
{
    public class HomeController : Controller
    {
        //modelin içindeki veri tabanı ve tabloları kullanacağız.

        urunEntities urunListe = new urunEntities();  // modelden bir nesne oluşturuldu.
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Liste()
        {
            ViewBag.Message = "ÜRÜN LİSTEMİZ";

            return View(urunListe.UrunTablo.ToList()); // yukarıda oluşturulan nesneyi burada kullanıyoruz.
        }

    }
}