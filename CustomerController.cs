using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiClient.Models;



namespace WebApiClient.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            CustomerClient cuslst = new CustomerClient();
            ViewBag.listCustomer = cuslst.FindAll();
            return View();
        }
        [HttpGet]
         public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
         public ActionResult Create(ClsCustomer cust)
         {
             CustomerClient cusclt = new CustomerClient();
             cusclt.Create(cust.customer);
             return RedirectToAction("Index");
         }
         [HttpGet]
        public ActionResult Delete(int Id)
        {
            CustomerClient cusclt = new CustomerClient();
            cusclt.Delete(Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            CustomerClient cusclt = new CustomerClient();
            ClsCustomer cus = new ClsCustomer();
            cus.customer = cusclt.Find(Id);
            return View("Edit",cus);
        }
        [HttpPost]
        public ActionResult Edit(ClsCustomer cust)
        {
            CustomerClient cusclt = new CustomerClient();
            cusclt.Edit(cust.customer);
            return RedirectToAction("Index");
        }
    }
}
 