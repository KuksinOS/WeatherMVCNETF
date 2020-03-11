using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherMVCNETF.Library.Interfaces;
using WeatherMVCNETF.Library.Models;

namespace WeatherMVCNETF.Library.Api
{
    public class CountryEndPoint: ICountryEndPoint
    {
        private IAPIHelper _apiHelper;
        public CountryEndPoint(IAPIHelper apiHelper)
        {
            string apiCountries = ConfigurationManager.AppSettings["apiCountries"];
            _apiHelper = apiHelper;
            _apiHelper.ApiClient.BaseAddress = new Uri(apiCountries);
        }

        public async Task<List<CountryModel>> GetAll()
        {
            //_apiClient.DefaultRequestHeaders.Clear();
            //_apiClient.DefaultRequestHeaders.Accept.Clear();
            //_apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //_apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            //using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Product"))
            //{
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var result = await response.Content.ReadAsAsync<List<CountryModel>>();
            //        return result;
            //    }
            //    else
            //    {
            //        throw new Exception(response.ReasonPhrase);
            //    }
            //}

            var schema = Schema.For(@"
          type Query {
              hello: String
          }
          ");


            return null;

        }




    }
}
