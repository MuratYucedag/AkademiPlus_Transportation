using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class EmployeeController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            var values = db.TblEmployee.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(TblEmployee tblEmployee)
        {
            db.TblEmployee.Add(tblEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            var value = db.TblEmployee.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(TblEmployee tblEmployee)
        {
            var value = db.TblEmployee.Find(tblEmployee.EmployeeID);
            value.EmployeeName = tblEmployee.EmployeeName;
            value.EmployeeSurname = tblEmployee.EmployeeSurname;
            value.Employeeimage = tblEmployee.Employeeimage;
            value.EmployeeDescription = tblEmployee.EmployeeDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}