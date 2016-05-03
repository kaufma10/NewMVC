using NewMVC.models;
using NewMVC.models.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewMVC.models
{
    public class TripsRepository
    {
        private TripContext db;
        public TripsRepository()
        {
            db  = new TripContext();
        }
        public IEnumerable<Trip> GetAllTrips()
        {
            return db.Trips.OrderBy(t => t.Name).ToList();
        }
        public Trip GetTrip(int ?id)
        {
            return db.Trips.Where(r => r.ID == id).Single();
        }
        public IEnumerable<Stop> GetAllStops()
        {
            return db.Stops.OrderBy(t => t.Name).ToList();
        }
        public Stop GetStop(int? id)
        {
            return db.Stops.Where(r => r.ID == id).Single();
        }
        public Trip Post(Trip trip)
        {
            db.Trips.Add(trip);
            db.SaveChanges();
            return null;
        }
        public Stop Post(Stop stop)
        {
            db.Stops.Add(stop);
            db.SaveChanges();
            return null;
        }
        //private int Order { get; set; }
    }
}
