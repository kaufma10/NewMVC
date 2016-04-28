﻿using System;
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
        public IEnumerable<Trip> GetTrip()
        {
            //return db.Trips.Where(r => r.ID == id).single;
            return db.Trips.OrderBy(t => t.Name).ToList();
        }
        
        private int Order { get; set; }
    }
}
