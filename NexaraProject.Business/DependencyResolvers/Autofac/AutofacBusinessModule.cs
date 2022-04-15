using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using Castle.DynamicProxy;
using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Business.Engines;
using NexaraProject.Business.Mappings.AutoMapper;
using NexaraProject.Core.Utilities.Interceptors;
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

            builder.Register(c => new ColorRepository(c.Resolve<NexaraContext>())).As<IColorRepository>().InstancePerLifetimeScope();
            builder.Register(c => new CountryRepository(c.Resolve<NexaraContext>())).As<ICountryRepository>().InstancePerLifetimeScope();
            builder.Register(c => new OrderRepository(c.Resolve<NexaraContext>())).As<IOrderRepository>().InstancePerLifetimeScope();
            builder.Register(c => new OrderDetailRepository(c.Resolve<NexaraContext>())).As<IOrderDetailRepository>().InstancePerLifetimeScope();
            builder.Register(c => new PatternRepository(c.Resolve<NexaraContext>())).As<IPatternRepository>().InstancePerLifetimeScope();
            builder.Register(c => new ProductModelRepository(c.Resolve<NexaraContext>())).As<IProductModelRepository>().InstancePerLifetimeScope();
            builder.Register(c => new SeasonRepository(c.Resolve<NexaraContext>())).As<ISeasonRepository>().InstancePerLifetimeScope();
            builder.Register(c => new SizeRepository(c.Resolve<NexaraContext>())).As<ISizeRepository>().InstancePerLifetimeScope();
            builder.Register(c => new SizeSetRepository(c.Resolve<NexaraContext>())).As<ISizeSetRepository>().InstancePerLifetimeScope();
            builder.Register(c => new SizeSetSizeRepository(c.Resolve<NexaraContext>())).As<ISizeSetSizeRepository>().InstancePerLifetimeScope();

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

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}