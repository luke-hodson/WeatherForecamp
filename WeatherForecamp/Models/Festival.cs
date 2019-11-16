using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForecamp.Models
{
    public class Festival
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string City { get; set; }
        public string Date { get; set; }
        public List<Weather> Weather { get; set; }
    }
}