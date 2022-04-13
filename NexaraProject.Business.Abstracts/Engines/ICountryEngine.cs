using NexaraProject.Core.Business;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using System;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ICountryEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Country>> GetCountries();
    }
}