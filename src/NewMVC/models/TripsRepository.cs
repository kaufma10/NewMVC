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
        public IEnumerable<Trip> GetTrip(int ?id)
        {
            return db.Trips.Where(r => r.ID == id);
        }
        
        private int Order { get; set; }
    }
}
