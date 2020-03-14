using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WeatherMVCNETF.Library.Interfaces;
using AutoMapper;
using WeatherMVCNETF.Models;

namespace WeatherMVCNETF.ApiControllers
{
    public class CitiesController : ApiController
    {
        private readonly ICityEndPoint _cityEndPoint;
        private IMapper _mapper;

        public CitiesController(IMapper mapper, ICityEndPoint cityEndPoint)
        {
            _cityEndPoint = cityEndPoint;
            _mapper = mapper;
        }

        public async Task<List<CityDisplayModel>> Get(string code)
        {
            return await LoadCities(code);
        }

        private async Task<List<CityDisplayModel>> LoadCities(string code)
        {

            var cityList = await _cityEndPoint.GetCities(code);
            var cities = _mapper.Map<List<CityDisplayModel>>(cityList);

            return cities;
        }
    }
}