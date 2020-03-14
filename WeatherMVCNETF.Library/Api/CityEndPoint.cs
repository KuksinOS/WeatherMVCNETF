using GraphQL;
using GraphQL.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WeatherMVCNETF.Library.Interfaces;
using WeatherMVCNETF.Library.Models;
using WeatherMVCNETF.Library.Models.Cities;

namespace WeatherMVCNETF.Library.Api
{
    public class CityEndPoint: ICityEndPoint
    {
        private IGraphQLHelper _graphQLHelper;
        public CityEndPoint(IGraphQLHelper graphQLHelper)
        {
            _graphQLHelper = graphQLHelper;
        }

        public async Task<List<WeatherMVCNETF.Library.Models.Cities.Result>> GetCities(string code)
        {
            string apiCities = ConfigurationManager.AppSettings["apiCities"];
            string endPoint = apiCities + "/graphql";

            _graphQLHelper.InitializeClient(endPoint);
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Accept.Clear();
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Add("authority", "parseapi.back4app.com");
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Add("x-parse-application-id", "mxsebv4KoWIGkRntXwyzg6c6DhKWQuit8Ry9sHja");
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Add("x-parse-master-key", "TpO0j3lG2PmEVMXlKYQACoOXKQrL3lwM0HwR9dbH");


            code = "\"" + code +"\"";

            var query = new GraphQLRequest
            {
                Query = @"
                query allCountries {
                  countries (where: {code: {equalTo:" + code + @"}} ) {
                    results {
                      cities  {
                         results {
                         id
                         name
                         location {
                           latitude
                           longitude
                          }
                       }
                     }
                   }
                  }
                 }",
                Variables = null,
                OperationName = "allCountries"
            };



            // var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<object>(query);
            // var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<JObject>(query);
            //var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<dynamic>(query);
            //var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<GraphQLResponse<Data>>(query);
            var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<WeatherMVCNETF.Library.Models.Countries.Data>(query);

            // return null;
            return response.Data.countries.results[0].cities.results;
        }






    }
}
