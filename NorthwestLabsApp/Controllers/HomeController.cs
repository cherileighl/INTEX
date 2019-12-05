using NorthwestLabsApp.DAL;
using NorthwestLabsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabsApp.Controllers
{
    public class HomeController : Controller
    {
        private NorthwestContext db = new NorthwestContext();
        // GET: Home
        public ActionResult Index()
        {
            Company_Information companyInfo = db.Database.SqlQuery<Company_Information>("Select * From Company_Information").ToList()[0];
            ViewBag.CompanyInfo = companyInfo;
            ViewBag.CompanyName = companyInfo.CompanyName;
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}