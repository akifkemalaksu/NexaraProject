using Autofac;
using AutoMapper;
using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Business.Engines;
using NexaraProject.Business.Mappings.AutoMapper;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.DataAccess.EntityFramework.Repositories;
using System;

namespace NexaraProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ColorRepository>().As<IColorRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().InstancePerLifetimeScope();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>().InstancePerLifetimeScope();
            builder.RegisterType<OrderDetailRepository>().As<IOrderDetailRepository>().InstancePerLifetimeScope();
            builder.RegisterType<PatternRepository>().As<IPatternRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ProductModelRepository>().As<IProductModelRepository>().InstancePerLifetimeScope();
            builder.RegisterType<SeasonRepository>().As<ISeasonRepository>().InstancePerLifetimeScope();
            builder.RegisterType<SizeRepository>().As<ISizeRepository>().InstancePerLifetimeScope();
            builder.RegisterType<SizeSetRepository>().As<ISizeSetRepository>().InstancePerLifetimeScope();
            builder.RegisterType<SizeSetSizeRepository>().As<ISizeSetSizeRepository>().InstancePerLifetimeScope();

            builder.RegisterType<ColorEngine>().As<IColorEngine>().InstancePerLifetimeScope();
            builder.RegisterType<CountryEngine>().As<ICountryEngine>().InstancePerLifetimeScope();
            builder.RegisterType<OrderEngine>().As<IOrderEngine>().InstancePerLifetimeScope();
            builder.RegisterType<OrderDetailEngine>().As<IOrderDetailEngine>().InstancePerLifetimeScope();
            builder.RegisterType<PatternEngine>().As<IPatternEngine>().InstancePerLifetimeScope();
            builder.RegisterType<ProductModelEngine>().As<IProductModelEngine>().InstancePerLifetimeScope();
            builder.RegisterType<SeasonEngine>().As<ISeasonEngine>().InstancePerLifetimeScope();
            builder.RegisterType<SizeEngine>().As<ISizeEngine>().InstancePerLifetimeScope();
            builder.RegisterType<SizeSetEngine>().As<ISizeSetEngine>().InstancePerLifetimeScope();

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            })).AsSelf().SingleInstance();
        }
    }
}