using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeatherMVCNETF.Library.Models;
using WeatherMVCNETF.Models;

namespace WeatherMVCNETF.AutoMapper
{
    public abstract class AutoMapperBase
    {
        protected readonly IMapper _mapper;

        protected AutoMapperBase()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CountryModel, CountryDisplayModel>();
            });

            _mapper = config.CreateMapper();
        }

    }
}