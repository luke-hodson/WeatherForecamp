using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherForecamp.Models;
using WeatherForecamp.Models.ViewModels;

namespace WeatherForecamp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WeatherViewModel model = new WeatherViewModel();

            List<Festival> fests = new List<Festival>
            {
                new Festival
                {
                    City = "Reading",
                    Date = new DateTime(2019, 08, 24),
                    Name = "Reading Festival",
                    Latitude = "51.724955",
                    Longitude = "-0.350472",
                    Weather = new List<Weather>
                    {
                        new Weather
                        {
                            Year = 2019,
                            WindDirection = Enums.WindDirection.NE,
                            FeelsLikeTemp = 21,
                            Temperature = 20,
                            Humidity = 85,
                            Visibility = Enums.Visibility.Good,
                            WeatherType = Enums.WeatherType.Sunny,
                            WindSpeed = 12
                        },
                        new Weather
                        {
                            Year = 2018,
                            WindDirection = Enums.WindDirection.NW,
                            FeelsLikeTemp = 15,
                            Temperature = 20,
                            Humidity = 55,
                            Visibility = Enums.Visibility.Good,
                            WeatherType = Enums.WeatherType.PartlySunny,
                            WindSpeed = 12
                        },
                        new Weather
                        {
                            Year = 2017,
                            WindDirection = Enums.WindDirection.SE,
                            FeelsLikeTemp = 10,
                            Temperature = 6,
                            Humidity = 65,
                            Visibility = Enums.Visibility.Poor,
                            WeatherType = Enums.WeatherType.LightRain,
                            WindSpeed = 17
                        },
                        new Weather
                        {
                            Year = 2016,
                            WindDirection = Enums.WindDirection.W,
                            FeelsLikeTemp = 15,
                            Temperature = 15,
                            Humidity = 60,
                            Visibility = Enums.Visibility.Okay,
                            WeatherType = Enums.WeatherType.Clear,
                            WindSpeed = 5
                        },

                    }
                },

                new Festival
                {
                    City = "Donington",
                    Date = new DateTime(2019, 06, 24),
                    Name = "Download Festival",
                    Latitude = "51.654786",
                    Longitude = "-0.359475",
                    Weather = new List<Weather>
                    {
                       new Weather
                        {
                            Year = 2019,
                            WindDirection = Enums.WindDirection.NE,
                            FeelsLikeTemp = 3,
                            Temperature = 2,
                            Humidity = 100,
                            Visibility = Enums.Visibility.Poor,
                            WeatherType = Enums.WeatherType.HeavyRain,
                            WindSpeed = 12
                        },
                        new Weather
                        {
                            Year = 2018,
                            WindDirection = Enums.WindDirection.NW,
                            FeelsLikeTemp = 15,
                            Temperature = 20,
                            Humidity = 55,
                            Visibility = Enums.Visibility.Good,
                            WeatherType = Enums.WeatherType.PartlySunny,
                            WindSpeed = 12
                        },
                        new Weather
                        {
                            Year = 2017,
                            WindDirection = Enums.WindDirection.SE,
                            FeelsLikeTemp = 10,
                            Temperature = 6,
                            Humidity = 65,
                            Visibility = Enums.Visibility.Poor,
                            WeatherType = Enums.WeatherType.Rain,
                            WindSpeed = 17
                        },
                        new Weather
                        {
                            Year = 2016,
                            WindDirection = Enums.WindDirection.W,
                            FeelsLikeTemp = 15,
                            Temperature = 15,
                            Humidity = 60,
                            Visibility = Enums.Visibility.Okay,
                            WeatherType = Enums.WeatherType.Clear,
                            WindSpeed = 5
                        },

                    }
                },

                new Festival
                {
                    City = "Glastonbury",
                    Date = new DateTime(2019, 07, 11),
                    Name = "Glastonbury Festival",
                    Latitude = "51.784512",
                    Longitude = "-0.356895",
                    Weather = new List<Weather>
                    {
                       new Weather
                        {
                            Year = 2019,
                            WindDirection = Enums.WindDirection.NE,
                            FeelsLikeTemp = 3,
                            Temperature = 2,
                            Humidity = 100,
                            Visibility = Enums.Visibility.Poor,
                            WeatherType = Enums.WeatherType.HeavyRain,
                            WindSpeed = 12
                        },
                        new Weather
                        {
                            Year = 2018,
                            WindDirection = Enums.WindDirection.NW,
                            FeelsLikeTemp = 15,
                            Temperature = 20,
                            Humidity = 55,
                            Visibility = Enums.Visibility.Good,
                            WeatherType = Enums.WeatherType.PartlySunny,
                            WindSpeed = 12
                        },
                        new Weather
                        {
                            Year = 2017,
                            WindDirection = Enums.WindDirection.SE,
                            FeelsLikeTemp = 10,
                            Temperature = 6,
                            Humidity = 65,
                            Visibility = Enums.Visibility.Poor,
                            WeatherType = Enums.WeatherType.Rain,
                            WindSpeed = 17
                        },
                        new Weather
                        {
                            Year = 2016,
                            WindDirection = Enums.WindDirection.W,
                            FeelsLikeTemp = 15,
                            Temperature = 15,
                            Humidity = 60,
                            Visibility = Enums.Visibility.Okay,
                            WeatherType = Enums.WeatherType.Clear,
                            WindSpeed = 5
                        },

                    }
                },
            };

            model.Weather = fests;
           
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";            
            
            return View();
        }
    }
}