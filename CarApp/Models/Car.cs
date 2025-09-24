using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarDescription { get; set; }
        public decimal CarPrice { get; set; }
    }
}