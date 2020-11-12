using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Net.Mail;
using System.Web;
using System.Net;
using System.Data.Entity;
using System.Web.Mvc;
using AbionDotNet.DAL;
using AbionDotNet.Models;

namespace AbionDotNet.Controllers
{
    public class HomeController : Controller
    {

        private AbionDotNetContext db = new AbionDotNetContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WebApp()
        {
            return View();
        }

        public ActionResult Mobile()
        {
            return View();
        }

        public ActionResult Azure()
        {
            return View();
        }

        public ActionResult WebAdvertising()
        {
            return View();
        }

        public ActionResult CustomApp()
        {
            return View();
        }

        public ActionResult OODevelopment()
        {
            return View();
        }

        public ActionResult SocialMedia()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }
        // Contact GET
        public ActionResult Contact()
        {
            ViewBag.Message = "Abion Technology Contact";

            return View();
        }
    }
}