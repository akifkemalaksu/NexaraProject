using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using NexaraProject.Core.Business.Abstracts;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ISizeEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Size>> GetSizes();
    }
}