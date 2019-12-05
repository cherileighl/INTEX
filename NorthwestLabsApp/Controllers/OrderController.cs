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
            IEnumerable<Order_Statuses> orderStatuses = db.Database.SqlQuery<Order_Statuses>(
                "SELECT * FROM Order_Statuses"
            ).ToList();
            IEnumerable<Orders> shippedOrders = db.Database.SqlQuery<Orders>(
                "SELECT * FROM Orders o INNER JOIN Order_Statuses os ON o.StatusCode = os.StatusCode WHERE os.StatusDescription = 'Shipped'"
            ).ToList();

            ViewBag.Statuses = orderStatuses;
            ViewBag.Orders = shippedOrders;
            ViewBag.Title = "Shipped Orders";
            return View();
        }

        //receive the order status and generate list
        [HttpPost]
        public ActionResult ListOrders(FormCollection form)
        {
            string status = form["Order Status"].ToString();
            IEnumerable<Order_Statuses> orderStatuses = db.Database.SqlQuery<Order_Statuses>(
                "SELECT * FROM Order_Statuses"
            ).ToList();
            IEnumerable<Orders> dynamicOrders = db.Database.SqlQuery<Orders>(
                $"SELECT * FROM Orders o INNER JOIN Order_Statuses os ON o.StatusCode = os.StatusCode WHERE os.StatusCode = '{status}'"
            ).ToList();
            ViewBag.Statuses = orderStatuses;
            ViewBag.Orders = dynamicOrders;
            ViewBag.Title = orderStatuses.FirstOrDefault(x => x.StatusCode == status).StatusDescription;
            return View();
        }
    }

}