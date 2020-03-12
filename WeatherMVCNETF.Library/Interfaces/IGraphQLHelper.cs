using GraphQL.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMVCNETF.Library.Interfaces
{
    public interface IGraphQLHelper
    {
        GraphQL.Client.Http.GraphQLHttpClient GraphQLClient { get; }
        void InitializeClient(string apiCountries);
        Task Authenticate();

    }
}
