using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WeatherMVCNETF.Library.Interfaces;

namespace WeatherMVCNETF.ApiControllers
{
    public class WeathersController : ApiController
    {

        private readonly IWeatherEndPoint _weatherEndPoint;
        private IMapper _mapper;

        public WeathersController(IMapper mapper, IWeatherEndPoint weatherEndPoint)
        {
            _weatherEndPoint = weatherEndPoint;
            _mapper = mapper;
        }

        public async Task Get(string city)
        {
             await LoadCurrentWeather(city);
        }

        private async Task LoadCurrentWeather(string city)
        {
            var countryList = await _weatherEndPoint.GetCurrentWeather(city);
            //var countries = _mapper.Map<List<CountryDisplayModel>>(countryList);

         
        }
    }
}
