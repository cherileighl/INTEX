using NorthwestLabsApp.DAL;
using NorthwestLabsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabsApp.Controllers
{
    public class OrderController : Controller
    {
        private NorthwestContext db = new NorthwestContext();
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
            ViewBag.status = OrderStatusController.lstOrderStatus;
            IEnumerable < Orders > shippedOrders = db.Database.SqlQuery<Orders>(
                "SELECT * FROM Orders o INNER JOIN Order_Statuses os ON o.StatusCode = os.StatusCode WHERE os.StatusDescription = 'Shipped'"
            );
            return View(shippedOrders);
        }

        //receive the order status and generate list
        [HttpPost]
        public ActionResult ListOrders(string orderStatus)
        {
            return View();
        }
    }

}