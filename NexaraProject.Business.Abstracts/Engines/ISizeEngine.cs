using NexaraProject.Core.Business.Abstracts;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ISizeEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Size>> GetSizes();

        public IDataResult<ICollection<Size>> GetSizesBySizeSet(int sizeSetId);
    }
}