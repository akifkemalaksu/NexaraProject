using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Engines
{
    public class SizeSetEngine : ISizeSetEngine
    {
        private readonly ISizeSetRepository _sizeSetRepository;

        public SizeSetEngine(ISizeSetRepository sizeSetRepository)
        {
            _sizeSetRepository = sizeSetRepository;
        }

        public IDataResult<ICollection<SizeSet>> GetSizeSets()
        {
            return new SuccessDataResult<ICollection<SizeSet>>(_sizeSetRepository.GetList());
        }
    }
}