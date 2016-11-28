using CoffeeShoppe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShoppe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Menu()
        {
            //ViewBag.Message = "Your Menu Page";
            //ViewBag.SheilaSays = "Hi";
            //TempData["MikeSays"] = "Yo Wad Up";
            //Session.Add("Steak", "coffee");
            //Session["Barney"] = "I heart you";

            CoffeeShoppeProductsEntities MyDatabase = new CoffeeShoppeProductsEntities();
            var ourData = MyDatabase.MenuItems.ToList();
            return View(ourData);
        }
    }
}