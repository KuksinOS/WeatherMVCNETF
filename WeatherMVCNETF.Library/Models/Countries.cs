using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMVCNETF.Library.Models.Countries
{
    public class Result
    {
        public object ACL { get; set; }
        public string capital { get; set; }
        public string code { get; set; }
        public DateTime createdAt { get; set; }
        public string currency { get; set; }
        public string emoji { get; set; }
        public string emojiU { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string native { get; set; }
        public string phone { get; set; }
        public DateTime updatedAt { get; set; }
        public WeatherMVCNETF.Library.Models.Cities.Cities cities { get; set; }
    }

    public class Countries
    {
        public List<Result> results { get; set; }
    }

    public class Data
    {
        public Countries countries { get; set; }
    }

    public class RootObject
    {
        public Data data { get; set; }
    }
}
