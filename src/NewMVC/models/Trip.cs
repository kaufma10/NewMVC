using Microsoft.AspNet.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewMVC.models
{
    [Authorize]
    public class Trip
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateMade { get; set; }
        public string UserName { get; set; }
        public ICollection<Stop> stops{ get; set; }
    }
}