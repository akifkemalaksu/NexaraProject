using NexaraProject.Core.Business.Abstracts;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.RequestModels;
using System;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ICountryEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Country>> GetCountries();

        public IResult AddCountry(AddCountryModel addCountry);
    }
}