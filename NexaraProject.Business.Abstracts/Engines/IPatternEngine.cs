using NexaraProject.Core.Business;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Abstracts.Engines
{
    public interface IPatternEngine : IBusinessEngine
    {
        public IDataResult<ICollection<Pattern>> GetPatterns();
    }
}