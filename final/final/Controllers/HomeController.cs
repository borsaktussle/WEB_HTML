﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final.Models;
namespace final.Controllers
{
    public class HomeController : Controller
    {
        private KepoITEntities data = new KepoITEntities();
        public ActionResult Index()
        {
            ViewBag.user = data.USER.Count();
            ViewBag.sharing = data.SHARING.Count();
            return View();
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
    }
}