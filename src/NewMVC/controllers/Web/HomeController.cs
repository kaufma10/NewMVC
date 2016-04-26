using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NewMVC.models;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NewMVC.controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Authorize]
        public IActionResult Index()
        {
            TripsRepository db = new TripsRepository();
            ViewBag.Trip = new Trip()
            {
                Name = "TripStarter",
                DateMade = DateTime.Now
            };
            var trips = db.GetAllTrips();
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
