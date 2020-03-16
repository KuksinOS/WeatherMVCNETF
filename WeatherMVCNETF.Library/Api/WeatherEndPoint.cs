using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherMVCNETF.Library.Interfaces;

namespace WeatherMVCNETF.Library.Api
{
    public class WeatherEndPoint: IWeatherEndPoint
    {
        private IAPIHelper _apiHelper;
        public WeatherEndPoint(IAPIHelper apiHelper)
        {
            string api = ConfigurationManager.AppSettings["apiWeather"];

            _apiHelper = apiHelper;

            _apiHelper.ApiClient.BaseAddress = new Uri(api);
        }

        public async Task<WeatherMVCNETF.Library.Models.Weathers.RootObject> GetCurrentWeather(string city)
        {
            string token = "e206053cc691d48f3deec1b17235a525";

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<String, object>("q", $"{city}"));
            parameters.Add(new KeyValuePair<String, object>("units", "metric"));
            parameters.Add(new KeyValuePair<String, object>("appid", $"{token}"));

            var uriString = string.Format("{0}/{1}", "/data/2.5/weather", APIHelper.AsQueryString(parameters));
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync(uriString))
            {
                if (response.IsSuccessStatusCode)
                {
                    // var result0 = await response.Content.ReadAsAsync<object>();                    
                    //return null;

                    var result = await response.Content.ReadAsAsync<WeatherMVCNETF.Library.Models.Weathers.RootObject>();
                    return result;

                    
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
