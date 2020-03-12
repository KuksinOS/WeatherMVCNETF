using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMVCNETF.Library.Interfaces;
using GraphQL.Client.Http;

namespace WeatherMVCNETF.Library.Api
{
    public class GraphQLHelper: IGraphQLHelper
    {
        private GraphQLHttpClient _graphQLClient;

        public void InitializeClient(string apiCountries)
        {                        
            _graphQLClient = new GraphQLHttpClient(apiCountries);
            _graphQLClient.HttpClient.DefaultRequestHeaders.Accept.Clear();
        }

        public GraphQL.Client.Http.GraphQLHttpClient GraphQLClient
        {
            get
            {
                return _graphQLClient;
            }
        }

        public Task Authenticate()
        {
            throw new NotImplementedException();
        }

    }
}
