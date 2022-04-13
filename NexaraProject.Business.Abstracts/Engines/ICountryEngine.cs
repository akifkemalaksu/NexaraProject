using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using System;
using NexaraProject.Core.Business.Abstracts;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ICountryEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Country>> GetCountries();
    }
}