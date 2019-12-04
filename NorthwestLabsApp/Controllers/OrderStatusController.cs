using NorthwestLabsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabsApp.Controllers
{
    public class OrderStatusController : Controller
    {
        public static List<Order_Statuses> lstOrderStatus = new List<Order_Statuses>()
        {

        };
        // GET: OrderStatus
        public ActionResult Index()
        {
            return View();
        }
    }
}