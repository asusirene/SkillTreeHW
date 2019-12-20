using HomeWork1.Models.ViewModels;
using HomeWork1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new AccountService().GetAccountCategory());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Account()
        {
            return View(new AccountService().GetAccountList());
        }
    }
}