using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMVCNETF.Library.Interfaces
{
    public interface ICityEndPoint
    {
        Task<List<WeatherMVCNETF.Library.Models.ISO3166CountryCodes.Result>> GetAll();
    }
}
