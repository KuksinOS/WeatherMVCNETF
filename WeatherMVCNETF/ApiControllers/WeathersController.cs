using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WeatherMVCNETF.Library.Interfaces;
using WeatherMVCNETF.Models;

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

        public async Task<IHttpActionResult> Get(string city)
        {
            if (city == null)
                return BadRequest();

            var weatherdisplay = await LoadCurrentWeather(city);

            if (weatherdisplay != null)
                return Ok(weatherdisplay);
            else
                return NotFound();


        }

        private async Task<WeatherDisplayModel> LoadCurrentWeather(string city)
        {
           
            var weather = await _weatherEndPoint.GetCurrentWeather(city);
            var weatherdisplay = _mapper.Map<WeatherDisplayModel>(weather);

            return weatherdisplay;


        }
    }
}
