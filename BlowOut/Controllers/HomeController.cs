using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
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

        public ActionResult Rentals()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Instrument(string name)
        {
            if (name.Equals("clarinet"))
            {
                ViewBag.name = "Clarinet";
                ViewBag.image = "clarinet.jpe";
                ViewBag.used = "$27 a month";
                ViewBag.new1 = "$35 a month";
            }
            else if (name.Equals("flute"))
            {
                ViewBag.name = "Flute";
                ViewBag.image = "flute.jpg";
                ViewBag.used = "$25 a month";
                ViewBag.new1 = "$40 a month";
            }
            else if (name.Equals("saxophone"))
            {
                ViewBag.name = "Saxophone";
                ViewBag.image = "saxophone.jpe";
                ViewBag.used = "$30 a month";
                ViewBag.new1 = "$42 a month";
            }
            else if (name.Equals("trombone"))
            {
                ViewBag.name = "Trombone";
                ViewBag.image = "Trombone.jpg";
                ViewBag.used = "$35 a month";
                ViewBag.new1 = "$60 a month";
            }
            else if (name.Equals("trumpet"))
            {
                ViewBag.name = "Trumpet";
                ViewBag.image = "trumpet.jpg";
                ViewBag.used = "$25 a month";
                ViewBag.new1 = "$55 a month";
            }
            else if (name.Equals("tuba"))
            {
                ViewBag.name = "Tuba";
                ViewBag.image = "Tuba.jpg";
                ViewBag.used = "$50 a month";
                ViewBag.new1 = "$70 a month";
            }
            return View();
        }

        public ActionResult newInstrument()
        {
            ViewBag.new3 = "19.99";
            return PartialView();
        }
    }
}