using AutoMapper;
using NexaraProject.Business.Mappings.AutoMapper;
using System;

namespace NexaraProject.Business.Engines
{
    public class BusinessEngineBase
    {
        protected readonly IMapper _mapper;

        public BusinessEngineBase()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            _mapper = mapperConfiguration.CreateMapper();
        }
    }
}