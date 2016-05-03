using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NewMVC.models;
using Microsoft.AspNet.Authorization;
using NewMVC.models.viewmodel;
using AutoMapper;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NewMVC.controllers.Web
{
    public class TripsController : Controller
    {
        private TripsRepository TCDB;
        TripsRepository db = new TripsRepository();
        public TripsController(TripsRepository TCDB)
        {
            TCDB = new TripsRepository();
        }/**/
            
        // GET: /<controller>/
        [Authorize]
        public JsonResult Index()
        {
            ViewBag.Trip = new Trip()
            {
                Name = "TripStarter",
                DateMade = DateTime.Now
            };
            var trips = TCDB.GetAllTrips();
            var results = AutoMapper.Mapper.Map<IEnumerable<TripViewModel>>(trips);

            return Json(results);
        }

        public JsonResult Trip(int ?id)
        {
            var oneTrip = TCDB.GetTrip(id);
            return Json(oneTrip);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(TripViewModel trip)
        {
            if (ModelState.IsValid)
            {
                var newTrip = Mapper.Map<Trip>(trip);
                return RedirectToAction("Index");
            }
            var results = AutoMapper.Mapper.Map<IEnumerable<TripViewModel>>(trip);
            return Json(results);
        }
    }
}
