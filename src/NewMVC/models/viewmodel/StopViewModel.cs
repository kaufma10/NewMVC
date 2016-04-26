using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewMVC.models.viewmodel
{
    public class StopViewModel
    {
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 255, MinimumLength = 5)]
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [Required]
        public DateTime ArrivalDate { get; set; }
        public int Order { get; set; }
    }
}
