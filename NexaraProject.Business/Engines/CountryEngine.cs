using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;
using NexaraProject.Entities.RequestModels;

namespace NexaraProject.Business.Engines
{
    public class CountryEngine : BusinessEngineBase, ICountryEngine
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

        public IResult AddCountry(AddCountryModel addCountry)
        {
            var country = _mapper.Map<Country>(addCountry);
            _countryRepository.Add(country);
            _countryRepository.SaveChanges();
            return new SuccessResult();
        }
    }
}