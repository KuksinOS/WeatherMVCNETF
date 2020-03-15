using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WeatherMVCNETF.Library.Interfaces;

namespace WeatherMVCNETF.Library.Api
{
    public class APIHelper : IAPIHelper
    {
        private HttpClient _apiClient;

        public APIHelper()
        {
            InitializeClient();

        }

        public static string AsQueryString(IEnumerable<KeyValuePair<string, object>> parameters)
        {
            if (!parameters.Any())
                return "";

            var builder = new StringBuilder("?");

            var separator = "";
            foreach (var kvp in parameters.Where(kvp => kvp.Value != null))
            {
                builder.AppendFormat("{0}{1}={2}", separator, WebUtility.UrlEncode(kvp.Key), WebUtility.UrlEncode(kvp.Value.ToString()));

                separator = "&";
            }

            return builder.ToString();
        }

        private void InitializeClient()
        {
            

            _apiClient = new HttpClient();
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        }

        public HttpClient ApiClient
        {
            get
            {
                return _apiClient;
            }
        }

        public Task Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
