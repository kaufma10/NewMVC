using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewMVC.models
{
    public class CoordinatesResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
