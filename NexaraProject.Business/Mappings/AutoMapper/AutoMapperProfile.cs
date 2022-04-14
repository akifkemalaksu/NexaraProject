using AutoMapper;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.RequestModels;
using System;

namespace NexaraProject.Business.Mappings.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddCountryModel, Country>();

            CreateMap<AddOrderDetailModel, OrderDetail>();

            CreateMap<AddOrderModel, Order>();
        }
    }
}