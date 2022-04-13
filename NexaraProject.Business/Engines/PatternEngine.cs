using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Core.Utilities.Results;
using NexaraProject.DataAccess.Abstracts.Repositories;
using NexaraProject.Entities.Concretes;

namespace NexaraProject.Business.Engines
{
    public class PatternEngine : IPatternEngine
    {
        private readonly IPatternRepository _patternRepository;

        public PatternEngine(IPatternRepository patternRepository)
        {
            _patternRepository = patternRepository;
        }

        public IDataResult<ICollection<Pattern>> GetPatterns()
        {
            return new SuccessDataResult<ICollection<Pattern>>(_patternRepository.GetList());
        }
    }
}