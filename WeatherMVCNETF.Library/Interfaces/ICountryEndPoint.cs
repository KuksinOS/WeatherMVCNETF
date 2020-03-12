using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMVCNETF.Library.Models;

namespace WeatherMVCNETF.Library.Interfaces
{
    public interface ICountryEndPoint
    {
        Task<List<WeatherMVCNETF.Library.Models.ISO3166CountryCodes.Result>> GetAll();
    }
}
