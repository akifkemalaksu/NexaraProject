using Microsoft.Extensions.DependencyInjection;
using NexaraProject.Core.Utilities.InversionOfControl;
using System;

namespace NexaraProject.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection)
        {
            return ServiceTool.Create(serviceCollection);
        }
    }
}