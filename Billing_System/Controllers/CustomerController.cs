using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Billing_System.Models;
namespace Billing_System.Controllers
{
    public class CustomerController : Controller
    {
        Billing_SystemEntities db = new Billing_SystemEntities();
        public ActionResult Index()
        {
            List<tblcutomer> lst = db.tblcutomers.ToList();
            return View(lst);
        }

        public ActionResult Customer() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Customer(tblcutomer c)
        {

            db.tblcutomers.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public ActionResult Delete(int id)
        {
            tblcutomer st = db.tblcutomers.Find(id);
            db.tblcutomers.Remove(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
           tblcutomer st = db.tblcutomers.Find(id);
            return View(st);
        }


        [HttpPost]
        public ActionResult Edit(tblcutomer s)
        {
            db.Entry<tblcutomer>(s).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}