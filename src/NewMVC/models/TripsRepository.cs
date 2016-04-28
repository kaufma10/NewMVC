using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewMVC.models
{
    public class TripsRepository
    {
        private TripContext db = new TripContext();
        public IEnumerable<Trip> GetAllTrips()
        {
            return db.Trips.OrderBy(t => t.Name).ToList();
        }
        /*public post()
        {
            return ();
        }*/
        private int Order { get; set; }
    }
}
