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
    public class CountriesController : ApiController
    {
        private readonly ICountryEndPoint _countryEndPoint;
        private IMapper _mapper;

        public CountriesController(IMapper mapper, ICountryEndPoint countryEndPoint)
        {
            _countryEndPoint = countryEndPoint;
            _mapper = mapper;
        }

        public async Task<List<CountryDisplayModel>> Get()
        {
            return await LoadCountries();
        }

        private async Task<List<CountryDisplayModel>> LoadCountries()
        {
            var countryList = await _countryEndPoint.GetCountries();
            var countries = _mapper.Map<List<CountryDisplayModel>>(countryList);

            return countries;
        }





    }
}
