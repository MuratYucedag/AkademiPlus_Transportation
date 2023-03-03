using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class StatisticController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            //Viewbag - Viewdata - Tempdata
            //Lambda --> öyle ki
            ViewBag.customerCount = db.TblCustomer.Count();
            ViewBag.cityAnkara = db.TblCustomer.Where(x => x.CustomerCity == "Ankara").Count();
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.citySelect = db.TblCustomer.Where(x => x.CustomerID == 1).Select(y => y.CustomerCity).FirstOrDefault();

            return View();
        }
    }
}