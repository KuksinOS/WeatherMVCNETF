using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMVCNETF.Library.Models.ISO3166CountryCodes
{
    public class Result
    {
        public object ACL { get; set; }
        public string Alpha_2_code { get; set; }
        public string Alpha_3_code { get; set; }
        public string English_short_name { get; set; }
        public int Numeric { get; set; }
        public DateTime createdAt { get; set; }
        public string id { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class ISO3166CountryCodes
    {
        public List<Result> results { get; set; }
    }

    public class Data
    {
        public ISO3166CountryCodes iSO_3166_Country_Codes { get; set; }
    }

    public class RootObject
    {
        public Data data { get; set; }
    }






}
