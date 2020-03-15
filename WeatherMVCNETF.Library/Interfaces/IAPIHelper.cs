using System.Net.Http;


namespace WeatherMVCNETF.Library.Interfaces
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
    }
}
