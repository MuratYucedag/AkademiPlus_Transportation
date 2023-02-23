using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class CategoryController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        public ActionResult AddCategory()
        {
            return View();
        }
    }
}