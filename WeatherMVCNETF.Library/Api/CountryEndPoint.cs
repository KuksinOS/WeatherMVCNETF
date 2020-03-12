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

namespace WeatherMVCNETF.Library.Api
{
    public class CountryEndPoint: ICountryEndPoint
    {
        private IGraphQLHelper _graphQLHelper;
        public CountryEndPoint(IGraphQLHelper graphQLHelper)
        {
           
            _graphQLHelper = graphQLHelper;
            
        }

        public async Task<List<WeatherMVCNETF.Library.Models.ISO3166CountryCodes.Result>> GetAll()
        {
            string apiCountries = ConfigurationManager.AppSettings["apiCountries"];
            string endPoint = apiCountries + "/graphql";

            _graphQLHelper.InitializeClient(endPoint);
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Accept.Clear();
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Add("authority", "parseapi.back4app.com");
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Add("x-parse-application-id", "QVTjSe9SWlhCWFK77Y6PT5w8KV5eme4rr0CLORDK");
            _graphQLHelper.GraphQLClient.HttpClient.DefaultRequestHeaders.Add("x-parse-master-key", "e1LJLyaPSCjGouaIoCL44WhaXC6hGkdwXB9yh2rb");


            var query = new GraphQLRequest
            {
                Query = @"
                query allISO_3166_Country_Codes {
                  iSO_3166_Country_Codes(skip: 0, limit: 1000) {
                    results {
                      ACL
                      Alpha_2_code
                      Alpha_3_code
                      English_short_name
                      Numeric
                      createdAt
                      id
                      updatedAt
                    }
                  }
                }",
                Variables = null,
                OperationName = "allISO_3166_Country_Codes"
            };

            // var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<object>(query);
            // var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<JObject>(query);
            //var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<dynamic>(query);
            //var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<GraphQLResponse<Data>>(query);
            var response = await _graphQLHelper.GraphQLClient.SendQueryAsync<WeatherMVCNETF.Library.Models.ISO3166CountryCodes.Data>(query);

            // return null;
            return response.Data.iSO_3166_Country_Codes.results;

        }




    }
}
