using Microsoft.Extensions.DependencyInjection;
using System;

namespace NexaraProject.Core.Utilities.InversionOfControl
{
    public interface ICoreModule
    {
        public void Load(IServiceCollection serviceCollection);
    }
}