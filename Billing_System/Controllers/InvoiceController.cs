using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Billing_System.Models;

namespace Billing_System.Controllers
{
    public class InvoiceController : Controller
    {
        Billing_SystemEntities db;
        public InvoiceController()
        {
            db = new Billing_SystemEntities();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewInvoive()
        {
            ViewBag.customer = GetCustomer();
            ViewBag.product = GetProduct();
            return View();
        }


        public List<SelectListItem> GetCustomer()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            foreach (tblcutomer c in db.tblcutomers.ToList())
            {
                lst.Add(new SelectListItem
                {
                    Text = c.customer_name,
                    Value = c.customer_id.ToString()
                });

            }
            return lst;
        }

        public List<SelectListItem> GetProduct()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            foreach (tblproduct c in db.tblproducts.ToList())
            {
                lst.Add(new SelectListItem
                {
                    Text = c.product_name,
                    Value = c.product_id.ToString()
                });
            }
            return lst;
        }
    }
}