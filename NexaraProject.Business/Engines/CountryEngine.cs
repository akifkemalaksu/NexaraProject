using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Engines
{
    public class CountryEngine : ICountryEngine
    {
        private readonly ICountryRepository _countryRepository;

        public CountryEngine(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IDataResult<ICollection<Country>> GetCountries()
        {
            return new SuccessDataResult<ICollection<Country>>(_countryRepository.GetList());
        }
    }
}