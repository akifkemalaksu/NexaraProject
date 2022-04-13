using Microsoft.Extensions.DependencyInjection;
using System;

namespace NexaraProject.Core.Utilities.InversionOfControl
{
    public static class ServiceTool
    {
        public static IServiceProvider serviceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection serviceCollection)
        {
            serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceCollection;
        }
    }
}