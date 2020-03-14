using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMVCNETF.Library.Models.Cities
{
    public class Location
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location location { get; set; }
    }

    public class Cities
    {
        public List<Result> results { get; set; }
    }

    public class Data
    {
        public Cities cities { get; set; }
    }

    public class RootObject
    {
        public Data data { get; set; }
    }


}
