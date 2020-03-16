using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherMVCNETF.Models
{
    public class WeatherDisplayModel
    {
        public string temp { get; set; }
        public double speed { get; set; }
        public List<Weather> weather { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }




}