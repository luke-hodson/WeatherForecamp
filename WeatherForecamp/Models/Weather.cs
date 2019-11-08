using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WeatherForecamp.Models.Enums;

namespace WeatherForecamp.Models
{
    public class Weather
    {
        public WeatherType WeatherType { get; set; }
        public Visibility Visibility { get; set; }
        public WindDirection WindDirection { get; set; }        
        public int Humidity { get; set; }
        public int Temperature { get; set; }
        public int FeelsLikeTemp { get; set; }
        public int WindSpeed { get; set; }
        public int Year { get; set; }
    }
}