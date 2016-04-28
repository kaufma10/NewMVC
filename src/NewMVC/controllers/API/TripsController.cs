using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NewMVC.models;
using Microsoft.AspNet.Authorization;
using NewMVC.models.viewmodel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NewMVC.controllers.Web
{
    public class TripsController : Controller
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
            var results = AutoMapper.Mapper.Map<IEnumerable<TripViewModel>>(trips);
            var newTrip = AutoMapper.Mapper.Map<Trip>(trips);

            return Json(results);
        }

        public IActionResult Trip(int ?id)
        {
            TripsRepository db = new TripsRepository();
            /*Trip trip = db.
                db.Albums.Include(a => a.Artist).Include(a => a.Genre).Where(a => a.AlbumID == id).Single();*/
            var oneTrip = db.GetAllTrips();
            return Json(oneTrip);
        }
        [HttpPost]
        public IActionResult post(int? id)
        {
            TripsRepository db = new TripsRepository();
            var oneTrip = db.GetAllTrips();
            return Json(oneTrip);
        }/**/
    }
}
