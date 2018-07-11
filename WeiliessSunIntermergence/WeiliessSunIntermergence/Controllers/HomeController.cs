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
        [HttpGet]
        public ViewResult ArtTechnology()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Contactname()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Comment()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Machinery()
        {
            return View();
        }
        [HttpGet]
        public ViewResult SenateIntelligence()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // TODO: Email response to the party organizer
            return View("RsvpForm", guestResponse);
        }
        [HttpPost]
        public ViewResult ArtTechnology(PageResponse pageResponse)
        {
            // TODO: Email response to the party organizer
            return View("ArtTechnology", pageResponse);
        }
        [HttpPost]
        public ViewResult Contactname(PageResponse pageResponse)
        {
            // TODO: Email response to the party organizer
            return View("Contactname", pageResponse);
        }
        [HttpPost]
        public ViewResult Comment(PageResponse pageResponse)
        {
            // TODO: Email response to the party organizer
            return View("Comment", pageResponse);
        }
        [HttpPost]
        public ViewResult Machinery(PageResponse pageResponse)
        {
            // TODO: Email response to the party organizer
            return View("Machinery", pageResponse);
        }
        [HttpPost]
        public ViewResult SenateIntelligence(PageResponse pageResponse)
        {
            // TODO: Email response to the party organizer
            return View("SenateIntelligence", pageResponse);
        }
    }
}