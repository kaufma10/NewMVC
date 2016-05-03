using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NewMVC.models;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NewMVC.controllers.web
{
    public class HomeController : Controller
    {
        private TripsRepository TCDB;
        TripsRepository db = new TripsRepository();
        public HomeController(TripsRepository db)
        {
            TCDB = db;
        }
        // GET: /<controller>/
        //[Authorize]
        public IActionResult Index()
        {
            ViewBag.Trip = new Trip()
            {
                Name = "TripStarter",
                DateMade = DateTime.Now
            };
            var trips = TCDB.GetAllTrips();
            return View(); // pass trips to view
        }
        // GET: /<controller>/
        public IActionResult About()
        {
            return View();
        }
        // GET: /<controller>/
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
