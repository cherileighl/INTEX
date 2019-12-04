using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabsApp.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        //LIST OF ORDERS
        //Form with dropdown of order statuses
        [HttpGet]
        public ActionResult ListOrders()
        {
            return View();
        }

        //receive the order status and generate list
        [HttpPost]
        public ActionResult ListOrders(string orderStatus)
        {
            return View();
        }
    }

}