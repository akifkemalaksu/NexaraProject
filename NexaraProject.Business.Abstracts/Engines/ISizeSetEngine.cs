using NexaraProject.Core.Business;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface ISizeSetEngine : IBusinessEngine
    {
        public IDataResult<ICollection<SizeSet>> GetSizeSets();
    }
}