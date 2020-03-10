using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMVCNETF.Library.Models;

namespace WeatherMVCNETF.Library.Interfaces
{
    interface ICountryEndPoint
    {
        Task<List<CountryModel>> GetAll();
    }
}
