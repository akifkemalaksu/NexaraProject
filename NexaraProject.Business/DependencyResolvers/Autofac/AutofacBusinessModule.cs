using Autofac;
using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Business.Engines;
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

            builder.RegisterType<ColorRepository>().As<IColorRepository>();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<OrderDetailRepository>().As<IOrderDetailRepository>();
            builder.RegisterType<PatternRepository>().As<IPatternRepository>();
            builder.RegisterType<ProductModelRepository>().As<IProductModelRepository>();
            builder.RegisterType<SeasonRepository>().As<ISeasonRepository>();
            builder.RegisterType<SizeRepository>().As<ISizeRepository>();
            builder.RegisterType<SizeSetRepository>().As<ISizeSetRepository>();
            builder.RegisterType<SizeSetSizeRepository>().As<ISizeSetSizeRepository>();

            builder.RegisterType<ColorEngine>().As<IColorEngine>();
            builder.RegisterType<CountryEngine>().As<ICountryEngine>();
            builder.RegisterType<OrderEngine>().As<IOrderEngine>();
            builder.RegisterType<OrderDetailEngine>().As<IOrderDetailEngine>();
            builder.RegisterType<PatternEngine>().As<IPatternEngine>();
            builder.RegisterType<ProductModelEngine>().As<IProductModelEngine>();
            builder.RegisterType<SeasonEngine>().As<ISeasonEngine>();
            builder.RegisterType<SizeEngine>().As<ISizeEngine>();
            builder.RegisterType<SizeSetEngine>().As<ISizeSetEngine>();
        }
    }
}