using Microsoft.Extensions.DependencyInjection;
using NexaraProject.Core.Utilities.InversionOfControl;
using System;

namespace NexaraProject.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}