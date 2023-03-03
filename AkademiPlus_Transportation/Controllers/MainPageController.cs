using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class MainPageController : Controller
    {
        //scope --kapsam

        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDetail()
        {
            ViewBag.leftTitle1 = "Güvenli Taşımacılık";
            ViewBag.leftTitle2 = "Dünyanın Her Yerine Tüm Kargolar";
            ViewBag.leftTitle3 = "Konumu fark etmeksiniz, doğudan batıya, kuzeyden güneye en uzak noktalara uzman ekibimizle güvenli teslimat yapıyoruz.";

            ViewBag.rightTitle1 = "Taşıma Kolaylığı";
            ViewBag.rightTitle2 = "Kendi ambalajlarımızla ile kargolarınızı paketliyoruz.";

            ViewBag.rightTitle3 = "Şehir İçi Dağıtım";
            ViewBag.rightTitle4 = "İstediğiniz saatte evlerinize veya belirlediğiniz yere teslimat yapmaktayız.";
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }   

        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
    }
}