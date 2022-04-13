using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;
using NexaraProject.Core.Business.Abstracts;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ISizeSetEngine : IBusinessEngine
    {
        public IDataResult<ICollection<SizeSet>> GetSizeSets();
    }
}