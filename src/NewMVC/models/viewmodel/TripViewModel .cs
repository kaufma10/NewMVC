using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewMVC.models.viewmodel
{
    public class TripViewModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 255, MinimumLength = 5)]
        public string Name { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}
