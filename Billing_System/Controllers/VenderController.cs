using Billing_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Billing_System.Controllers
{
    public class VenderController : Controller
    {
        Billing_SystemEntities db = new Billing_SystemEntities();   
        public ActionResult Index()
        {
            List<vender> lst = db.venders.ToList();
            return View(lst);
        }

        public ActionResult Vender()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Vender(vender p)
        {

            db.venders.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id)
        {
            vender tt = db.venders.Find(id);
            db.venders.Remove(tt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            vender st = db.venders.Find(id);
            return View(st);
        }


        [HttpPost]
        public ActionResult Edit(vender s)
        {
            db.Entry<vender>(s).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
    
