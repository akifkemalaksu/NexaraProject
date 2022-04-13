using Autofac;
using AutoMapper;
using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Business.Engines;
using NexaraProject.Business.Mappings.AutoMapper;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.DataAccess.EntityFramework;
using NexaraProject.DataAccess.EntityFramework.Repositories;
using System;

namespace NexaraProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NexaraContext>();

            builder.Register(c => new ColorRepository(c.Resolve<NexaraContext>())).As<IColorRepository>();
            builder.Register(c => new CountryRepository(c.Resolve<NexaraContext>())).As<ICountryRepository>();
            builder.Register(c => new OrderRepository(c.Resolve<NexaraContext>())).As<IOrderRepository>();
            builder.Register(c => new OrderDetailRepository(c.Resolve<NexaraContext>())).As<IOrderDetailRepository>();
            builder.Register(c => new PatternRepository(c.Resolve<NexaraContext>())).As<IPatternRepository>();
            builder.Register(c => new ProductModelRepository(c.Resolve<NexaraContext>())).As<IProductModelRepository>();
            builder.Register(c => new SeasonRepository(c.Resolve<NexaraContext>())).As<ISeasonRepository>();
            builder.Register(c => new SizeRepository(c.Resolve<NexaraContext>())).As<ISizeRepository>();
            builder.Register(c => new SizeSetRepository(c.Resolve<NexaraContext>())).As<ISizeSetRepository>();
            builder.Register(c => new SizeSetSizeRepository(c.Resolve<NexaraContext>())).As<ISizeSetSizeRepository>();

            builder.RegisterType<ColorEngine>().As<IColorEngine>();
            builder.RegisterType<CountryEngine>().As<ICountryEngine>();
            builder.RegisterType<OrderEngine>().As<IOrderEngine>();
            builder.RegisterType<OrderDetailEngine>().As<IOrderDetailEngine>();
            builder.RegisterType<PatternEngine>().As<IPatternEngine>();
            builder.RegisterType<ProductModelEngine>().As<IProductModelEngine>();
            builder.RegisterType<SeasonEngine>().As<ISeasonEngine>();
            builder.RegisterType<SizeEngine>().As<ISizeEngine>();
            builder.RegisterType<SizeSetEngine>().As<ISizeSetEngine>();

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            })).AsSelf().SingleInstance();
        }
    }
}