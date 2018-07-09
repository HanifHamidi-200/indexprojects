using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeiliessSunIntermergence.Models;

namespace WeiliessSunIntermergence.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
         
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        public ViewResult ArtTechnology()
        {
            return View();
        }
        public ViewResult Contactname()
        {
            return View();
        }
        public ViewResult Comment()
        {
            return View();
        }
        public ViewResult Machinery()
        {
            return View();
        }
        public ViewResult SenateIntelligence()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // TODO: Email response to the party organizer
            return View("HomeController", guestResponse);
        }
    }
}