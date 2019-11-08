using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForecamp.Models
{
    public class Enums
    {
        public enum WeatherType
        {
            Clear = 1,
            LightRain,
            Rain,
            HeavyRain,
            ThunderStorms,
            Snow,
            Cloudy,
            PartlySunny,
            Sunny
        }

        public enum Visibility
        {
            Poor,
            Okay,
            Good
        }

        public enum WindDirection
        {
            N,
            NE,            
            NW,
            S,
            SW,
            SE,
            E,
            W            
        }
    }
}