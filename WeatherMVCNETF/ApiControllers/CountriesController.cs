using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WeatherMVCNETF.Library.Api;
using AutoMapper;
using WeatherMVCNETF.Models;

namespace WeatherMVCNETF.ApiControllers
{
    public class CountriesController : ApiController
    {
        private CountryEndPoint _countryEndPoint;
        private IMapper _mapper;

        //public CountriesController(CountryEndPoint countryEndPoint, IMapper mapper)
        //{
        //    _countryEndPoint = countryEndPoint;
        //}

        public async Task<List<CountryDisplayModel>> Get()
        {

            return await LoadCountries();
        }

        private async Task<List<CountryDisplayModel>> LoadCountries()
        {
            var countryList = await _countryEndPoint.GetAll();
            var countries = _mapper.Map<List<CountryDisplayModel>>(countryList);

            return countries;
        }





    }
}
