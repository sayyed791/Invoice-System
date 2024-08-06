using Billing_System.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Billing_System.Controllers
{
    public class ProductController : Controller
    {
        Billing_SystemEntities db = new Billing_SystemEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string AddProduct(tblproduct p)
        {
            db.tblproducts.Add(p);
            db.SaveChanges();
            return "Product Added Successfully";
        }

        public JsonResult GetProducts()
        {
            List<tblproduct> lst = db.tblproducts.ToList();
            return Json(lst , JsonRequestBehavior.AllowGet);
        }
    }
}
