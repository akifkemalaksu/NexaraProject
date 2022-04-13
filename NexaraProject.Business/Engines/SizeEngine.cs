using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Engines
{
    public class SizeEngine : ISizeEngine
    {
        private readonly ISizeRepository _sizeRepository;

        public SizeEngine(ISizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }

        public IDataResult<ICollection<Size>> GetSizes()
        {
            return new SuccessDataResult<ICollection<Size>>(_sizeRepository.GetList());
        }
    }
}