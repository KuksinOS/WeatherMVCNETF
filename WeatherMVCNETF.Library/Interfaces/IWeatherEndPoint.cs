using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMVCNETF.Library.Interfaces
{
    public interface IWeatherEndPoint
    {
        Task<WeatherMVCNETF.Library.Models.Weathers.RootObject> GetCurrentWeather(string city);
    }
}
